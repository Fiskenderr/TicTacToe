namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        Boolean check = false;
        int plusone;
        int count = 0;

        public void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        public void Score()
        {
            if (count != 9)
            {
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Player X won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labelx.Text);
                    labelx.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Player O won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labely.Text);
                    labely.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }

                if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("Player X won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labelx.Text);
                    labelx.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("Player O won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labely.Text);
                    labely.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }

                if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Player X won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labelx.Text);
                    labelx.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Player O won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labely.Text);
                    labely.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }

                if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {

                    MessageBox.Show("Player X won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labelx.Text);
                    labelx.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Player O won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labely.Text);
                    labely.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }

                if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {

                    MessageBox.Show("Player X won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labelx.Text);
                    labelx.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("Player O won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labely.Text);
                    labely.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }

                if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {

                    MessageBox.Show("Player X won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labelx.Text);
                    labelx.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("Player O won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labely.Text);
                    labely.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }

                if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {

                    MessageBox.Show("Player X won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labelx.Text);
                    labelx.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("Player O won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labely.Text);
                    labely.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }

                if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {

                    MessageBox.Show("Player X won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labelx.Text);
                    labelx.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Player O won the game!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    plusone = int.Parse(labely.Text);
                    labely.Text = Convert.ToString(plusone + 1);
                    Enable_False();
                }
            }
            else
            {
                MessageBox.Show("There is no winner!", "WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button1.Text = "X";
                check = true;
                count++;
            }
            else
            {
                button1.Text = "O";
                check = false;
                count++;
            }
            Score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button2.Text = "X";
                check = true;
                count++;
            }
            else
            {
                button2.Text = "O";
                check = false;
                count++;
            }
            Score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button3.Text = "X";
                check = true;
                count++;
            }
            else
            {
                button3.Text = "O";
                check = false;
                count++;
            }
            Score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button4.Text = "X";
                check = true;
                count++;
            }
            else
            {
                button4.Text = "O";
                check = false;
                count++;
            }
            Score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button5.Text = "X";
                check = true;
                count++;
            }
            else
            {
                button5.Text = "O";
                check = false;
                count++;
            }
            Score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button6.Text = "X";
                check = true;
                count++;
            }
            else
            {
                button6.Text = "O";
                check = false;
                count++;
            }
            Score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button7.Text = "X";
                check = true;
                count++;
            }
            else
            {
                button7.Text = "O";
                check = false;
                count++;
            }
            Score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button8.Text = "X";
                check = true;
                count++;
            }
            else
            {
                button8.Text = "O";
                check = false;
                count++;
            }
            Score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                button9.Text = "X";
                check = true;
                count++;
            }
            else
            {
                button9.Text = "O";
                check = false;
                count++;
            }
            Score();
            button9.Enabled = false;
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            labelx.Text = "0";
            labely.Text = "0";

            count = 0;

            check = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            count = 0;

            check = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
