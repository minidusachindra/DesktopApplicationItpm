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
    public partial class ManageLocation : Form
    {
        MySqlConnection con = null;
        MySqlConnection con2 = null;
        public ManageLocation()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
            con2 = DBConnect.ConnectDB();
        }
        string roomType;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            LocationDash LocationDash = new LocationDash();
            LocationDash.Show();
            this.Hide();
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT * FROM `addlocation`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMgLoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con2.Open();
            try
            {
                string qu = "SELECT `buildingName`, `roomName`, `roomType`, `capacity` FROM `addlocation` WHERE roomName = '" + txtRMSearch.Text + "'";
                MySqlCommand mcm = new MySqlCommand(qu, con2);
                MySqlDataReader sdr = mcm.ExecuteReader();
                while (sdr.Read())
                {
                    cmbbuildingName.Text = sdr.GetValue(0).ToString();
                    txtroomName.Text = sdr.GetValue(1).ToString();
                    roomType = sdr.GetValue(2).ToString();
                    txtcapacity.Text = sdr.GetValue(3).ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con2.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Lecture Hall";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Laboratory";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "UPDATE `addlocation` SET `buildingName`='" + cmbbuildingName.Text + "',`roomName`='" + txtroomName.Text + "',`roomType`='" + roomType + "',`capacity`='" + txtcapacity.Text + "' WHERE roomName = '" + txtroomName.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            cmbbuildingName.Text = string.Empty;
            txtroomName.Clear();
            roomType = string.Empty;
            txtcapacity.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "DELETE FROM `addlocation` WHERE roomName = '" + txtroomName.Text + "'";
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
    }
}
