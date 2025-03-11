using System;
using System.Windows.Forms;

using ACS.Helpers;

namespace Ex3.TransactionCommand
{
    public partial class Form1 : Form//testing with using UDM ->,<- 
    {
        private AcsManager acsManager;

        public Form1()
        {
            InitializeComponent();
            acsManager = AcsManager.GetInstance(); ;//generate a new instance

            txtCommand.KeyPress += TxtCommand_KeyPress;

            RDO_SIM.Checked = true;
            RDO_TCP.Checked = false;
        }

        private void TxtCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendCommand();
            }
        }

        #region Connection UI Control

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
            RDO_TCP.Enabled = true;
            RDO_TCP.Enabled = true;
        }

        #endregion

        #region Connection

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            try
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
                ConfigureUiForConnectStatus();
            }
            catch(Exception ex)//exception catch
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                System.Diagnostics.Debug.WriteLine(ex.Message);//debug tool to write program working process on console
            }
        }

        private void Disconnect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVar.Connected) 
                    acsManager.Disconnect();//if connect logic is completed, close commucation
                else return;
                ConfigureUiForDisconnectStatus();
            }
            catch (Exception ex)//exception catch
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);//debug tool to write program working process on console
            }
        }

        #endregion

        #region Transaction

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            SendCommand();
        }

        private void SendCommand()
        {
            if (GlobalVar.Connected)//연결되어 있어야만 작동함
            {
                string temp = string.Empty;//빈 변수 준비
                try//예외처리
                {
                    AppendTextToTextBox("> " + txtCommand.Text.Trim());//>(입력한 텍스트) 형식으로 텍스트박스에 적용되게 함
                    acsManager.Transaction(txtCommand.Text.Trim(), ref temp);//그다음 그 입력한 텍스트를 ACS로 트랜젝션을 던진다.
                }
                catch (ACS.SPiiPlusNET.ACSException ex)//ACS에서 발생하는 에러를 ex에 저장한다.
                {
                    temp = string.Format("?{0}", ex.ErrorCode);//그것을 텍스트화 하여 입력한다.
                }
                finally
                {
                    if (temp == null)//터미널창에 어떤 것이라도 입력하지 않으면
                    {
                        AppendTextToTextBox(":");//아무것도 입력하지 않고 오직 :만 입력되게 함
                    }
                    else if (temp.Length > 0)//뭐라도 입력한다면
                    {
                        AppendTextToTextBox(temp);//트랜젝션으로 받아온 내용을 표시한다.
                        AppendTextToTextBox(":");//그리고 :을 입력되게 한다. ->여기서 :은 명령어의 내용이 끝났음을 알려준다.
                    }
                }
                txtCommand.Focus();//입력하고 또 다시 입력할 수 있게 입력창에 포커스를 맞춘다.
                txtCommand.SelectAll();//그리고 입력했던 내용을 전부 선택되게 한다.
            }
        }

        private void AppendTextToTextBox(string text)
        {
            rtxtTerminal.AppendText(text);//이전 내용을 해치지 않게 append 사용 -> 인자로 받아온 내용을 그대로 추가한다.
            rtxtTerminal.AppendText(Environment.NewLine);//들여쓰기
            rtxtTerminal.ScrollToCaret();//최신 추가된 내용이 보이도록 맨 마지막으로 스크롤함
        }

        #endregion
    }
}
