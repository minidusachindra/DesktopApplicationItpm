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
    public partial class ManageLecturers : Form
    {
        MySqlConnection con = null;
        MySqlConnection con2 = null;
        public ManageLecturers()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            con2 = DBConnect.ConnectDB();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            LecturerDash LecturerDash = new LecturerDash();
            LecturerDash.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT * FROM `addlecture`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMgLec.DataSource = dt;
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
                string qu = "SELECT `LecName`, `EmpID`, `Faculty`, `Department`, `Center`, `Building`, `Level`, `Rank` FROM `addlecture` WHERE EmpID = '"+ txtEmpSearch.Text+ "'";
                MySqlCommand mcm = new MySqlCommand(qu, con2);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    txtLecName.Text = sdr.GetValue(0).ToString();
                    txtEmpID.Text = sdr.GetValue(1).ToString();
                    cmbFaculty.Text = sdr.GetValue(2).ToString();
                    cmbDepartment.Text = sdr.GetValue(3).ToString();
                    cmbCenters.Text = sdr.GetValue(4).ToString();
                    cmbBuildings.Text = sdr.GetValue(5).ToString();
                    cmbLevel.Text = sdr.GetValue(6).ToString();
                    txtRank.Text = sdr.GetValue(7).ToString();
                }
                //mcm.ExecuteNonQuery();
                //MessageBox.Show("Insert successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con2.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "UPDATE `addlecture` SET `LecName`='"+txtLecName.Text+ "',`EmpID`='"+txtEmpID.Text + "',`Faculty`='"+cmbFaculty.Text + "',`Department`='"+cmbDepartment.Text + "',`Center`='"+cmbCenters.Text + "',`Building`='"+cmbBuildings.Text + "',`Level`='"+cmbLevel.Text + "',`Rank`='"+txtRank.Text + "' WHERE EmpID = '" + txtEmpID.Text+ "'";
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

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                /*cmbFaculty.Items.Add("Computing");
                cmbFaculty.Items.Add("Engineering");
                cmbFaculty.Items.Add("Business");
                cmbFaculty.Items.Add("Sciences");*/
                string fac = this.cmbFaculty.SelectedItem.ToString();
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

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*cmbLevel.Items.Add("Professor");
            cmbLevel.Items.Add("Assistant Professor");
            cmbLevel.Items.Add("Senior Lecturer(HG)");
            cmbLevel.Items.Add("Senior Lecturer");
            cmbLevel.Items.Add("Lecturer");
            cmbLevel.Items.Add("Assistant Lecturer");*/

            string lev = this.cmbLevel.SelectedItem.ToString();
            if (lev == "Professor")
            {
                txtRank.Text = Convert.ToString("1");
            }
            else if (lev == "Assistant Professor")
            {
                txtRank.Text = Convert.ToString("2");
            }
            else if (lev == "Senior Lecturer(HG)")
            {
                txtRank.Text = Convert.ToString("3");
            }
            else if (lev == "Senior Lecturer")
            {
                txtRank.Text = Convert.ToString("4");
            }
            else if (lev == "Lecturer")
            {
                txtRank.Text = Convert.ToString("5");
            }
            else if (lev == "Assistant Lecturer")
            {
                txtRank.Text = Convert.ToString("6");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `addlecture` WHERE EmpID = '" + txtEmpID.Text + "'";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLecName.Clear();
            txtEmpID.Clear();
            txtRank.Clear();
            cmbBuildings.Text = string.Empty;
            cmbCenters.Text = string.Empty;
            cmbDepartment.Text = string.Empty;
            cmbFaculty.Text = string.Empty;
            cmbLevel.Text = string.Empty;
        }
    }
}
