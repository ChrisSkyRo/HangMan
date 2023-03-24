namespace Spanzuratoare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SentenceToGuess = new System.Windows.Forms.Label();
            this.GuessedLetters = new System.Windows.Forms.Label();
            this.PickLetter = new System.Windows.Forms.Button();
            this.LetterInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SentenceToGuess
            // 
            this.SentenceToGuess.AutoSize = true;
            this.SentenceToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentenceToGuess.Location = new System.Drawing.Point(12, 36);
            this.SentenceToGuess.Name = "SentenceToGuess";
            this.SentenceToGuess.Size = new System.Drawing.Size(70, 25);
            this.SentenceToGuess.TabIndex = 0;
            this.SentenceToGuess.Text = "label1";
            // 
            // GuessedLetters
            // 
            this.GuessedLetters.AutoSize = true;
            this.GuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessedLetters.ForeColor = System.Drawing.Color.Maroon;
            this.GuessedLetters.Location = new System.Drawing.Point(12, 185);
            this.GuessedLetters.Name = "GuessedLetters";
            this.GuessedLetters.Size = new System.Drawing.Size(99, 20);
            this.GuessedLetters.TabIndex = 1;
            this.GuessedLetters.Text = "Litere alese: ";
            // 
            // PickLetter
            // 
            this.PickLetter.Location = new System.Drawing.Point(139, 128);
            this.PickLetter.Name = "PickLetter";
            this.PickLetter.Size = new System.Drawing.Size(69, 23);
            this.PickLetter.TabIndex = 2;
            this.PickLetter.Text = "Alege litera";
            this.PickLetter.UseVisualStyleBackColor = true;
            this.PickLetter.Click += new System.EventHandler(this.PickLetter_Click);
            // 
            // LetterInput
            // 
            this.LetterInput.Location = new System.Drawing.Point(16, 128);
            this.LetterInput.Name = "LetterInput";
            this.LetterInput.Size = new System.Drawing.Size(100, 20);
            this.LetterInput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 312);
            this.Controls.Add(this.LetterInput);
            this.Controls.Add(this.PickLetter);
            this.Controls.Add(this.GuessedLetters);
            this.Controls.Add(this.SentenceToGuess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SentenceToGuess;
        private System.Windows.Forms.Label GuessedLetters;
        private System.Windows.Forms.Button PickLetter;
        private System.Windows.Forms.TextBox LetterInput;
    }
}

