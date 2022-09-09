// Author: Cassandra Ziesman
// Class: CIS162AD
// Section: 31778
// Assignment: Chapter Final Program High or Low Game
// Date: May 17th 2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_CZiesman_HighLowGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // PlayGame() Method
        private void PlayGame()
        {
            // Chooses at random a number from 1-10
            Random dealerValue = new Random();
            int dealerNumber = dealerValue.Next(1, 10);

            //Switch Statement for displaying the Dealer Card graphic and Updating Dealer Label Text
            switch (dealerNumber)
            {
                case 1:
                    dealerCard.Image = Properties.Resources.card01;
                    dealerLabel.Text = "1";
                    break;
                case 2:
                    dealerCard.Image = Properties.Resources.card02;
                    dealerLabel.Text = "2";
                    break;
                case 3:
                    dealerCard.Image = Properties.Resources.card03;
                    dealerLabel.Text = "3";
                    break;
                case 4:
                    dealerCard.Image = Properties.Resources.card04;
                    dealerLabel.Text = "4";
                    break;
                case 5:
                    dealerCard.Image = Properties.Resources.card05;
                    dealerLabel.Text = "5";
                    break;
                case 6:
                    dealerCard.Image = Properties.Resources.card06;
                    dealerLabel.Text = "6";
                    break;
                case 7:
                    dealerCard.Image = Properties.Resources.card07;
                    dealerLabel.Text = "7";
                    break;
                case 8:
                    dealerCard.Image = Properties.Resources.card08;
                    dealerLabel.Text = "8";
                    break;
                case 9:
                    dealerCard.Image = Properties.Resources.card09;
                    dealerLabel.Text = "9";
                    break;
                case 10:
                    dealerCard.Image = Properties.Resources.card10;
                    dealerLabel.Text = "10";
                    break;
            }

            // Resets the User's Card and Label Text

            userCard.Image = Properties.Resources.cardBack;
            userLabel.Text = "";
        }

        private void UserGuess() {
            // Chooses at random a number from 1-10
            Random userValue = new Random();
            int userNumber = userValue.Next(1, 10);

            // Switch statement to display User Card graphic and Updating the User Label Text
            switch (userNumber)
            {
                case 1:
                    userCard.Image = Properties.Resources.card01;
                    userLabel.Text = "1";
                    break;
                case 2:
                    userCard.Image = Properties.Resources.card02;
                    userLabel.Text = "2";
                    break;
                case 3:
                    userCard.Image = Properties.Resources.card03;
                    userLabel.Text = "3";
                    break;
                case 4:
                    userCard.Image = Properties.Resources.card04;
                    userLabel.Text = "4";
                    break;
                case 5:
                    userCard.Image = Properties.Resources.card05;
                    userLabel.Text = "5";
                    break;
                case 6:
                    userCard.Image = Properties.Resources.card06;
                    userLabel.Text = "6";
                    break;
                case 7:
                    userCard.Image = Properties.Resources.card07;
                    userLabel.Text = "7";
                    break;
                case 8:
                    userCard.Image = Properties.Resources.card08;
                    userLabel.Text = "8";
                    break;
                case 9:
                    userCard.Image = Properties.Resources.card09;
                    userLabel.Text = "9";
                    break;
                case 10:
                    userCard.Image = Properties.Resources.card10;
                    userLabel.Text = "10";
                    break;
            }
        }

        // Play Button 
        private void playButton_Click(object sender, EventArgs e)
        {
            // Call Play Game Method
            PlayGame();

            // Enables High and Low buttons. Disables Play button.
            highButton.Enabled = true;
            lowButton.Enabled = true;
            playButton.Enabled = false;
        }
        // High Button
        private void highButton_Click(object sender, EventArgs e)
        {
            // Calls User Guess Method
            UserGuess();

            // Disables High and Low buttons. Enables Play button.
            highButton.Enabled = false;
            lowButton.Enabled = false;
            playButton.Enabled = true;

            //Parses String from Label Text to Interget
            int dealerN = int.Parse(dealerLabel.Text);
            int userN = int.Parse(userLabel.Text);

            // If Else Statement to Compare and Check if User was Correct
            if (dealerN == userN) {
                MessageBox.Show("You tied!");
            }
            if (dealerN > userN) {
                MessageBox.Show("You lose!");
            }
            else
            {
                MessageBox.Show("You won!");
            }
        }

        private void lowButton_Click(object sender, EventArgs e)
        {
            // Calls User Guess Method
            UserGuess();

            // Disables High and Low buttons. Enables Play button.
            highButton.Enabled = false;
            lowButton.Enabled = false;
            playButton.Enabled = true;

            // Parses String gtom Label Text to Interger
            int dealerN = int.Parse(dealerLabel.Text);
            int userN = int.Parse(userLabel.Text);

            // If Else Statement to Compare and Check if User was Correct
            if (dealerN == userN)
            {
                MessageBox.Show("You tied!");
            }
            if (dealerN < userN)
            {
                MessageBox.Show("You lose!");
            }
            else
            {
                MessageBox.Show("You won!");
            }
        }

        // Exit Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
