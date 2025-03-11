namespace Ex2.RunBuffer
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
            this.Disconnect_btn = new System.Windows.Forms.Button();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPtxt = new System.Windows.Forms.TextBox();
            this.PORTtxt = new System.Windows.Forms.TextBox();
            this.RDO_SIM = new System.Windows.Forms.RadioButton();
            this.RDO_TCP = new System.Windows.Forms.RadioButton();
            this.tmrMonitor = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Compstate = new System.Windows.Forms.Label();
            this.lblCompstate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPRG_Status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPRG_Status_LED = new System.Windows.Forms.Label();
            this.upload_btn = new System.Windows.Forms.Button();
            this.Load_btn = new System.Windows.Forms.Button();
            this.compile_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.Runbtn = new System.Windows.Forms.Button();
            this.Stopbtn = new System.Windows.Forms.Button();
            this.Labeltxt = new System.Windows.Forms.TextBox();
            this.BufferNoCombox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bufferPLtxt = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Disconnect_btn);
            this.groupBox1.Controls.Add(this.Connect_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IPtxt);
            this.groupBox1.Controls.Add(this.PORTtxt);
            this.groupBox1.Controls.Add(this.RDO_SIM);
            this.groupBox1.Controls.Add(this.RDO_TCP);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(330, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Setting";
            // 
            // Disconnect_btn
            // 
            this.Disconnect_btn.Enabled = false;
            this.Disconnect_btn.Location = new System.Drawing.Point(212, 69);
            this.Disconnect_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disconnect_btn.Name = "Disconnect_btn";
            this.Disconnect_btn.Size = new System.Drawing.Size(100, 35);
            this.Disconnect_btn.TabIndex = 7;
            this.Disconnect_btn.Text = "Disconnect";
            this.Disconnect_btn.UseVisualStyleBackColor = true;
            this.Disconnect_btn.Click += new System.EventHandler(this.Disconnect_btn_Click);
            // 
            // Connect_btn
            // 
            this.Connect_btn.Location = new System.Drawing.Point(107, 69);
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
            this.label2.Location = new System.Drawing.Point(164, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "PORT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP :";
            // 
            // IPtxt
            // 
            this.IPtxt.Location = new System.Drawing.Point(213, 18);
            this.IPtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(100, 21);
            this.IPtxt.TabIndex = 3;
            this.IPtxt.Text = "10.0.0.100";
            // 
            // PORTtxt
            // 
            this.PORTtxt.Location = new System.Drawing.Point(213, 43);
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
            this.RDO_SIM.Location = new System.Drawing.Point(13, 19);
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
            this.RDO_TCP.Location = new System.Drawing.Point(13, 39);
            this.RDO_TCP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDO_TCP.Name = "RDO_TCP";
            this.RDO_TCP.Size = new System.Drawing.Size(65, 16);
            this.RDO_TCP.TabIndex = 0;
            this.RDO_TCP.TabStop = true;
            this.RDO_TCP.Text = "TCP/IP";
            this.RDO_TCP.UseVisualStyleBackColor = true;
            this.RDO_TCP.CheckedChanged += new System.EventHandler(this.RDO_TCP_CheckedChanged);
            // 
            // tmrMonitor
            // 
            this.tmrMonitor.Tick += new System.EventHandler(this.tmrMonitor_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Compstate);
            this.groupBox2.Controls.Add(this.lblCompstate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblPRG_Status);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblPRG_Status_LED);
            this.groupBox2.Controls.Add(this.upload_btn);
            this.groupBox2.Controls.Add(this.Load_btn);
            this.groupBox2.Controls.Add(this.compile_btn);
            this.groupBox2.Controls.Add(this.clr_btn);
            this.groupBox2.Controls.Add(this.Runbtn);
            this.groupBox2.Controls.Add(this.Stopbtn);
            this.groupBox2.Controls.Add(this.Labeltxt);
            this.groupBox2.Controls.Add(this.BufferNoCombox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(319, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buffer Program Control";
            // 
            // Compstate
            // 
            this.Compstate.AutoSize = true;
            this.Compstate.Location = new System.Drawing.Point(270, 122);
            this.Compstate.Name = "Compstate";
            this.Compstate.Size = new System.Drawing.Size(40, 12);
            this.Compstate.TabIndex = 11;
            this.Compstate.Text = "NONE";
            // 
            // lblCompstate
            // 
            this.lblCompstate.Image = global::Ex2.RunBuffer.Properties.Resources.Off;
            this.lblCompstate.Location = new System.Drawing.Point(243, 118);
            this.lblCompstate.Name = "lblCompstate";
            this.lblCompstate.Size = new System.Drawing.Size(25, 21);
            this.lblCompstate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Compiled : ";
            // 
            // lblPRG_Status
            // 
            this.lblPRG_Status.AutoSize = true;
            this.lblPRG_Status.Location = new System.Drawing.Point(87, 122);
            this.lblPRG_Status.Name = "lblPRG_Status";
            this.lblPRG_Status.Size = new System.Drawing.Size(30, 12);
            this.lblPRG_Status.TabIndex = 10;
            this.lblPRG_Status.Text = "Stop";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status : ";
            // 
            // lblPRG_Status_LED
            // 
            this.lblPRG_Status_LED.BackColor = System.Drawing.SystemColors.Control;
            this.lblPRG_Status_LED.Image = global::Ex2.RunBuffer.Properties.Resources.Off;
            this.lblPRG_Status_LED.Location = new System.Drawing.Point(59, 119);
            this.lblPRG_Status_LED.Name = "lblPRG_Status_LED";
            this.lblPRG_Status_LED.Size = new System.Drawing.Size(24, 18);
            this.lblPRG_Status_LED.TabIndex = 3;
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(212, 42);
            this.upload_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(100, 35);
            this.upload_btn.TabIndex = 8;
            this.upload_btn.Text = "Upload";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // Load_btn
            // 
            this.Load_btn.Location = new System.Drawing.Point(6, 42);
            this.Load_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(100, 35);
            this.Load_btn.TabIndex = 7;
            this.Load_btn.Text = "Load";
            this.Load_btn.UseVisualStyleBackColor = true;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // compile_btn
            // 
            this.compile_btn.Location = new System.Drawing.Point(6, 80);
            this.compile_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compile_btn.Name = "compile_btn";
            this.compile_btn.Size = new System.Drawing.Size(100, 35);
            this.compile_btn.TabIndex = 6;
            this.compile_btn.Text = "Compile";
            this.compile_btn.UseVisualStyleBackColor = true;
            this.compile_btn.Click += new System.EventHandler(this.compile_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.Location = new System.Drawing.Point(212, 80);
            this.clr_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(100, 35);
            this.clr_btn.TabIndex = 3;
            this.clr_btn.Text = "Clear All";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // Runbtn
            // 
            this.Runbtn.Location = new System.Drawing.Point(109, 42);
            this.Runbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Runbtn.Name = "Runbtn";
            this.Runbtn.Size = new System.Drawing.Size(100, 35);
            this.Runbtn.TabIndex = 5;
            this.Runbtn.Text = "RUN";
            this.Runbtn.UseVisualStyleBackColor = true;
            this.Runbtn.Click += new System.EventHandler(this.Runbtn_Click);
            // 
            // Stopbtn
            // 
            this.Stopbtn.Location = new System.Drawing.Point(109, 80);
            this.Stopbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stopbtn.Name = "Stopbtn";
            this.Stopbtn.Size = new System.Drawing.Size(100, 35);
            this.Stopbtn.TabIndex = 4;
            this.Stopbtn.Text = "STOP";
            this.Stopbtn.UseVisualStyleBackColor = true;
            this.Stopbtn.Click += new System.EventHandler(this.Stopbtn_Click);
            // 
            // Labeltxt
            // 
            this.Labeltxt.Location = new System.Drawing.Point(211, 17);
            this.Labeltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Labeltxt.Name = "Labeltxt";
            this.Labeltxt.Size = new System.Drawing.Size(99, 21);
            this.Labeltxt.TabIndex = 3;
            // 
            // BufferNoCombox
            // 
            this.BufferNoCombox.FormattingEnabled = true;
            this.BufferNoCombox.Location = new System.Drawing.Point(77, 17);
            this.BufferNoCombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BufferNoCombox.Name = "BufferNoCombox";
            this.BufferNoCombox.Size = new System.Drawing.Size(63, 20);
            this.BufferNoCombox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buffer No.";
            // 
            // bufferPLtxt
            // 
            this.bufferPLtxt.Location = new System.Drawing.Point(336, 8);
            this.bufferPLtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bufferPLtxt.Name = "bufferPLtxt";
            this.bufferPLtxt.Size = new System.Drawing.Size(295, 337);
            this.bufferPLtxt.TabIndex = 2;
            this.bufferPLtxt.Text = "ENABLE 0\nWAIT 100\n\nPTP/e 0,10000\nWAIT 1000\nGOTO MoveToZero\nSTOP\n\nMoveToZero:\nPTP/" +
    "e 0,0\nSTOP\n\nRelativeMove:\nPTP/re 0,100\nSTOP";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 351);
            this.Controls.Add(this.bufferPLtxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Ex2.RunBuffer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button Disconnect_btn;
        private System.Windows.Forms.Timer tmrMonitor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Stopbtn;
        private System.Windows.Forms.TextBox Labeltxt;
        private System.Windows.Forms.ComboBox BufferNoCombox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Runbtn;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.RichTextBox bufferPLtxt;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.Button compile_btn;
        private System.Windows.Forms.Label lblPRG_Status_LED;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPRG_Status;
        private System.Windows.Forms.Label Compstate;
        private System.Windows.Forms.Label lblCompstate;
        private System.Windows.Forms.Label label5;
    }
}

