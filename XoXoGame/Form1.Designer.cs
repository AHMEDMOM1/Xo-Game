namespace XoXoGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.winner = new System.Windows.Forms.Label();
            this.lblProg = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.pB2 = new System.Windows.Forms.PictureBox();
            this.pB3 = new System.Windows.Forms.PictureBox();
            this.pB4 = new System.Windows.Forms.PictureBox();
            this.pB5 = new System.Windows.Forms.PictureBox();
            this.pB6 = new System.Windows.Forms.PictureBox();
            this.pB7 = new System.Windows.Forms.PictureBox();
            this.pB8 = new System.Windows.Forms.PictureBox();
            this.pB9 = new System.Windows.Forms.PictureBox();
            this.labelOfGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(25, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn";
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Font = new System.Drawing.Font("Tahoma", 22F);
            this.player.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.player.Location = new System.Drawing.Point(25, 170);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(122, 36);
            this.player.TabIndex = 1;
            this.player.Text = "Player 1";
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.winner.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner.ForeColor = System.Drawing.Color.Yellow;
            this.winner.Location = new System.Drawing.Point(24, 231);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(135, 36);
            this.winner.TabIndex = 2;
            this.winner.Text = "Winner";
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProg.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProg.ForeColor = System.Drawing.Color.Lime;
            this.lblProg.Location = new System.Drawing.Point(23, 289);
            this.lblProg.Margin = new System.Windows.Forms.Padding(0);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(204, 41);
            this.lblProg.TabIndex = 3;
            this.lblProg.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRestart.Location = new System.Drawing.Point(31, 351);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(171, 42);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Tahoma", 26F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(313, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tic-Tac-Toe Game";
            // 
            // pB1
            // 
            this.pB1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pB1.Image = global::XoXoGame.Properties.Resources.question_mark_96;
            this.pB1.Location = new System.Drawing.Point(308, 99);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(83, 65);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB1.TabIndex = 6;
            this.pB1.TabStop = false;
            this.pB1.Tag = "?";
            // 
            // pB2
            // 
            this.pB2.Image = global::XoXoGame.Properties.Resources.question_mark_96;
            this.pB2.Location = new System.Drawing.Point(413, 99);
            this.pB2.Name = "pB2";
            this.pB2.Size = new System.Drawing.Size(90, 65);
            this.pB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB2.TabIndex = 7;
            this.pB2.TabStop = false;
            this.pB2.Tag = "?";
            // 
            // pB3
            // 
            this.pB3.Image = global::XoXoGame.Properties.Resources.question_mark_96;
            this.pB3.Location = new System.Drawing.Point(520, 99);
            this.pB3.Name = "pB3";
            this.pB3.Size = new System.Drawing.Size(91, 65);
            this.pB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB3.TabIndex = 8;
            this.pB3.TabStop = false;
            this.pB3.Tag = "?";
            // 
            // pB4
            // 
            this.pB4.BackColor = System.Drawing.SystemColors.ControlText;
            this.pB4.Image = global::XoXoGame.Properties.Resources.question_mark_96;
            this.pB4.Location = new System.Drawing.Point(308, 202);
            this.pB4.Name = "pB4";
            this.pB4.Size = new System.Drawing.Size(83, 65);
            this.pB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB4.TabIndex = 9;
            this.pB4.TabStop = false;
            this.pB4.Tag = "?";
            // 
            // pB5
            // 
            this.pB5.Image = global::XoXoGame.Properties.Resources.question_mark_96;
            this.pB5.Location = new System.Drawing.Point(413, 202);
            this.pB5.Name = "pB5";
            this.pB5.Size = new System.Drawing.Size(90, 65);
            this.pB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB5.TabIndex = 10;
            this.pB5.TabStop = false;
            this.pB5.Tag = "?";
            // 
            // pB6
            // 
            this.pB6.Image = global::XoXoGame.Properties.Resources.question_mark_96;
            this.pB6.Location = new System.Drawing.Point(520, 202);
            this.pB6.Name = "pB6";
            this.pB6.Size = new System.Drawing.Size(91, 65);
            this.pB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB6.TabIndex = 11;
            this.pB6.TabStop = false;
            this.pB6.Tag = "?";
            // 
            // pB7
            // 
            this.pB7.BackColor = System.Drawing.SystemColors.ControlText;
            this.pB7.Image = global::XoXoGame.Properties.Resources.question_mark_96;
            this.pB7.Location = new System.Drawing.Point(308, 315);
            this.pB7.Name = "pB7";
            this.pB7.Size = new System.Drawing.Size(83, 65);
            this.pB7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB7.TabIndex = 12;
            this.pB7.TabStop = false;
            this.pB7.Tag = "?";
            // 
            // pB8
            // 
            this.pB8.Image = global::XoXoGame.Properties.Resources.question_mark_96;
            this.pB8.Location = new System.Drawing.Point(413, 315);
            this.pB8.Name = "pB8";
            this.pB8.Size = new System.Drawing.Size(90, 65);
            this.pB8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB8.TabIndex = 13;
            this.pB8.TabStop = false;
            this.pB8.Tag = "?";
            // 
            // pB9
            // 
            this.pB9.Image = global::XoXoGame.Properties.Resources.question_mark_96;
            this.pB9.Location = new System.Drawing.Point(520, 315);
            this.pB9.Name = "pB9";
            this.pB9.Size = new System.Drawing.Size(91, 65);
            this.pB9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB9.TabIndex = 14;
            this.pB9.TabStop = false;
            this.pB9.Tag = "?";
            // 
            // labelOfGame
            // 
            this.labelOfGame.AutoSize = true;
            this.labelOfGame.Location = new System.Drawing.Point(292, 62);
            this.labelOfGame.Name = "labelOfGame";
            this.labelOfGame.Size = new System.Drawing.Size(35, 13);
            this.labelOfGame.TabIndex = 15;
            this.labelOfGame.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOfGame);
            this.Controls.Add(this.pB9);
            this.Controls.Add(this.pB8);
            this.Controls.Add(this.pB7);
            this.Controls.Add(this.pB6);
            this.Controls.Add(this.pB5);
            this.Controls.Add(this.pB4);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.PictureBox pB2;
        private System.Windows.Forms.PictureBox pB3;
        private System.Windows.Forms.PictureBox pB4;
        private System.Windows.Forms.PictureBox pB5;
        private System.Windows.Forms.PictureBox pB6;
        private System.Windows.Forms.PictureBox pB7;
        private System.Windows.Forms.PictureBox pB8;
        private System.Windows.Forms.PictureBox pB9;
        private System.Windows.Forms.Label labelOfGame;
    }
}

