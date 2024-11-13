
namespace TicTacToe
{
    partial class _3x3View
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
            components = new System.ComponentModel.Container();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            label2 = new Label();
            button10 = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button3.Location = new Point(291, 62);
            button3.Name = "button3";
            button3.Size = new Size(122, 111);
            button3.TabIndex = 7;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += playerclickbutton;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button2.Location = new Point(163, 62);
            button2.Name = "button2";
            button2.Size = new Size(122, 111);
            button2.TabIndex = 6;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += playerclickbutton;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button1.Location = new Point(35, 62);
            button1.Name = "button1";
            button1.Size = new Size(122, 111);
            button1.TabIndex = 5;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += playerclickbutton;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button4.Location = new Point(291, 179);
            button4.Name = "button4";
            button4.Size = new Size(122, 111);
            button4.TabIndex = 10;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += playerclickbutton;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button5.Location = new Point(163, 179);
            button5.Name = "button5";
            button5.Size = new Size(122, 111);
            button5.TabIndex = 9;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += playerclickbutton;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button6.Location = new Point(35, 179);
            button6.Name = "button6";
            button6.Size = new Size(122, 111);
            button6.TabIndex = 8;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += playerclickbutton;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button7.Location = new Point(291, 296);
            button7.Name = "button7";
            button7.Size = new Size(122, 111);
            button7.TabIndex = 13;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += playerclickbutton;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button8.Location = new Point(163, 296);
            button8.Name = "button8";
            button8.Size = new Size(122, 111);
            button8.TabIndex = 12;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += playerclickbutton;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button9.Location = new Point(35, 296);
            button9.Name = "button9";
            button9.Size = new Size(122, 111);
            button9.TabIndex = 11;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += playerclickbutton;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 14;
            label1.Text = "Player Wins:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(356, 18);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 15;
            label2.Text = "Pc Wins:";
            // 
            // button10
            // 
            button10.BackColor = Color.Yellow;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button10.Location = new Point(177, 422);
            button10.Name = "button10";
            button10.Size = new Size(95, 27);
            button10.TabIndex = 16;
            button10.Text = "Restart Game";
            button10.UseVisualStyleBackColor = false;
            button10.Click += restartgame;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 500;
            gameTimer.Tick += CPUtasima;
            // 
            // _3x3View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(button10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "_3x3View";
            Text = "Form1";
            FormClosed += _3x3View_FormClosed;
            ResumeLayout(false);
        }


        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label label2;
        private Button button10;
        private System.Windows.Forms.Timer gameTimer;
    }
}
