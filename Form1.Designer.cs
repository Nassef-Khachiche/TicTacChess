
namespace TicTacChess
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
            this.gbxPieces = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.cbxArduino = new System.Windows.Forms.CheckBox();
            this.tmrArduino = new System.Windows.Forms.Timer(this.components);
            this.pcbWizard = new System.Windows.Forms.PictureBox();
            this.pcbKing = new System.Windows.Forms.PictureBox();
            this.pcbQueen = new System.Windows.Forms.PictureBox();
            this.pcbRook = new System.Windows.Forms.PictureBox();
            this.pcbKnight = new System.Windows.Forms.PictureBox();
            this.gbxBoard = new System.Windows.Forms.GroupBox();
            this.pcbNine = new System.Windows.Forms.PictureBox();
            this.pcbEight = new System.Windows.Forms.PictureBox();
            this.pcbSeven = new System.Windows.Forms.PictureBox();
            this.pcbSix = new System.Windows.Forms.PictureBox();
            this.pcbFive = new System.Windows.Forms.PictureBox();
            this.pcbFour = new System.Windows.Forms.PictureBox();
            this.pcbThree = new System.Windows.Forms.PictureBox();
            this.pcbTwo = new System.Windows.Forms.PictureBox();
            this.pcbOne = new System.Windows.Forms.PictureBox();
            this.gbxPieces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWizard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKnight)).BeginInit();
            this.gbxBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSeven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOne)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPieces
            // 
            this.gbxPieces.Controls.Add(this.pcbWizard);
            this.gbxPieces.Controls.Add(this.pcbKing);
            this.gbxPieces.Controls.Add(this.pcbQueen);
            this.gbxPieces.Controls.Add(this.pcbRook);
            this.gbxPieces.Controls.Add(this.pcbKnight);
            this.gbxPieces.Location = new System.Drawing.Point(485, 87);
            this.gbxPieces.Name = "gbxPieces";
            this.gbxPieces.Size = new System.Drawing.Size(248, 371);
            this.gbxPieces.TabIndex = 1;
            this.gbxPieces.TabStop = false;
            this.gbxPieces.Text = "Pieces";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.Location = new System.Drawing.Point(161, 52);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(197, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Start game, Setup pieces";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRestart.Location = new System.Drawing.Point(12, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(129, 60);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(485, 51);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(65, 21);
            this.rdbWhite.TabIndex = 4;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            this.rdbWhite.CheckedChanged += new System.EventHandler(this.rdbWhite_CheckedChanged);
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(645, 51);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(63, 21);
            this.rdbBlack.TabIndex = 5;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            this.rdbBlack.CheckedChanged += new System.EventHandler(this.rdbBlack_CheckedChanged);
            // 
            // cbxArduino
            // 
            this.cbxArduino.AutoSize = true;
            this.cbxArduino.Location = new System.Drawing.Point(165, 25);
            this.cbxArduino.Name = "cbxArduino";
            this.cbxArduino.Size = new System.Drawing.Size(79, 21);
            this.cbxArduino.TabIndex = 6;
            this.cbxArduino.Text = "Arduino";
            this.cbxArduino.UseVisualStyleBackColor = true;
            this.cbxArduino.CheckedChanged += new System.EventHandler(this.cbxArduino_CheckedChanged);
            // 
            // tmrArduino
            // 
            this.tmrArduino.Tick += new System.EventHandler(this.tmrArduino_Tick);
            // 
            // pcbWizard
            // 
            this.pcbWizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbWizard.Image = global::TicTacChess.Properties.Resources.white_wizard;
            this.pcbWizard.Location = new System.Drawing.Point(124, 142);
            this.pcbWizard.Name = "pcbWizard";
            this.pcbWizard.Size = new System.Drawing.Size(99, 99);
            this.pcbWizard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbWizard.TabIndex = 13;
            this.pcbWizard.TabStop = false;
            this.pcbWizard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbAllPieces_MouseDown);
            // 
            // pcbKing
            // 
            this.pcbKing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbKing.Image = global::TicTacChess.Properties.Resources.white_king;
            this.pcbKing.Location = new System.Drawing.Point(124, 22);
            this.pcbKing.Name = "pcbKing";
            this.pcbKing.Size = new System.Drawing.Size(99, 99);
            this.pcbKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbKing.TabIndex = 12;
            this.pcbKing.TabStop = false;
            this.pcbKing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbAllPieces_MouseDown);
            // 
            // pcbQueen
            // 
            this.pcbQueen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbQueen.Image = ((System.Drawing.Image)(resources.GetObject("pcbQueen.Image")));
            this.pcbQueen.Location = new System.Drawing.Point(71, 256);
            this.pcbQueen.Name = "pcbQueen";
            this.pcbQueen.Size = new System.Drawing.Size(99, 99);
            this.pcbQueen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbQueen.TabIndex = 11;
            this.pcbQueen.TabStop = false;
            this.pcbQueen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbAllPieces_MouseDown);
            // 
            // pcbRook
            // 
            this.pcbRook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbRook.Image = ((System.Drawing.Image)(resources.GetObject("pcbRook.Image")));
            this.pcbRook.Location = new System.Drawing.Point(19, 142);
            this.pcbRook.Name = "pcbRook";
            this.pcbRook.Size = new System.Drawing.Size(99, 99);
            this.pcbRook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbRook.TabIndex = 10;
            this.pcbRook.TabStop = false;
            this.pcbRook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbAllPieces_MouseDown);
            // 
            // pcbKnight
            // 
            this.pcbKnight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbKnight.Image = ((System.Drawing.Image)(resources.GetObject("pcbKnight.Image")));
            this.pcbKnight.Location = new System.Drawing.Point(19, 22);
            this.pcbKnight.Name = "pcbKnight";
            this.pcbKnight.Size = new System.Drawing.Size(99, 99);
            this.pcbKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbKnight.TabIndex = 9;
            this.pcbKnight.TabStop = false;
            this.pcbKnight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbAllPieces_MouseDown);
            // 
            // gbxBoard
            // 
            this.gbxBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbxBoard.BackgroundImage")));
            this.gbxBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxBoard.Controls.Add(this.pcbNine);
            this.gbxBoard.Controls.Add(this.pcbEight);
            this.gbxBoard.Controls.Add(this.pcbSeven);
            this.gbxBoard.Controls.Add(this.pcbSix);
            this.gbxBoard.Controls.Add(this.pcbFive);
            this.gbxBoard.Controls.Add(this.pcbFour);
            this.gbxBoard.Controls.Add(this.pcbThree);
            this.gbxBoard.Controls.Add(this.pcbTwo);
            this.gbxBoard.Controls.Add(this.pcbOne);
            this.gbxBoard.Location = new System.Drawing.Point(12, 87);
            this.gbxBoard.Name = "gbxBoard";
            this.gbxBoard.Size = new System.Drawing.Size(454, 371);
            this.gbxBoard.TabIndex = 0;
            this.gbxBoard.TabStop = false;
            this.gbxBoard.Text = "Board";
            // 
            // pcbNine
            // 
            this.pcbNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbNine.Location = new System.Drawing.Point(304, 256);
            this.pcbNine.Name = "pcbNine";
            this.pcbNine.Size = new System.Drawing.Size(106, 99);
            this.pcbNine.TabIndex = 8;
            this.pcbNine.TabStop = false;
            this.pcbNine.Tag = "33";
            this.pcbNine.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbNine.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragEnter);
            this.pcbNine.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            this.pcbNine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbBoard_MouseDown);
            // 
            // pcbEight
            // 
            this.pcbEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbEight.Location = new System.Drawing.Point(184, 256);
            this.pcbEight.Name = "pcbEight";
            this.pcbEight.Size = new System.Drawing.Size(99, 99);
            this.pcbEight.TabIndex = 7;
            this.pcbEight.TabStop = false;
            this.pcbEight.Tag = "23";
            this.pcbEight.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbEight.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragEnter);
            this.pcbEight.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            this.pcbEight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbBoard_MouseDown);
            // 
            // pcbSeven
            // 
            this.pcbSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbSeven.Location = new System.Drawing.Point(55, 256);
            this.pcbSeven.Name = "pcbSeven";
            this.pcbSeven.Size = new System.Drawing.Size(108, 99);
            this.pcbSeven.TabIndex = 6;
            this.pcbSeven.TabStop = false;
            this.pcbSeven.Tag = "13";
            this.pcbSeven.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbSeven.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragEnter);
            this.pcbSeven.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            this.pcbSeven.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbBoard_MouseDown);
            // 
            // pcbSix
            // 
            this.pcbSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbSix.Location = new System.Drawing.Point(304, 142);
            this.pcbSix.Name = "pcbSix";
            this.pcbSix.Size = new System.Drawing.Size(106, 94);
            this.pcbSix.TabIndex = 5;
            this.pcbSix.TabStop = false;
            this.pcbSix.Tag = "32";
            this.pcbSix.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbSix.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragEnter);
            this.pcbSix.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            this.pcbSix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbBoard_MouseDown);
            // 
            // pcbFive
            // 
            this.pcbFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbFive.Location = new System.Drawing.Point(184, 142);
            this.pcbFive.Name = "pcbFive";
            this.pcbFive.Size = new System.Drawing.Size(99, 94);
            this.pcbFive.TabIndex = 4;
            this.pcbFive.TabStop = false;
            this.pcbFive.Tag = "22";
            this.pcbFive.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbFive.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragEnter);
            this.pcbFive.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            this.pcbFive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbBoard_MouseDown);
            // 
            // pcbFour
            // 
            this.pcbFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbFour.Location = new System.Drawing.Point(55, 142);
            this.pcbFour.Name = "pcbFour";
            this.pcbFour.Size = new System.Drawing.Size(108, 94);
            this.pcbFour.TabIndex = 3;
            this.pcbFour.TabStop = false;
            this.pcbFour.Tag = "12";
            this.pcbFour.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbFour.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragEnter);
            this.pcbFour.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            this.pcbFour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbBoard_MouseDown);
            // 
            // pcbThree
            // 
            this.pcbThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbThree.Location = new System.Drawing.Point(304, 21);
            this.pcbThree.Name = "pcbThree";
            this.pcbThree.Size = new System.Drawing.Size(106, 100);
            this.pcbThree.TabIndex = 2;
            this.pcbThree.TabStop = false;
            this.pcbThree.Tag = "31";
            this.pcbThree.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbThree.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragEnter);
            this.pcbThree.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            this.pcbThree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbBoard_MouseDown);
            // 
            // pcbTwo
            // 
            this.pcbTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbTwo.Location = new System.Drawing.Point(184, 21);
            this.pcbTwo.Name = "pcbTwo";
            this.pcbTwo.Size = new System.Drawing.Size(99, 100);
            this.pcbTwo.TabIndex = 1;
            this.pcbTwo.TabStop = false;
            this.pcbTwo.Tag = "21";
            this.pcbTwo.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbTwo.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragEnter);
            this.pcbTwo.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            this.pcbTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbBoard_MouseDown);
            // 
            // pcbOne
            // 
            this.pcbOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbOne.Location = new System.Drawing.Point(55, 21);
            this.pcbOne.Name = "pcbOne";
            this.pcbOne.Size = new System.Drawing.Size(108, 100);
            this.pcbOne.TabIndex = 0;
            this.pcbOne.TabStop = false;
            this.pcbOne.Tag = "11";
            this.pcbOne.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbOne.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragEnter);
            this.pcbOne.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            this.pcbOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbBoard_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 470);
            this.Controls.Add(this.cbxArduino);
            this.Controls.Add(this.rdbBlack);
            this.Controls.Add(this.rdbWhite);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gbxPieces);
            this.Controls.Add(this.gbxBoard);
            this.Name = "Form1";
            this.Text = "TicTacChess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxPieces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbWizard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKnight)).EndInit();
            this.gbxBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbNine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSeven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBoard;
        private System.Windows.Forms.PictureBox pcbNine;
        private System.Windows.Forms.PictureBox pcbEight;
        private System.Windows.Forms.PictureBox pcbSeven;
        private System.Windows.Forms.PictureBox pcbSix;
        private System.Windows.Forms.PictureBox pcbFive;
        private System.Windows.Forms.PictureBox pcbFour;
        private System.Windows.Forms.PictureBox pcbThree;
        private System.Windows.Forms.PictureBox pcbTwo;
        private System.Windows.Forms.PictureBox pcbOne;
        private System.Windows.Forms.GroupBox gbxPieces;
        private System.Windows.Forms.PictureBox pcbQueen;
        private System.Windows.Forms.PictureBox pcbRook;
        private System.Windows.Forms.PictureBox pcbKnight;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.CheckBox cbxArduino;
        private System.Windows.Forms.Timer tmrArduino;
        private System.Windows.Forms.PictureBox pcbWizard;
        private System.Windows.Forms.PictureBox pcbKing;
    }
}

