using System;
using System.Threading;
using System.Windows.Forms;

using ACS.Helpers;

namespace Ex4.IoControl
{
    public partial class Ex4_Main : Form//testing with using UDM ->,<- 
    {
        private AcsManager acsManager;

        private const int MAX_UI_LIMIT_CNT = 8;
        private const int MAX_UI_IO_CNT = 8;
        private int m_nTotalAxis = 0;

        // For update values
        private object m_objReadVar = null;
        private Array m_arrReadVector = null;
        private int m_nValues, m_nOutputState;//m_nValues 는 inputstate를 의미함 왜 그냥 values나면 input은 우리가 직접 수정할 수 없기 때문

        private Label[] m_lblLeftLimit;
        private Label[] m_lblRightLimit;
        private Label[] m_lblInput;
        private Label[] m_lblOutput;
        private Button[] m_btnOutput;
        
        private int tmr_monitor_exception_chk = 0;
        private bool _isMessageShown;

        public Ex4_Main()
        {
            InitializeComponent();
            acsManager = AcsManager.GetInstance();//generate a new instance
        }

        #region Connection UI Status

        private void RDO_TCP_CheckedChanged(object sender, EventArgs e)
        {
            IPtxt.Enabled = true;//can input IP address
            PORTtxt.Enabled = true;//can input port
        }

        private void RDO_SIM_CheckedChanged(object sender, EventArgs e)
        {
            IPtxt.Enabled = false;//can't input IP address
            PORTtxt.Enabled = false;//can't input port 
        }

        private void ConfigureUiForConnectStatus()
        {
            Connect_btn.Enabled = false;
            Disconnect_btn.Enabled = true;
        }

        private void ConfigureUiForDisconnectStatus()
        {
            Disconnect_btn.Enabled = false;
            Connect_btn.Enabled = true;
            RDO_SIM.Enabled = true;
            RDO_TCP.Enabled = true;
        }

        #endregion

        #region Connection

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectByMode();
                ConfigureUiForConnectStatus();

                Thread.Sleep(100);
                m_nTotalAxis = GlobalVar.MAX_AXES;

