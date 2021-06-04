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
    public partial class AddWorking : Form
    {
        MySqlConnection con = null;
        MySqlConnection con2 = null;
        public AddWorking()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            con2 = DBConnect.ConnectDB();
        }

        void chkDays()
        {
            string monday;
            string tuesday;
            string wednesday;
            string thursday;
            string friday;
            string saturday;
            string sunday;
            if (checkBox1.Checked)
            {
                monday = "monday";
            }
            else
            {
                monday = null;
            }
            if (checkBox2.Checked)
            {
                tuesday = "tuesday";
            }
            else
            {
                tuesday = null;
            }
            if (checkBox3.Checked)
            {
                wednesday = "wednesday";
            }
            else
            {
                wednesday = null;
            }
            if (checkBox4.Checked)
            {
                tuesday = "tuesday";
            }
            else
            {
                tuesday = null;
            }
            if (checkBox5.Checked)
            {
                friday = "friday";
            }
            else
            {
                friday = null;
            }
            if (checkBox7.Checked)
            {
                saturday = "saturday";
            }
            else
            {
                saturday = null;
            }
            if (checkBox6.Checked)
            {
                sunday = "sunday";
            }
            else
            {
                sunday = null;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
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
            string monday;
            string tuesday;
            string wednesday;
            string thursday;
            string friday;
            string saturday;
            string sunday;
            if (checkBox1.Checked)
            {
                monday = "monday";
            }
            else
            {
                monday = null;
            }
            if (checkBox2.Checked)
            {
                tuesday = "tuesday";
            }
            else
            {
                tuesday = null;
            }
            if (checkBox3.Checked)
            {
                wednesday = "wednesday";
            }
            else
            {
                wednesday = null;
            }
            if (checkBox4.Checked)
            {
                thursday = "thursday";
            }
            else
            {
                thursday = null;
            }
            if (checkBox5.Checked)
            {
                friday = "friday";
            }
            else
            {
                friday = null;
            }
            if (checkBox7.Checked)
            {
                saturday = "saturday";
            }
            else
            {
                saturday = null;
            }
            if (checkBox6.Checked)
            {
                sunday = "sunday";
            }
            else
            {
                sunday = null;
            }


            con.Open();
            try
            {
                string qu = "INSERT INTO `workingdays`(`EmpID`, `NoOfWorkingDays`, `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday`, `Saturday`, `Sunday`, `WrkTimePerDay`) VALUES ('" + txtEmpID.Text + "','" + UpDownNoOfWorkingDays.Text + "','" + monday + "','" + tuesday + "','" + wednesday + "','" + thursday + "','" + friday + "','" + saturday + "','" + sunday + "','" + dateTimePicker1.Text + "')";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "HH:mm";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `workingdays` WHERE EmpID = '" + txtEmpID.Text + "'";
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

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            con2.Open();
            try
            {
                string qu = "SELECT `EmpID`, `NoOfWorkingDays`, `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday`, `Saturday`, `Sunday`, `WrkTimePerDay` FROM `workingdays` WHERE EmpID = '" + txtEpSearch.Text + "'";
                MySqlCommand mcm = new MySqlCommand(qu, con2);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    txtEmpID.Text = sdr.GetValue(0).ToString();
                    UpDownNoOfWorkingDays.Text = sdr.GetValue(1).ToString();
                    
                    
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con2.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtEmpID.Clear();
            UpDownNoOfWorkingDays.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "UPDATE `workingdays` SET `NoOfWorkingDays`='" + UpDownNoOfWorkingDays.Text + "',`Monday`='" + checkBox1.Text + "',`Tuesday`='" + checkBox2.Text + "',`Wednesday`='" + checkBox3.Text + "',`Thursday`='" + checkBox4.Text + "',`Friday`='" + checkBox5.Text + "',`Saturday`='" + checkBox7.Text + "',`Sunday`='" + checkBox6.Text + "',`WrkTimePerDay`='" + dateTimePicker1.Text + "' WHERE EmpID  = '" + txtEmpID.Text + "'";
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

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT * FROM `workingdays`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAddWrk.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddTimeSlot AddTimeSlot = new AddTimeSlot();
            AddTimeSlot.Show();
            this.Hide();
        }
    }
}
