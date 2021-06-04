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
    public partial class AddLocation : Form
    {
        MySqlConnection con = null;
        public AddLocation()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }
        string roomType;
        void BuildingName()
        {
            cmbbuildingName.Items.Add("Computing Building");
            cmbbuildingName.Items.Add("Engineering Building");
            cmbbuildingName.Items.Add("Business Building");
            cmbbuildingName.Items.Add("New Building");
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

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "INSERT INTO `addlocation`(`buildingName`, `roomName`, `roomType`, `capacity`) VALUES ('" + cmbbuildingName.Text + "','" + txtroomName.Text + "','" + roomType + "','" + txtcapacity.Text + "')";
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

        private void button3_Click(object sender, EventArgs e)
        {
            cmbbuildingName.Text = string.Empty;
            txtroomName.Clear();
            roomType = string.Empty;
            txtcapacity.Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Lecture Hall";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "Laboratory";
        }
    }
}
