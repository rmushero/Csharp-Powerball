using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];

            Random rand = new Random();

            for (int index = 0; index < lotteryNumbers.Length; index++)
            {
                lotteryNumbers[index] = rand.Next(69);
            }

            int pball = rand.Next(26);

            firstLabel.Text = lotteryNumbers[0].ToString();
            secondLabel.Text = lotteryNumbers[1].ToString();
            thirdLabel.Text = lotteryNumbers[2].ToString();
            fourthLabel.Text = lotteryNumbers[3].ToString();
            fifthLabel.Text = lotteryNumbers[4].ToString();
            powerBall.Text = pball.ToString();
        }
    }
}
