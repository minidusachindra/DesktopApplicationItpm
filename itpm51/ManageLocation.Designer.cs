namespace TimeTableM
{
    partial class ManageLocation
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtroomName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtRMSearch = new System.Windows.Forms.TextBox();
            this.dgvMgLoc = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button_view = new System.Windows.Forms.Button();
            this.cmbbuildingName = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label6.Location = new System.Drawing.Point(52, 687);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(166, 31);
            label6.TabIndex = 37;
            label6.Text = "Room Name";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label4.Location = new System.Drawing.Point(52, 616);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(194, 31);
            label4.TabIndex = 35;
            label4.Text = "Building Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cmbbuildingName);
            this.panel2.Controls.Add(label7);
            this.panel2.Controls.Add(this.button_view);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.txtcapacity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(this.txtroomName);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.txtRMSearch);
            this.panel2.Controls.Add(this.dgvMgLoc);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.SpringGreen;
            this.panel2.Location = new System.Drawing.Point(-10, -68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 832);
            this.panel2.TabIndex = 6;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton4.Location = new System.Drawing.Point(1134, 618);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(142, 31);
            this.radioButton4.TabIndex = 42;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Laboratory";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButton3.Location = new System.Drawing.Point(955, 618);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(153, 31);
            this.radioButton3.TabIndex = 41;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Lecture Hall";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtcapacity
            // 
            this.txtcapacity.Location = new System.Drawing.Point(955, 683);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(321, 34);
            this.txtcapacity.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(711, 621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 31);
            this.label5.TabIndex = 39;
            this.label5.Text = "Room Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtroomName
            // 
            this.txtroomName.Location = new System.Drawing.Point(261, 688);
            this.txtroomName.Name = "txtroomName";
            this.txtroomName.Size = new System.Drawing.Size(321, 34);
            this.txtroomName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(711, 683);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "Capacity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Honeydew;
            this.button6.Location = new System.Drawing.Point(1184, 161);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 50);
            this.button6.TabIndex = 32;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtRMSearch
            // 
            this.txtRMSearch.Location = new System.Drawing.Point(999, 177);
            this.txtRMSearch.Name = "txtRMSearch";
            this.txtRMSearch.Size = new System.Drawing.Size(158, 34);
            this.txtRMSearch.TabIndex = 31;
            this.txtRMSearch.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dgvMgLoc
            // 
            this.dgvMgLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMgLoc.Location = new System.Drawing.Point(181, 234);
            this.dgvMgLoc.Name = "dgvMgLoc";
            this.dgvMgLoc.RowTemplate.Height = 24;
            this.dgvMgLoc.Size = new System.Drawing.Size(814, 338);
            this.dgvMgLoc.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1037, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 46);
            this.button3.TabIndex = 19;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1037, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 46);
            this.button2.TabIndex = 18;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1037, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1184, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "HOME";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1175, 768);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "WE_R_51";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(447, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Location";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1046, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 44);
            this.button5.TabIndex = 0;
            this.button5.Text = "BACK";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_view
            // 
            this.button_view.BackColor = System.Drawing.Color.Gray;
            this.button_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_view.ForeColor = System.Drawing.Color.White;
            this.button_view.Location = new System.Drawing.Point(45, 181);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(99, 55);
            this.button_view.TabIndex = 43;
            this.button_view.Text = "VIEW";
            this.button_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_view.UseVisualStyleBackColor = false;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            label7.Location = new System.Drawing.Point(846, 185);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(131, 26);
            label7.TabIndex = 44;
            label7.Text = "Room Name";
            label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbbuildingName
            // 
            this.cmbbuildingName.FormattingEnabled = true;
            this.cmbbuildingName.Items.AddRange(new object[] {
            "Computing Building",
            "Engineering Building",
            "Business Building",
            "New Building"});
            this.cmbbuildingName.Location = new System.Drawing.Point(261, 612);
            this.cmbbuildingName.Name = "cmbbuildingName";
            this.cmbbuildingName.Size = new System.Drawing.Size(321, 35);
            this.cmbbuildingName.TabIndex = 45;
            // 
            // ManageLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 744);
            this.Controls.Add(this.panel2);
            this.Name = "ManageLocation";
            this.Text = "ManageLocation";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgLoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtroomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtRMSearch;
        private System.Windows.Forms.DataGridView dgvMgLoc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtcapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.ComboBox cmbbuildingName;
    }
}