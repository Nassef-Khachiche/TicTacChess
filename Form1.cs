using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace TicTacChess
{
    public partial class Form1 : Form
    {
        // Selected Color
        string selectedPieceColor = "";

        // The pictureboxes to use while moving pieces
        PictureBox pcbFrom = null;
        PictureBox pcbTo = null;

        //Variables to move pieces
        List<Piece> pieceList = null;
        Piece activePiece = null;

        List<Board> boardList = null;
        Board activeBoard = null;

        string pieceOptions = "";
        int horizontal, vertical;
        PictureBox pbxForbidden;
        Board forbidden;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Start as white */
            selectedPieceColor = "White";
            rdbWhite.Checked = true;

            foreach (PictureBox item in gbxBoard.Controls.OfType<PictureBox>())
            {
                item.AllowDrop = true;
            }

            SetupGame();
        }

        private void pcbBoard_MouseDown(object sender, MouseEventArgs e)
        {
            pcbFrom = (PictureBox)sender;

            horizontal = Convert.ToInt32(pcbFrom.Tag.ToString().Substring(0, 1));
            vertical = Convert.ToInt32(pcbFrom.Tag.ToString().Substring(1, 1));

            activeBoard = boardList.FirstOrDefault(x => x.GetHorizontal() == horizontal && x.GetVertical() == vertical);
            activePiece = activeBoard.GetPiece();

            GetBoardOptions();
            UpdateBoardpieceOptions();

            pcbFrom.DoDragDrop(pcbFrom.Image, DragDropEffects.Copy);
        }

        private void pcbBoard_DragDrop(object sender, DragEventArgs e)
        {
            pcbTo = (PictureBox)sender;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pcbTo.Image = getPicture;
        }

        private void pcbBoard_DragOver(object sender, DragEventArgs e)
        {
            pcbTo = (PictureBox)sender;
            if (pcbTo.BackColor == Color.Green)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pcbAllPieces_MouseDown(object sender, MouseEventArgs e)
        {   
            activeBoard = null;
            pcbFrom = (PictureBox)sender;

            foreach (Piece item in pieceList)
            {
                if (item.GetBasePictureBoxName() == pcbFrom.Name && item.GetColor() == selectedPieceColor)
                {
                    activePiece = item;
                }
            }

            GetStartingOptions();

            pcbFrom.DoDragDrop(pcbFrom.Image, DragDropEffects.Copy);
        }

        private void rdbBlack_CheckedChanged(object sender, EventArgs e)
        {
            selectedPieceColor = "Black";
        }

        private void rdbWhite_CheckedChanged(object sender, EventArgs e)
        {
            selectedPieceColor = "White";
        }

        /* update staring position onnodig */
        public void CheckForIllegalMoves() 
        {

        }

        public void UpdateBoardpieceOptions()
        {
            for (int i = 0; i < pieceOptions.Length; i += 2)
            {
                foreach (PictureBox pb in gbxBoard.Controls.OfType<PictureBox>())
                {
                    if (pb.Tag.ToString() == pieceOptions[i].ToString() + pieceOptions[i + 1].ToString() && pb.Image == null)
                    {
                        pb.BackColor = Color.Green;
                    }
                }
            }
        }
        public void GetBoardOptions() 
        {
            pieceOptions = "";
            foreach (Board item in boardList)
            {
                if (activePiece != null && item.GetPiece() == null)
                {
                    pieceOptions += activePiece.GetMoveOptions(horizontal, vertical, item.GetHorizontal(), item.GetVertical());
                }
            }
        }
        public void GetStartingOptions()
        {
            if (selectedPieceColor == "White")
            {
                pieceOptions = "132333";
            }
            else
            {
                pieceOptions = "112131";
            }

            UpdateBoardpieceOptions();
        }
        public void SetupGame()
        {
            pieceList = new List<Piece>();
            pieceList.Add(new Piece("Rook", "White"));
            pieceList.Add(new Piece("Knight", "White"));
            pieceList.Add(new Piece("Queen", "White"));
            pieceList.Add(new Piece("Rook", "Black"));
            pieceList.Add(new Piece("Knight", "Black"));
            pieceList.Add(new Piece("Queen", "Black"));

            boardList = new List<Board>();
            boardList.Add(new Board(1, 1, "pcbOne"));
            boardList.Add(new Board(2, 1, "pcbTwo"));
            boardList.Add(new Board(3, 1, "pcbOne"));
            boardList.Add(new Board(1, 2, "pcbFour"));
            boardList.Add(new Board(2, 2, "pcbFive"));
            boardList.Add(new Board(3, 2, "pcbSix"));
            boardList.Add(new Board(1, 3, "pcbSeven"));
            boardList.Add(new Board(2, 3, "pcbEight"));
            boardList.Add(new Board(3, 3, "pcbNine"));
        }
    }
}
