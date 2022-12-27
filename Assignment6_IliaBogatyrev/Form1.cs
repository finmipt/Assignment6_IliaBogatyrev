namespace Assignment6_IliaBogatyrev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();


        }
        int computerChoice = 1;


        private void DisplayComputerChoice(int computerChoice)
        {
            // Set the image and text of the picture box and label based on the computer's choice
            switch (computerChoice)
            {
                case 1:
                    pictureBox4.Image = Properties.Resources.rock;
                    label5.Text = "Computer chose rock.";
                    break;
                case 2:
                    pictureBox4.Image = Properties.Resources.paper;
                    label5.Text = "Computer chose paper.";
                    break;
                case 3:
                    pictureBox4.Image = Properties.Resources.scissors;
                    label5.Text = "Computer chose scissors.";
                    break;
            }

            // Delay for 2.5 seconds
            System.Threading.Thread.Sleep(500);

        }

        private void StartNewGame(int number) 
        {
            Random rnd = new Random();
            computerChoice = rnd.Next(1, 4);
            System.Threading.Thread.Sleep(200);
            pictureBox4.Image = Properties.Resources.question;
            label5.Text = "New Game Has Started";
        }


        int computerScores = 0;
        int playerScores = 0;
        private void computerWins(int computerChoice)
        {
            computerScores++;
            System.Threading.Thread.Sleep(200);
            comPoints.Text = String.Format( "{0}", computerScores);

        }

        private void playerWins(int computerChoice)
        {
            playerScores++;
            System.Threading.Thread.Sleep(200);
            playerPoints.Text = String.Format("{0}", playerScores);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisplayComputerChoice(computerChoice);
            // Compare the user's choice (paper) to the computer's choice
            if (computerChoice == 1)
            {
                // The computer chose rock, so the user wins
                MessageBox.Show("You win! Paper beats rock.");
                playerWins(1);
            }
            else if (computerChoice == 2)
            {
                // Both players chose paper, so the game is a draw
                MessageBox.Show("It's a draw!");
            }
            else if (computerChoice == 3)
            {
                // The computer chose scissors, so the user loses
                MessageBox.Show("You lose! Scissors beats paper.");
                computerWins(2);
            }
            StartNewGame(computerChoice);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label5.Text = "Welcome to the Rock, Paper, Scissors game!\n" +
                      "Click a picture to select your choice and\n" +
                      "play against the computer." ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int computerChoice = rnd.Next(1, 4);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplayComputerChoice(computerChoice);
            
            if (computerChoice == 1)
            {
                
                MessageBox.Show("It's a draw!");
                
            }
            else if (computerChoice == 2)
            {
                
                MessageBox.Show("You lose! Paper beats rock.");
                computerWins(2);
            }
            else if (computerChoice == 3)
            {
                
                MessageBox.Show("You win! Rock beats scissors.");
                playerWins(1);
            }
            StartNewGame(computerChoice);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DisplayComputerChoice(computerChoice);
            // Compare the user's choice (scissors) to the computer's choice
            if (computerChoice == 1)
            {
                
                MessageBox.Show("You lose! Rock beats scissors.");
                computerWins(2);

            }
            else if (computerChoice == 2)
            {
                
                MessageBox.Show("You win! Scissors beats paper");
                playerWins(1);
            }
            else if (computerChoice == 3)
            {
                
                MessageBox.Show("It's a draw!");
                
            }
            StartNewGame(computerChoice);
        }
    }
}