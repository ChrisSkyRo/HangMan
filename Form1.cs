using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Spanzuratoare
{
    public partial class Form1 : Form
    {
        private int lives = 6;
        private string sentence = "C a l i n   e s t e   o r f a n";
        private bool[] fr = new bool[26];

        private void DrawHangMan()
        {
            Pen thick = new Pen(Color.Black, 5);
            Pen thin = new Pen(Color.Black, 2);
            Graphics draw = CreateGraphics();

            if (lives == 6)
            {
                draw.DrawLine(thick, 350, 50, 350, 200);
                draw.DrawLine(thick, 325, 200, 375, 200);
                draw.DrawLine(thick, 350, 50, 400, 50);
                draw.DrawLine(thin, 400, 50, 400, 100);
            }
            else if(lives == 5)
            {
                draw.DrawEllipse(thin, 390, 100, 20, 20);
            }
            else if(lives == 4)
            {
                draw.DrawLine(thick, 400, 120, 400, 150);
            }
            else if (lives == 3)
            {
                draw.DrawArc(thin, 375, 125, 50, 50, 270, 90);
            }
            else if (lives == 2)
            {
                draw.DrawArc(thin, 375, 125, 50, 50, 270, -90);
            }
            else if (lives == 1)
            {
                draw.DrawLine(thin, 400, 145, 375, 175);
            }
            else
            {
                draw.DrawLine(thin, 400, 145, 425, 175);
                if (MessageBox.Show("Ai pierdut! Renunti?", "Gheim ovar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    Form1 q = new Form1();
                    this.Hide();
                    q.Show();
                }
            }
        }

        private bool Solve(char c)
        {
            bool ok = false;
            char[] newText = SentenceToGuess.Text.ToCharArray();
            for (int i = 0; i < sentence.Length; i++)
                if (sentence[i] == c || sentence[i] == (char)(c + 32))
                { 
                    newText[i] = sentence[i];
                    ok = true;
                }
            SentenceToGuess.Text = new string(newText);
            if (sentence == SentenceToGuess.Text)
            {
                MessageBox.Show("weiner, weiner, chiken dinner");
                PickLetter.Enabled = false;
            }
            return ok;
        }

        public Form1()
        {
            InitializeComponent();
            SentenceToGuess.Text = "_ _ _ _ _   _ _ _ _   _ _ _ _ _";
        }

        private void PickLetter_Click(object sender, EventArgs e)
        {
            if (LetterInput.Text.Length == 0)
            {
                MessageBox.Show("Alege o litera!");
            }
            else if (LetterInput.Text.Length > 1)
            {
                MessageBox.Show("Alege o SINGURA litera!");
                LetterInput.Text = "";
            }
            else
            {
                char c = LetterInput.Text[0];
                if (c >= 'a' && c <= 'z')
                    c -= (char)(32);
                if (c >= 'A' && c <= 'Z')
                {
                    if (!fr[c - 'A'])
                    {
                        if (!Solve(c))
                        {
                            lives--;
                            DrawHangMan();
                        }
                        GuessedLetters.Text += c + ", ";
                        LetterInput.Text = "";
                        fr[c - 'A'] = true;
                    }
                    else
                    {
                        MessageBox.Show("Ai ghicit litera asta deja!");
                        LetterInput.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Litere, orfanule, litere!");
                    LetterInput.Text = "";
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(lives == 6)
                DrawHangMan();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
