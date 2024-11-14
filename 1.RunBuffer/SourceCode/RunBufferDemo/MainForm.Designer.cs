
namespace RunBufferDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerAutoExec = new System.Windows.Forms.Timer(this.components);
            this.BtnRunBuffer = new System.Windows.Forms.Button();
            this.txtIPAddr = new System.Windows.Forms.TextBox();
            this.rtxtBox = new System.Windows.Forms.RichTextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAutoExecStop = new System.Windows.Forms.Button();
            this.BtnAutoExecStart = new System.Windows.Forms.Button();
            this.txtAutoExecInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.cbxBufferNum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnCommTcpIp = new System.Windows.Forms.RadioButton();
            this.rBtnCommSimul = new System.Windows.Forms.RadioButton();
            this.pnlMain.SuspendLayout();
            this.gbxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRunBuffer
            // 
            this.BtnRunBuffer.Location = new System.Drawing.Point(285, 104);
            this.BtnRunBuffer.Name = "BtnRunBuffer";
            this.BtnRunBuffer.Size = new System.Drawing.Size(156, 31);
            this.BtnRunBuffer.TabIndex = 0;
            this.BtnRunBuffer.Text = "Run Buffer";
            this.BtnRunBuffer.UseVisualStyleBackColor = true;
            // 
            // txtIPAddr
            // 
            this.txtIPAddr.Location = new System.Drawing.Point(175, 25);
            this.txtIPAddr.Name = "txtIPAddr";
            this.txtIPAddr.Size = new System.Drawing.Size(128, 21);
            this.txtIPAddr.TabIndex = 1;
            this.txtIPAddr.Text = "10.0.0.100";
            // 
            // rtxtBox
            // 
            this.rtxtBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtBox.Location = new System.Drawing.Point(0, 218);
            this.rtxtBox.Name = "rtxtBox";
            this.rtxtBox.Size = new System.Drawing.Size(447, 267);
            this.rtxtBox.TabIndex = 2;
            this.rtxtBox.Text = "";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbxMain);
            this.pnlMain.Controls.Add(this.rtxtBox);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(447, 485);
            this.pnlMain.TabIndex = 3;
            // 
            // gbxMain
            // 
            this.gbxMain.Controls.Add(this.label5);
            this.gbxMain.Controls.Add(this.BtnAutoExecStop);
            this.gbxMain.Controls.Add(this.BtnAutoExecStart);
            this.gbxMain.Controls.Add(this.txtAutoExecInterval);
            this.gbxMain.Controls.Add(this.label4);
            this.gbxMain.Controls.Add(this.BtnDisconnect);
            this.gbxMain.Controls.Add(this.BtnConnect);
            this.gbxMain.Controls.Add(this.cbxBufferNum);
            this.gbxMain.Controls.Add(this.label3);
            this.gbxMain.Controls.Add(this.txtPort);
            this.gbxMain.Controls.Add(this.label2);
            this.gbxMain.Controls.Add(this.label1);
            this.gbxMain.Controls.Add(this.rBtnCommTcpIp);
            this.gbxMain.Controls.Add(this.rBtnCommSimul);
            this.gbxMain.Controls.Add(this.txtIPAddr);
            this.gbxMain.Controls.Add(this.BtnRunBuffer);
            this.gbxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMain.Location = new System.Drawing.Point(0, 0);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(447, 218);
            this.gbxMain.TabIndex = 3;
            this.gbxMain.TabStop = false;
            this.gbxMain.Text = "Connection And RunBuffer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "min";
            // 
            // BtnAutoExecStop
            // 
            this.BtnAutoExecStop.Location = new System.Drawing.Point(366, 157);
            this.BtnAutoExecStop.Name = "BtnAutoExecStop";
            this.BtnAutoExecStop.Size = new System.Drawing.Size(75, 38);
            this.BtnAutoExecStop.TabIndex = 14;
            this.BtnAutoExecStop.Text = "Stop";
            this.BtnAutoExecStop.UseVisualStyleBackColor = true;
            // 
            // BtnAutoExecStart
            // 
            this.BtnAutoExecStart.Location = new System.Drawing.Point(287, 157);
            this.BtnAutoExecStart.Name = "BtnAutoExecStart";
            this.BtnAutoExecStart.Size = new System.Drawing.Size(75, 38);
            this.BtnAutoExecStart.TabIndex = 13;
            this.BtnAutoExecStart.Text = "Start";
            this.BtnAutoExecStart.UseVisualStyleBackColor = true;
            // 
            // txtAutoExecInterval
            // 
            this.txtAutoExecInterval.Location = new System.Drawing.Point(176, 165);
            this.txtAutoExecInterval.Name = "txtAutoExecInterval";
            this.txtAutoExecInterval.Size = new System.Drawing.Size(72, 21);
            this.txtAutoExecInterval.TabIndex = 12;
            this.txtAutoExecInterval.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "RunBuffer Auto Execution :";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(315, 56);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(126, 30);
            this.BtnDisconnect.TabIndex = 10;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(315, 20);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(126, 30);
            this.BtnConnect.TabIndex = 9;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            // 
            // cbxBufferNum
            // 
            this.cbxBufferNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBufferNum.FormattingEnabled = true;
            this.cbxBufferNum.Location = new System.Drawing.Point(113, 108);
            this.cbxBufferNum.Name = "cbxBufferNum";
            this.cbxBufferNum.Size = new System.Drawing.Size(156, 20);
            this.cbxBufferNum.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buffer Number :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(175, 60);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(128, 21);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "701";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address :";
            // 
            // rBtnCommTcpIp
            // 
            this.rBtnCommTcpIp.AutoSize = true;
            this.rBtnCommTcpIp.Location = new System.Drawing.Point(10, 61);
            this.rBtnCommTcpIp.Name = "rBtnCommTcpIp";
            this.rBtnCommTcpIp.Size = new System.Drawing.Size(65, 16);
            this.rBtnCommTcpIp.TabIndex = 3;
            this.rBtnCommTcpIp.TabStop = true;
            this.rBtnCommTcpIp.Text = "TCP/IP";
            this.rBtnCommTcpIp.UseVisualStyleBackColor = true;
            // 
            // rBtnCommSimul
            // 
            this.rBtnCommSimul.AutoSize = true;
            this.rBtnCommSimul.Location = new System.Drawing.Point(10, 28);
            this.rBtnCommSimul.Name = "rBtnCommSimul";
            this.rBtnCommSimul.Size = new System.Drawing.Size(76, 16);
            this.rBtnCommSimul.TabIndex = 2;
            this.rBtnCommSimul.TabStop = true;
            this.rBtnCommSimul.Text = "Simulator";
            this.rBtnCommSimul.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 485);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.pnlMain.ResumeLayout(false);
            this.gbxMain.ResumeLayout(false);
            this.gbxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerAutoExec;
        private System.Windows.Forms.Button BtnRunBuffer;
        private System.Windows.Forms.TextBox txtIPAddr;
        private System.Windows.Forms.RichTextBox rtxtBox;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnCommTcpIp;
        private System.Windows.Forms.RadioButton rBtnCommSimul;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ComboBox cbxBufferNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutoExecInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAutoExecStop;
        private System.Windows.Forms.Button BtnAutoExecStart;
    }
}

