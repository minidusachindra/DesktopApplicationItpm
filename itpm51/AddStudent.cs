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
    public partial class AddStudent : Form
    {
        MySqlConnection con = null;
        public AddStudent()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }
        string acedemic;
        string prog;
        string grpNo;
        string subNo;
        void Academic()
        {
            cmbAcademicSemYear.Items.Add("Y1 S1");
            cmbAcademicSemYear.Items.Add("Y1 S2");
            cmbAcademicSemYear.Items.Add("Y2 S1");
            cmbAcademicSemYear.Items.Add("Y2 S2");
            cmbAcademicSemYear.Items.Add("Y3 S1");
            cmbAcademicSemYear.Items.Add("Y3 S2");
            cmbAcademicSemYear.Items.Add("Y4 S1");
            cmbAcademicSemYear.Items.Add("Y4 S2");
        }
       
        /*void ProgrammeS()
        {
            cmbProgramme.Items.Add("IT");
            cmbProgramme.Items.Add("SE");
            cmbProgramme.Items.Add("DS");
            cmbProgramme.Items.Add("CSNE");
            cmbProgramme.Items.Add("CS");
            cmbProgramme.Items.Add("IM");
        }*/

        void GroupNo()
        {
            cmbGrpNo.Items.Add("01");
            cmbGrpNo.Items.Add("02");
            cmbGrpNo.Items.Add("03");
            cmbGrpNo.Items.Add("04");
            cmbGrpNo.Items.Add("05");
            cmbGrpNo.Items.Add("06");
            cmbGrpNo.Items.Add("07");
            cmbGrpNo.Items.Add("08");
        }
        void SubGroup()
        {
            cmbSubGrpNum.Items.Add("S1");
            cmbSubGrpNum.Items.Add("S2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDash StudentDash = new StudentDash();
            StudentDash.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "INSERT INTO `addstudentgrp`(`Fac`, `Dep`,`AcademicSemYear`, `Programme`, `GrpNo`, `SubGrpNum`, `GrpID`, `SubGrpID`) VALUES ('" + cmbFac.Text + "','" + cmbDep.Text + "','" + cmbAcademicSemYear.Text + "','" + txtProgramme.Text + "','" + cmbGrpNo.Text + "','" + cmbSubGrpNum.Text + "','" + txtGrpID.Text + "','" + txtSubGrpID.Text + "')";
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
        private void cmbAcademicSemYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Academic();
        }

        private void cmbProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ProgrammeS();
        }

        private void cmbGrpNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupNo();
        }

        private void cmbSubGrpNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubGroup();
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

        private void button3_Click(object sender, EventArgs e)
        {

            cmbAcademicSemYear.Text = string.Empty;
            txtProgramme.Text = string.Empty;
            cmbGrpNo.Text = string.Empty;
            cmbSubGrpNum.Text = string.Empty;
            txtGrpID.Clear();
            txtSubGrpID.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string acedemic = this.cmbAcademicSemYear.SelectedItem.ToString();
            string prog = this.txtProgramme.Text.ToString();
            string grpNo = this.cmbGrpNo.SelectedItem.ToString();
            string subNo = this.cmbSubGrpNum.SelectedItem.ToString();

            txtGrpID.Text = acedemic + "." + prog + "." + grpNo;
            txtSubGrpID.Text = acedemic + "." + prog + "." + grpNo + "." + subNo;
        }

        private void cmbFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fac = this.cmbFac.SelectedItem.ToString();
            if (fac == "Computing")
            {
                cmbDep.Items.Add("Computer Sciance");
                cmbDep.Items.Add("Software engneering");
                cmbDep.Items.Add("Business studies and software engneering");
                cmbDep.Items.Add("Information systems");
            }
            else if (fac == "Engineering")
            {
                cmbDep.Items.Add("Civil Engneering");
                cmbDep.Items.Add("Electrical and electronic engneering");
                cmbDep.Items.Add("Megatronic engneering");
            }
            else if (fac == "Business")
            {
                cmbDep.Items.Add("Business studies and analysis");
                cmbDep.Items.Add("Business studies");
            }
            else if (fac == "Sciences")
            {
                cmbDep.Items.Add("Medicine");
                cmbDep.Items.Add("Vetnory");
                cmbDep.Items.Add("Dental Surgen");
            }
        }

        private void cmbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dep = this.cmbDep.SelectedItem.ToString();
            if (dep == "Computer Sciance")
            {
                txtProgramme.Text = "CS";
            }
            else if (dep == "Software engneering")
            {
                txtProgramme.Text = "SE";
            }
            else if (dep == "Business studies and software engneering")
            {
                txtProgramme.Text = "BS&SE";
            }
            else if (dep == "Information systems")
            {
                txtProgramme.Text = "IS";
            }
            else if (dep == "Civil Engneering")
            {
                txtProgramme.Text = "CE";
            }
            else if (dep == "Electrical and electronic engneering")
            {
                txtProgramme.Text = "EEE";
            }
            else if (dep == "Megatronic engneering")
            {
                txtProgramme.Text = "ME";
            }
            else if (dep == "Business studies and analysis")
            {
                txtProgramme.Text = "BSA";
            }
            else if (dep == "Business studies")
            {
                txtProgramme.Text = "BS";
            }
            else if (dep == "Dental Surgen")
            {
                txtProgramme.Text = "DENTAL";
            }
            else if (dep == "Vetnory")
            {
                txtProgramme.Text = "VET";
            }
            else if (dep == "Medicine")
            {
                txtProgramme.Text = "MED";
            }
        }

        private void cmbDep_Click(object sender, EventArgs e)
        {
            
        }
    }
}
