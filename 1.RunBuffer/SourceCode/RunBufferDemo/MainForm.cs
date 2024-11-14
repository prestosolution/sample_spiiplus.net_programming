using System;
using System.IO;

using System.Windows.Forms;

using ACS.SPiiPlusNET;
using ACSSimDev.SEQ;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static RunBufferDemo.FrmMain;

namespace RunBufferDemo
{
    public partial class FrmMain : Form
    {
        AcsManager acsManager;
        Logger logger;

        int timecount = 0;
        int runBufferLoopCount = 0;

        public class Logger
        {
            public string LogEvent(string message)
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string eventMessage = ($"[{timestamp}] {message}\n");

                return eventMessage;
            }
        }


        public FrmMain()
        {
            InitializeComponent();

            acsManager = AcsManager.GetInstance();
            logger = new Logger();

            InitializeForm();
        }

        public void InitializeForm()
        {
            rBtnCommSimul.Checked = false;
            rBtnCommTcpIp.Checked = true;

            string[] buffNames = Enum.GetNames(typeof(ACS.SPiiPlusNET.ProgramBuffer));
            cbxBufferNum.Items.AddRange(buffNames);
            cbxBufferNum.SelectedIndex = 0;

            timerAutoExec.Enabled = false;
            timerAutoExec.Tick += TimerAutoExec_Tick;

            BtnConnect.Click += BtnConnect_Click;
            BtnDisconnect.Click += BtnDisconnect_Click;

            BtnRunBuffer.Click += BtnRunBuffer_Click;

            BtnAutoExecStart.Click += BtnAutoExecStart_Click;
            BtnAutoExecStop.Click += BtnAutoExecStop_Click;
        }



        private void TimerAutoExec_Tick(object sender, EventArgs e)
        {
            int bufferNum = cbxBufferNum.SelectedIndex;
            acsManager.RunBuffer(bufferNum);

            runBufferLoopCount++;

            if (acsManager.GetLastError() == 0)
                rtxtBox.AppendText(logger.LogEvent(string.Format("Buffer Auto Execution Success({0})", runBufferLoopCount)));
            else
            {
                rtxtBox.AppendText(logger.LogEvent("Run Buffer Error Occur"));
                timerAutoExec.Enabled = false;
            }
        }

        private void BtnAutoExecStop_Click(object sender, EventArgs e)
        {
            timerAutoExec.Enabled = false;
            rtxtBox.AppendText(logger.LogEvent("Buffer Auto Execution Stop"));
        }

        private void BtnAutoExecStart_Click(object sender, EventArgs e)
        {
            int timeInterval = 0;
            int.TryParse(txtAutoExecInterval.Text, out timeInterval);

            if (timeInterval <= 0){
                timeInterval = 1;
            }
            else if (timeInterval > 60){
                timeInterval = 60;
            }

            rtxtBox.Text = "";

            txtAutoExecInterval.Text = timeInterval.ToString();

            runBufferLoopCount = 0;

            timerAutoExec.Interval = 60000 * timeInterval;
            timerAutoExec.Enabled = true;

            rtxtBox.AppendText(logger.LogEvent("Buffer Auto Execution Start"));
        }

        private void BtnRunBuffer_Click(object sender, EventArgs e)
        {
            int bufferNum = cbxBufferNum.SelectedIndex;
            acsManager.RunBuffer(bufferNum);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            bool isConnect = false;
            if(rBtnCommSimul.Checked)
            {
                isConnect = acsManager.Connect();
            }
            else if(rBtnCommTcpIp.Checked)
            {
                string ipAddr = txtIPAddr.Text;
                string port = txtPort.Text;

                isConnect = acsManager.Connect(AcsManager.ConnType.TCPIP, ipAddr, port);
            }

            if (isConnect)
                rtxtBox.AppendText(logger.LogEvent("Communication Connected"));
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            acsManager.Disconnect();
            rtxtBox.AppendText(logger.LogEvent("Communication Disconnected"));

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //acslib.CloseSimulator();
        }

    }
}
