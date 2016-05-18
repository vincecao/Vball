namespace VBall
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground = new System.Windows.Forms.Panel();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.replay = new System.Windows.Forms.Label();
            this.showScore = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DownScore = new System.Windows.Forms.Label();
            this.playIcon = new System.Windows.Forms.PictureBox();
            this.pauseIcon = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ReturnToGame = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.returnIcon = new System.Windows.Forms.PictureBox();
            this.MMoving = new System.Windows.Forms.Label();
            this.AMoving = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CloseGame = new System.Windows.Forms.Label();
            this.AboutMe = new System.Windows.Forms.Label();
            this.MultiMode = new System.Windows.Forms.Label();
            this.singleMode = new System.Windows.Forms.Label();
            this.controlLable = new System.Windows.Forms.Label();
            this.racket1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.UpScore = new System.Windows.Forms.Label();
            this.racket2 = new System.Windows.Forms.PictureBox();
            this.Orange = new System.Windows.Forms.PictureBox();
            this.Blue = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.playground.SuspendLayout();
            this.ScorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseIcon)).BeginInit();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnToGame)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playground
            // 
            this.playground.Controls.Add(this.ScorePanel);
            this.playground.Controls.Add(this.DownScore);
            this.playground.Controls.Add(this.playIcon);
            this.playground.Controls.Add(this.pauseIcon);
            this.playground.Controls.Add(this.MenuPanel);
            this.playground.Controls.Add(this.racket1);
            this.playground.Controls.Add(this.label7);
            this.playground.Controls.Add(this.menuLabel);
            this.playground.Controls.Add(this.UpScore);
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.label2);
            this.playground.Controls.Add(this.racket2);
            this.playground.Controls.Add(this.Orange);
            this.playground.Controls.Add(this.Blue);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Margin = new System.Windows.Forms.Padding(2);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1916, 837);
            this.playground.TabIndex = 7;
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.Black;
            this.ScorePanel.Controls.Add(this.label5);
            this.ScorePanel.Controls.Add(this.replay);
            this.ScorePanel.Controls.Add(this.showScore);
            this.ScorePanel.Controls.Add(this.pictureBox1);
            this.ScorePanel.Location = new System.Drawing.Point(235, 542);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(405, 137);
            this.ScorePanel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Intro ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(212, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 58);
            this.label5.TabIndex = 18;
            this.label5.Text = "Share";
            // 
            // replay
            // 
            this.replay.AutoSize = true;
            this.replay.Font = new System.Drawing.Font("Intro ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replay.ForeColor = System.Drawing.Color.White;
            this.replay.Location = new System.Drawing.Point(191, 15);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(214, 58);
            this.replay.TabIndex = 17;
            this.replay.Text = "Replay";
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // showScore
            // 
            this.showScore.BackColor = System.Drawing.Color.Black;
            this.showScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showScore.Font = new System.Drawing.Font("Intro ", 80.24999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showScore.ForeColor = System.Drawing.Color.White;
            this.showScore.Location = new System.Drawing.Point(44, 15);
            this.showScore.Name = "showScore";
            this.showScore.Size = new System.Drawing.Size(162, 129);
            this.showScore.TabIndex = 16;
            this.showScore.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-38, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DownScore
            // 
            this.DownScore.AutoSize = true;
            this.DownScore.BackColor = System.Drawing.Color.DarkTurquoise;
            this.DownScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DownScore.Font = new System.Drawing.Font("Intro ", 26.25F);
            this.DownScore.Location = new System.Drawing.Point(8, 549);
            this.DownScore.Name = "DownScore";
            this.DownScore.Size = new System.Drawing.Size(187, 42);
            this.DownScore.TabIndex = 9;
            this.DownScore.Text = "SCORE: 0";
            // 
            // playIcon
            // 
            this.playIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playIcon.BackColor = System.Drawing.Color.DarkTurquoise;
            this.playIcon.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.playIcon.Image = ((System.Drawing.Image)(resources.GetObject("playIcon.Image")));
            this.playIcon.Location = new System.Drawing.Point(1832, 587);
            this.playIcon.Name = "playIcon";
            this.playIcon.Size = new System.Drawing.Size(60, 60);
            this.playIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playIcon.TabIndex = 14;
            this.playIcon.TabStop = false;
            this.playIcon.UseWaitCursor = true;
            // 
            // pauseIcon
            // 
            this.pauseIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseIcon.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pauseIcon.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pauseIcon.Image = ((System.Drawing.Image)(resources.GetObject("pauseIcon.Image")));
            this.pauseIcon.Location = new System.Drawing.Point(1832, 587);
            this.pauseIcon.Name = "pauseIcon";
            this.pauseIcon.Size = new System.Drawing.Size(60, 60);
            this.pauseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pauseIcon.TabIndex = 14;
            this.pauseIcon.TabStop = false;
            this.pauseIcon.UseWaitCursor = true;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Black;
            this.MenuPanel.Controls.Add(this.ReturnToGame);
            this.MenuPanel.Controls.Add(this.ControlPanel);
            this.MenuPanel.Controls.Add(this.CloseGame);
            this.MenuPanel.Controls.Add(this.AboutMe);
            this.MenuPanel.Controls.Add(this.MultiMode);
            this.MenuPanel.Controls.Add(this.singleMode);
            this.MenuPanel.Controls.Add(this.controlLable);
            this.MenuPanel.Location = new System.Drawing.Point(646, 320);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(615, 512);
            this.MenuPanel.TabIndex = 13;
            // 
            // ReturnToGame
            // 
            this.ReturnToGame.Image = ((System.Drawing.Image)(resources.GetObject("ReturnToGame.Image")));
            this.ReturnToGame.Location = new System.Drawing.Point(19, 12);
            this.ReturnToGame.Name = "ReturnToGame";
            this.ReturnToGame.Size = new System.Drawing.Size(35, 27);
            this.ReturnToGame.TabIndex = 2;
            this.ReturnToGame.TabStop = false;
            this.ReturnToGame.Click += new System.EventHandler(this.ReturnToGame_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.SystemColors.MenuText;
            this.ControlPanel.Controls.Add(this.returnIcon);
            this.ControlPanel.Controls.Add(this.MMoving);
            this.ControlPanel.Controls.Add(this.AMoving);
            this.ControlPanel.Controls.Add(this.label8);
            this.ControlPanel.Location = new System.Drawing.Point(0, 92);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(615, 258);
            this.ControlPanel.TabIndex = 1;
            // 
            // returnIcon
            // 
            this.returnIcon.Image = ((System.Drawing.Image)(resources.GetObject("returnIcon.Image")));
            this.returnIcon.InitialImage = null;
            this.returnIcon.Location = new System.Drawing.Point(19, 13);
            this.returnIcon.Name = "returnIcon";
            this.returnIcon.Size = new System.Drawing.Size(35, 27);
            this.returnIcon.TabIndex = 2;
            this.returnIcon.TabStop = false;
            this.returnIcon.Click += new System.EventHandler(this.returnIcon_Click);
            // 
            // MMoving
            // 
            this.MMoving.AutoSize = true;
            this.MMoving.Font = new System.Drawing.Font("Intro ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMoving.ForeColor = System.Drawing.Color.White;
            this.MMoving.Location = new System.Drawing.Point(68, 172);
            this.MMoving.Name = "MMoving";
            this.MMoving.Size = new System.Drawing.Size(455, 58);
            this.MMoving.TabIndex = 0;
            this.MMoving.Text = "Manual Moving";
            this.MMoving.Click += new System.EventHandler(this.MMoving_Click);
            // 
            // AMoving
            // 
            this.AMoving.AutoSize = true;
            this.AMoving.BackColor = System.Drawing.Color.Transparent;
            this.AMoving.Font = new System.Drawing.Font("Intro ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMoving.ForeColor = System.Drawing.Color.White;
            this.AMoving.Location = new System.Drawing.Point(113, 100);
            this.AMoving.Name = "AMoving";
            this.AMoving.Size = new System.Drawing.Size(382, 58);
            this.AMoving.TabIndex = 0;
            this.AMoving.Text = "AUTO MOVING";
            this.AMoving.Click += new System.EventHandler(this.AMoving_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Intro ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(60, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(488, 58);
            this.label8.TabIndex = 0;
            this.label8.Text = "Control Setting";
            // 
            // CloseGame
            // 
            this.CloseGame.AutoSize = true;
            this.CloseGame.Font = new System.Drawing.Font("Intro ", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseGame.ForeColor = System.Drawing.Color.White;
            this.CloseGame.Location = new System.Drawing.Point(192, 392);
            this.CloseGame.Name = "CloseGame";
            this.CloseGame.Size = new System.Drawing.Size(219, 67);
            this.CloseGame.TabIndex = 0;
            this.CloseGame.Text = "CLOSE";
            this.CloseGame.Click += new System.EventHandler(this.CloseGame_Click);
            // 
            // AboutMe
            // 
            this.AboutMe.AutoSize = true;
            this.AboutMe.Font = new System.Drawing.Font("Intro ", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutMe.ForeColor = System.Drawing.Color.White;
            this.AboutMe.Location = new System.Drawing.Point(192, 311);
            this.AboutMe.Name = "AboutMe";
            this.AboutMe.Size = new System.Drawing.Size(223, 67);
            this.AboutMe.TabIndex = 0;
            this.AboutMe.Text = "ABOUT";
            this.AboutMe.Click += new System.EventHandler(this.AboutMe_Click);
            // 
            // MultiMode
            // 
            this.MultiMode.AutoSize = true;
            this.MultiMode.Font = new System.Drawing.Font("Intro ", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiMode.ForeColor = System.Drawing.Color.White;
            this.MultiMode.Location = new System.Drawing.Point(121, 230);
            this.MultiMode.Name = "MultiMode";
            this.MultiMode.Size = new System.Drawing.Size(386, 67);
            this.MultiMode.TabIndex = 0;
            this.MultiMode.Text = "Multi MODE";
            this.MultiMode.Click += new System.EventHandler(this.MultiMode_Click);
            // 
            // singleMode
            // 
            this.singleMode.AutoSize = true;
            this.singleMode.Font = new System.Drawing.Font("Intro ", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleMode.ForeColor = System.Drawing.Color.White;
            this.singleMode.Location = new System.Drawing.Point(98, 149);
            this.singleMode.Name = "singleMode";
            this.singleMode.Size = new System.Drawing.Size(425, 67);
            this.singleMode.TabIndex = 0;
            this.singleMode.Text = "Single Mode";
            this.singleMode.Click += new System.EventHandler(this.singleMode_Click);
            // 
            // controlLable
            // 
            this.controlLable.AutoSize = true;
            this.controlLable.Font = new System.Drawing.Font("Intro ", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlLable.ForeColor = System.Drawing.Color.White;
            this.controlLable.Location = new System.Drawing.Point(153, 64);
            this.controlLable.Name = "controlLable";
            this.controlLable.Size = new System.Drawing.Size(308, 67);
            this.controlLable.TabIndex = 0;
            this.controlLable.Text = "Control";
            this.controlLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.controlLable.Click += new System.EventHandler(this.controlLable_Click);
            // 
            // racket1
            // 
            this.racket1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.racket1.Location = new System.Drawing.Point(46, 966);
            this.racket1.Margin = new System.Windows.Forms.Padding(2);
            this.racket1.Name = "racket1";
            this.racket1.Size = new System.Drawing.Size(135, 15);
            this.racket1.TabIndex = 6;
            this.racket1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label7.Font = new System.Drawing.Font("Intro ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1637, 542);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 42);
            this.label7.TabIndex = 9;
            this.label7.Text = "F2: Continue";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Orange;
            this.menuLabel.Font = new System.Drawing.Font("Intro ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(1712, 498);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(192, 42);
            this.menuLabel.TabIndex = 9;
            this.menuLabel.Text = "F1: Pause";
            // 
            // UpScore
            // 
            this.UpScore.AutoSize = true;
            this.UpScore.BackColor = System.Drawing.Color.Orange;
            this.UpScore.Font = new System.Drawing.Font("Intro ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpScore.Location = new System.Drawing.Point(0, 0);
            this.UpScore.Name = "UpScore";
            this.UpScore.Size = new System.Drawing.Size(187, 42);
            this.UpScore.TabIndex = 9;
            this.UpScore.Text = "SCORE: 0";
            // 
            // racket2
            // 
            this.racket2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.racket2.Location = new System.Drawing.Point(222, 11);
            this.racket2.Margin = new System.Windows.Forms.Padding(2);
            this.racket2.Name = "racket2";
            this.racket2.Size = new System.Drawing.Size(135, 15);
            this.racket2.TabIndex = 8;
            this.racket2.TabStop = false;
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.Dock = System.Windows.Forms.DockStyle.Top;
            this.Orange.Location = new System.Drawing.Point(0, 0);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(1916, 540);
            this.Orange.TabIndex = 10;
            this.Orange.TabStop = false;
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Blue.Location = new System.Drawing.Point(0, 0);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(1916, 837);
            this.Blue.TabIndex = 11;
            this.Blue.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ball.Location = new System.Drawing.Point(64, 40);
            this.ball.Margin = new System.Windows.Forms.Padding(2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(65, 65);
            this.ball.TabIndex = 5;
            this.ball.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1916, 837);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.playground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "VBALL";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseIcon)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnToGame)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket1;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox racket2;
        private System.Windows.Forms.Label UpScore;
        private System.Windows.Forms.Label DownScore;
        private System.Windows.Forms.PictureBox Orange;
        private System.Windows.Forms.PictureBox Blue;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label AboutMe;
        private System.Windows.Forms.Label MultiMode;
        private System.Windows.Forms.Label singleMode;
        private System.Windows.Forms.Label controlLable;
        private System.Windows.Forms.PictureBox playIcon;
        private System.Windows.Forms.PictureBox pauseIcon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox returnIcon;
        private System.Windows.Forms.Label CloseGame;
        private System.Windows.Forms.Label MMoving;
        private System.Windows.Forms.Label AMoving;
        private System.Windows.Forms.PictureBox ReturnToGame;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label replay;
        private System.Windows.Forms.TextBox showScore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

