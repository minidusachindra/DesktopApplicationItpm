using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TimeTableM
{
    public partial class ManageStudent : Form
    {
        MySqlConnection con = null;
        MySqlConnection con2 = null;
        public ManageStudent()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            con2 = DBConnect.ConnectDB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentDash StudentDash = new StudentDash();
            StudentDash.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT * FROM `addstudentgrp`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMgStd.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con2.Open();
            try
            {
                string qu = "SELECT `AcademicSemYear`,`Programme`, `GrpNo`, `SubGrpNum`, `GrpID`, `SubGrpID` FROM `addstudentgrp` WHERE GrpID = '" + txtStdSearch.Text + "'";
                MySqlCommand mcm = new MySqlCommand(qu, con2);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    cmbAcademicSemYear.Text = sdr.GetValue(0).ToString();
                    txtProg.Text = sdr.GetValue(1).ToString();
                    cmbGrpNo.Text = sdr.GetValue(2).ToString();
                    cmbSubGrpNum.Text = sdr.GetValue(3).ToString();
                    txtGrpID.Text = sdr.GetValue(4).ToString();
                    txtSubGrpID.Text = sdr.GetValue(5).ToString();
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbAcademicSemYear.Text = string.Empty;
           
            cmbGrpNo.Text = string.Empty;
            cmbSubGrpNum.Text = string.Empty;
            txtGrpID.Clear();
            txtSubGrpID.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `addstudentgrp` WHERE GrpID = '" + txtSubGrpID.Text + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "UPDATE `addstudentgrp` SET `AcademicSemYear`='" + cmbAcademicSemYear.Text + "',`GrpNo`='" + cmbGrpNo.Text + "',`SubGrpNum`='" + cmbSubGrpNum.Text + "',`GrpID`='" + txtGrpID.Text + "',`SubGrpID`='" + txtSubGrpID.Text + "' WHERE GrpID = '" + txtSubGrpID.Text + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Update succesfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string acedemic = this.cmbAcademicSemYear.SelectedItem.ToString();
            string prog = this.txtProg.Text.ToString();
            string grpNo = this.cmbGrpNo.SelectedItem.ToString();
            string subNo = this.cmbSubGrpNum.SelectedItem.ToString();

            txtGrpID.Text = acedemic + "." + prog + "." + grpNo;
            txtSubGrpID.Text = acedemic + "." + prog + "." + grpNo + "." + subNo;
        }
    }
}
