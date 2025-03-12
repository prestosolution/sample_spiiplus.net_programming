using System;
using System.Windows.Forms;

using ACS.Helpers;

namespace Ex5.MotorControl
{
    public partial class Form1 : Form
    {
        AcsManager acsManager;

        private int m_nTotalAxis = 0;//전체 축 할당 변수

        private MotorStates m_nMotorState;
        private double m_lfRPos, m_lfFPos, m_lfPE, m_lfFVEL;

        private int tmr_monitor_exception_chk = 0;
        private bool _isMessageShown;

        public Form1()
        {            
            InitializeComponent();
            acsManager = new AcsManager();

            RDO_SIM.Checked = true;
            RDO_TCP.Checked = false;
        }

        #region Connection UI

        private void Configure_Ui_For_Disconnected_State()
        {
            RDO_SIM.Enabled = true;
            RDO_TCP.Enabled = true;
            Disconnectbtn.Enabled = false;//중복입력 방지
            Connectbtn.Enabled = true;//중복입력 방지
        }

        private void Configure_Ui_For_Connected_State()
        {
            Disconnectbtn.Enabled = true;//enable됬음을 알려주도록 disconnectbtn true connectbtn false
            Connectbtn.Enabled = false;
        }

        private void RDO_TCP_CheckedChanged(object sender, EventArgs e)
        {
            IPtxt.Enabled = true;//can input IP address
            Porttxt.Enabled = true;//can input port
        }

        private void RDO_SIM_CheckedChanged(object sender, EventArgs e)
        {
            IPtxt.Enabled = false;//can't input IP address
            Porttxt.Enabled = false;//can't input port 
        }

        #endregion

        #region Connection
        private void Connectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectByMode();
                Configure_Ui_For_Connected_State();

                string strTemp = string.Empty;
                acsManager.Transaction("?SYSINFO(13)", ref strTemp);//transaction ?SYSINFO(13)을 입력해서 나오는 결과값(=>최대 모터축 수)을 strTemp에 저장
                m_nTotalAxis = Convert.ToInt32(strTemp.Trim());//최대축수를 반복문에 활용하기 위해 Intger로 변형

                AxisCombox.SelectedIndex = 0;//그리고 콤보박스 기본 선택은 0번축으로 진행함

                UpdateProfile();//축에 맞는 모터 속도값 불러오기

                tmrMonitor.Interval = 50;
                tmrMonitor.Start();
            }
            catch (Exception ex)//예외처리
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void ConnectByMode()
        {
            if (RDO_SIM.Checked)//라디오 버튼 시뮬레이터
            {
                acsManager.Connect();
            }
            else if (RDO_TCP.Checked)//라디오 버튼 TCP
            {
                string ipAddr = IPtxt.Text;
                string port = Porttxt.Text;
                acsManager.Connect(Connect_Type.TCP, ipAddr, port);
            }
        }

