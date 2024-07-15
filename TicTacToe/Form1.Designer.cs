namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            newgame = new Button();
            reset = new Button();
            exit = new Button();
            label1 = new Label();
            label2 = new Label();
            labely = new Label();
            labelx = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(155, 133);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(184, 12);
            button2.Name = "button2";
            button2.Size = new Size(155, 133);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(355, 12);
            button3.Name = "button3";
            button3.Size = new Size(155, 133);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(12, 151);
            button4.Name = "button4";
            button4.Size = new Size(155, 133);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            button5.Location = new Point(184, 151);
            button5.Name = "button5";
            button5.Size = new Size(155, 133);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            button6.Location = new Point(355, 151);
            button6.Name = "button6";
            button6.Size = new Size(155, 133);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            button7.Location = new Point(12, 290);
            button7.Name = "button7";
            button7.Size = new Size(155, 133);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            button8.Location = new Point(184, 290);
            button8.Name = "button8";
            button8.Size = new Size(155, 133);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            button9.Location = new Point(355, 290);
            button9.Name = "button9";
            button9.Size = new Size(155, 133);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // newgame
            // 
            newgame.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            newgame.Location = new Point(553, 246);
            newgame.Name = "newgame";
            newgame.Size = new Size(285, 53);
            newgame.TabIndex = 9;
            newgame.Text = "New Game";
            newgame.UseVisualStyleBackColor = true;
            newgame.Click += newgame_Click;
            // 
            // reset
            // 
            reset.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            reset.Location = new Point(553, 305);
            reset.Name = "reset";
            reset.Size = new Size(285, 53);
            reset.TabIndex = 10;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            exit.Location = new Point(553, 364);
            exit.Name = "exit";
            exit.Size = new Size(285, 53);
            exit.TabIndex = 11;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(553, 41);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 12;
            label1.Text = "PLAYER X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(553, 85);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 13;
            label2.Text = "PLAYER O:";
            // 
            // labely
            // 
            labely.AutoSize = true;
            labely.BackColor = Color.Silver;
            labely.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labely.Location = new Point(723, 82);
            labely.Name = "labely";
            labely.Size = new Size(30, 35);
            labely.TabIndex = 15;
            labely.Text = "0";
            // 
            // labelx
            // 
            labelx.AutoSize = true;
            labelx.BackColor = Color.Silver;
            labelx.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelx.Location = new Point(723, 41);
            labelx.Name = "labelx";
            labelx.Size = new Size(28, 32);
            labelx.TabIndex = 14;
            labelx.Text = "0";
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(846, 430);
            Controls.Add(labely);
            Controls.Add(labelx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(reset);
            Controls.Add(newgame);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TicTacToe";
            Text = "X-0-X";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button newgame;
        private Button reset;
        private Button exit;
        private Label label1;
        private Label label2;
        private Label labely;
        private Label labelx;
    }
}
