using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockScissorsPaper
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        string[] computerChoices = new string[] { "Rock", "Scissors", "Paper" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pixabay.com/pl/users/clker-free-vector-images-3736/?utm_source=link-attribution&utm_medium=referral&utm_campaign=image&utm_content=296853");
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            this.picBoxPlayer.Image = Properties.Resources.imgRo;
            checkWhoWins("Rock");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            this.picBoxPlayer.Image = Properties.Resources.imgSc;
            checkWhoWins("Scissors");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            this.picBoxPlayer.Image = Properties.Resources.imgPa;
            checkWhoWins("Paper");
        }

        void checkWhoWins(string playerPlays)
        {
            string cPlays = computerPlays();

            if (playerPlays == "Rock" & cPlays =="Rock")
            {
                updateForm("draw");
            }
            else if (playerPlays == "Rock" & cPlays == "Scissors")
            {
                updateForm("player");
            }
            else if (playerPlays == "Rock" & cPlays == "Paper")
            {
                updateForm("computer");
            }
            else if (playerPlays == "Scissors" & cPlays == "Rock")
            {
                updateForm("computer");
            }
            else if (playerPlays == "Scissors" & cPlays == "Scissors")
            {
                updateForm("draw");
            }
            else if (playerPlays == "Scissors" & cPlays == "Paper")
            {
                updateForm("player");
            }
            else if (playerPlays == "Paper" & cPlays == "Rock")
            {
                updateForm("player");
            }
            else if (playerPlays == "Paper" & cPlays == "Scissors")
            {
                updateForm("computer");
            }
            else if (playerPlays == "Paper" & cPlays == "Paper")
            {
                updateForm("draw");
            }
        }

        string computerPlays()
        {
            string computerPlay = computerChoices[random.Next(0, computerChoices.Length)];
            if (computerPlay=="Rock")
            {
                this.picBoxComp.Image = Properties.Resources.imgRo;
            }
            else if (computerPlay=="Scissors")
            {
                this.picBoxComp.Image = Properties.Resources.imgSc;
            }
            else
            {
                this.picBoxComp.Image = Properties.Resources.imgPa;
            }
            return computerPlay;
        }

        void updateForm(string winer)
        {
            if (winer=="player")
            {
                this.labResult.Text = "<-";
                this.labDraw.Text = "";
                int playerScore = Convert.ToInt32(this.labPlayerScore.Text);
                playerScore += 1;
                this.labPlayerScore.Text = playerScore.ToString();
            }
            else if (winer=="computer")
            {
                this.labResult.Text = "->";
                this.labDraw.Text = "";
                int computerScore = Convert.ToInt32(this.labComputerScore.Text);
                computerScore += 1;
                this.labComputerScore.Text = computerScore.ToString();
            }
            else
            {
                this.labDraw.Text = "DRAW!";
                this.labResult.Text = "";
            }
        }
    }
}