        private void Disconnectbtn_Click(object sender, EventArgs e)//연결끊기 버튼
        {
            try
            {
                if (GlobalVar.Connected)//연결을 확인하는 변수가 참이면
                {
                    acsManager.Disconnect();
                    Configure_Ui_For_Disconnected_State();
                }
                tmrMonitor.Stop();//타이머 정지
            }
            catch (Exception ex)//예외처리
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        #endregion

        #region tmrMonitor
        private void tmrMonitor_Tick(object sender, EventArgs e)//모니터링 타이머 
        {
            if (GlobalVar.Connected)
            {
                try
                {
                    UpdateAxisStatus();

                    UpdateProfile();

                    if ((m_nMotorState & MotorStates.ACSC_MST_MOVE) != 0) lblMoving.Image = Properties.Resources.On; else lblMoving.Image = Properties.Resources.Off;
                    //현 모터 상태와 비교해서 움직임 상태에 따라 토글
                    if ((m_nMotorState & MotorStates.ACSC_MST_INPOS) != 0) lblInPos.Image = Properties.Resources.On; else lblInPos.Image = Properties.Resources.Off;
                    //현 모터 상태와 비교해서 in pos 상태에 따라 토글(타그라드 내에 있는 값)
                    if ((m_nMotorState & MotorStates.ACSC_MST_ACC) != 0) lblAcc.Image = Properties.Resources.On; else lblAcc.Image = Properties.Resources.Off;
                    //현 모터 상태와 비교해서 가속 상태에 따라 토글
                    if ((m_nMotorState & MotorStates.ACSC_MST_ENABLE) != 0) lblEnable.Image = Properties.Resources.On; else lblEnable.Image = Properties.Resources.Off;
                    //현 모터 상태와 비교해서 enable 상태에 따라 토글
                    //throw new InvalidOperationException("text excepiton");//예외처리 테스트해보기
                }
                catch (Exception ex)//예외처리
                {
                    HandleExcepiton(ex);
                }
            }
        }

        private void HandleExcepiton(Exception ex)
        {
            tmr_monitor_exception_chk++;

            if(tmr_monitor_exception_chk >= 3 && !_isMessageShown)
            {
                _isMessageShown = true;

                DialogResult result = MessageBox.Show(
                    "The connection is unstable. retry Connecting?",
                    "ERROR",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);

                switch (result)
                {
                    case DialogResult.Retry:
                        tmr_monitor_exception_chk = 0;
                        ConnectByMode();
                        Configure_Ui_For_Connected_State();
                        break;

                    case DialogResult.Cancel:
                        acsManager.Disconnect();
                        Configure_Ui_For_Disconnected_State();
                        tmrMonitor.Stop();//타이머 정지
                        _isMessageShown = false;
                        break;
                }
            }
        }

        #endregion

        #region En/Dis able
        private void button_Enable_Click(object sender, EventArgs e)//enable
        {
            button_Disable.Enabled = true;
            button_Enable.Enabled = false;
            acsManager.Enable(AxisCombox.SelectedIndex);
        }

        private void button_Disable_Click(object sender, EventArgs e)//disable
        {
            button_Disable.Enabled = false;
            button_Enable.Enabled = true;
            acsManager.Disable(AxisCombox.SelectedIndex);
        }

        #endregion

        #region Absolute/Relative PtP

        private void start_abs_mo_btn_Click(object sender, EventArgs e)//execute absolute motion
        {            
            double IfTargetPos = 0.0f;//할당 변수
            if (Abtxt.Text.Length > 0)//뭐라도 입력해야 동작
            {
                IfTargetPos = Convert.ToDouble(Abtxt.Text);//입력한 값을 double로 바꿔서 할당함
                acsManager.AbsolutePTP((Axis)AxisCombox.SelectedIndex, IfTargetPos);    
            }
        }

        private void stop_abs_mo_btn_Click(object sender, EventArgs e)
        {
            acsManager.HaltAxis((Axis)AxisCombox.SelectedIndex);
        }

        private void Start_Re_mo_btn_Click(object sender, EventArgs e)//execute relative motion
        {
            double IfTargetPos = 0.0f;//할당 변수
            if (Retxt.Text.Length > 0)//뭐라도 입력해야 동작
            {
                IfTargetPos = Convert.ToDouble(Retxt.Text);//입력한 값을 double로 바꿔서 할당함
                _AcsManager.RelativePTP((Axis)AxisCombox.SelectedIndex, IfTargetPos);
            }
        }

        private void Stop_Re_mo_btn_Click(object sender, EventArgs e)
        {
            _AcsManager.HaltAxis((Axis)AxisCombox.SelectedIndex);
        }

        #endregion

        #region Jog

        private void PJog_btn_MouseDown(object sender, MouseEventArgs e)//+방향 jog 버튼(꾹 누르기)
        {
            double IfVelocity = 0.0f;//할당 변수
            if (chk_use_vel.Checked)//지정된 속도를 사용하기로 한 경우
            {
                IfVelocity = Convert.ToDouble(Jog_vel_txt.Text.Trim());//공백을 제거한 속도값을 더블로 바꿔서 할당

                _AcsManager.Jog((Axis)AxisCombox.SelectedIndex, true ,IfVelocity, true);
            }
            else
            {
                _AcsManager.Jog((Axis)AxisCombox.SelectedIndex, true);
            }
        }

        private void NJog_btn_MouseDown(object sender, MouseEventArgs e)//-방향 jog 버튼(꾹 누르기)
        {
            double IfVelocity = 0.0f;//변수할당
            if (chk_use_vel.Checked)//지정된 속도를 사용하기로 한 경우
            {
                IfVelocity = Convert.ToDouble(Jog_vel_txt.Text.Trim());//입력된 속도를 공백없이 더블로 바꿔 할당
                if (IfVelocity > 0) 
                    IfVelocity = IfVelocity * -1;//이후 양수 값을 입력했다면 음수로 변환

                _AcsManager.Jog((Axis)AxisCombox.SelectedIndex, false ,IfVelocity, true);
            }
            else
            {
                _AcsManager.Jog((Axis)AxisCombox.SelectedIndex, false);
            }
        }

        private void PJog_btn_MouseUp(object sender, MouseEventArgs e)//눌렀다가 때면 선택한 축 멈춤
        {
            _AcsManager.HaltAxis((Axis)AxisCombox.SelectedIndex);
        }

        private void NJog_btn_MouseUp(object sender, MouseEventArgs e)//눌렀다가 때면 선택한 축 멈춤
        {
            _AcsManager.HaltAxis((Axis)AxisCombox.SelectedIndex);
        }

        #endregion

        //-----------------------------------------------------------------------------------------------------------------------
        #region Back and Forth Move

        private void Start_bnf_btn_Click(object sender, EventArgs e)//back and forth 시작 버튼
        {
            _AcsManager.BackandForthStart(AxisCombox.SelectedIndex, PointAtxt.Text, PointBtxt.Text, Dwelltxt.Text);
            Start_bnf_btn.Enabled = false; // 버튼 비활성화
            Stop_bnf_btn.Enabled = true;  // Stop 버튼 활성화
        }

        private void Stop_bnf_btn_Click(object sender, EventArgs e)//back and forth 정지버튼
        {
            _AcsManager.BackandForthStop((Axis)AxisCombox.SelectedIndex);                                 
            Start_bnf_btn.Enabled = true; // Start 버튼 활성화
            Stop_bnf_btn.Enabled = false; // Stop 버튼 비활성화
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)//프로그램을 껐을 때도 모터가 움직임을 막기 위함
        {
            // 운동 스레드가 실행 중이라면 안전하게 종료
            _AcsManager.BackandForthThreadCleanUp();
            _AcsManager.HaltAxis((Axis)AxisCombox.SelectedIndex);//축멈춤
        }

        private void A_Pos_Read_btn_Click(object sender, EventArgs e)//현재 위치 읽기 버튼
        {
            PointAtxt.Text = m_lfFPos.ToString();
        }

        private void B_Pos_Read_btn_Click(object sender, EventArgs e)//현재 위치 읽기 버튼
        {
            PointBtxt.Text = m_lfFPos.ToString();
        }
        #endregion
        //-----------------------------------------------------------------------------------------------------------------------

        #region Update Status

        private void UpdateProfile()
        {
            try
            {
                string[] Save = _AcsManager.UpdateProfile((Axis)AxisCombox.SelectedIndex);

                if (Save.Length < 5)
                {
                    throw new InvalidOperationException("유효하지 않은 프로파일 데이터");
                }

                Veltxt.Text = Save[0];//콤보박스에서 선택된 인덱스의 속도 값을 문자열로 변환 후 텍스트 박스에 나타냄
                ACCtxt.Text = Save[1];//콤보박스에서 선택된 인덱스의 가속도 값을 문자열로 변환 후 텍스트 박스에 나타냄
                DECtxt.Text = Save[2];//콤보박스에서 선택된 인덱스의 감속도 값을 문자열로 변환 후 텍스트 박스에 나타냄
                KDECtxt.Text = Save[3];//콤보박스에서 선택된 인덱스의 비상정지 감속도 값을 문자열로 변환 후 텍스트 박스에 나타냄
                JERKtxt.Text = Save[4];//콤보박스에서 선택된 인덱스의 가가속도 값을 문자열로 변환 후 텍스트 박스에 나타냄
            }
            catch (Exception ex)
            {
                MessageBox.Show($"프로파일 업데이트 중 오류가 발생했습니다.\n{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                // UI 초기화 (예외 발생 시)
                Veltxt.Text = "";
                ACCtxt.Text = "";
                DECtxt.Text = "";
                KDECtxt.Text = "";
                JERKtxt.Text = "";
            }
        }

        private void UpdateAxisStatus()// 너무 복잡한 형변환 (다양한 형식 -> string -> 다양한 형식 (motorstate의 경우 추가로 motorstate 진행)) -> 수정 필요
        {
            int iAxisNo = AxisCombox.SelectedIndex;
            string[] Save = _AcsManager.UpdateAxisStatus(iAxisNo);

            if (Save.Length < 5)
            {
                throw new InvalidOperationException("유효하지 않은 axis status 데이터");
            }

            try
            {
                m_nMotorState = (MotorStates)Convert.ToInt32(Save[0]);//모터 상태 0b0000형태로 받아온다. 

                m_lfRPos = Convert.ToDouble(Save[1]);//지령 모터위치 할당 

                m_lfFPos = Convert.ToDouble(Save[2]);//실제 모터위치 할당

                m_lfPE = Convert.ToDouble(Save[3]);//모든 버퍼의 1차원 위치 오차값을 할당함

                m_lfFVEL = Convert.ToDouble(Save[4]);//모든 버퍼의 1차원 실회전속을 할당함

                RPOStxt.Text = String.Format("{0:0.0000}", m_lfRPos);//지령 모터 위치 가시할 수 있도록 텍스트화작업
                FPOStxt.Text = String.Format("{0:0.0000}", m_lfFPos);//실제 모터 위치 가시할 수 있도록 텍스트화작업
                PEtxt.Text = String.Format("{0:0.0000}", m_lfPE);//위치 오차값 가시할 수 있도록 텍스트화작업
                FVELtxt.Text = String.Format("{0:0.0000}", m_lfFVEL);//실회전속 모터 위치 가시할 수 있도록 텍스트화작업
            }
            catch (Exception ex)
            {
                MessageBox.Show($"axis status 업데이트 중 오류가 발생했습니다.\n{ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                // UI 초기화 (예외 발생 시)
                RPOStxt.Text = "";//지령 모터 위치 가시할 수 있도록 텍스트화작업
                FPOStxt.Text = "";//실제 모터 위치 가시할 수 있도록 텍스트화작업
                PEtxt.Text = "";//위치 오차값 가시할 수 있도록 텍스트화작업
                FVELtxt.Text = "";//실회전속 모터 위치 가시할 수 있도록 텍스트화작업
            }
        }

        private void Set_Zero_Pos_btn_Click(object sender, EventArgs e)//set fpos zero position
        {
            _AcsManager.SetZeroPos((Axis)AxisCombox.SelectedIndex);
        }

        #endregion

        #region change direction

        private void change_direction(TextBox textbox)
        {
            //한줄로 다 적을 수 있지만 가독성을 위해 변수를 사용하기로 함
            string val;//문자열 할당 변수
            int i = 0;//정수 할당변수
            if (textbox.Text.Length > 0)//뭐라도 적어야 실행됨
            {
                val = textbox.Text;//문자열 텍스트를 변수로 받는다.
                i = Convert.ToInt32(val) * -1;//받은 문자열을 정수로 바꿔서 -1곱한 후 i변수에 할당한다.
                textbox.Text = i.ToString();//다시 문자열로 바꿔서 텍스트에 넣는다.
            }
        }

        private void change_btn1_Click(object sender, EventArgs e)//absolute move +- 전환버튼
        {
            change_direction(Abtxt);
        }

        private void change_btn2_Click(object sender, EventArgs e)//relative move +- 전환버튼
        {
            change_direction(Retxt);
        }

        private void change_btn3_Click(object sender, EventArgs e)//back and forth point A +- 전환버튼
        {
            change_direction(PointAtxt);
        }

        private void change_btn4_Click(object sender, EventArgs e)//back and forth point B +- 전환버튼
        {
            change_direction(PointBtxt);
        }

        #endregion
    }
}
