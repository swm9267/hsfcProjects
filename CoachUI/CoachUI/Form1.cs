using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachUI
{
    public partial class Form1 : Form
    {
        public Coach myCoach = new Coach();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(nameTextBox.Text, Convert.ToInt32(ageTextBox.Text));
            int Seat = myCoach.AddPerson(p1);
            seatTextBox.Text = Seat + "";
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text= "";
            ageTextBox.Text = "";
            seatTextBox.Text = "";
        }

        private void seatLabel_Click(object sender, EventArgs e)
        {

        }

        private void seatTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
