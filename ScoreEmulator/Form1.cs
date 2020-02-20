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
        int scoreTotal; //Declaring the int class variable type to scoreTotal
        int scoreCount; //Declaring the int class variable type to scoreCount

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
            scoreTotal = scoreTotal + score; //scoreTotal =+Score is another way of doing this correct?
            txtScoreTotal.Text = scoreTotal.ToString(); //the input of the txtScoreTotal is converted to a string
            scoreCount++; //Add one to scoreCount
            txtScoreCount.Text = scoreCount.ToString(); //the input of the score count is converted to a string
            double averageScore = scoreTotal / scoreCount; //the Average score is a double number that is equal of the scoreTotal divided by the scoreCount
            txtAverage.Text = averageScore.ToString(); //the result of the average is equal to a string
            txtScore.Text = ""; //empty string for txtScore
            txtScore.Focus(); //focus on the txtScore after the code is executed and result is generated
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scoreCount = 0; //Sets scoreCount to 0
            scoreTotal = 0; //Sets scoreTotal to 0

            txtScoreTotal.Text = ""; //txtScoreTotal is cleared
            txtScoreCount.Text = ""; //tktScoreCount is cleared
            txtAverage.Text = ""; //txtAverage is cleared
            txtScore.Focus(); //Focus is set on on the txtScore where the result will be
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
