using System;
using System.Security.Cryptography;
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
            acsManager = AcsManager.GetInstance();

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

                AxisCombox.Items.Clear();
                for (int i=0; i<GlobalVar.MAX_AXES; i++)
                {
                    AxisCombox.Items.Add(i);
                }
                AxisCombox.SelectedIndex = 0;//그리고 콤보박스 기본 선택은 0번축으로 진행함

                //UpdateProfile();//축에 맞는 모터 속도값 불러오기

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
    }
}
