using System;
using System.Windows.Forms;

using ACS.Helpers;

namespace Ex1.Communication
{
    public partial class MainForm : Form//testing with using UDM ->,<- 
    {
        AcsManager acsManager;

        public MainForm()
        {
            InitializeComponent();
            acsManager = AcsManager.GetInstance();
        }

        #region button enabled state
        private void Configure_Ui_For_Disconnected_State()
        {
            Connect_btn.Enabled = true;
            disconnect_btn.Enabled = false;
            connect_state.Text = "Disconnected";
            lbl_connect_state.Image = Properties.Resources.Off;
        }

        private void Configure_Ui_For_Connected_State()
        {
            Connect_btn.Enabled = false;
            disconnect_btn.Enabled = true;
            connect_state.Text = "Connected";
            lbl_connect_state.Image = Properties.Resources.On;
        }

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
        #endregion

        #region Connection
        private void Connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RDO_SIM.Checked)//is RDO.SIM checked? 
                {
                    acsManager.Connect();
                }
                else if (RDO_TCP.Checked)//is RDO_TCP checked?
                {
                    string ipAddr = IPtxt.Text;
                    string port = PORTtxt.Text;
                    acsManager.Connect(Connect_Type.TCP, ipAddr, port);
                }
                Configure_Ui_For_Connected_State();
            }
            catch(Exception ex)//exception catch
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
                System.Diagnostics.Debug.WriteLine(ex.Message);//debug tool to write program working process on console
            }
        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                acsManager.Disconnect();
                Configure_Ui_For_Disconnected_State();
            }
            catch (Exception ex)//exception catch
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);//debug tool to write program working process on console
            }
        }
        #endregion
    }
}
