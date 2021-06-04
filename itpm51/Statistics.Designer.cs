namespace TimeTableM
{
    partial class Statistics
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
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLecName = new System.Windows.Forms.TextBox();
            this.txtLgrp = new System.Windows.Forms.TextBox();
            this.txtLSubject = new System.Windows.Forms.TextBox();
            this.lblRegLecture = new System.Windows.Forms.Label();
            this.lblRegStd = new System.Windows.Forms.Label();
            this.lblRegSubject = new System.Windows.Forms.Label();
            this.lblRegRooms = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(818, 34);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(104, 43);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "HOME";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(411, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "Statics";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtLSubject);
            this.panel1.Controls.Add(this.txtLgrp);
            this.panel1.Controls.Add(this.txtLecName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(43, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 300);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(31, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Latest Lecture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(31, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Latest Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(31, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Latest Subject";
            // 
            // txtLecName
            // 
            this.txtLecName.Location = new System.Drawing.Point(196, 56);
            this.txtLecName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLecName.Name = "txtLecName";
            this.txtLecName.Size = new System.Drawing.Size(238, 20);
            this.txtLecName.TabIndex = 12;
            // 
            // txtLgrp
            // 
            this.txtLgrp.Location = new System.Drawing.Point(196, 134);
            this.txtLgrp.Margin = new System.Windows.Forms.Padding(2);
            this.txtLgrp.Name = "txtLgrp";
            this.txtLgrp.Size = new System.Drawing.Size(238, 20);
            this.txtLgrp.TabIndex = 15;
            // 
            // txtLSubject
            // 
            this.txtLSubject.Location = new System.Drawing.Point(196, 214);
            this.txtLSubject.Margin = new System.Windows.Forms.Padding(2);
            this.txtLSubject.Name = "txtLSubject";
            this.txtLSubject.Size = new System.Drawing.Size(238, 20);
            this.txtLSubject.TabIndex = 16;
            // 
            // lblRegLecture
            // 
            this.lblRegLecture.AutoSize = true;
            this.lblRegLecture.BackColor = System.Drawing.Color.Blue;
            this.lblRegLecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegLecture.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRegLecture.Location = new System.Drawing.Point(538, 174);
            this.lblRegLecture.MaximumSize = new System.Drawing.Size(400, 100);
            this.lblRegLecture.Name = "lblRegLecture";
            this.lblRegLecture.Size = new System.Drawing.Size(0, 69);
            this.lblRegLecture.TabIndex = 12;
            this.lblRegLecture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegStd
            // 
            this.lblRegStd.AutoSize = true;
            this.lblRegStd.BackColor = System.Drawing.Color.Blue;
            this.lblRegStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegStd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRegStd.Location = new System.Drawing.Point(781, 174);
            this.lblRegStd.MaximumSize = new System.Drawing.Size(400, 100);
            this.lblRegStd.Name = "lblRegStd";
            this.lblRegStd.Size = new System.Drawing.Size(0, 69);
            this.lblRegStd.TabIndex = 13;
            this.lblRegStd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegSubject
            // 
            this.lblRegSubject.AutoSize = true;
            this.lblRegSubject.BackColor = System.Drawing.Color.Blue;
            this.lblRegSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegSubject.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRegSubject.Location = new System.Drawing.Point(538, 339);
            this.lblRegSubject.MaximumSize = new System.Drawing.Size(400, 100);
            this.lblRegSubject.Name = "lblRegSubject";
            this.lblRegSubject.Size = new System.Drawing.Size(0, 69);
            this.lblRegSubject.TabIndex = 14;
            this.lblRegSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegRooms
            // 
            this.lblRegRooms.AutoSize = true;
            this.lblRegRooms.BackColor = System.Drawing.Color.Blue;
            this.lblRegRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegRooms.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRegRooms.Location = new System.Drawing.Point(781, 339);
            this.lblRegRooms.MaximumSize = new System.Drawing.Size(400, 100);
            this.lblRegRooms.Name = "lblRegRooms";
            this.lblRegRooms.Size = new System.Drawing.Size(0, 69);
            this.lblRegRooms.TabIndex = 15;
            this.lblRegRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(537, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Registered Lecture";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(776, 266);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "Registered Tags";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(534, 429);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "Registered Subjects";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Location = new System.Drawing.Point(782, 429);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 26);
            this.label12.TabIndex = 19;
            this.label12.Text = "Registered Rooms";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.CadetBlue;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(43, 99);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(104, 43);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(996, 537);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRegRooms);
            this.Controls.Add(this.lblRegSubject);
            this.Controls.Add(this.lblRegStd);
            this.Controls.Add(this.lblRegLecture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLSubject;
        private System.Windows.Forms.TextBox txtLgrp;
        private System.Windows.Forms.TextBox txtLecName;
        private System.Windows.Forms.Label lblRegLecture;
        private System.Windows.Forms.Label lblRegStd;
        private System.Windows.Forms.Label lblRegSubject;
        private System.Windows.Forms.Label lblRegRooms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnView;
    }
}