                tmrMonitor.Interval = 50;
                tmrMonitor.Start();//starting timer
            }
            catch(Exception ex)//exception catch
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                System.Diagnostics.Debug.WriteLine(ex.Message);//debug tool to write program working process on console
            }
        }

        private void ConnectByMode()
        {
            if (RDO_SIM.Checked)//is RDO.Sim checked? 
            {
                acsManager.Connect();
            }
            else if (RDO_TCP.Checked)//is RDO_TCP checked?
            {
                string IpAddr = IPtxt.Text;
                string port = PORTtxt.Text;
                acsManager.Connect(Connect_Type.TCP, IpAddr, port);
            }
        }

        private void Disconnect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVar.Connected) acsManager.Disconnect();//if connect logic is completed, close commucation
                else return;

                tmrMonitor.Stop();//타이머 멈추기~
                ConfigureUiForDisconnectStatus();
            }
            catch (Exception ex)//exception catch
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);//debug tool to write program working process on console
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            RDO_SIM.Checked = true;//set radio_btn simulator
            Connect_btn.Enabled = true;
            Disconnect_btn.Enabled = false;

            //각각의 라벨을 하나의 배열에 넣는다
            //상태변화시 각각의 라벨명을 직접 호출하는게 아니라
            //하나의 배열에 숫자만 포문으로 돌리면서 효율적으로 상태변화를 적용할 수 있게 해준다.

            m_lblLeftLimit = new Label[MAX_UI_LIMIT_CNT];//Arrange left limit label
            m_lblLeftLimit[0] = lblLL0;
            m_lblLeftLimit[1] = lblLL1;
            m_lblLeftLimit[2] = lblLL2;
            m_lblLeftLimit[3] = lblLL3;
            m_lblLeftLimit[4] = lblLL4;
            m_lblLeftLimit[5] = lblLL5;
            m_lblLeftLimit[6] = lblLL6;
            m_lblLeftLimit[7] = lblLL7;

            m_lblRightLimit = new Label[MAX_UI_LIMIT_CNT];//Arrange right limit label
            m_lblRightLimit[0] = lblRL0;
            m_lblRightLimit[1] = lblRL1;
            m_lblRightLimit[2] = lblRL2;
            m_lblRightLimit[3] = lblRL3;
            m_lblRightLimit[4] = lblRL4;
            m_lblRightLimit[5] = lblRL5;
            m_lblRightLimit[6] = lblRL6;
            m_lblRightLimit[7] = lblRL7;

            m_lblInput = new Label[MAX_UI_IO_CNT];////Arrange input label
            m_lblInput[0] = lblIN0;
            m_lblInput[1] = lblIN1;
            m_lblInput[2] = lblIN2;
            m_lblInput[3] = lblIN3;
            m_lblInput[4] = lblIN4;
            m_lblInput[5] = lblIN5;
            m_lblInput[6] = lblIN6;
            m_lblInput[7] = lblIN7;

            m_lblOutput = new Label[MAX_UI_IO_CNT];//Arrange output label
            m_lblOutput[0] = lblOUT0;
            m_lblOutput[1] = lblOUT1;
            m_lblOutput[2] = lblOUT2;
            m_lblOutput[3] = lblOUT3;
            m_lblOutput[4] = lblOUT4;
            m_lblOutput[5] = lblOUT5;
            m_lblOutput[6] = lblOUT6;
            m_lblOutput[7] = lblOUT7;

            m_btnOutput = new Button[MAX_UI_IO_CNT];////Arrange button changing output signal
            m_btnOutput[0] = btnSW0;
            m_btnOutput[1] = btnSW1;
            m_btnOutput[2] = btnSW2;
            m_btnOutput[3] = btnSW3;
            m_btnOutput[4] = btnSW4;
            m_btnOutput[5] = btnSW5;
            m_btnOutput[6] = btnSW6;
            m_btnOutput[7] = btnSW7;

            m_nOutputState = 0;//off any output bit
        }

        private void btnSW_Click(object sender, EventArgs e)
        {
            int nBitNo = 0x01;//this variable is used to know output state
            Button btn = sender as Button;//safe casting sender
            if (btn == null) return;

            nBitNo = btn.TabIndex;//get pushed button's Tabindex

            if (btn.Text == "ON")
            {
                btn.Text = "OFF";
                acsManager.SetOutputBit(0, nBitNo, 1);
            }
            else
            {
                btn.Text = "ON";
                acsManager.SetOutputBit(0, nBitNo, 0);
            }
        }

        #region tmrMonitor

        private void tmrMonitor_Tick(object sender, EventArgs e)
        {
            if (!GlobalVar.Connected)//check connected
            {
                tmrMonitor.Enabled = false;
                return;
            }

            if (acsManager.ReadFault(ref m_objReadVar))
            {
                m_arrReadVector = m_objReadVar as Array;//Array 형식으로 형변환 
                if (m_arrReadVector != null)
                {
                    for (int i = 0; i < m_nTotalAxis; i++)
                    {
                        UpdateLimitState(i, (int)m_arrReadVector.GetValue(i));//Updating All Axis State
                    }
                }
            }
            //port mean all bit
            acsManager.GetInputPort(0, ref m_nValues);      //0번 포트의 input bit 값을 받아온다.
            UpdateIOState(m_nValues, true);                             //위 받은 bit 값을 기반으로 input image label을 갱신해준다.

            acsManager.GetOutputPort(0, ref m_nOutputState);//0번 포트의 output bit 값을 받아온다.
            UpdateIOState(m_nOutputState, false);//위 받은 bit 값을 기반으로 output image label을 갱신해준다.
        }

        private void HandleExcepiton(Exception ex)
        {
            tmr_monitor_exception_chk++;

            if (tmr_monitor_exception_chk >= 3 && !_isMessageShown)
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
                        ConfigureUiForConnectStatus();
                        break;
                    
                    case DialogResult.Cancel:
                        acsManager.Disconnect();
                        ConfigureUiForDisconnectStatus();
                        tmrMonitor.Stop();//타이머 정지
                        _isMessageShown = false;
                        break;
                }
            }
        }

        private void UpdateLimitState(int axisNo, int fault)
        {
            if (axisNo < MAX_UI_LIMIT_CNT)//지정된 리밋 수만큼만 갱신시킴
            {
                if ((fault & (int)SafetyControlMasks.ACSC_SAFETY_LL) != 0) m_lblLeftLimit[axisNo].Image = Properties.Resources.Error; 
                else m_lblLeftLimit[axisNo].Image = Properties.Resources.Off;
                //현재축의 LL bit가 켜져있으면 현재축 LL image error로 교체, 꺼져있으면 off로 교체

                if ((fault & (int)SafetyControlMasks.ACSC_SAFETY_RL) != 0) m_lblRightLimit[axisNo].Image = Properties.Resources.Error; 
                else m_lblRightLimit[axisNo].Image = Properties.Resources.Off;
                //현재축의 RL bit가 켜져있으면 현재축 RL image error로 교체, 꺼져있으면 off로 교체
            }
        }

        private void UpdateIOState(int value, bool isinput)
        {
            int bitUpCnt = 0x01;//0번 부터 시작하는 io 갱신
            for (int i = 0; i < MAX_UI_IO_CNT; i++)//Update only Max Ui
            {
                if (isinput)//input에 해당하는 로직
                {
                    if ((value & bitUpCnt) != 0) m_lblInput[i].Image = Properties.Resources.On;//현재input(value)가 on 상태라면 이미지를 on 이미지로 교체
                    else m_lblInput[i].Image = Properties.Resources.Off;//현재 input(value)가 off 상태라면 이미지를 off로 교체
                }
                else//output에 해당하는 로직(button text 바꾸기 추가됨)
                {
                    if ((value & bitUpCnt) != 0)
                    {
                        m_btnOutput[i].Text = "OFF";//현재 output(value)가 on상태라면 출력버튼의 텍스트를 off로 바꾸고 이미지를 on 상태로 교체
                        m_lblOutput[i].Image = Properties.Resources.On;
                    }
                    else
                    {
                        m_btnOutput[i].Text = "ON";//현재 output(value)가 off상태라면 출력버튼의 텍스트를 ON으로 바꾸고 이미지를 off 상태로 교체
                        m_lblOutput[i].Image = Properties.Resources.Off;
                    }
                }
                bitUpCnt = (0x01) << (i + 1);//shift comparison bit to check the next bit
            }
        }

        #endregion    
    }
}