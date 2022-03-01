using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xo_project
{
    public partial class Form1 : Form
    {
        Boolean checker=true;
        int count;

        void Enable_false()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false; 
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        void score()
        {
            //player X
            // row in widht
            if (btn1.Text == "X" && btn2.Text=="X" && btn3.Text == "X")
            {
                btn1.BackColor = Color.Azure;
                btn2.BackColor = Color.Azure;
                btn3.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ","XO GAME",MessageBoxButtons.OK,MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblX.Text = Convert.ToString(count+1);
                Enable_false();
            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = Color.Azure;
                btn5.BackColor = Color.Azure;
                btn6.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblX.Text = Convert.ToString(count+1);
                Enable_false();
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.Azure;
                btn8.BackColor = Color.Azure;
                btn9.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblX.Text = Convert.ToString(count+1);
                Enable_false();
            }

            //row in hight
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.Azure;
                btn4.BackColor = Color.Azure;
                btn7.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblX.Text = Convert.ToString(count+1);
                Enable_false();
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.Azure;
                btn5.BackColor = Color.Azure;
                btn8.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblX.Text = Convert.ToString(count+1);
                Enable_false();
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = Color.Azure;
                btn6.BackColor = Color.Azure;
                btn9.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblX.Text = Convert.ToString(count+1);
                Enable_false();
            }
            
            //row in crosse
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.Azure;
                btn5.BackColor = Color.Azure;
                btn9.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblX.Text = Convert.ToString(count+1);
                Enable_false();
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = Color.Azure;
                btn5.BackColor = Color.Azure;
                btn7.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblX.Text = Convert.ToString(count+1);
                Enable_false();
            }
            //end of player X

            //player O
            //   row in widht
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = Color.Azure;
                btn2.BackColor = Color.Azure;
                btn3.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblO.Text = Convert.ToString(count + 1);
                Enable_false();
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = Color.Azure;
                btn5.BackColor = Color.Azure;
                btn6.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblO.Text = Convert.ToString(count + 1);
                Enable_false();
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = Color.Azure;
                btn8.BackColor = Color.Azure;
                btn9.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblO.Text = Convert.ToString(count + 1);
                Enable_false();
            }

            // row in hight
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = Color.Azure;
                btn4.BackColor = Color.Azure;
                btn7.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblO.Text = Convert.ToString(count + 1);
                Enable_false();
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = Color.Azure;
                btn5.BackColor = Color.Azure;
                btn8.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblO.Text = Convert.ToString(count + 1);
                Enable_false();
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = Color.Azure;
                btn6.BackColor = Color.Azure;
                btn9.BackColor = Color.Azure;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblO.Text = Convert.ToString(count + 1);
                Enable_false();
            }

            //row in ceosse
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = Color.Azure;
                btn5.BackColor = Color.Azure;
                btn9.BackColor = Color.Black;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblO.Text = Convert.ToString(count + 1);
                Enable_false();
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = Color.Black;
                btn5.BackColor = Color.Black;
                btn7.BackColor = Color.Black;
                MessageBox.Show(" The Winner Is Player X ", "XO GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = int.Parse(lblX.Text);
                lblO.Text = Convert.ToString(count + 1);
                Enable_false();
            }
            //end player O
        }

       void new_game()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            //color
            btn1.BackColor = Color.Transparent;
            btn2.BackColor = Color.Transparent;
            btn3.BackColor = Color.Transparent;
            btn4.BackColor = Color.Transparent;
            btn5.BackColor = Color.Transparent;
            btn6.BackColor = Color.Transparent;
            btn7.BackColor = Color.Transparent;
            btn8.BackColor = Color.Transparent;
            btn9.BackColor = Color.Transparent;
            //text
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                btn4.Text = "X";
                checker = false;
            }
            else
            {
                btn4.Text = "O";
                checker = true;
            }
            score();
            btn4.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                btn7.Text = "X";
                checker = false;
            }
            else
            {
                btn7.Text = "O";
                checker = true;
            }
            score();
            btn7.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(checker == true)
            {
                btn1.Text = "X";
                checker = false;
            }else
            {
                btn1.Text = "O";
                checker = true;
            }
            score();
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                btn2.Text = "X";
                checker = false;
            }
            else
            {
                btn2.Text = "O";
                checker = true;
            }
            score();
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                btn3.Text = "X";
                checker = false;
            }
            else
            {
                btn3.Text = "O";
                checker = true;
            }
            score();
            btn3.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                btn5.Text = "X";
                checker = false;
            }
            else
            {
                btn5.Text = "O";
                checker = true;
            }
            score();
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                btn6.Text = "X";
                checker = false;
            }
            else
            {
                btn6.Text = "O";
                checker = true;
            }
            score();
            btn6.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                btn8.Text = "X";
                checker = false;
            }
            else
            {
                btn8.Text = "O";
                checker = true;
            }
            score();
            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (checker == true)
            {
                btn9.Text = "X";
                checker = false;
            }
            else
            {
                btn9.Text = "O";
                checker = true;
            }
            score();
            btn9.Enabled = false;
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            try { 
            new_game();
            lblX.Text = "0";
            lblO.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "XO game",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            try { 
            new_game();
            newgame.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "XO game",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
