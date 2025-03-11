using System;
using System.Threading;
using System.Windows.Forms;

using ACS.Helpers;

namespace Ex2.RunBuffer
{
    public partial class MainForm : Form
    {
        private AcsManager acsManager;

        private int m_nTotalBuffer = 0;
        private bool asking;

        // For update values
        private ProgramStates m_nProgramState;

        public MainForm()
        {
            InitializeComponent();

            acsManager = AcsManager.GetInstance();

            RDO_SIM.Checked = true;
            RDO_TCP.Checked = false;
        }

        #region Connection UI status

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

        private void ConfigureUiForDisconnectStatus()
        {
            Disconnect_btn.Enabled = false;//interlocked button
            Connect_btn.Enabled = true;
            RDO_SIM.Enabled = true;
            RDO_TCP.Enabled = true;
        }

        private void ConfigureUiForConnectStatus()
        {
            Connect_btn.Enabled = false;
            Disconnect_btn.Enabled = true;//interlocked buttons
        }

        #endregion

        #region Connection

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            string strTemp = string.Empty;
            int i = 0;

            ConnectByMode();
            ConfigureUiForConnectStatus();

            Thread.Sleep(100);
            //set max buffer
            if (!acsManager.Transaction("?SYSINFO(10)", ref strTemp)) //ask transaction api
            {
                MessageBox.Show(acsManager.GetLastErrorString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConfigureUiForDisconnectStatus();
                return;
            }

            m_nTotalBuffer = Convert.ToInt32(strTemp.Trim());//converting
            for (i = 0; i < m_nTotalBuffer; i++) { BufferNoCombox.Items.Add(i.ToString()); }//fill combo box
            BufferNoCombox.SelectedIndex = 0;//basic value

            //start Timer
            tmrMonitor.Interval = 50;
            tmrMonitor.Start();
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
            if (!acsManager.Disconnect())
            {
                MessageBox.Show(acsManager.GetLastErrorString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConfigureUiForDisconnectStatus();
            tmrMonitor.Stop();
        }

        #endregion

        #region BufferControl

        private void clr_btn_Click(object sender, EventArgs e)
        {
            asking = check_buffer_option("clear All");//nudge asking 
            if (asking == true)
            {
                acsManager.ClearBuffer((ProgramBuffer)BufferNoCombox.SelectedIndex);
            }
        }

        private void compile_btn_Click(object sender, EventArgs e)
        {
            acsManager.CompileBuffer((ProgramBuffer)BufferNoCombox.SelectedIndex);
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            string temp;
            asking = check_buffer_option("Load this buffer");
            if (asking)
            {
                temp = bufferPLtxt.Text;
                acsManager.LoadBuffer((ProgramBuffer)BufferNoCombox.SelectedIndex, temp);
            }
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            asking = check_buffer_option("upload this buffer");//nudge
            if (asking == true)
            {
                string result = string.Empty;
                acsManager.UploadBuffer((ProgramBuffer)BufferNoCombox.SelectedIndex, ref result);
                bufferPLtxt.Text = result;
            }
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            acsManager.StopBuffer((ProgramBuffer)BufferNoCombox.SelectedIndex);//stop buffer
        }

        private void Runbtn_Click(object sender, EventArgs e)
        {
            if (Labeltxt.Text.Length > 0)//check LABEL 
            {
                isValidLabel();
                acsManager.RunBuffer((ProgramBuffer)BufferNoCombox.SelectedIndex, Labeltxt.Text.Trim());//라벨 시작함
                return;
            }
            acsManager.RunBuffer((ProgramBuffer)BufferNoCombox.SelectedIndex, null);//전체 버퍼 실행함.
        }

        private void isValidLabel()
        {
            string temp;
            temp = Labeltxt.Text.ToUpper();//LABEL 대문자로 바꿈
            if (temp[0] != 0x5F && (temp[0] < 0x41 || temp[0] > 0x5A))//라벨의 첫글자가 A~Z범위 밖이며 _로 시작하지 않으면 메세지 발동 
            {
                MessageBox.Show("Wrong 'Label' name input.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool check_buffer_option(string check_m)//method to check Confirmation of Reconfirmation Intentions
        {
            if (MessageBox.Show("are you sure to " + check_m + "?", "asking", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        #endregion

        #region tmrMonitor

        private void tmrMonitor_Tick(object sender, EventArgs e)//0.05초마다 반복함.
        {
            int iBufferNo = BufferNoCombox.SelectedIndex;  //현재 선택된 버퍼를 담는 지역변수 
            if (!acsManager.GetProgramState((ProgramBuffer)iBufferNo, ref m_nProgramState))
            {
                tmrMonitor.Enabled = false;
                MessageBox.Show(acsManager.GetLastErrorString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshProgramState();
        }

        private void RefreshProgramState()
        {
            // 공통 로직을 간단히 인라인 처리
            Action<Label, Label, bool, string, string> updateStatus = (lblLED, lblStatus, isActive, activeText, inactiveText) =>
            {
                lblLED.Image = isActive ? Properties.Resources.On : Properties.Resources.Off;
                lblStatus.Text = isActive ? activeText : inactiveText;
            };

            // 동작 상태 업데이트
            bool isRunning = (m_nProgramState & ProgramStates.ACSC_PST_RUN) != 0;
            updateStatus(lblPRG_Status_LED, lblPRG_Status, isRunning, "Running", "Stop");

            // 컴파일 상태 업데이트
            bool isCompiled = (m_nProgramState & ProgramStates.ACSC_PST_COMPILED) != 0;
            updateStatus(lblCompstate, Compstate, isCompiled, "OK", "NONE");
        }

        #endregion
    }
}
