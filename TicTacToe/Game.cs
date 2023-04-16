namespace TicTacToe
{
    public partial class Game : Form
    {
        private char NextPlayer { get; set; }
        private int Round { get; set; }
        public Game()
        {
            InitializeComponent();
            ResetGame();
        }

        private void ResetGame()
        {
            label1.Text = "  ";
            label2.Text = "  ";
            label3.Text = "  ";
            label4.Text = "  ";
            label5.Text = "  ";
            label6.Text = "  ";
            label7.Text = "  ";
            label8.Text = "  ";
            label9.Text = "  ";
            NextPlayer = 'X';
            Round = 0;
        }

        private void Play(Label label)
        {
            if (label.Text != "  ") return;
            label.Text = NextPlayer.ToString();
            NextPlayer = NextPlayer == 'X' ? 'O' : 'X';
            Round++;
            IsGameOver();
        }

        private void IsGameOver()
        {
            char lastPlayer = NextPlayer == 'X' ? 'O' : 'X';
            if (label1.Text == label2.Text && label2.Text == label3.Text && label3.Text != "  ") EndGame(lastPlayer);
            else if (label4.Text == label5.Text && label5.Text == label6.Text && label6.Text != "  ") EndGame(lastPlayer);
            else if (label7.Text == label8.Text && label8.Text == label9.Text && label9.Text != "  ") EndGame(lastPlayer);
            else if (label1.Text == label4.Text && label4.Text == label7.Text && label7.Text != "  ") EndGame(lastPlayer);
            else if (label2.Text == label5.Text && label5.Text == label8.Text && label8.Text != "  ") EndGame(lastPlayer);
            else if (label3.Text == label6.Text && label6.Text == label9.Text && label9.Text != "  ") EndGame(lastPlayer);
            else if (label1.Text == label5.Text && label5.Text == label9.Text && label9.Text != "  ") EndGame(lastPlayer);
            else if (label3.Text == label5.Text && label5.Text == label7.Text && label7.Text != "  ") EndGame(lastPlayer);
            else if (Round == 9) EndGame('D');
        }

        private void EndGame(char winner)
        {
            string message = $"GAME IS OVER! WINNER IS: {winner}";
            if (winner == 'D') message = $"GAME IS OVER! THAT WAS A DRAW!";
            MessageBox.Show(message);
            ResetGame();
        }

        private void Label0_Click(object sender, EventArgs e) => Play(label1);
        private void Label1_Click(object sender, EventArgs e) => Play(label2);
        private void Label2_Click(object sender, EventArgs e) => Play(label3);
        private void Label3_Click(object sender, EventArgs e) => Play(label4);
        private void Label4_Click(object sender, EventArgs e) => Play(label5);
        private void Label5_Click(object sender, EventArgs e) => Play(label6);
        private void Label6_Click(object sender, EventArgs e) => Play(label7);
        private void Label7_Click(object sender, EventArgs e) => Play(label8);
        private void Label8_Click(object sender, EventArgs e) => Play(label9);

    }
}