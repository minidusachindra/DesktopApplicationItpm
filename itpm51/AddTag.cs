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
    public partial class AddTag : Form
    {
        MySqlConnection con = null;
        public AddTag()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }
        void RelatedTag()
        {
            cmbRelatedTag.Items.Add("Lecture");
            cmbRelatedTag.Items.Add("Tutorial");
            cmbRelatedTag.Items.Add("Lab");
        }

        private void label3_Click(object sender, EventArgs e)
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
            TagDash TagDash = new TagDash();
            TagDash.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            try
            {
                string qu = "INSERT INTO `addtag`(`SubjectTagName`, `SubjectTagCode`, `RelatedTag`) VALUES ('" + cmbSubName.Text + "','" + txtSubCode.Text + "','" + cmbRelatedTag.Text + "')";
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
        private void cmbRelatedTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            RelatedTag();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSubCode.Clear();
            cmbRelatedTag.Text = string.Empty;
            cmbDepartment.Text = string.Empty;
            cmbFac.Text = string.Empty;
            cmbSubName.Text = string.Empty;
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
            }
            else if (fac == "Engineering")
            {
                cmbDepartment.Items.Add("Civil Engneering");
                cmbDepartment.Items.Add("Electrical and electronic engneering");
                cmbDepartment.Items.Add("Megatronic engneering");
            }
            else if (fac == "Business")
            {
                cmbDepartment.Items.Add("Business studies and analysis");
                cmbDepartment.Items.Add("Business studies");
            }
            else if (fac == "Sciences")
            {
                cmbDepartment.Items.Add("Medicine");
                cmbDepartment.Items.Add("Vetnory");
                cmbDepartment.Items.Add("Dental Surgen");
            }
        }

        private void cmbSubName_Click(object sender, EventArgs e)
        {

            con.Open();
            try
            {
                cmbSubName.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SubjectName FROM `addsubject` WHERE department = '" + cmbDepartment.Text + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSubName.Items.Add(dr["SubjectName"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbSubName_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT SubjectCode FROM addsubject WHERE SubjectName = '" + cmbSubName.Text + "'";
                MySqlCommand mcm = new MySqlCommand(qu, con);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    txtSubCode.Text = sdr.GetValue(0).ToString();
                }
                //mcm.ExecuteNonQuery();
                //MessageBox.Show("Insert successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
    }

}

