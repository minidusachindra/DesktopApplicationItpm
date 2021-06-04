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
    public partial class ManageSubject : Form
    {
        MySqlConnection con = null;
        MySqlConnection con2 = null;
        public ManageSubject()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            con2 = DBConnect.ConnectDB();
        }
        string sem;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubjectDash SubjectDash = new SubjectDash();
            SubjectDash.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT * FROM `addsubject`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvManSub.DataSource = dt;
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
                string qu = "SELECT `department`, `OfferdYear`, `OfferedSem`, `SubjectName`, `SubjectCode`, `NoOfLecHours`, `NoOfTuHours`, `NoOfLabHours`, `NoOfEveHours` FROM `addsubject` WHERE SubjectCode = '" + txtSubSearch.Text + "'";
                MySqlCommand mcm = new MySqlCommand(qu, con2);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    cmbDepartment.Text = sdr.GetValue(0).ToString();
                    cmbYear.Text = sdr.GetValue(1).ToString();
                    sem = sdr.GetValue(2).ToString();
                    txtSubName.Text = sdr.GetValue(3).ToString();
                    txtSubCode.Text = sdr.GetValue(4).ToString();
                    noUpDwnLecHours.Text = sdr.GetValue(5).ToString();
                    noUpDwnNoOfTuteHours.Text = sdr.GetValue(6).ToString();
                    noUpDwnLabHours.Text = sdr.GetValue(7).ToString();
                    noUpDwnEvaHours.Text = sdr.GetValue(8).ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `addsubject` WHERE SubjectCode = '" + txtSubCode.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            cmbDepartment.Text = string.Empty;
            cmbYear.Text = string.Empty;
            sem = string.Empty;
            txtSubName.Clear();
            txtSubCode.Clear();
            noUpDwnLecHours.Text = string.Empty;
            noUpDwnNoOfTuteHours.Text = string.Empty;
            noUpDwnLabHours.Text = string.Empty;
            noUpDwnEvaHours.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "UPDATE `addsubject` SET `department`='" + cmbDepartment.Text + "', `OfferdYear`='" + cmbYear.Text + "',`OfferedSem`='" + sem + "',`SubjectName`='" + txtSubName.Text + "',`SubjectCode`='" + txtSubCode.Text + "',`NoOfLecHours`='" + noUpDwnLecHours.Text + "',`NoOfTuHours`='" + noUpDwnNoOfTuteHours.Text + "',`NoOfTuHours`='" + noUpDwnLabHours.Text + "',`NoOfLabHours`='" + noUpDwnEvaHours.Text + "' WHERE SubjectCode = '" + txtSubCode.Text + "'";
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sem = "1st Semester";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sem = "2nd Semester";
        }
    }
}
