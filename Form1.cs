using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Alexandros Nicolaou
//592067
//09-13-20
//will tell users what card they pick

namespace Homework2_CardIdentifier
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //when the user clicks the picture the code will access the text of the label and change it to the desired text
        private void Diamonds_Click(object sender, EventArgs e)
        {
            YourCard.Text = "Two of diamonds";

        }

        private void Clubs_Click(object sender, EventArgs e)
        {
            YourCard.Text = "Two of Clubs";

        }

        private void YourCard_Click(object sender, EventArgs e)
        {

        }

        private void Hearts_Click(object sender, EventArgs e)
        {
            YourCard.Text = "Two of Hearts";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
