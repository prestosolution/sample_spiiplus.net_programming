using System.Windows.Forms;

namespace Ex4.IoControl
{
    partial class Ex4_Main
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRL7 = new System.Windows.Forms.Label();
            this.lblRL6 = new System.Windows.Forms.Label();
            this.lblRL5 = new System.Windows.Forms.Label();
            this.lblRL4 = new System.Windows.Forms.Label();
            this.lblRL3 = new System.Windows.Forms.Label();
            this.lblRL2 = new System.Windows.Forms.Label();
            this.lblRL1 = new System.Windows.Forms.Label();
            this.lblRL0 = new System.Windows.Forms.Label();
            this.lblEMG = new System.Windows.Forms.Label();
            this.lblLL7 = new System.Windows.Forms.Label();
            this.lblLL6 = new System.Windows.Forms.Label();
            this.lblLL5 = new System.Windows.Forms.Label();
            this.lblLL4 = new System.Windows.Forms.Label();
            this.lblLL3 = new System.Windows.Forms.Label();
            this.lblLL2 = new System.Windows.Forms.Label();
            this.lblLL1 = new System.Windows.Forms.Label();
            this.lblLL0 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSW7 = new System.Windows.Forms.Button();
            this.btnSW6 = new System.Windows.Forms.Button();
            this.btnSW5 = new System.Windows.Forms.Button();
            this.btnSW4 = new System.Windows.Forms.Button();
            this.btnSW3 = new System.Windows.Forms.Button();
            this.btnSW2 = new System.Windows.Forms.Button();
            this.btnSW1 = new System.Windows.Forms.Button();
            this.btnSW0 = new System.Windows.Forms.Button();
            this.lblOUT7 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblOUT6 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblOUT5 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblOUT4 = new System.Windows.Forms.Label();
            this.lblOUT3 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblOUT2 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblOUT1 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblOUT0 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblIN7 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblIN6 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblIN5 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.lblIN4 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.lblIN3 = new System.Windows.Forms.Label();
            this.lblIN0 = new System.Windows.Forms.Label();
            this.lblIN2 = new System.Windows.Forms.Label();
            this.lblIN1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(281, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Setting";
            // 
            // Disconnect_btn
            // 
            this.Disconnect_btn.Location = new System.Drawing.Point(186, 68);
            this.Disconnect_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disconnect_btn.Name = "Disconnect_btn";
            this.Disconnect_btn.Size = new System.Drawing.Size(80, 35);
            this.Disconnect_btn.TabIndex = 7;
            this.Disconnect_btn.Text = "Disconnect";
            this.Disconnect_btn.UseVisualStyleBackColor = true;
            this.Disconnect_btn.Click += new System.EventHandler(this.Disconnect_btn_Click);
            // 
            // Connect_btn
            // 
            this.Connect_btn.Location = new System.Drawing.Point(100, 68);
            this.Connect_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(80, 35);
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
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // IPtxt
            // 
            this.IPtxt.Enabled = false;
            this.IPtxt.Location = new System.Drawing.Point(178, 18);
            this.IPtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(88, 21);
            this.IPtxt.TabIndex = 3;
            this.IPtxt.Text = "10.0.0.100";
            // 
            // PORTtxt
            // 
            this.PORTtxt.Enabled = false;
            this.PORTtxt.Location = new System.Drawing.Point(178, 43);
            this.PORTtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PORTtxt.Name = "PORTtxt";
            this.PORTtxt.Size = new System.Drawing.Size(88, 21);
            this.PORTtxt.TabIndex = 2;
            this.PORTtxt.Text = "701";
            // 
            // RDO_SIM
            // 
            this.RDO_SIM.AutoSize = true;
            this.RDO_SIM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RDO_SIM.Checked = true;
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
            this.groupBox2.Controls.Add(this.lblRL7);
            this.groupBox2.Controls.Add(this.lblRL6);
            this.groupBox2.Controls.Add(this.lblRL5);
            this.groupBox2.Controls.Add(this.lblRL4);
            this.groupBox2.Controls.Add(this.lblRL3);
            this.groupBox2.Controls.Add(this.lblRL2);
            this.groupBox2.Controls.Add(this.lblRL1);
            this.groupBox2.Controls.Add(this.lblRL0);
            this.groupBox2.Controls.Add(this.lblEMG);
            this.groupBox2.Controls.Add(this.lblLL7);
            this.groupBox2.Controls.Add(this.lblLL6);
            this.groupBox2.Controls.Add(this.lblLL5);
            this.groupBox2.Controls.Add(this.lblLL4);
            this.groupBox2.Controls.Add(this.lblLL3);
            this.groupBox2.Controls.Add(this.lblLL2);
            this.groupBox2.Controls.Add(this.lblLL1);
            this.groupBox2.Controls.Add(this.lblLL0);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(287, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(289, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Safety State";
            // 
            // lblRL7
            // 
            this.lblRL7.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblRL7.Location = new System.Drawing.Point(222, 71);
            this.lblRL7.Name = "lblRL7";
            this.lblRL7.Size = new System.Drawing.Size(14, 23);
            this.lblRL7.TabIndex = 30;
            // 
            // lblRL6
            // 
            this.lblRL6.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblRL6.Location = new System.Drawing.Point(201, 71);
            this.lblRL6.Name = "lblRL6";
            this.lblRL6.Size = new System.Drawing.Size(14, 23);
            this.lblRL6.TabIndex = 29;
            // 
            // lblRL5
            // 
            this.lblRL5.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblRL5.Location = new System.Drawing.Point(180, 71);
            this.lblRL5.Name = "lblRL5";
            this.lblRL5.Size = new System.Drawing.Size(14, 23);
            this.lblRL5.TabIndex = 28;
            // 
            // lblRL4
            // 
            this.lblRL4.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblRL4.Location = new System.Drawing.Point(159, 71);
            this.lblRL4.Name = "lblRL4";
            this.lblRL4.Size = new System.Drawing.Size(14, 23);
            this.lblRL4.TabIndex = 27;
            // 
            // lblRL3
            // 
            this.lblRL3.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblRL3.Location = new System.Drawing.Point(138, 71);
            this.lblRL3.Name = "lblRL3";
            this.lblRL3.Size = new System.Drawing.Size(14, 23);
            this.lblRL3.TabIndex = 26;
            // 
            // lblRL2
            // 
            this.lblRL2.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblRL2.Location = new System.Drawing.Point(117, 71);
            this.lblRL2.Name = "lblRL2";
            this.lblRL2.Size = new System.Drawing.Size(14, 23);
            this.lblRL2.TabIndex = 25;
            // 
            // lblRL1
            // 
            this.lblRL1.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblRL1.Location = new System.Drawing.Point(96, 71);
            this.lblRL1.Name = "lblRL1";
            this.lblRL1.Size = new System.Drawing.Size(14, 23);
            this.lblRL1.TabIndex = 24;
            // 
            // lblRL0
            // 
            this.lblRL0.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblRL0.Location = new System.Drawing.Point(75, 71);
            this.lblRL0.Name = "lblRL0";
            this.lblRL0.Size = new System.Drawing.Size(14, 23);
            this.lblRL0.TabIndex = 23;
            // 
            // lblEMG
            // 
            this.lblEMG.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblEMG.Location = new System.Drawing.Point(254, 43);
            this.lblEMG.Name = "lblEMG";
            this.lblEMG.Size = new System.Drawing.Size(14, 23);
            this.lblEMG.TabIndex = 21;
            // 
            // lblLL7
            // 
            this.lblLL7.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblLL7.Location = new System.Drawing.Point(222, 43);
            this.lblLL7.Name = "lblLL7";
            this.lblLL7.Size = new System.Drawing.Size(14, 23);
            this.lblLL7.TabIndex = 20;
            // 
            // lblLL6
            // 
            this.lblLL6.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblLL6.Location = new System.Drawing.Point(201, 43);
            this.lblLL6.Name = "lblLL6";
            this.lblLL6.Size = new System.Drawing.Size(14, 23);
            this.lblLL6.TabIndex = 19;
            // 
            // lblLL5
            // 
            this.lblLL5.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblLL5.Location = new System.Drawing.Point(180, 43);
            this.lblLL5.Name = "lblLL5";
            this.lblLL5.Size = new System.Drawing.Size(14, 23);
            this.lblLL5.TabIndex = 18;
            // 
            // lblLL4
            // 
            this.lblLL4.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblLL4.Location = new System.Drawing.Point(159, 43);
            this.lblLL4.Name = "lblLL4";
            this.lblLL4.Size = new System.Drawing.Size(14, 23);
            this.lblLL4.TabIndex = 17;
            // 
            // lblLL3
            // 
            this.lblLL3.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblLL3.Location = new System.Drawing.Point(138, 43);
            this.lblLL3.Name = "lblLL3";
            this.lblLL3.Size = new System.Drawing.Size(14, 23);
            this.lblLL3.TabIndex = 15;
            // 
            // lblLL2
            // 
            this.lblLL2.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblLL2.Location = new System.Drawing.Point(117, 43);
            this.lblLL2.Name = "lblLL2";
            this.lblLL2.Size = new System.Drawing.Size(14, 23);
            this.lblLL2.TabIndex = 14;
            // 
            // lblLL1
            // 
            this.lblLL1.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblLL1.Location = new System.Drawing.Point(96, 43);
            this.lblLL1.Name = "lblLL1";
            this.lblLL1.Size = new System.Drawing.Size(14, 23);
            this.lblLL1.TabIndex = 13;
            // 
            // lblLL0
            // 
            this.lblLL0.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblLL0.Location = new System.Drawing.Point(75, 43);
            this.lblLL0.Name = "lblLL0";
            this.lblLL0.Size = new System.Drawing.Size(14, 23);
            this.lblLL0.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "Right Limit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "Left Limit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "EMG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Axis No";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSW7);
            this.groupBox3.Controls.Add(this.btnSW6);
            this.groupBox3.Controls.Add(this.btnSW5);
            this.groupBox3.Controls.Add(this.btnSW4);
            this.groupBox3.Controls.Add(this.btnSW3);
            this.groupBox3.Controls.Add(this.btnSW2);
            this.groupBox3.Controls.Add(this.btnSW1);
            this.groupBox3.Controls.Add(this.btnSW0);
            this.groupBox3.Controls.Add(this.lblOUT7);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.lblOUT6);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.lblOUT5);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.lblOUT4);
            this.groupBox3.Controls.Add(this.lblOUT3);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.lblOUT2);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.lblOUT1);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.lblOUT0);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.lblIN7);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.lblIN6);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.lblIN5);
            this.groupBox3.Controls.Add(this.label57);
            this.groupBox3.Controls.Add(this.lblIN4);
            this.groupBox3.Controls.Add(this.label58);
            this.groupBox3.Controls.Add(this.lblIN3);
            this.groupBox3.Controls.Add(this.lblIN0);
            this.groupBox3.Controls.Add(this.lblIN2);
            this.groupBox3.Controls.Add(this.lblIN1);
            this.groupBox3.Location = new System.Drawing.Point(0, 114);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(426, 143);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General I/O";
            // 
            // btnSW7
            // 
            this.btnSW7.Location = new System.Drawing.Point(371, 98);
            this.btnSW7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSW7.Name = "btnSW7";
            this.btnSW7.Size = new System.Drawing.Size(40, 35);
            this.btnSW7.TabIndex = 7;
            this.btnSW7.Text = "OFF";
            this.btnSW7.UseVisualStyleBackColor = true;
            this.btnSW7.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // btnSW6
            // 
            this.btnSW6.Location = new System.Drawing.Point(324, 98);
            this.btnSW6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSW6.Name = "btnSW6";
            this.btnSW6.Size = new System.Drawing.Size(40, 35);
            this.btnSW6.TabIndex = 6;
            this.btnSW6.Text = "OFF";
            this.btnSW6.UseVisualStyleBackColor = true;
            this.btnSW6.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // btnSW5
            // 
            this.btnSW5.Location = new System.Drawing.Point(277, 98);
            this.btnSW5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSW5.Name = "btnSW5";
            this.btnSW5.Size = new System.Drawing.Size(40, 35);
            this.btnSW5.TabIndex = 5;
            this.btnSW5.Text = "OFF";
            this.btnSW5.UseVisualStyleBackColor = true;
            this.btnSW5.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // btnSW4
            // 
            this.btnSW4.Location = new System.Drawing.Point(230, 98);
            this.btnSW4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSW4.Name = "btnSW4";
            this.btnSW4.Size = new System.Drawing.Size(40, 35);
            this.btnSW4.TabIndex = 4;
            this.btnSW4.Text = "OFF";
            this.btnSW4.UseVisualStyleBackColor = true;
            this.btnSW4.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // btnSW3
            // 
            this.btnSW3.Location = new System.Drawing.Point(183, 98);
            this.btnSW3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSW3.Name = "btnSW3";
            this.btnSW3.Size = new System.Drawing.Size(40, 35);
            this.btnSW3.TabIndex = 3;
            this.btnSW3.Text = "OFF";
            this.btnSW3.UseVisualStyleBackColor = true;
            this.btnSW3.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // btnSW2
            // 
            this.btnSW2.Location = new System.Drawing.Point(136, 98);
            this.btnSW2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSW2.Name = "btnSW2";
            this.btnSW2.Size = new System.Drawing.Size(40, 35);
            this.btnSW2.TabIndex = 2;
            this.btnSW2.Text = "OFF";
            this.btnSW2.UseVisualStyleBackColor = true;
            this.btnSW2.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // btnSW1
            // 
            this.btnSW1.Location = new System.Drawing.Point(89, 98);
            this.btnSW1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSW1.Name = "btnSW1";
            this.btnSW1.Size = new System.Drawing.Size(40, 35);
            this.btnSW1.TabIndex = 1;
            this.btnSW1.Text = "OFF";
            this.btnSW1.UseVisualStyleBackColor = true;
            this.btnSW1.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // btnSW0
            // 
            this.btnSW0.Location = new System.Drawing.Point(42, 98);
            this.btnSW0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSW0.Name = "btnSW0";
            this.btnSW0.Size = new System.Drawing.Size(40, 35);
            this.btnSW0.TabIndex = 0;
            this.btnSW0.Text = "OFF";
            this.btnSW0.UseVisualStyleBackColor = true;
            this.btnSW0.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // lblOUT7
            // 
            this.lblOUT7.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblOUT7.Location = new System.Drawing.Point(381, 73);
            this.lblOUT7.Name = "lblOUT7";
            this.lblOUT7.Size = new System.Drawing.Size(20, 23);
            this.lblOUT7.TabIndex = 48;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(386, 27);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(11, 12);
            this.label32.TabIndex = 39;
            this.label32.Text = "7";
            // 
            // lblOUT6
            // 
            this.lblOUT6.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblOUT6.Location = new System.Drawing.Point(333, 73);
            this.lblOUT6.Name = "lblOUT6";
            this.lblOUT6.Size = new System.Drawing.Size(23, 23);
            this.lblOUT6.TabIndex = 47;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(5, 27);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(43, 12);
            this.label31.TabIndex = 0;
            this.label31.Text = "Bit No.";
            // 
            // lblOUT5
            // 
            this.lblOUT5.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblOUT5.Location = new System.Drawing.Point(287, 73);
            this.lblOUT5.Name = "lblOUT5";
            this.lblOUT5.Size = new System.Drawing.Size(21, 23);
            this.lblOUT5.TabIndex = 46;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(339, 27);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(11, 12);
            this.label33.TabIndex = 38;
            this.label33.Text = "6";
            // 
            // lblOUT4
            // 
            this.lblOUT4.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblOUT4.Location = new System.Drawing.Point(240, 73);
            this.lblOUT4.Name = "lblOUT4";
            this.lblOUT4.Size = new System.Drawing.Size(20, 23);
            this.lblOUT4.TabIndex = 45;
            // 
            // lblOUT3
            // 
            this.lblOUT3.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblOUT3.Location = new System.Drawing.Point(191, 73);
            this.lblOUT3.Name = "lblOUT3";
            this.lblOUT3.Size = new System.Drawing.Size(24, 23);
            this.lblOUT3.TabIndex = 44;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(292, 27);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(11, 12);
            this.label34.TabIndex = 37;
            this.label34.Text = "5";
            // 
            // lblOUT2
            // 
            this.lblOUT2.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblOUT2.Location = new System.Drawing.Point(146, 73);
            this.lblOUT2.Name = "lblOUT2";
            this.lblOUT2.Size = new System.Drawing.Size(21, 23);
            this.lblOUT2.TabIndex = 43;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(57, 27);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(11, 12);
            this.label39.TabIndex = 32;
            this.label39.Text = "0";
            // 
            // lblOUT1
            // 
            this.lblOUT1.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblOUT1.Location = new System.Drawing.Point(98, 73);
            this.lblOUT1.Name = "lblOUT1";
            this.lblOUT1.Size = new System.Drawing.Size(23, 23);
            this.lblOUT1.TabIndex = 42;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(245, 27);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(11, 12);
            this.label35.TabIndex = 36;
            this.label35.Text = "4";
            // 
            // lblOUT0
            // 
            this.lblOUT0.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblOUT0.Location = new System.Drawing.Point(49, 73);
            this.lblOUT0.Name = "lblOUT0";
            this.lblOUT0.Size = new System.Drawing.Size(27, 23);
            this.lblOUT0.TabIndex = 41;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(104, 27);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(11, 12);
            this.label38.TabIndex = 33;
            this.label38.Text = "1";
            // 
            // lblIN7
            // 
            this.lblIN7.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblIN7.Location = new System.Drawing.Point(380, 50);
            this.lblIN7.Name = "lblIN7";
            this.lblIN7.Size = new System.Drawing.Size(23, 23);
            this.lblIN7.TabIndex = 40;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(198, 27);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(11, 12);
            this.label36.TabIndex = 35;
            this.label36.Text = "3";
            // 
            // lblIN6
            // 
            this.lblIN6.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblIN6.Location = new System.Drawing.Point(333, 50);
            this.lblIN6.Name = "lblIN6";
            this.lblIN6.Size = new System.Drawing.Size(23, 23);
            this.lblIN6.TabIndex = 39;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(151, 27);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(11, 12);
            this.label37.TabIndex = 34;
            this.label37.Text = "2";
            // 
            // lblIN5
            // 
            this.lblIN5.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblIN5.Location = new System.Drawing.Point(287, 50);
            this.lblIN5.Name = "lblIN5";
            this.lblIN5.Size = new System.Drawing.Size(21, 23);
            this.lblIN5.TabIndex = 38;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(-3, 78);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(41, 12);
            this.label57.TabIndex = 32;
            this.label57.Text = "Output";
            // 
            // lblIN4
            // 
            this.lblIN4.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblIN4.Location = new System.Drawing.Point(240, 50);
            this.lblIN4.Name = "lblIN4";
            this.lblIN4.Size = new System.Drawing.Size(20, 23);
            this.lblIN4.TabIndex = 37;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(5, 55);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(32, 12);
            this.label58.TabIndex = 31;
            this.label58.Text = "Input";
            // 
            // lblIN3
            // 
            this.lblIN3.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblIN3.Location = new System.Drawing.Point(192, 50);
            this.lblIN3.Name = "lblIN3";
            this.lblIN3.Size = new System.Drawing.Size(22, 23);
            this.lblIN3.TabIndex = 36;
            // 
            // lblIN0
            // 
            this.lblIN0.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblIN0.Location = new System.Drawing.Point(49, 50);
            this.lblIN0.Name = "lblIN0";
            this.lblIN0.Size = new System.Drawing.Size(27, 23);
            this.lblIN0.TabIndex = 33;
            // 
            // lblIN2
            // 
            this.lblIN2.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblIN2.Location = new System.Drawing.Point(146, 50);
            this.lblIN2.Name = "lblIN2";
            this.lblIN2.Size = new System.Drawing.Size(20, 23);
            this.lblIN2.TabIndex = 35;
            // 
            // lblIN1
            // 
            this.lblIN1.Image = global::Ex4.IoControl.Properties.Resources.Off;
            this.lblIN1.Location = new System.Drawing.Point(98, 50);
            this.lblIN1.Name = "lblIN1";
            this.lblIN1.Size = new System.Drawing.Size(23, 23);
            this.lblIN1.TabIndex = 34;
            // 
            // Ex4_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 264);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ex4_Main";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblLL0;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label lblRL7;
        private Label lblRL6;
        private Label lblRL5;
        private Label lblRL4;
        private Label lblRL3;
        private Label lblRL2;
        private Label lblRL1;
        private Label lblRL0;
        private Label lblEMG;
        private Label lblLL7;
        private Label lblLL6;
        private Label lblLL5;
        private Label lblLL4;
        private Label lblLL3;
        private Label lblLL2;
        private Label lblLL1;
        private GroupBox groupBox3;
        private Label label32;
        private Label label31;
        private Label label33;
        private Label label34;
        private Label label39;
        private Label label35;
        private Label label38;
        private Label label36;
        private Label label37;
        private Label lblOUT7;
        private Label lblOUT6;
        private Label lblOUT5;
        private Label lblOUT4;
        private Label lblOUT3;
        private Label lblOUT2;
        private Label lblOUT1;
        private Label lblOUT0;
        private Label lblIN7;
        private Label lblIN6;
        private Label lblIN5;
        private Label label57;
        private Label lblIN4;
        private Label label58;
        private Label lblIN3;
        private Label lblIN0;
        private Label lblIN2;
        private Label lblIN1;
        private Button btnSW0;
        private Button btnSW7;
        private Button btnSW6;
        private Button btnSW5;
        private Button btnSW4;
        private Button btnSW3;
        private Button btnSW2;
        private Button btnSW1;
    }
}

