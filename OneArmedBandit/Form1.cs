using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
       //1 is cherry, 2 is diamond, 3is 7
        Random rng = new Random();
       
        int score = 10;
        
        int reelOne;
        int reelTwo;
        int reelThree;


        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            int reelOne = rng.Next(1, 4);
            int reelTwo = rng.Next(1, 4);
            int reelThree = rng.Next(1, 4);
            // get random values for each reel (store each in separate int variable)



            switch (reelOne)
            {

                case 1:
                    outputLabel.Text = "cherry";
                    reel2.Image = (OneArmedBandit.Properties.Resources.cherry_100x125);
                    break;
                case 2:
                    //image of diamond
                    reel2.Image = OneArmedBandit.Properties.Resources

                    break;
                case 3:
                    //image of 7
                    break;
            }
          

            switch (reelTwo)
            {
                case 1:
                    //image of cherry
                    outputLabel.Text = "cherry";
                    reel2.Image = (OneArmedBandit.Properties.Resources.cherry_100x125);
                    break;
                case 2:
                    //image of diamond
                    break;
                case 3:
                    //image of 7
                    break;
            }
            
            switch (reelThree)
            {
                case 1:
                    //image of cherry
                    outputLabel.Text = "cherry";
                    reel2.Image = (OneArmedBandit.Properties.Resources.cherry_100x125);
                    break;
                case 2:
                    //image of diamond
                    break;
                case 3:
                    //image of 7
                    break;
             
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         


            // if score has reached 0 display "lose" message and set button enabled property to false


            // display updated score

        }
    }
}
