namespace TimeTableM
{
    partial class SessionDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionDash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddLoc = new System.Windows.Forms.TabPage();
            this.dgvAddLoc = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbnEveLoc = new System.Windows.Forms.RadioButton();
            this.rbnMorLoc = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDayLoc = new System.Windows.Forms.ComboBox();
            this.Not_available_time = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvNotAvaTime = new System.Windows.Forms.DataGridView();
            this.Consecutive = new System.Windows.Forms.TabPage();
            this.btnViewCon = new System.Windows.Forms.Button();
            this.dgvConsec = new System.Windows.Forms.DataGridView();
            this.Non_overlaping = new System.Windows.Forms.TabPage();
            this.btnNonOver = new System.Windows.Forms.Button();
            this.dgvNonOverL = new System.Windows.Forms.DataGridView();
            this.Pararel = new System.Windows.Forms.TabPage();
            this.btnPereral = new System.Windows.Forms.Button();
            this.dgvPereral = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AddLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddLoc)).BeginInit();
            this.Not_available_time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotAvaTime)).BeginInit();
            this.Consecutive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsec)).BeginInit();
            this.Non_overlaping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonOverL)).BeginInit();
            this.Pararel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPereral)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            label4.Location = new System.Drawing.Point(686, 189);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(166, 26);
            label4.TabIndex = 4;
            label4.Text = "Manage Session";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.cmbDepartment);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cmbFaculty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.SpringGreen;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 764);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(836, 107);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 58);
            this.button4.TabIndex = 14;
            this.button4.Text = "ADD Not Available Time";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(221, 176);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(284, 30);
            this.cmbDepartment.TabIndex = 13;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddLoc);
            this.tabControl1.Controls.Add(this.Not_available_time);
            this.tabControl1.Controls.Add(this.Consecutive);
            this.tabControl1.Controls.Add(this.Non_overlaping);
            this.tabControl1.Controls.Add(this.Pararel);
            this.tabControl1.Location = new System.Drawing.Point(31, 232);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1036, 346);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddLoc
            // 
            this.AddLoc.Controls.Add(this.dgvAddLoc);
            this.AddLoc.Controls.Add(this.btnView);
            this.AddLoc.Controls.Add(this.btnSave);
            this.AddLoc.Controls.Add(this.label11);
            this.AddLoc.Controls.Add(this.cmbLocation);
            this.AddLoc.Controls.Add(this.label9);
            this.AddLoc.Controls.Add(this.rbnEveLoc);
            this.AddLoc.Controls.Add(this.rbnMorLoc);
            this.AddLoc.Controls.Add(this.label10);
            this.AddLoc.Controls.Add(this.cmbDayLoc);
            this.AddLoc.Location = new System.Drawing.Point(4, 31);
            this.AddLoc.Name = "AddLoc";
            this.AddLoc.Size = new System.Drawing.Size(1028, 311);
            this.AddLoc.TabIndex = 4;
            this.AddLoc.Text = "Add Location";
            this.AddLoc.UseVisualStyleBackColor = true;
            // 
            // dgvAddLoc
            // 
            this.dgvAddLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddLoc.Location = new System.Drawing.Point(54, 199);
            this.dgvAddLoc.Name = "dgvAddLoc";
            this.dgvAddLoc.Size = new System.Drawing.Size(916, 88);
            this.dgvAddLoc.TabIndex = 72;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DarkRed;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(556, 91);
            this.btnView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 40);
            this.btnView.TabIndex = 71;
            this.btnView.Text = "View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(556, 32);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 40);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(48, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 31);
            this.label11.TabIndex = 70;
            this.label11.Text = "Add Location";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(234, 148);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(284, 30);
            this.cmbLocation.TabIndex = 69;
            this.cmbLocation.Click += new System.EventHandler(this.cmbLocation_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(48, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 31);
            this.label9.TabIndex = 68;
            this.label9.Text = "Time";
            // 
            // rbnEveLoc
            // 
            this.rbnEveLoc.AutoSize = true;
            this.rbnEveLoc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEveLoc.ForeColor = System.Drawing.Color.Black;
            this.rbnEveLoc.Location = new System.Drawing.Point(234, 98);
            this.rbnEveLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbnEveLoc.Name = "rbnEveLoc";
            this.rbnEveLoc.Size = new System.Drawing.Size(190, 26);
            this.rbnEveLoc.TabIndex = 67;
            this.rbnEveLoc.TabStop = true;
            this.rbnEveLoc.Text = "1.00 PM to 5.00 PM";
            this.rbnEveLoc.UseVisualStyleBackColor = true;
            this.rbnEveLoc.CheckedChanged += new System.EventHandler(this.rbnEveLoc_CheckedChanged);
            // 
            // rbnMorLoc
            // 
            this.rbnMorLoc.AutoSize = true;
            this.rbnMorLoc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMorLoc.ForeColor = System.Drawing.Color.Black;
            this.rbnMorLoc.Location = new System.Drawing.Point(234, 67);
            this.rbnMorLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbnMorLoc.Name = "rbnMorLoc";
            this.rbnMorLoc.Size = new System.Drawing.Size(201, 26);
            this.rbnMorLoc.TabIndex = 66;
            this.rbnMorLoc.TabStop = true;
            this.rbnMorLoc.Text = "8.00 AM to 12.00 PM";
            this.rbnMorLoc.UseVisualStyleBackColor = true;
            this.rbnMorLoc.CheckedChanged += new System.EventHandler(this.rbnMorLoc_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(48, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 31);
            this.label10.TabIndex = 64;
            this.label10.Text = "Day";
            // 
            // cmbDayLoc
            // 
            this.cmbDayLoc.FormattingEnabled = true;
            this.cmbDayLoc.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbDayLoc.Location = new System.Drawing.Point(234, 32);
            this.cmbDayLoc.Name = "cmbDayLoc";
            this.cmbDayLoc.Size = new System.Drawing.Size(284, 30);
            this.cmbDayLoc.TabIndex = 65;
            // 
            // Not_available_time
            // 
            this.Not_available_time.Controls.Add(this.button5);
            this.Not_available_time.Controls.Add(this.dgvNotAvaTime);
            this.Not_available_time.Location = new System.Drawing.Point(4, 31);
            this.Not_available_time.Name = "Not_available_time";
            this.Not_available_time.Size = new System.Drawing.Size(1028, 311);
            this.Not_available_time.TabIndex = 3;
            this.Not_available_time.Text = "Not available time";
            this.Not_available_time.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(45, 258);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 43);
            this.button5.TabIndex = 65;
            this.button5.Text = "View";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvNotAvaTime
            // 
            this.dgvNotAvaTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotAvaTime.Location = new System.Drawing.Point(45, 18);
            this.dgvNotAvaTime.Name = "dgvNotAvaTime";
            this.dgvNotAvaTime.Size = new System.Drawing.Size(928, 222);
            this.dgvNotAvaTime.TabIndex = 64;
            // 
            // Consecutive
            // 
            this.Consecutive.Controls.Add(this.btnViewCon);
            this.Consecutive.Controls.Add(this.dgvConsec);
            this.Consecutive.Location = new System.Drawing.Point(4, 31);
            this.Consecutive.Name = "Consecutive";
            this.Consecutive.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Consecutive.Size = new System.Drawing.Size(1028, 311);
            this.Consecutive.TabIndex = 0;
            this.Consecutive.Text = "Consecutive";
            this.Consecutive.UseVisualStyleBackColor = true;
            // 
            // btnViewCon
            // 
            this.btnViewCon.BackColor = System.Drawing.Color.DarkRed;
            this.btnViewCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCon.ForeColor = System.Drawing.Color.White;
            this.btnViewCon.Location = new System.Drawing.Point(0, 275);
            this.btnViewCon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewCon.Name = "btnViewCon";
            this.btnViewCon.Size = new System.Drawing.Size(101, 34);
            this.btnViewCon.TabIndex = 8;
            this.btnViewCon.Text = "VIEW";
            this.btnViewCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewCon.UseVisualStyleBackColor = false;
            this.btnViewCon.Click += new System.EventHandler(this.btnViewCon_Click);
            // 
            // dgvConsec
            // 
            this.dgvConsec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsec.Location = new System.Drawing.Point(0, 0);
            this.dgvConsec.Name = "dgvConsec";
            this.dgvConsec.Size = new System.Drawing.Size(966, 270);
            this.dgvConsec.TabIndex = 0;
            // 
            // Non_overlaping
            // 
            this.Non_overlaping.Controls.Add(this.btnNonOver);
            this.Non_overlaping.Controls.Add(this.dgvNonOverL);
            this.Non_overlaping.Location = new System.Drawing.Point(4, 31);
            this.Non_overlaping.Name = "Non_overlaping";
            this.Non_overlaping.Size = new System.Drawing.Size(1028, 311);
            this.Non_overlaping.TabIndex = 2;
            this.Non_overlaping.Text = "Non overlaping";
            this.Non_overlaping.UseVisualStyleBackColor = true;
            // 
            // btnNonOver
            // 
            this.btnNonOver.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNonOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonOver.ForeColor = System.Drawing.Color.White;
            this.btnNonOver.Location = new System.Drawing.Point(2, 275);
            this.btnNonOver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNonOver.Name = "btnNonOver";
            this.btnNonOver.Size = new System.Drawing.Size(101, 34);
            this.btnNonOver.TabIndex = 10;
            this.btnNonOver.Text = "VIEW";
            this.btnNonOver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNonOver.UseVisualStyleBackColor = false;
            this.btnNonOver.Click += new System.EventHandler(this.btnNonOver_Click);
            // 
            // dgvNonOverL
            // 
            this.dgvNonOverL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonOverL.Location = new System.Drawing.Point(1, 0);
            this.dgvNonOverL.Name = "dgvNonOverL";
            this.dgvNonOverL.Size = new System.Drawing.Size(1025, 270);
            this.dgvNonOverL.TabIndex = 2;
            // 
            // Pararel
            // 
            this.Pararel.Controls.Add(this.btnPereral);
            this.Pararel.Controls.Add(this.dgvPereral);
            this.Pararel.Location = new System.Drawing.Point(4, 31);
            this.Pararel.Name = "Pararel";
            this.Pararel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Pararel.Size = new System.Drawing.Size(1028, 311);
            this.Pararel.TabIndex = 1;
            this.Pararel.Text = "Pareral";
            this.Pararel.UseVisualStyleBackColor = true;
            // 
            // btnPereral
            // 
            this.btnPereral.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPereral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPereral.ForeColor = System.Drawing.Color.White;
            this.btnPereral.Location = new System.Drawing.Point(0, 277);
            this.btnPereral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPereral.Name = "btnPereral";
            this.btnPereral.Size = new System.Drawing.Size(101, 34);
            this.btnPereral.TabIndex = 9;
            this.btnPereral.Text = "VIEW";
            this.btnPereral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPereral.UseVisualStyleBackColor = false;
            this.btnPereral.Click += new System.EventHandler(this.btnPereral_Click);
            // 
            // dgvPereral
            // 
            this.dgvPereral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPereral.Location = new System.Drawing.Point(6, 6);
            this.dgvPereral.Name = "dgvPereral";
            this.dgvPereral.Size = new System.Drawing.Size(959, 266);
            this.dgvPereral.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(44, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Department";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(713, 90);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 92);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Sciences"});
            this.cmbFaculty.Location = new System.Drawing.Point(221, 117);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(284, 30);
            this.cmbFaculty.TabIndex = 11;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Faculty";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(547, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 92);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(543, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Session";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(962, 694);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "WE_R_51";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Session Management";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(942, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "HOME";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SessionDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 609);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SessionDash";
            this.Text = "SessionDash";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.AddLoc.ResumeLayout(false);
            this.AddLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddLoc)).EndInit();
            this.Not_available_time.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotAvaTime)).EndInit();
            this.Consecutive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsec)).EndInit();
            this.Non_overlaping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonOverL)).EndInit();
            this.Pararel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPereral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Consecutive;
        private System.Windows.Forms.TabPage Pararel;
        private System.Windows.Forms.TabPage Non_overlaping;
        private System.Windows.Forms.TabPage Not_available_time;
        private System.Windows.Forms.Button btnViewCon;
        private System.Windows.Forms.DataGridView dgvConsec;
        private System.Windows.Forms.Button btnPereral;
        private System.Windows.Forms.DataGridView dgvPereral;
        private System.Windows.Forms.Button btnNonOver;
        private System.Windows.Forms.DataGridView dgvNonOverL;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNotAvaTime;
        private System.Windows.Forms.TabPage AddLoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbnEveLoc;
        private System.Windows.Forms.RadioButton rbnMorLoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDayLoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAddLoc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}