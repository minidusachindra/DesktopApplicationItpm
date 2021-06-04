namespace TimeTableM
{
    partial class LecturerDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerDash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.managelec = new System.Windows.Forms.Button();
            this.addlec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            label4.Location = new System.Drawing.Point(729, 455);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(270, 40);
            label4.TabIndex = 4;
            label4.Text = "Manage Lecturer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.managelec);
            this.panel1.Controls.Add(this.addlec);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.SpringGreen;
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 772);
            this.panel1.TabIndex = 1;
            // 
            // managelec
            // 
            this.managelec.BackColor = System.Drawing.Color.Silver;
            this.managelec.Image = ((System.Drawing.Image)(resources.GetObject("managelec.Image")));
            this.managelec.Location = new System.Drawing.Point(770, 284);
            this.managelec.Name = "managelec";
            this.managelec.Size = new System.Drawing.Size(178, 149);
            this.managelec.TabIndex = 6;
            this.managelec.UseVisualStyleBackColor = false;
            this.managelec.Click += new System.EventHandler(this.managelec_Click);
            // 
            // addlec
            // 
            this.addlec.BackColor = System.Drawing.Color.Silver;
            this.addlec.Image = ((System.Drawing.Image)(resources.GetObject("addlec.Image")));
            this.addlec.Location = new System.Drawing.Point(318, 284);
            this.addlec.Name = "addlec";
            this.addlec.Size = new System.Drawing.Size(171, 149);
            this.addlec.TabIndex = 5;
            this.addlec.UseVisualStyleBackColor = false;
            this.addlec.Click += new System.EventHandler(this.addlec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(302, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Lecturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1155, 605);
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(986, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Lecturer Management";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1161, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "HOME";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LecturerDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 773);
            this.Controls.Add(this.panel1);
            this.Name = "LecturerDash";
            this.Text = "LecturerDash";
            this.Load += new System.EventHandler(this.LecturerDash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button managelec;
        private System.Windows.Forms.Button addlec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}