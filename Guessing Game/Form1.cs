using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class guesingGame : Form
    {
        Random randGen = new Random();
        int actualValue;

        int randomValues;

        public guesingGame()
        {
            InitializeComponent();
            actualValue = randGen.Next(1, 101);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int playerGuess;
            playerGuess = Convert.ToInt32(guessInput.Text);
            randomValues = actualValue;

            if(playerGuess == randomValues)
            {
                outputLabel.Text = "CONGRATS! You Got It !!";
            }
            else if(playerGuess < randomValues)
            {
                outputLabel.Text = "Too Low, Try Again";
            }
            else if(playerGuess > randomValues)
            {
                outputLabel.Text = "Too High, Try Again";
            }

            int num = playerGuess - randomValues;
            int numAbsolute = Math.Abs(num);
            if(numAbsolute >= 50)
            {
                outputLabel2.Text = "FREEZING - More than 50 away";
            }
            else if(numAbsolute >= 25)
            {
                outputLabel2.Text = "COLD - More than 25 away";
            }
            else if(numAbsolute >= 15)
            {
                outputLabel2.Text = "COOL - More than 15 away";
            }
            else if(numAbsolute >= 10)
            {
                outputLabel2.Text = "WARM - More than 10 away";
            }
            else if(numAbsolute >= 5)
            {
                outputLabel2.Text = "HOT - More than 5 away";
            }
            else if(numAbsolute >= 2)
            {
                outputLabel2.Text = "BOILING - 1 to 4 away";
            }
            else if(numAbsolute == 0)
            {
                outputLabel2.Text = "";
            }
            
        }
    }
}
