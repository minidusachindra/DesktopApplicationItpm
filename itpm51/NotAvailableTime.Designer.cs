namespace TimeTableM
{
    partial class NotAvailableTime
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
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            this.lblAllDetails = new System.Windows.Forms.Label();
            this.cmbSrch = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbLecr = new System.Windows.Forms.ComboBox();
            this.cmbSuGrp = new System.Windows.Forms.ComboBox();
            this.cmbGrop = new System.Windows.Forms.ComboBox();
            this.cmb1Lec = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvMngeNt = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textTime = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMngeNt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label11.Location = new System.Drawing.Point(734, 309);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(63, 27);
            label11.TabIndex = 73;
            label11.Text = "Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label6.Location = new System.Drawing.Point(48, 365);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(221, 31);
            label6.TabIndex = 58;
            label6.Text = "Select Sub Group";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label7.Location = new System.Drawing.Point(48, 302);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(168, 31);
            label7.TabIndex = 57;
            label7.Text = "Select Group";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label2.Location = new System.Drawing.Point(734, 252);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(218, 27);
            label2.TabIndex = 53;
            label2.Text = "Select Lecture Room";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label4.Location = new System.Drawing.Point(48, 246);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(181, 31);
            label4.TabIndex = 51;
            label4.Text = "Select Lecture";
            // 
            // lblAllDetails
            // 
            this.lblAllDetails.AutoSize = true;
            this.lblAllDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAllDetails.Location = new System.Drawing.Point(41, 774);
            this.lblAllDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllDetails.Name = "lblAllDetails";
            this.lblAllDetails.Size = new System.Drawing.Size(0, 17);
            this.lblAllDetails.TabIndex = 79;
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
            this.cmbSrch.Location = new System.Drawing.Point(849, 102);
            this.cmbSrch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSrch.Name = "cmbSrch";
            this.cmbSrch.Size = new System.Drawing.Size(270, 33);
            this.cmbSrch.TabIndex = 71;
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
            this.cmbDay.Location = new System.Drawing.Point(969, 365);
            this.cmbDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(338, 33);
            this.cmbDay.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Location = new System.Drawing.Point(733, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 31);
            this.label13.TabIndex = 62;
            this.label13.Text = "Days";
            // 
            // cmbLecr
            // 
            this.cmbLecr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLecr.FormattingEnabled = true;
            this.cmbLecr.Items.AddRange(new object[] {
            "A301",
            "A302",
            "A303",
            "A304",
            "A305",
            "A501",
            "A502",
            "A503",
            "A504",
            "A505"});
            this.cmbLecr.Location = new System.Drawing.Point(969, 244);
            this.cmbLecr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLecr.Name = "cmbLecr";
            this.cmbLecr.Size = new System.Drawing.Size(338, 33);
            this.cmbLecr.TabIndex = 56;
            // 
            // cmbSuGrp
            // 
            this.cmbSuGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuGrp.FormattingEnabled = true;
            this.cmbSuGrp.Items.AddRange(new object[] {
            "Y1 S2.SE.02.S2",
            "Y4 S1.SE.02.S1",
            "Y4 S1.SE.03.S1",
            "Y4 S1.SE.04.S1",
            "Y4 S1.SE.05.S1"});
            this.cmbSuGrp.Location = new System.Drawing.Point(289, 363);
            this.cmbSuGrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSuGrp.Name = "cmbSuGrp";
            this.cmbSuGrp.Size = new System.Drawing.Size(349, 33);
            this.cmbSuGrp.TabIndex = 55;
            // 
            // cmbGrop
            // 
            this.cmbGrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrop.FormattingEnabled = true;
            this.cmbGrop.Items.AddRange(new object[] {
            "Y1 S2.SE.02",
            "Y4 S1.SE.02",
            "Y4 S1.SE.03",
            "Y4 S1.SE.04",
            "Y4 S1.SE.05"});
            this.cmbGrop.Location = new System.Drawing.Point(289, 303);
            this.cmbGrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGrop.Name = "cmbGrop";
            this.cmbGrop.Size = new System.Drawing.Size(349, 33);
            this.cmbGrop.TabIndex = 54;
            // 
            // cmb1Lec
            // 
            this.cmb1Lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb1Lec.FormattingEnabled = true;
            this.cmb1Lec.Items.AddRange(new object[] {
            "Ravindu lakshan",
            "Rangana Atapattu",
            "Madawa Balasooriya",
            "Chathuranga Premathilaka",
            "Sangeetha Gamage",
            "Shan Ratnayake",
            "Nawodya Senaratne"});
            this.cmb1Lec.Location = new System.Drawing.Point(289, 246);
            this.cmb1Lec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb1Lec.Name = "cmb1Lec";
            this.cmb1Lec.Size = new System.Drawing.Size(349, 33);
            this.cmb1Lec.TabIndex = 52;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Green;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1170, 443);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 53);
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
            this.btnUpdate.Location = new System.Drawing.Point(782, 444);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 53);
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
            this.label5.Location = new System.Drawing.Point(673, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "Search Day";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Gray;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(42, 512);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(103, 53);
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
            this.btnSearch.Location = new System.Drawing.Point(1158, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 51);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvMngeNt
            // 
            this.dgvMngeNt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMngeNt.Location = new System.Drawing.Point(42, 589);
            this.dgvMngeNt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMngeNt.Name = "dgvMngeNt";
            this.dgvMngeNt.RowTemplate.Height = 24;
            this.dgvMngeNt.Size = new System.Drawing.Size(1288, 285);
            this.dgvMngeNt.TabIndex = 44;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(979, 443);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 53);
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
            this.btnHome.Location = new System.Drawing.Point(1288, 43);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 38);
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
            this.btnBack.Location = new System.Drawing.Point(25, 43);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 38);
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
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 23F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(161, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1023, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Not Availabe Time Allocations for Lecture and Batch Group";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.textTime);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblAllDetails);
            this.panel1.Controls.Add(label11);
            this.panel1.Controls.Add(this.cmbSrch);
            this.panel1.Controls.Add(this.cmbDay);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.cmbLecr);
            this.panel1.Controls.Add(this.cmbSuGrp);
            this.panel1.Controls.Add(this.cmbGrop);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.cmb1Lec);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dgvMngeNt);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 882);
            this.panel1.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Blue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(446, 444);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(140, 53);
            this.btnSubmit.TabIndex = 80;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textTime
            // 
            this.textTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTime.Location = new System.Drawing.Point(969, 306);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(161, 30);
            this.textTime.TabIndex = 81;
            // 
            // NotAvailableTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 886);
            this.Controls.Add(this.panel1);
            this.Name = "NotAvailableTime";
            this.Text = "NotAvailableTime";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMngeNt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAllDetails;
        private System.Windows.Forms.ComboBox cmbSrch;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbLecr;
        private System.Windows.Forms.ComboBox cmbSuGrp;
        private System.Windows.Forms.ComboBox cmbGrop;
        private System.Windows.Forms.ComboBox cmb1Lec;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvMngeNt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textTime;
    }
}