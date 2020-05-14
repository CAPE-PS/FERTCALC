namespace FERTCALC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tank = new System.Windows.Forms.TextBox();
            this.Container = new System.Windows.Forms.TextBox();
            this.Dosing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.PPMNO3 = new System.Windows.Forms.TextBox();
            this.PPMK = new System.Windows.Forms.TextBox();
            this.PPMPO4 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.PPMMG = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.MixK2SO4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.MixKH2PO4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MixKNO3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.MixMgSO4 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label22 = new System.Windows.Forms.Label();
            this.mlNO3 = new System.Windows.Forms.TextBox();
            this.mlK = new System.Windows.Forms.TextBox();
            this.mlPO4 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.DNO3 = new System.Windows.Forms.TextBox();
            this.DK = new System.Windows.Forms.TextBox();
            this.DPO4 = new System.Windows.Forms.TextBox();
            this.WNO3 = new System.Windows.Forms.TextBox();
            this.WK = new System.Windows.Forms.TextBox();
            this.WPO4 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mlMg = new System.Windows.Forms.TextBox();
            this.DMg = new System.Windows.Forms.TextBox();
            this.WMg = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tank
            // 
            this.Tank.Location = new System.Drawing.Point(112, 19);
            this.Tank.Name = "Tank";
            this.Tank.Size = new System.Drawing.Size(42, 20);
            this.Tank.TabIndex = 0;
            this.Tank.Text = "17";
            this.Tank.Validated += new System.EventHandler(this.Tank_Validated);
            // 
            // Container
            // 
            this.Container.Location = new System.Drawing.Point(112, 45);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(42, 20);
            this.Container.TabIndex = 1;
            this.Container.Text = "500";
            this.Container.Validated += new System.EventHandler(this.Tank_Validated);
            // 
            // Dosing
            // 
            this.Dosing.Location = new System.Drawing.Point(112, 71);
            this.Dosing.Name = "Dosing";
            this.Dosing.Size = new System.Drawing.Size(42, 20);
            this.Dosing.TabIndex = 2;
            this.Dosing.Text = "10";
            this.Dosing.Validated += new System.EventHandler(this.Tank_Validated);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tank size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Container";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dosing";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Days per week";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(112, 98);
            this.Days.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Days.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(42, 20);
            this.Days.TabIndex = 8;
            this.Days.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Days.ValueChanged += new System.EventHandler(this.Days_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Days);
            this.groupBox1.Controls.Add(this.Tank);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Container);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Dosing);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 138);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GAL",
            "L"});
            this.comboBox1.Location = new System.Drawing.Point(160, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "ml";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "ml";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.PPMNO3);
            this.groupBox2.Controls.Add(this.PPMK);
            this.groupBox2.Controls.Add(this.PPMPO4);
            this.groupBox2.Location = new System.Drawing.Point(235, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 138);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target PPMs per week";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "NO3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "PO4";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "K";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Presets";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "EI",
            "ADA",
            "PPS-PRO",
            "PMDD"});
            this.comboBox2.Location = new System.Drawing.Point(61, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // PPMNO3
            // 
            this.PPMNO3.Location = new System.Drawing.Point(61, 20);
            this.PPMNO3.Name = "PPMNO3";
            this.PPMNO3.Size = new System.Drawing.Size(47, 20);
            this.PPMNO3.TabIndex = 0;
            this.PPMNO3.Text = "20";
            this.PPMNO3.Validated += new System.EventHandler(this.PPMNO3_Validated);
            // 
            // PPMK
            // 
            this.PPMK.Location = new System.Drawing.Point(61, 46);
            this.PPMK.Name = "PPMK";
            this.PPMK.Size = new System.Drawing.Size(47, 20);
            this.PPMK.TabIndex = 1;
            this.PPMK.Text = "5";
            this.PPMK.Validated += new System.EventHandler(this.PPMNO3_Validated);
            // 
            // PPMPO4
            // 
            this.PPMPO4.Location = new System.Drawing.Point(61, 72);
            this.PPMPO4.Name = "PPMPO4";
            this.PPMPO4.Size = new System.Drawing.Size(47, 20);
            this.PPMPO4.TabIndex = 2;
            this.PPMPO4.Text = "5";
            this.PPMPO4.Validated += new System.EventHandler(this.PPMNO3_Validated);
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(67, 84);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 23);
            this.label23.TabIndex = 13;
            this.label23.Text = "Mg";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PPMMG
            // 
            this.PPMMG.Location = new System.Drawing.Point(124, 86);
            this.PPMMG.Name = "PPMMG";
            this.PPMMG.Size = new System.Drawing.Size(66, 20);
            this.PPMMG.TabIndex = 12;
            this.PPMMG.Text = "5";
            this.PPMMG.Validated += new System.EventHandler(this.PPMNO3_Validated);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.MixK2SO4);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.MixKH2PO4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.MixKNO3);
            this.groupBox3.Location = new System.Drawing.Point(12, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 149);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add to stock solution";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(184, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "g";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(6, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 15;
            this.label16.Text = "K2SO4";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MixK2SO4
            // 
            this.MixK2SO4.Location = new System.Drawing.Point(112, 74);
            this.MixK2SO4.Name = "MixK2SO4";
            this.MixK2SO4.Size = new System.Drawing.Size(66, 20);
            this.MixK2SO4.TabIndex = 14;
            this.MixK2SO4.Text = "20";
            this.MixK2SO4.Validated += new System.EventHandler(this.MixKNO3_Validated);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(184, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "g";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "KH2PO4";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MixKH2PO4
            // 
            this.MixKH2PO4.Location = new System.Drawing.Point(112, 48);
            this.MixKH2PO4.Name = "MixKH2PO4";
            this.MixKH2PO4.Size = new System.Drawing.Size(66, 20);
            this.MixKH2PO4.TabIndex = 11;
            this.MixKH2PO4.Text = "20";
            this.MixKH2PO4.Validated += new System.EventHandler(this.MixKNO3_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "g";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "KNO3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MixKNO3
            // 
            this.MixKNO3.Location = new System.Drawing.Point(112, 22);
            this.MixKNO3.Name = "MixKNO3";
            this.MixKNO3.Size = new System.Drawing.Size(66, 20);
            this.MixKNO3.TabIndex = 5;
            this.MixKNO3.Text = "20";
            this.MixKNO3.Validated += new System.EventHandler(this.MixKNO3_Validated);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(199, 33);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 20;
            this.label24.Text = "g";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(21, 23);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 23);
            this.label25.TabIndex = 19;
            this.label25.Text = "MgSo4*7H2O";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MixMgSO4
            // 
            this.MixMgSO4.Location = new System.Drawing.Point(127, 26);
            this.MixMgSO4.Name = "MixMgSO4";
            this.MixMgSO4.Size = new System.Drawing.Size(66, 20);
            this.MixMgSO4.TabIndex = 18;
            this.MixMgSO4.Text = "20";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.mlNO3);
            this.groupBox4.Controls.Add(this.mlK);
            this.groupBox4.Controls.Add(this.mlPO4);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.DNO3);
            this.groupBox4.Controls.Add(this.DK);
            this.groupBox4.Controls.Add(this.DPO4);
            this.groupBox4.Controls.Add(this.WNO3);
            this.groupBox4.Controls.Add(this.WK);
            this.groupBox4.Controls.Add(this.WPO4);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(235, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 149);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result PPMs";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(114, 110);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 13);
            this.label27.TabIndex = 19;
            this.label27.Text = "Dosing";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(6, 126);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(217, 20);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(165, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "1 ml";
            // 
            // mlNO3
            // 
            this.mlNO3.BackColor = System.Drawing.Color.PaleGreen;
            this.mlNO3.Location = new System.Drawing.Point(167, 35);
            this.mlNO3.Name = "mlNO3";
            this.mlNO3.Size = new System.Drawing.Size(47, 20);
            this.mlNO3.TabIndex = 21;
            this.mlNO3.Text = "20";
            // 
            // mlK
            // 
            this.mlK.BackColor = System.Drawing.Color.PaleGreen;
            this.mlK.Location = new System.Drawing.Point(167, 61);
            this.mlK.Name = "mlK";
            this.mlK.Size = new System.Drawing.Size(47, 20);
            this.mlK.TabIndex = 22;
            this.mlK.Text = "5";
            // 
            // mlPO4
            // 
            this.mlPO4.BackColor = System.Drawing.Color.PaleGreen;
            this.mlPO4.Location = new System.Drawing.Point(167, 87);
            this.mlPO4.Name = "mlPO4";
            this.mlPO4.Size = new System.Drawing.Size(47, 20);
            this.mlPO4.TabIndex = 23;
            this.mlPO4.Text = "5";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(114, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Dose";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(61, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Week";
            // 
            // DNO3
            // 
            this.DNO3.BackColor = System.Drawing.Color.PaleGreen;
            this.DNO3.Location = new System.Drawing.Point(114, 35);
            this.DNO3.Name = "DNO3";
            this.DNO3.Size = new System.Drawing.Size(47, 20);
            this.DNO3.TabIndex = 16;
            this.DNO3.Text = "20";
            // 
            // DK
            // 
            this.DK.BackColor = System.Drawing.Color.PaleGreen;
            this.DK.Location = new System.Drawing.Point(114, 61);
            this.DK.Name = "DK";
            this.DK.Size = new System.Drawing.Size(47, 20);
            this.DK.TabIndex = 17;
            this.DK.Text = "5";
            // 
            // DPO4
            // 
            this.DPO4.BackColor = System.Drawing.Color.PaleGreen;
            this.DPO4.Location = new System.Drawing.Point(114, 87);
            this.DPO4.Name = "DPO4";
            this.DPO4.Size = new System.Drawing.Size(47, 20);
            this.DPO4.TabIndex = 18;
            this.DPO4.Text = "5";
            // 
            // WNO3
            // 
            this.WNO3.BackColor = System.Drawing.Color.PaleGreen;
            this.WNO3.Location = new System.Drawing.Point(61, 35);
            this.WNO3.Name = "WNO3";
            this.WNO3.Size = new System.Drawing.Size(47, 20);
            this.WNO3.TabIndex = 13;
            this.WNO3.Text = "20";
            // 
            // WK
            // 
            this.WK.BackColor = System.Drawing.Color.PaleGreen;
            this.WK.Location = new System.Drawing.Point(61, 61);
            this.WK.Name = "WK";
            this.WK.Size = new System.Drawing.Size(47, 20);
            this.WK.TabIndex = 14;
            this.WK.Text = "5";
            // 
            // WPO4
            // 
            this.WPO4.BackColor = System.Drawing.Color.PaleGreen;
            this.WPO4.Location = new System.Drawing.Point(61, 87);
            this.WPO4.Name = "WPO4";
            this.WPO4.Size = new System.Drawing.Size(47, 20);
            this.WPO4.TabIndex = 15;
            this.WPO4.Text = "5";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(17, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 23);
            this.label17.TabIndex = 10;
            this.label17.Text = "NO3";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(14, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 23);
            this.label18.TabIndex = 12;
            this.label18.Text = "PO4";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(14, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 23);
            this.label19.TabIndex = 11;
            this.label19.Text = "K";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mlMg
            // 
            this.mlMg.BackColor = System.Drawing.Color.PaleGreen;
            this.mlMg.Location = new System.Drawing.Point(196, 55);
            this.mlMg.Name = "mlMg";
            this.mlMg.Size = new System.Drawing.Size(47, 20);
            this.mlMg.TabIndex = 28;
            this.mlMg.Text = "5";
            // 
            // DMg
            // 
            this.DMg.BackColor = System.Drawing.Color.PaleGreen;
            this.DMg.Location = new System.Drawing.Point(143, 55);
            this.DMg.Name = "DMg";
            this.DMg.Size = new System.Drawing.Size(47, 20);
            this.DMg.TabIndex = 27;
            this.DMg.Text = "5";
            // 
            // WMg
            // 
            this.WMg.BackColor = System.Drawing.Color.PaleGreen;
            this.WMg.Location = new System.Drawing.Point(90, 55);
            this.WMg.Name = "WMg";
            this.WMg.Size = new System.Drawing.Size(47, 20);
            this.WMg.TabIndex = 26;
            this.WMg.Text = "5";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(43, 53);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 23);
            this.label26.TabIndex = 25;
            this.label26.Text = "Mg";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.MixMgSO4);
            this.groupBox6.Controls.Add(this.PPMMG);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.WMg);
            this.groupBox6.Controls.Add(this.mlMg);
            this.groupBox6.Controls.Add(this.DMg);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Location = new System.Drawing.Point(525, 104);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(260, 121);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            this.groupBox6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 316);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Macro solution calculator";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Days)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Tank;
        private System.Windows.Forms.TextBox Container;
        private System.Windows.Forms.TextBox Dosing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Days;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PPMNO3;
        private System.Windows.Forms.TextBox PPMK;
        private System.Windows.Forms.TextBox PPMPO4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MixK2SO4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox MixKH2PO4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MixKNO3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox WNO3;
        private System.Windows.Forms.TextBox WK;
        private System.Windows.Forms.TextBox WPO4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox DNO3;
        private System.Windows.Forms.TextBox DK;
        private System.Windows.Forms.TextBox DPO4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox mlNO3;
        private System.Windows.Forms.TextBox mlK;
        private System.Windows.Forms.TextBox mlPO4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox PPMMG;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox MixMgSO4;
        private System.Windows.Forms.TextBox mlMg;
        private System.Windows.Forms.TextBox DMg;
        private System.Windows.Forms.TextBox WMg;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

