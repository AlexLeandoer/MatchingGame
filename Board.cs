using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchingGame
{
    public partial class Board : Form
    {
        int score = 0;
        int count = 0;
        List<Card> cards = new List<Card>();
        List<String> paths = new List<String>();
        List<Card> comparation = new List<Card>();
        public Board()
        {
            InitializeComponent();
            initPaths();
            randomizePaths();
            initCards();
        }

        private void Board_Load(object sender, EventArgs e){
        }

        private void cardClick(object sender, EventArgs e)
        {
            // The timer is only on after two non-matching 
            // icons have been shown to the player, 
            // so ignore any clicks if the timer is running
            if (cardTimer.Enabled == true)
                return;

            PictureBox clicked = (PictureBox) sender;
            Card clicked_card = getClickedCard(clicked);
            if (clicked_card != null)
            {
                if (clicked_card.isFlipped())
                {
                    MessageBox.Show("The Card is already Flipped");
                }
                else {
                    comparation.Add(clicked_card);
                    clicked_card.swapImage();
                    if (comparation.Count == 2) {
                        if (compare())
                        {
                            score += 1;
                            count++;
                            if (count > 1) {
                                score *= count;
                            }
                            comparation.Clear();
                            if (checkWin())
                            {
                                Victory victory_screen = new Victory();
                                victory_screen.Show();
                                MessageBox.Show("Your score: " + score);
                                this.Close();
                            }
                        }
                        else {
                            cardTimer.Start();
                        }
                    }
                }

            }
            else {
                MessageBox.Show("Error Getting the card");
            }

            
        }


        //METODOS DE INICIALIZACION
        private void initPaths() {
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\paches.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\antonidas.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\rhonin.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\malchazar.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\cthun.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\drboom.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\gigante.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\confesora.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\leviatan.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\keltuzar.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\paches.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\antonidas.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\rhonin.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\malchazar.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\cthun.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\drboom.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\gigante.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\confesora.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\leviatan.png");
            paths.Add("F:\\matchingGame\\matchingGame\\assets\\keltuzar.png");
        }

        private void initCards() {
            cards.Add(new Card(pictureBox1, paths[0]));
            cards.Add(new Card(pictureBox2, paths[1]));
            cards.Add(new Card(pictureBox3, paths[2]));
            cards.Add(new Card(pictureBox4, paths[3]));
            cards.Add(new Card(pictureBox5, paths[4]));
            cards.Add(new Card(pictureBox6, paths[5]));
            cards.Add(new Card(pictureBox7, paths[6]));
            cards.Add(new Card(pictureBox8, paths[7]));
            cards.Add(new Card(pictureBox9, paths[8]));
            cards.Add(new Card(pictureBox10, paths[9]));
            cards.Add(new Card(pictureBox11, paths[10]));
            cards.Add(new Card(pictureBox12, paths[11]));
            cards.Add(new Card(pictureBox13, paths[12]));
            cards.Add(new Card(pictureBox14, paths[13]));
            cards.Add(new Card(pictureBox15, paths[14]));
            cards.Add(new Card(pictureBox16, paths[15]));
            cards.Add(new Card(pictureBox17, paths[16]));
            cards.Add(new Card(pictureBox18, paths[17]));
            cards.Add(new Card(pictureBox19, paths[18]));
            cards.Add(new Card(pictureBox20, paths[19]));
        }

        private Card getClickedCard(PictureBox clicked) {

            foreach (Card card in cards)
            {
                if (card.getPicture() == clicked)
                {
                    return card;                    // Devuelve la Card clickada
                }
            }
            return null;                            // En caso de Error Devuelve Null
        }   

        private void randomizePaths()
        {
            Shuffle.shuffle(paths);
        }

        private Boolean compare() {

            if (comparation[0].getPath() == comparation[1].getPath()) {
                return true;
            }
            return false;
        }

        private Boolean checkWin() {
            foreach (Card card in cards) {
                if (!card.isFlipped()) {
                    return false;
                }
            }
            return true;
        }

        private void cardTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            cardTimer.Stop();

            // Hide both icons
            comparation[0].swapImage();
            comparation[1].swapImage();
            count = 0;

            comparation.Clear();
        }

        private void exit_button_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void max_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void min_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1316, 717);
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            Board board = new Board();
            board.Show();
            this.Close();
        }

        private void cardsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
