namespace Ex1.Communication
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connect_state = new System.Windows.Forms.Label();
            this.lbl_connect_state = new System.Windows.Forms.Label();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPtxt = new System.Windows.Forms.TextBox();
            this.PORTtxt = new System.Windows.Forms.TextBox();
            this.RDO_SIM = new System.Windows.Forms.RadioButton();
            this.RDO_TCP = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnControllerReboot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnControllerReboot);
            this.groupBox1.Controls.Add(this.connect_state);
            this.groupBox1.Controls.Add(this.lbl_connect_state);
            this.groupBox1.Controls.Add(this.disconnect_btn);
            this.groupBox1.Controls.Add(this.Connect_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IPtxt);
            this.groupBox1.Controls.Add(this.PORTtxt);
            this.groupBox1.Controls.Add(this.RDO_SIM);
            this.groupBox1.Controls.Add(this.RDO_TCP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(323, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Setting";
            // 
            // connect_state
            // 
            this.connect_state.AutoSize = true;
            this.connect_state.Location = new System.Drawing.Point(15, 71);
            this.connect_state.Name = "connect_state";
            this.connect_state.Size = new System.Drawing.Size(82, 12);
            this.connect_state.TabIndex = 8;
            this.connect_state.Text = "Disconnected";
            // 
            // lbl_connect_state
            // 
            this.lbl_connect_state.Image = global::Ex1.Communication.Properties.Resources.Off;
            this.lbl_connect_state.Location = new System.Drawing.Point(42, 87);
            this.lbl_connect_state.Name = "lbl_connect_state";
            this.lbl_connect_state.Size = new System.Drawing.Size(23, 22);
            this.lbl_connect_state.TabIndex = 1;
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Enabled = false;
            this.disconnect_btn.Location = new System.Drawing.Point(214, 77);
            this.disconnect_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(100, 35);
            this.disconnect_btn.TabIndex = 7;
            this.disconnect_btn.Text = "Disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // Connect_btn
            // 
            this.Connect_btn.Location = new System.Drawing.Point(110, 77);
            this.Connect_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(100, 35);
            this.Connect_btn.TabIndex = 6;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "PORT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP :";
            // 
            // IPtxt
            // 
            this.IPtxt.Enabled = false;
            this.IPtxt.Location = new System.Drawing.Point(184, 18);
            this.IPtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(100, 21);
            this.IPtxt.TabIndex = 3;
            this.IPtxt.Text = "10.0.0.100";
            // 
            // PORTtxt
            // 
            this.PORTtxt.Enabled = false;
            this.PORTtxt.Location = new System.Drawing.Point(184, 43);
            this.PORTtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PORTtxt.Name = "PORTtxt";
            this.PORTtxt.Size = new System.Drawing.Size(100, 21);
            this.PORTtxt.TabIndex = 2;
            this.PORTtxt.Text = "701";
            // 
            // RDO_SIM
            // 
            this.RDO_SIM.AutoSize = true;
            this.RDO_SIM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RDO_SIM.Checked = true;
            this.RDO_SIM.Location = new System.Drawing.Point(17, 21);
            this.RDO_SIM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDO_SIM.Name = "RDO_SIM";
            this.RDO_SIM.Size = new System.Drawing.Size(76, 16);
            this.RDO_SIM.TabIndex = 1;
            this.RDO_SIM.TabStop = true;
            this.RDO_SIM.Text = "Simulator";
            this.RDO_SIM.UseVisualStyleBackColor = false;
            this.RDO_SIM.CheckedChanged += new System.EventHandler(this.RDO_SIM_CheckedChanged);
            // 
            // RDO_TCP
            // 
            this.RDO_TCP.AutoSize = true;
            this.RDO_TCP.Location = new System.Drawing.Point(17, 41);
            this.RDO_TCP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDO_TCP.Name = "RDO_TCP";
            this.RDO_TCP.Size = new System.Drawing.Size(65, 16);
            this.RDO_TCP.TabIndex = 0;
            this.RDO_TCP.Text = "TCP/IP";
            this.RDO_TCP.UseVisualStyleBackColor = true;
            this.RDO_TCP.CheckedChanged += new System.EventHandler(this.RDO_TCP_CheckedChanged);
            // 
            // BtnControllerReboot
            // 
            this.BtnControllerReboot.Location = new System.Drawing.Point(110, 117);
            this.BtnControllerReboot.Name = "BtnControllerReboot";
            this.BtnControllerReboot.Size = new System.Drawing.Size(204, 34);
            this.BtnControllerReboot.TabIndex = 9;
            this.BtnControllerReboot.Text = "Controller Reboot";
            this.BtnControllerReboot.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 157);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Ex0.Communication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDO_TCP;
        private System.Windows.Forms.RadioButton RDO_SIM;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPtxt;
        private System.Windows.Forms.TextBox PORTtxt;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_connect_state;
        private System.Windows.Forms.Label connect_state;
        private System.Windows.Forms.Button BtnControllerReboot;
    }
}

