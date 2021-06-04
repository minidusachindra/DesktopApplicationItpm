namespace TimeTableM
{
    partial class ManageSession
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAllDetails = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbnEve = new System.Windows.Forms.RadioButton();
            this.rbnMor = new System.Windows.Forms.RadioButton();
            this.rbnEvening = new System.Windows.Forms.RadioButton();
            this.rbnMorning = new System.Windows.Forms.RadioButton();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.cmbSrch = new System.Windows.Forms.ComboBox();
            this.txtNoOfStd = new System.Windows.Forms.TextBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtShowTag = new System.Windows.Forms.TextBox();
            this.cmbTimeSlot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbGrp = new System.Windows.Forms.ComboBox();
            this.cmb2Lec = new System.Windows.Forms.ComboBox();
            this.cmb1Lec = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMngeSes = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMngeSes)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label4.Location = new System.Drawing.Point(29, 414);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(180, 26);
            label4.TabIndex = 51;
            label4.Text = "Select 1st Lecture";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label2.Location = new System.Drawing.Point(29, 466);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(188, 26);
            label2.TabIndex = 53;
            label2.Text = "Select 2nd Lecture";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label6.Location = new System.Drawing.Point(29, 575);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(146, 26);
            label6.TabIndex = 58;
            label6.Text = "Select Subject";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label7.Location = new System.Drawing.Point(29, 523);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(135, 26);
            label7.TabIndex = 57;
            label7.Text = "Select Group";
            label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label10.Location = new System.Drawing.Point(562, 521);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(144, 22);
            label10.TabIndex = 67;
            label10.Text = "No. of Students ";
            label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label11.Location = new System.Drawing.Point(562, 565);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(50, 22);
            label11.TabIndex = 73;
            label11.Text = "Time";
            label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblAllDetails);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rbnEve);
            this.panel1.Controls.Add(this.rbnMor);
            this.panel1.Controls.Add(this.rbnEvening);
            this.panel1.Controls.Add(this.rbnMorning);
            this.panel1.Controls.Add(label11);
            this.panel1.Controls.Add(this.btnDeleteAll);
            this.panel1.Controls.Add(this.cmbSrch);
            this.panel1.Controls.Add(label10);
            this.panel1.Controls.Add(this.txtNoOfStd);
            this.panel1.Controls.Add(this.cmbDay);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtShowTag);
            this.panel1.Controls.Add(this.cmbTimeSlot);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.cmbSubject);
            this.panel1.Controls.Add(this.cmbGrp);
            this.panel1.Controls.Add(this.cmb2Lec);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.cmb1Lec);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dgvMngeSes);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 717);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAllDetails
            // 
            this.lblAllDetails.AutoSize = true;
            this.lblAllDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAllDetails.Location = new System.Drawing.Point(31, 629);
            this.lblAllDetails.Name = "lblAllDetails";
            this.lblAllDetails.Size = new System.Drawing.Size(0, 13);
            this.lblAllDetails.TabIndex = 79;
            this.lblAllDetails.Click += new System.EventHandler(this.lblAllDetails_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(501, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 26);
            this.label8.TabIndex = 78;
            this.label8.Text = "Time";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // rbnEve
            // 
            this.rbnEve.AutoSize = true;
            this.rbnEve.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbnEve.Location = new System.Drawing.Point(648, 128);
            this.rbnEve.Margin = new System.Windows.Forms.Padding(2);
            this.rbnEve.Name = "rbnEve";
            this.rbnEve.Size = new System.Drawing.Size(190, 26);
            this.rbnEve.TabIndex = 77;
            this.rbnEve.TabStop = true;
            this.rbnEve.Text = "1.00 PM to 5.00 PM";
            this.rbnEve.UseVisualStyleBackColor = true;
            this.rbnEve.CheckedChanged += new System.EventHandler(this.rbnEve_CheckedChanged);
            // 
            // rbnMor
            // 
            this.rbnMor.AutoSize = true;
            this.rbnMor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbnMor.Location = new System.Drawing.Point(648, 104);
            this.rbnMor.Margin = new System.Windows.Forms.Padding(2);
            this.rbnMor.Name = "rbnMor";
            this.rbnMor.Size = new System.Drawing.Size(201, 26);
            this.rbnMor.TabIndex = 76;
            this.rbnMor.TabStop = true;
            this.rbnMor.Text = "8.00 AM to 12.00 PM";
            this.rbnMor.UseVisualStyleBackColor = true;
            this.rbnMor.CheckedChanged += new System.EventHandler(this.rbnMor_CheckedChanged);
            // 
            // rbnEvening
            // 
            this.rbnEvening.AutoSize = true;
            this.rbnEvening.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEvening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbnEvening.Location = new System.Drawing.Point(710, 587);
            this.rbnEvening.Margin = new System.Windows.Forms.Padding(2);
            this.rbnEvening.Name = "rbnEvening";
            this.rbnEvening.Size = new System.Drawing.Size(190, 26);
            this.rbnEvening.TabIndex = 75;
            this.rbnEvening.TabStop = true;
            this.rbnEvening.Text = "1.00 PM to 5.00 PM";
            this.rbnEvening.UseVisualStyleBackColor = true;
            this.rbnEvening.CheckedChanged += new System.EventHandler(this.rbnEvening_CheckedChanged);
            // 
            // rbnMorning
            // 
            this.rbnMorning.AutoSize = true;
            this.rbnMorning.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMorning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbnMorning.Location = new System.Drawing.Point(710, 563);
            this.rbnMorning.Margin = new System.Windows.Forms.Padding(2);
            this.rbnMorning.Name = "rbnMorning";
            this.rbnMorning.Size = new System.Drawing.Size(201, 26);
            this.rbnMorning.TabIndex = 74;
            this.rbnMorning.TabStop = true;
            this.rbnMorning.Text = "8.00 AM to 12.00 PM";
            this.rbnMorning.UseVisualStyleBackColor = true;
            this.rbnMorning.CheckedChanged += new System.EventHandler(this.rbnMorning_CheckedChanged);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(827, 617);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(105, 58);
            this.btnDeleteAll.TabIndex = 72;
            this.btnDeleteAll.Text = "DELETE ALL";
            this.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // cmbSrch
            // 
            this.cmbSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSrch.FormattingEnabled = true;
            this.cmbSrch.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbSrch.Location = new System.Drawing.Point(648, 67);
            this.cmbSrch.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSrch.Name = "cmbSrch";
            this.cmbSrch.Size = new System.Drawing.Size(193, 28);
            this.cmbSrch.TabIndex = 71;
            this.cmbSrch.SelectedIndexChanged += new System.EventHandler(this.cmbSrch_SelectedIndexChanged);
            // 
            // txtNoOfStd
            // 
            this.txtNoOfStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfStd.Location = new System.Drawing.Point(710, 521);
            this.txtNoOfStd.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoOfStd.Name = "txtNoOfStd";
            this.txtNoOfStd.Size = new System.Drawing.Size(227, 26);
            this.txtNoOfStd.TabIndex = 64;
            this.txtNoOfStd.TextChanged += new System.EventHandler(this.txtNoOfStd_TextChanged);
            // 
            // cmbDay
            // 
            this.cmbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbDay.Location = new System.Drawing.Point(637, 466);
            this.cmbDay.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(149, 28);
            this.cmbDay.TabIndex = 63;
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.cmbDay_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(561, 466);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 26);
            this.label13.TabIndex = 62;
            this.label13.Text = "Days";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtShowTag
            // 
            this.txtShowTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowTag.Location = new System.Drawing.Point(808, 414);
            this.txtShowTag.Margin = new System.Windows.Forms.Padding(2);
            this.txtShowTag.Name = "txtShowTag";
            this.txtShowTag.Size = new System.Drawing.Size(149, 26);
            this.txtShowTag.TabIndex = 61;
            this.txtShowTag.TextChanged += new System.EventHandler(this.txtShowTag_TextChanged);
            // 
            // cmbTimeSlot
            // 
            this.cmbTimeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeSlot.FormattingEnabled = true;
            this.cmbTimeSlot.Location = new System.Drawing.Point(637, 414);
            this.cmbTimeSlot.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTimeSlot.Name = "cmbTimeSlot";
            this.cmbTimeSlot.Size = new System.Drawing.Size(149, 28);
            this.cmbTimeSlot.TabIndex = 60;
            this.cmbTimeSlot.SelectedIndexChanged += new System.EventHandler(this.cmbTimeSlot_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(561, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tag";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(248, 573);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(263, 28);
            this.cmbSubject.TabIndex = 56;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // cmbGrp
            // 
            this.cmbGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrp.FormattingEnabled = true;
            this.cmbGrp.Location = new System.Drawing.Point(248, 521);
            this.cmbGrp.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrp.Name = "cmbGrp";
            this.cmbGrp.Size = new System.Drawing.Size(263, 28);
            this.cmbGrp.TabIndex = 55;
            this.cmbGrp.SelectedIndexChanged += new System.EventHandler(this.cmbGrp_SelectedIndexChanged);
            // 
            // cmb2Lec
            // 
            this.cmb2Lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2Lec.FormattingEnabled = true;
            this.cmb2Lec.Location = new System.Drawing.Point(248, 466);
            this.cmb2Lec.Margin = new System.Windows.Forms.Padding(2);
            this.cmb2Lec.Name = "cmb2Lec";
            this.cmb2Lec.Size = new System.Drawing.Size(263, 28);
            this.cmb2Lec.TabIndex = 54;
            this.cmb2Lec.SelectedIndexChanged += new System.EventHandler(this.cmb2Lec_SelectedIndexChanged);
            // 
            // cmb1Lec
            // 
            this.cmb1Lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb1Lec.FormattingEnabled = true;
            this.cmb1Lec.Location = new System.Drawing.Point(248, 414);
            this.cmb1Lec.Margin = new System.Windows.Forms.Padding(2);
            this.cmb1Lec.Name = "cmb1Lec";
            this.cmb1Lec.Size = new System.Drawing.Size(263, 28);
            this.cmb1Lec.TabIndex = 52;
            this.cmb1Lec.SelectedIndexChanged += new System.EventHandler(this.cmb1Lec_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Green;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(514, 641);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 34);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(394, 639);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 34);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(501, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 26);
            this.label5.TabIndex = 48;
            this.label5.Text = "Search Day";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Gray;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(34, 91);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(77, 43);
            this.btnView.TabIndex = 47;
            this.btnView.Text = "View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Honeydew;
            this.btnSearch.Location = new System.Drawing.Point(875, 70);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 64);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMngeSes
            // 
            this.dgvMngeSes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMngeSes.Location = new System.Drawing.Point(34, 158);
            this.dgvMngeSes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMngeSes.Name = "dgvMngeSes";
            this.dgvMngeSes.RowTemplate.Height = 24;
            this.dgvMngeSes.Size = new System.Drawing.Size(966, 214);
            this.dgvMngeSes.TabIndex = 44;
            this.dgvMngeSes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMngeSes_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(628, 639);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 36);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(837, 25);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(104, 31);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "HOME";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(699, 25);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 31);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "BACK";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(351, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Session";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManageSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 710);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageSession";
            this.Text = "ManageSession";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMngeSes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMngeSes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmb1Lec;
        private System.Windows.Forms.ComboBox cmb2Lec;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbGrp;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtShowTag;
        private System.Windows.Forms.ComboBox cmbTimeSlot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoOfStd;
        private System.Windows.Forms.ComboBox cmbSrch;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbnEve;
        private System.Windows.Forms.RadioButton rbnMor;
        private System.Windows.Forms.RadioButton rbnEvening;
        private System.Windows.Forms.RadioButton rbnMorning;
        private System.Windows.Forms.Label lblAllDetails;
    }
}