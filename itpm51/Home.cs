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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLec_Click(object sender, EventArgs e)
        {
            LecturerDash LecturerDash = new LecturerDash();
            LecturerDash.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkingDaysAndHours_Click(object sender, EventArgs e)
        {
            AddWorking AddWorking = new AddWorking();
            AddWorking.Show();
            this.Hide();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            SubjectDash SubjectDash = new SubjectDash();
            SubjectDash.Show();
            this.Hide();
        }

        private void btnAddTags_Click(object sender, EventArgs e)
        {
            TagDash TagDash = new TagDash();
            TagDash.Show();
            this.Hide();
        }

        private void btnStdGrp_Click(object sender, EventArgs e)
        {
            StudentDash StudentDash = new StudentDash();
            StudentDash.Show();
            this.Hide();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            LocationDash LocationDash = new LocationDash();
            LocationDash.Show();
            this.Hide();
        }

        private void btnVisuStat_Click(object sender, EventArgs e)
        {
            Statistics Statistics = new Statistics();
            Statistics.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SessionDash SessionDash = new SessionDash();
            SessionDash.Show();
            this.Hide();
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeTbl TimeTbl = new TimeTbl();
            TimeTbl.Show();
            this.Hide();
        }
    }
}
