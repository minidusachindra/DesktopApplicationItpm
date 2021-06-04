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
    public partial class AddSubject : Form
    {
        MySqlConnection con = null;
        public AddSubject()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }
        string sem;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "INSERT INTO `addsubject`(`department`,`dep2`,`OfferdYear`, `OfferedSem`, `SubjectName`, `SubjectCode`, `NoOfLecHours`, `NoOfTuHours`, `NoOfLabHours`, `NoOfEveHours`) VALUES ('" + cmbDepartment.Text + "','" + cmbDep2.Text + "','" + cmbYear.Text + "','" + sem + "','" + txtSubName.Text + "','" + txtSubCode.Text + "','" + noUpDwnLecHours.Text + "','" + noUpDwnNoOfTuteHours.Text + "','" + noUpDwnLabHours.Text + "','" + noUpDwnEvaHours.Text + "')";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Insert successfully");
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

        private void button3_Click(object sender, EventArgs e)
        {
            cmbYear.Text = string.Empty;
            sem = string.Empty;
            txtSubName.Clear();
            txtSubCode.Clear();
            noUpDwnLecHours.Text = string.Empty;
            noUpDwnNoOfTuteHours.Text = string.Empty;
            noUpDwnLabHours.Text = string.Empty;
            noUpDwnEvaHours.Text = string.Empty;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbDep2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void cmbFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fac = this.cmbFac.SelectedItem.ToString();
            if (fac == "Computing")
            {
                cmbDepartment.Items.Add("Computer Sciance");
                cmbDepartment.Items.Add("Software engneering");
                cmbDepartment.Items.Add("Business studies and software engneering");
                cmbDepartment.Items.Add("Information systems");
                cmbDep2.Items.Add("Computer Sciance");
                cmbDep2.Items.Add("Software engneering");
                cmbDep2.Items.Add("Business studies and software engneering");
                cmbDep2.Items.Add("Information systems");
            }
            else if (fac == "Engineering")
            {
                cmbDepartment.Items.Add("Civil Engneering");
                cmbDepartment.Items.Add("Electrical and electronic engneering");
                cmbDepartment.Items.Add("Megatronic engneering");
                cmbDep2.Items.Add("Civil Engneering");
                cmbDep2.Items.Add("Electrical and electronic engneering");
                cmbDep2.Items.Add("Megatronic engneering");
            }
            else if (fac == "Business")
            {
                cmbDepartment.Items.Add("Business studies and analysis");
                cmbDepartment.Items.Add("Business studies");
                cmbDep2.Items.Add("Business studies and analysis");
                cmbDep2.Items.Add("Business studies");
            }
            else if (fac == "Sciences")
            {
                cmbDepartment.Items.Add("Medicine");
                cmbDepartment.Items.Add("Vetnory");
                cmbDepartment.Items.Add("Dental Surgen");
                cmbDep2.Items.Add("Medicine");
                cmbDep2.Items.Add("Vetnory");
                cmbDep2.Items.Add("Dental Surgen");
            }
        }
    }
}
