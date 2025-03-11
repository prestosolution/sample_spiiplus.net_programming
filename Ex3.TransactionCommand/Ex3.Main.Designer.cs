namespace Ex3.TransactionCommand
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Disconnect_btn = new System.Windows.Forms.Button();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPtxt = new System.Windows.Forms.TextBox();
            this.PORTtxt = new System.Windows.Forms.TextBox();
            this.RDO_SIM = new System.Windows.Forms.RadioButton();
            this.RDO_TCP = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtTerminal = new System.Windows.Forms.RichTextBox();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(693, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Setting";
            // 
            // Disconnect_btn
            // 
            this.Disconnect_btn.Enabled = false;
            this.Disconnect_btn.Location = new System.Drawing.Point(185, 68);
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
            this.Connect_btn.Location = new System.Drawing.Point(82, 68);
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
            this.IPtxt.Location = new System.Drawing.Point(184, 18);
            this.IPtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(100, 21);
            this.IPtxt.TabIndex = 3;
            this.IPtxt.Text = "10.0.0.100";
            // 
            // PORTtxt
            // 
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
            this.RDO_SIM.Location = new System.Drawing.Point(10, 19);
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
            this.RDO_TCP.Location = new System.Drawing.Point(10, 39);
            this.RDO_TCP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDO_TCP.Name = "RDO_TCP";
            this.RDO_TCP.Size = new System.Drawing.Size(65, 16);
            this.RDO_TCP.TabIndex = 0;
            this.RDO_TCP.TabStop = true;
            this.RDO_TCP.Text = "TCP/IP";
            this.RDO_TCP.UseVisualStyleBackColor = true;
            this.RDO_TCP.CheckedChanged += new System.EventHandler(this.RDO_TCP_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(693, 408);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication Terminal";
            // 
            // rtxtTerminal
            // 
            this.rtxtTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtTerminal.Location = new System.Drawing.Point(0, 0);
            this.rtxtTerminal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtTerminal.Name = "rtxtTerminal";
            this.rtxtTerminal.Size = new System.Drawing.Size(687, 353);
            this.rtxtTerminal.TabIndex = 2;
            this.rtxtTerminal.Text = "";
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(596, 6);
            this.Sendbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(85, 25);
            this.Sendbtn.TabIndex = 1;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(6, 8);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(585, 21);
            this.txtCommand.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(693, 527);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCommand);
            this.panel1.Controls.Add(this.Sendbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 37);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtxtTerminal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 353);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 527);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ex3.TransactionCommand";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.RichTextBox rtxtTerminal;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

