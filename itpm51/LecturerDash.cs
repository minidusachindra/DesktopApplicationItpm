using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableM
{
    public partial class LecturerDash : Form
    {
        public LecturerDash()
        {
            InitializeComponent();
        }

        private void LecturerDash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void addlec_Click(object sender, EventArgs e)
        {
            AddLecturer AddLecturer = new AddLecturer();
            AddLecturer.Show();
            this.Hide();
        }

        private void managelec_Click(object sender, EventArgs e)
        {
            ManageLecturers ManageLecturers = new ManageLecturers();
            ManageLecturers.Show();
            this.Hide();
        }
    }
}
