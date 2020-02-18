using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreEmulator
{
    public partial class Form1 : Form
    {
        //Create class variables - accessible in every method and available for the lifetime of the form(window)
        int scoreTotal;
        int scoreCount;
        int averageScore;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //Validation of a number input
            int score = Convert.ToInt32(txtScore.Text);
            scoreTotal = scoreTotal + score;
            txtScoreTotal.Text = scoreTotal.ToString();
            scoreCount++; //Add one to scoreCount
            txtScoreCount.Text = scoreCount.ToString();
            averageScore = scoreTotal / scoreCount;
            txtAverage.Text = averageScore.ToString();
            txtScore.Text = "";
            txtScore.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scoreCount = 0;
            scoreTotal = 0;
            averageScore = 0;
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
