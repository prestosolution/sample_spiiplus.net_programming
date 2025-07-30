namespace Ex5.MotorControl
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
            this.components = new System.ComponentModel.Container();
            this.Com_set = new System.Windows.Forms.GroupBox();
            this.Connectbtn = new System.Windows.Forms.Button();
            this.Disconnectbtn = new System.Windows.Forms.Button();
            this.Porttxt = new System.Windows.Forms.TextBox();
            this.IPtxt = new System.Windows.Forms.TextBox();
            this.POrtlabel1 = new System.Windows.Forms.Label();
            this.IPlabel1 = new System.Windows.Forms.Label();
            this.RDO_SIM = new System.Windows.Forms.RadioButton();
            this.RDO_TCP = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblEnable = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblInPos = new System.Windows.Forms.Label();
            this.lblMoving = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Stop_bnf_btn = new System.Windows.Forms.Button();
            this.Start_bnf_btn = new System.Windows.Forms.Button();
            this.change_btn4 = new System.Windows.Forms.Button();
            this.change_btn3 = new System.Windows.Forms.Button();
            this.B_Pos_Read_btn = new System.Windows.Forms.Button();
            this.A_Pos_Read_btn = new System.Windows.Forms.Button();
            this.Dwelltxt = new System.Windows.Forms.TextBox();
            this.PointBtxt = new System.Windows.Forms.TextBox();
            this.PointAtxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Jog_vel_txt = new System.Windows.Forms.TextBox();
            this.chk_use_vel = new System.Windows.Forms.CheckBox();
            this.PJog_btn = new System.Windows.Forms.Button();
            this.NJog_btn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Stop_Re_mo_btn = new System.Windows.Forms.Button();
            this.change_btn2 = new System.Windows.Forms.Button();
            this.Start_Re_mo_btn = new System.Windows.Forms.Button();
            this.Retxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stop_Ab_mo_btn = new System.Windows.Forms.Button();
            this.change_btn1 = new System.Windows.Forms.Button();
            this.start_abs_mo_btn = new System.Windows.Forms.Button();
            this.Abtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Set_Zero_Pos_btn = new System.Windows.Forms.Button();
            this.PEtxt = new System.Windows.Forms.TextBox();
            this.FVELtxt = new System.Windows.Forms.TextBox();
            this.FPOStxt = new System.Windows.Forms.TextBox();
            this.RPOStxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Disable = new System.Windows.Forms.Button();
            this.button_Enable = new System.Windows.Forms.Button();
            this.AxisCombox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.JERKtxt = new System.Windows.Forms.TextBox();
            this.KDECtxt = new System.Windows.Forms.TextBox();
            this.DECtxt = new System.Windows.Forms.TextBox();
            this.ACCtxt = new System.Windows.Forms.TextBox();
            this.Veltxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrMonitor = new System.Windows.Forms.Timer(this.components);
            this.BtnSetMoveParam = new System.Windows.Forms.Button();
            this.Com_set.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Com_set
            // 
            this.Com_set.Controls.Add(this.Connectbtn);
            this.Com_set.Controls.Add(this.Disconnectbtn);
            this.Com_set.Controls.Add(this.Porttxt);
            this.Com_set.Controls.Add(this.IPtxt);
            this.Com_set.Controls.Add(this.POrtlabel1);
            this.Com_set.Controls.Add(this.IPlabel1);
            this.Com_set.Controls.Add(this.RDO_SIM);
            this.Com_set.Controls.Add(this.RDO_TCP);
            this.Com_set.Location = new System.Drawing.Point(3, 14);
            this.Com_set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Com_set.Name = "Com_set";
            this.Com_set.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Com_set.Size = new System.Drawing.Size(210, 109);
            this.Com_set.TabIndex = 0;
            this.Com_set.TabStop = false;
            this.Com_set.Text = "Communication Setting";
            // 
            // Connectbtn
            // 
            this.Connectbtn.Location = new System.Drawing.Point(55, 79);
            this.Connectbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connectbtn.Name = "Connectbtn";
            this.Connectbtn.Size = new System.Drawing.Size(66, 22);
            this.Connectbtn.TabIndex = 6;
            this.Connectbtn.Text = "Connect";
            this.Connectbtn.UseVisualStyleBackColor = true;
            this.Connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // Disconnectbtn
            // 
            this.Disconnectbtn.Enabled = false;
            this.Disconnectbtn.Location = new System.Drawing.Point(126, 79);
            this.Disconnectbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disconnectbtn.Name = "Disconnectbtn";
            this.Disconnectbtn.Size = new System.Drawing.Size(79, 22);
            this.Disconnectbtn.TabIndex = 1;
            this.Disconnectbtn.Text = "Disconnect";
            this.Disconnectbtn.UseVisualStyleBackColor = true;
            this.Disconnectbtn.Click += new System.EventHandler(this.Disconnectbtn_Click);
            // 
            // Porttxt
            // 
            this.Porttxt.Enabled = false;
            this.Porttxt.Location = new System.Drawing.Point(109, 48);
            this.Porttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Porttxt.Name = "Porttxt";
            this.Porttxt.Size = new System.Drawing.Size(96, 23);
            this.Porttxt.TabIndex = 5;
            this.Porttxt.Text = "701";
            // 
            // IPtxt
            // 
            this.IPtxt.Enabled = false;
            this.IPtxt.Location = new System.Drawing.Point(109, 20);
            this.IPtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(96, 23);
            this.IPtxt.TabIndex = 4;
            this.IPtxt.Text = "10.0.0.100";
            // 
            // POrtlabel1
            // 
            this.POrtlabel1.AutoSize = true;
            this.POrtlabel1.Location = new System.Drawing.Point(82, 48);
            this.POrtlabel1.Name = "POrtlabel1";
            this.POrtlabel1.Size = new System.Drawing.Size(29, 15);
            this.POrtlabel1.TabIndex = 3;
            this.POrtlabel1.Text = "Port";
            // 
            // IPlabel1
            // 
            this.IPlabel1.AutoSize = true;
            this.IPlabel1.Location = new System.Drawing.Point(82, 25);
            this.IPlabel1.Name = "IPlabel1";
            this.IPlabel1.Size = new System.Drawing.Size(17, 15);
            this.IPlabel1.TabIndex = 2;
            this.IPlabel1.Text = "IP";
            // 
            // RDO_SIM
            // 
            this.RDO_SIM.AutoSize = true;
            this.RDO_SIM.Checked = true;
            this.RDO_SIM.Location = new System.Drawing.Point(3, 46);
            this.RDO_SIM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDO_SIM.Name = "RDO_SIM";
            this.RDO_SIM.Size = new System.Drawing.Size(76, 19);
            this.RDO_SIM.TabIndex = 1;
            this.RDO_SIM.TabStop = true;
            this.RDO_SIM.Text = "Simulator";
            this.RDO_SIM.UseVisualStyleBackColor = true;
            this.RDO_SIM.CheckedChanged += new System.EventHandler(this.RDO_SIM_CheckedChanged);
            // 
            // RDO_TCP
            // 
            this.RDO_TCP.AutoSize = true;
            this.RDO_TCP.Location = new System.Drawing.Point(3, 21);
            this.RDO_TCP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RDO_TCP.Name = "RDO_TCP";
            this.RDO_TCP.Size = new System.Drawing.Size(47, 19);
            this.RDO_TCP.TabIndex = 0;
            this.RDO_TCP.Text = "TCP";
            this.RDO_TCP.UseVisualStyleBackColor = true;
            this.RDO_TCP.CheckedChanged += new System.EventHandler(this.RDO_TCP_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button_Disable);
            this.groupBox1.Controls.Add(this.button_Enable);
            this.groupBox1.Controls.Add(this.AxisCombox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(568, 460);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motion Set";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblEnable);
            this.groupBox8.Controls.Add(this.lblAcc);
            this.groupBox8.Controls.Add(this.lblInPos);
            this.groupBox8.Controls.Add(this.lblMoving);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Location = new System.Drawing.Point(375, 326);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(183, 128);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Motor State (MST)";
            // 
            // lblEnable
            // 
            this.lblEnable.Image = global::Ex5.MotorControl.Properties.Resources.Off;
            this.lblEnable.Location = new System.Drawing.Point(120, 96);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(27, 29);
            this.lblEnable.TabIndex = 22;
            // 
            // lblAcc
            // 
            this.lblAcc.Image = global::Ex5.MotorControl.Properties.Resources.Off;
            this.lblAcc.Location = new System.Drawing.Point(120, 45);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(27, 29);
            this.lblAcc.TabIndex = 21;
            // 
            // lblInPos
            // 
            this.lblInPos.Image = global::Ex5.MotorControl.Properties.Resources.Off;
            this.lblInPos.Location = new System.Drawing.Point(120, 68);
            this.lblInPos.Name = "lblInPos";
            this.lblInPos.Size = new System.Drawing.Size(27, 32);
            this.lblInPos.TabIndex = 21;
            // 
            // lblMoving
            // 
            this.lblMoving.Image = global::Ex5.MotorControl.Properties.Resources.Off;
            this.lblMoving.Location = new System.Drawing.Point(120, 19);
            this.lblMoving.Name = "lblMoving";
            this.lblMoving.Size = new System.Drawing.Size(27, 29);
            this.lblMoving.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 15);
            this.label19.TabIndex = 19;
            this.label19.Text = "Enable";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "In Position";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Accelerating";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Moving";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.Stop_bnf_btn);
            this.groupBox7.Controls.Add(this.Start_bnf_btn);
            this.groupBox7.Controls.Add(this.change_btn4);
            this.groupBox7.Controls.Add(this.change_btn3);
            this.groupBox7.Controls.Add(this.B_Pos_Read_btn);
            this.groupBox7.Controls.Add(this.A_Pos_Read_btn);
            this.groupBox7.Controls.Add(this.Dwelltxt);
            this.groupBox7.Controls.Add(this.PointBtxt);
            this.groupBox7.Controls.Add(this.PointAtxt);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(8, 326);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(362, 128);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Back and Forth";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(158, 78);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 11);
            this.label25.TabIndex = 17;
            this.label25.Text = "ms";
            // 
            // Stop_bnf_btn
            // 
            this.Stop_bnf_btn.Enabled = false;
            this.Stop_bnf_btn.Location = new System.Drawing.Point(179, 99);
            this.Stop_bnf_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stop_bnf_btn.Name = "Stop_bnf_btn";
            this.Stop_bnf_btn.Size = new System.Drawing.Size(175, 22);
            this.Stop_bnf_btn.TabIndex = 17;
            this.Stop_bnf_btn.Text = "Stop Back and Forth Move";
            this.Stop_bnf_btn.UseVisualStyleBackColor = true;
            this.Stop_bnf_btn.Click += new System.EventHandler(this.Stop_bnf_btn_Click);
            // 
            // Start_bnf_btn
            // 
            this.Start_bnf_btn.Location = new System.Drawing.Point(5, 98);
            this.Start_bnf_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_bnf_btn.Name = "Start_bnf_btn";
            this.Start_bnf_btn.Size = new System.Drawing.Size(171, 25);
            this.Start_bnf_btn.TabIndex = 16;
            this.Start_bnf_btn.Text = "Start Back and Forth Move";
            this.Start_bnf_btn.UseVisualStyleBackColor = true;
            this.Start_bnf_btn.Click += new System.EventHandler(this.Start_bnf_btn_Click);
            // 
            // change_btn4
            // 
            this.change_btn4.Location = new System.Drawing.Point(228, 46);
            this.change_btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_btn4.Name = "change_btn4";
            this.change_btn4.Size = new System.Drawing.Size(41, 22);
            this.change_btn4.TabIndex = 15;
            this.change_btn4.Text = "+/-";
            this.change_btn4.UseVisualStyleBackColor = true;
            this.change_btn4.Click += new System.EventHandler(this.change_btn4_Click);
            // 
            // change_btn3
            // 
            this.change_btn3.Location = new System.Drawing.Point(228, 20);
            this.change_btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_btn3.Name = "change_btn3";
            this.change_btn3.Size = new System.Drawing.Size(41, 22);
            this.change_btn3.TabIndex = 14;
            this.change_btn3.Text = "+/-";
            this.change_btn3.UseVisualStyleBackColor = true;
            this.change_btn3.Click += new System.EventHandler(this.change_btn3_Click);
            // 
            // B_Pos_Read_btn
            // 
            this.B_Pos_Read_btn.Location = new System.Drawing.Point(158, 46);
            this.B_Pos_Read_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Pos_Read_btn.Name = "B_Pos_Read_btn";
            this.B_Pos_Read_btn.Size = new System.Drawing.Size(66, 22);
            this.B_Pos_Read_btn.TabIndex = 13;
            this.B_Pos_Read_btn.Text = "Read";
            this.B_Pos_Read_btn.UseVisualStyleBackColor = true;
            this.B_Pos_Read_btn.Click += new System.EventHandler(this.B_Pos_Read_btn_Click);
            // 
            // A_Pos_Read_btn
            // 
            this.A_Pos_Read_btn.Location = new System.Drawing.Point(158, 21);
            this.A_Pos_Read_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A_Pos_Read_btn.Name = "A_Pos_Read_btn";
            this.A_Pos_Read_btn.Size = new System.Drawing.Size(66, 22);
            this.A_Pos_Read_btn.TabIndex = 9;
            this.A_Pos_Read_btn.Text = "Read";
            this.A_Pos_Read_btn.UseVisualStyleBackColor = true;
            this.A_Pos_Read_btn.Click += new System.EventHandler(this.A_Pos_Read_btn_Click);
            // 
            // Dwelltxt
            // 
            this.Dwelltxt.Location = new System.Drawing.Point(65, 70);
            this.Dwelltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dwelltxt.Name = "Dwelltxt";
            this.Dwelltxt.Size = new System.Drawing.Size(88, 23);
            this.Dwelltxt.TabIndex = 12;
            this.Dwelltxt.Text = "0";
            // 
            // PointBtxt
            // 
            this.PointBtxt.Location = new System.Drawing.Point(65, 44);
            this.PointBtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PointBtxt.Name = "PointBtxt";
            this.PointBtxt.Size = new System.Drawing.Size(88, 23);
            this.PointBtxt.TabIndex = 11;
            // 
            // PointAtxt
            // 
            this.PointAtxt.Location = new System.Drawing.Point(65, 18);
            this.PointAtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PointAtxt.Name = "PointAtxt";
            this.PointAtxt.Size = new System.Drawing.Size(88, 23);
            this.PointAtxt.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Dwell    : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Point B : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Point A : ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Jog_vel_txt);
            this.groupBox6.Controls.Add(this.chk_use_vel);
            this.groupBox6.Controls.Add(this.PJog_btn);
            this.groupBox6.Controls.Add(this.NJog_btn);
            this.groupBox6.Location = new System.Drawing.Point(355, 237);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(203, 85);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Jog Motion";
            // 
            // Jog_vel_txt
            // 
            this.Jog_vel_txt.Location = new System.Drawing.Point(108, 25);
            this.Jog_vel_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Jog_vel_txt.Name = "Jog_vel_txt";
            this.Jog_vel_txt.Size = new System.Drawing.Size(88, 23);
            this.Jog_vel_txt.TabIndex = 9;
            // 
            // chk_use_vel
            // 
            this.chk_use_vel.AutoSize = true;
            this.chk_use_vel.Location = new System.Drawing.Point(5, 28);
            this.chk_use_vel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_use_vel.Name = "chk_use_vel";
            this.chk_use_vel.Size = new System.Drawing.Size(90, 19);
            this.chk_use_vel.TabIndex = 10;
            this.chk_use_vel.Text = "Use Velocity";
            this.chk_use_vel.UseVisualStyleBackColor = true;
            // 
            // PJog_btn
            // 
            this.PJog_btn.Location = new System.Drawing.Point(108, 54);
            this.PJog_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PJog_btn.Name = "PJog_btn";
            this.PJog_btn.Size = new System.Drawing.Size(86, 25);
            this.PJog_btn.TabIndex = 1;
            this.PJog_btn.Text = "Positive >>";
            this.PJog_btn.UseVisualStyleBackColor = true;
            this.PJog_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PJog_btn_MouseDown);
            this.PJog_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PJog_btn_MouseUp);
            // 
            // NJog_btn
            // 
            this.NJog_btn.Location = new System.Drawing.Point(5, 54);
            this.NJog_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NJog_btn.Name = "NJog_btn";
            this.NJog_btn.Size = new System.Drawing.Size(97, 26);
            this.NJog_btn.TabIndex = 0;
            this.NJog_btn.Text = "<< Negative";
            this.NJog_btn.UseVisualStyleBackColor = true;
            this.NJog_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NJog_btn_MouseDown);
            this.NJog_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NJog_btn_MouseUp);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Stop_Re_mo_btn);
            this.groupBox5.Controls.Add(this.change_btn2);
            this.groupBox5.Controls.Add(this.Start_Re_mo_btn);
            this.groupBox5.Controls.Add(this.Retxt);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(180, 237);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(170, 85);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Relative Move";
            // 
            // Stop_Re_mo_btn
            // 
            this.Stop_Re_mo_btn.Location = new System.Drawing.Point(7, 54);
            this.Stop_Re_mo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stop_Re_mo_btn.Name = "Stop_Re_mo_btn";
            this.Stop_Re_mo_btn.Size = new System.Drawing.Size(66, 26);
            this.Stop_Re_mo_btn.TabIndex = 15;
            this.Stop_Re_mo_btn.Text = "Stop";
            this.Stop_Re_mo_btn.UseVisualStyleBackColor = true;
            this.Stop_Re_mo_btn.Click += new System.EventHandler(this.Stop_Re_mo_btn_Click);
            // 
            // change_btn2
            // 
            this.change_btn2.Location = new System.Drawing.Point(129, 21);
            this.change_btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_btn2.Name = "change_btn2";
            this.change_btn2.Size = new System.Drawing.Size(41, 22);
            this.change_btn2.TabIndex = 14;
            this.change_btn2.Text = "+/-";
            this.change_btn2.UseVisualStyleBackColor = true;
            this.change_btn2.Click += new System.EventHandler(this.change_btn2_Click);
            // 
            // Start_Re_mo_btn
            // 
            this.Start_Re_mo_btn.Location = new System.Drawing.Point(80, 54);
            this.Start_Re_mo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_Re_mo_btn.Name = "Start_Re_mo_btn";
            this.Start_Re_mo_btn.Size = new System.Drawing.Size(90, 26);
            this.Start_Re_mo_btn.TabIndex = 13;
            this.Start_Re_mo_btn.Text = "Start Motion";
            this.Start_Re_mo_btn.UseVisualStyleBackColor = true;
            this.Start_Re_mo_btn.Click += new System.EventHandler(this.Start_Re_mo_btn_Click);
            // 
            // Retxt
            // 
            this.Retxt.Location = new System.Drawing.Point(64, 18);
            this.Retxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Retxt.Name = "Retxt";
            this.Retxt.Size = new System.Drawing.Size(64, 23);
            this.Retxt.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Move by";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stop_Ab_mo_btn);
            this.groupBox4.Controls.Add(this.change_btn1);
            this.groupBox4.Controls.Add(this.start_abs_mo_btn);
            this.groupBox4.Controls.Add(this.Abtxt);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(8, 237);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(167, 85);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Absolute Move";
            // 
            // stop_Ab_mo_btn
            // 
            this.stop_Ab_mo_btn.Location = new System.Drawing.Point(4, 54);
            this.stop_Ab_mo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop_Ab_mo_btn.Name = "stop_Ab_mo_btn";
            this.stop_Ab_mo_btn.Size = new System.Drawing.Size(66, 26);
            this.stop_Ab_mo_btn.TabIndex = 14;
            this.stop_Ab_mo_btn.Text = "Stop";
            this.stop_Ab_mo_btn.UseVisualStyleBackColor = true;
            this.stop_Ab_mo_btn.Click += new System.EventHandler(this.stop_abs_mo_btn_Click);
            // 
            // change_btn1
            // 
            this.change_btn1.Location = new System.Drawing.Point(126, 21);
            this.change_btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_btn1.Name = "change_btn1";
            this.change_btn1.Size = new System.Drawing.Size(41, 22);
            this.change_btn1.TabIndex = 9;
            this.change_btn1.Text = "+/-";
            this.change_btn1.UseVisualStyleBackColor = true;
            this.change_btn1.Click += new System.EventHandler(this.change_btn1_Click);
            // 
            // start_abs_mo_btn
            // 
            this.start_abs_mo_btn.Location = new System.Drawing.Point(74, 54);
            this.start_abs_mo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_abs_mo_btn.Name = "start_abs_mo_btn";
            this.start_abs_mo_btn.Size = new System.Drawing.Size(93, 26);
            this.start_abs_mo_btn.TabIndex = 13;
            this.start_abs_mo_btn.Text = "Start Motion";
            this.start_abs_mo_btn.UseVisualStyleBackColor = true;
            this.start_abs_mo_btn.Click += new System.EventHandler(this.start_abs_mo_btn_Click);
            // 
            // Abtxt
            // 
            this.Abtxt.Location = new System.Drawing.Point(61, 18);
            this.Abtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Abtxt.Name = "Abtxt";
            this.Abtxt.Size = new System.Drawing.Size(64, 23);
            this.Abtxt.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Move by";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Set_Zero_Pos_btn);
            this.groupBox3.Controls.Add(this.PEtxt);
            this.groupBox3.Controls.Add(this.FVELtxt);
            this.groupBox3.Controls.Add(this.FPOStxt);
            this.groupBox3.Controls.Add(this.RPOStxt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(283, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(276, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Position";
            // 
            // Set_Zero_Pos_btn
            // 
            this.Set_Zero_Pos_btn.Location = new System.Drawing.Point(110, 140);
            this.Set_Zero_Pos_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Set_Zero_Pos_btn.Name = "Set_Zero_Pos_btn";
            this.Set_Zero_Pos_btn.Size = new System.Drawing.Size(160, 35);
            this.Set_Zero_Pos_btn.TabIndex = 15;
            this.Set_Zero_Pos_btn.Text = "Set Zero Position";
            this.Set_Zero_Pos_btn.UseVisualStyleBackColor = true;
            this.Set_Zero_Pos_btn.Click += new System.EventHandler(this.Set_Zero_Pos_btn_Click);
            // 
            // PEtxt
            // 
            this.PEtxt.Location = new System.Drawing.Point(181, 108);
            this.PEtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PEtxt.Name = "PEtxt";
            this.PEtxt.ReadOnly = true;
            this.PEtxt.Size = new System.Drawing.Size(88, 23);
            this.PEtxt.TabIndex = 14;
            // 
            // FVELtxt
            // 
            this.FVELtxt.Location = new System.Drawing.Point(181, 78);
            this.FVELtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FVELtxt.Name = "FVELtxt";
            this.FVELtxt.ReadOnly = true;
            this.FVELtxt.Size = new System.Drawing.Size(88, 23);
            this.FVELtxt.TabIndex = 13;
            // 
            // FPOStxt
            // 
            this.FPOStxt.Location = new System.Drawing.Point(181, 48);
            this.FPOStxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FPOStxt.Name = "FPOStxt";
            this.FPOStxt.ReadOnly = true;
            this.FPOStxt.Size = new System.Drawing.Size(88, 23);
            this.FPOStxt.TabIndex = 12;
            // 
            // RPOStxt
            // 
            this.RPOStxt.Location = new System.Drawing.Point(181, 18);
            this.RPOStxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RPOStxt.Name = "RPOStxt";
            this.RPOStxt.ReadOnly = true;
            this.RPOStxt.Size = new System.Drawing.Size(88, 23);
            this.RPOStxt.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Position Error (PE)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Actual Velocity (FVEL)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Feedback Position (FPOS)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Reference Position (RPOS)";
            // 
            // button_Disable
            // 
            this.button_Disable.Enabled = false;
            this.button_Disable.Location = new System.Drawing.Point(265, 11);
            this.button_Disable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Disable.Name = "button_Disable";
            this.button_Disable.Size = new System.Drawing.Size(70, 35);
            this.button_Disable.TabIndex = 6;
            this.button_Disable.Text = "Disable";
            this.button_Disable.UseVisualStyleBackColor = true;
            this.button_Disable.Click += new System.EventHandler(this.button_Disable_Click);
            // 
            // button_Enable
            // 
            this.button_Enable.Location = new System.Drawing.Point(194, 11);
            this.button_Enable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Enable.Name = "button_Enable";
            this.button_Enable.Size = new System.Drawing.Size(70, 35);
            this.button_Enable.TabIndex = 5;
            this.button_Enable.Text = "Enable";
            this.button_Enable.UseVisualStyleBackColor = true;
            this.button_Enable.Click += new System.EventHandler(this.button_Enable_Click);
            // 
            // AxisCombox
            // 
            this.AxisCombox.FormattingEnabled = true;
            this.AxisCombox.Location = new System.Drawing.Point(107, 18);
            this.AxisCombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AxisCombox.Name = "AxisCombox";
            this.AxisCombox.Size = new System.Drawing.Size(80, 23);
            this.AxisCombox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Axis No. ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSetMoveParam);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.JERKtxt);
            this.groupBox2.Controls.Add(this.KDECtxt);
            this.groupBox2.Controls.Add(this.DECtxt);
            this.groupBox2.Controls.Add(this.ACCtxt);
            this.groupBox2.Controls.Add(this.Veltxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(270, 187);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motion Profile";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(226, 129);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 11);
            this.label24.TabIndex = 16;
            this.label24.Text = "m/s^3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(226, 102);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 11);
            this.label23.TabIndex = 15;
            this.label23.Text = "m/s^2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(226, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 11);
            this.label22.TabIndex = 14;
            this.label22.Text = "m/s^2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(226, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 11);
            this.label21.TabIndex = 13;
            this.label21.Text = "m/s^2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(226, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 11);
            this.label20.TabIndex = 12;
            this.label20.Text = "m/s";
            // 
            // JERKtxt
            // 
            this.JERKtxt.Location = new System.Drawing.Point(148, 123);
            this.JERKtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JERKtxt.Name = "JERKtxt";
            this.JERKtxt.Size = new System.Drawing.Size(73, 23);
            this.JERKtxt.TabIndex = 11;
            // 
            // KDECtxt
            // 
            this.KDECtxt.Location = new System.Drawing.Point(148, 96);
            this.KDECtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KDECtxt.Name = "KDECtxt";
            this.KDECtxt.Size = new System.Drawing.Size(73, 23);
            this.KDECtxt.TabIndex = 10;
            // 
            // DECtxt
            // 
            this.DECtxt.Location = new System.Drawing.Point(148, 69);
            this.DECtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DECtxt.Name = "DECtxt";
            this.DECtxt.Size = new System.Drawing.Size(73, 23);
            this.DECtxt.TabIndex = 9;
            // 
            // ACCtxt
            // 
            this.ACCtxt.Location = new System.Drawing.Point(148, 42);
            this.ACCtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ACCtxt.Name = "ACCtxt";
            this.ACCtxt.Size = new System.Drawing.Size(73, 23);
            this.ACCtxt.TabIndex = 8;
            // 
            // Veltxt
            // 
            this.Veltxt.Location = new System.Drawing.Point(148, 15);
            this.Veltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Veltxt.Name = "Veltxt";
            this.Veltxt.Size = new System.Drawing.Size(73, 23);
            this.Veltxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Jerk(JERK)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kill Deceleration(KDEC)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Deceleration(DEC)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Acceleration(ACC)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Velocity(VEL)";
            // 
            // tmrMonitor
            // 
            this.tmrMonitor.Tick += new System.EventHandler(this.tmrMonitor_Tick);
            // 
            // BtnSetMoveParam
            // 
            this.BtnSetMoveParam.Location = new System.Drawing.Point(113, 151);
            this.BtnSetMoveParam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSetMoveParam.Name = "BtnSetMoveParam";
            this.BtnSetMoveParam.Size = new System.Drawing.Size(150, 30);
            this.BtnSetMoveParam.TabIndex = 17;
            this.BtnSetMoveParam.Text = "Set Move Param";
            this.BtnSetMoveParam.UseVisualStyleBackColor = true;
            this.BtnSetMoveParam.Click += new System.EventHandler(this.BtnSetMoveParam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 591);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Com_set);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "1. Single Axis Control";
            this.Com_set.ResumeLayout(false);
            this.Com_set.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Com_set;
        private System.Windows.Forms.Button Connectbtn;
        private System.Windows.Forms.Button Disconnectbtn;
        private System.Windows.Forms.TextBox Porttxt;
        private System.Windows.Forms.TextBox IPtxt;
        private System.Windows.Forms.Label POrtlabel1;
        private System.Windows.Forms.Label IPlabel1;
        private System.Windows.Forms.RadioButton RDO_SIM;
        private System.Windows.Forms.RadioButton RDO_TCP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox AxisCombox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Disable;
        private System.Windows.Forms.Button button_Enable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox JERKtxt;
        private System.Windows.Forms.TextBox KDECtxt;
        private System.Windows.Forms.TextBox DECtxt;
        private System.Windows.Forms.TextBox ACCtxt;
        private System.Windows.Forms.TextBox Veltxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrMonitor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Set_Zero_Pos_btn;
        private System.Windows.Forms.TextBox PEtxt;
        private System.Windows.Forms.TextBox FVELtxt;
        private System.Windows.Forms.TextBox FPOStxt;
        private System.Windows.Forms.TextBox RPOStxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Abtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Retxt;
        private System.Windows.Forms.Button start_abs_mo_btn;
        private System.Windows.Forms.Button Start_Re_mo_btn;
        private System.Windows.Forms.Button change_btn2;
        private System.Windows.Forms.Button change_btn1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button PJog_btn;
        private System.Windows.Forms.Button NJog_btn;
        private System.Windows.Forms.TextBox Jog_vel_txt;
        private System.Windows.Forms.CheckBox chk_use_vel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button B_Pos_Read_btn;
        private System.Windows.Forms.Button A_Pos_Read_btn;
        private System.Windows.Forms.TextBox Dwelltxt;
        private System.Windows.Forms.TextBox PointBtxt;
        private System.Windows.Forms.TextBox PointAtxt;
        private System.Windows.Forms.Button change_btn4;
        private System.Windows.Forms.Button change_btn3;
        private System.Windows.Forms.Button Start_bnf_btn;
        private System.Windows.Forms.Button Stop_bnf_btn;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblEnable;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblInPos;
        private System.Windows.Forms.Label lblMoving;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Stop_Re_mo_btn;
        private System.Windows.Forms.Button stop_Ab_mo_btn;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BtnSetMoveParam;
    }
}

