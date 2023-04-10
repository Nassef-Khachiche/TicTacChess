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

        // Move when its your turn
        int onBoardCount = 0;
        bool gameStart = false;
        string turnColor = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Start as white */
            selectedPieceColor = "White";
            turnColor = "White";
            rdbWhite.Checked = true;
            UpdatePieceColor();

            foreach (PictureBox item in gbxBoard.Controls.OfType<PictureBox>())
            {
                item.AllowDrop = true;
            }

            SetupGame();
        }

        private void pcbBoard_MouseDown(object sender, MouseEventArgs e)
        {
            pcbFrom = (PictureBox)sender;

            if (pcbFrom.BackColor == Color.White)
            {
                horizontal = Convert.ToInt32(pcbFrom.Tag.ToString().Substring(0, 1));
                vertical = Convert.ToInt32(pcbFrom.Tag.ToString().Substring(1, 1));

                activeBoard = boardList.FirstOrDefault(x => x.GetHorizontal() == horizontal && x.GetVertical() == vertical);
                activePiece = activeBoard.GetPiece();


                GetBoardOptions();
                ResetBoardOptions();
                UpdateBoardpieceOptions();

                CheckForIllegalMoves();

                if (pcbFrom.Image != null)
                {
                    pcbFrom.DoDragDrop(pcbFrom.Image, DragDropEffects.Copy);
                }
            }
        }

        private void pcbBoard_DragDrop(object sender, DragEventArgs e)
        {
            pcbTo = (PictureBox)sender;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pcbTo.Image = getPicture;
            pcbTo.BackColor = Color.Transparent;

            horizontal = Convert.ToInt32(pcbTo.Tag.ToString().Substring(0,1));
            vertical = Convert.ToInt32(pcbTo.Tag.ToString().Substring(1, 1));

            if (activeBoard != null)
            {
                activeBoard.SetPiece(null);
                activeBoard = boardList.FirstOrDefault(x => x.GetHorizontal() == horizontal && x.GetVertical() == vertical);
                activePiece.SetCurrentPictureBox(pcbTo.Name);
                activeBoard.SetPiece(activePiece);
                pcbFrom.Image = null;

                if (turnColor == "White")
                {
                    turnColor = "Black";
                }
                else
                {
                    turnColor = "White";
                }
            }
            else
            {
                // Pieces area to the board
                activePiece.SetCurrentPictureBox(pcbTo.Name);
                boardList.FirstOrDefault(x => x.GetHorizontal() == horizontal && x.GetVertical() == vertical).SetPiece(activePiece);

                onBoardCount++;
                activePiece.SetIsOnBoard(true);
                UpdateBoardpieceOptions();
               
            }

            ResetBoardOptions();
            UpdatePieceOnBoardColors();

            if (onBoardCount == 6)
            {
                onBoardCount++;
                gameStart = true;
                turnColor = "White";
            }
            UpdateAllBoardColors();
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
            /* ClearBoardCalls moet niet !!!*/

            activeBoard = null;
            pcbFrom = (PictureBox)sender;
            if (pcbFrom.BackColor == Color.White)
            {
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
        }

        private void rdbBlack_CheckedChanged(object sender, EventArgs e)
        {
            selectedPieceColor = "Black";
            UpdatePieceColor();
            UpdatePieceOnBoardColors();
        }

        private void rdbWhite_CheckedChanged(object sender, EventArgs e)
        {
            selectedPieceColor = "White";
            UpdatePieceColor();
            UpdatePieceOnBoardColors();
        }

        /* update staring position onnodig */
        public void CheckForIllegalMoves()
        {
            Board right = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() + 1 && x.GetVertical() == activeBoard.GetVertical());
            Board left = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() - 1 && x.GetVertical() == activeBoard.GetVertical());
            Board up = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() && x.GetVertical() == activeBoard.GetVertical() - 1);
            Board down = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() && x.GetVertical() == activeBoard.GetVertical() + 1);


            if (activePiece != null)
            {
                if (activePiece.GetName() == "Rook" || activePiece.GetName() == "Queen")
                {
                    CheckForNeighbour(right, "Right");
                    CheckForNeighbour(left, "Left");
                    CheckForNeighbour(up, "Up");
                    CheckForNeighbour(down, "Down");

                }

                if (activePiece.GetName() == "Queen")
                {
                    Board upRight = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() + 1 && x.GetVertical() == activeBoard.GetVertical() - 1);
                    Board upLeft = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() - 1 && x.GetVertical() == activeBoard.GetVertical() - 1);
                    Board downRight = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() + 1 && x.GetVertical() == activeBoard.GetVertical() + 1);
                    Board downLeft = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() - 1 && x.GetVertical() == activeBoard.GetVertical() + 1);

                    CheckForNeighbour(upRight, "UpRight");
                    CheckForNeighbour(upLeft, "UpLeft");
                    CheckForNeighbour(downRight, "DownRight");
                    CheckForNeighbour(downLeft, "DownLeft");
                }
            }
        }

        private void CheckForNeighbour(Board neighbour, string direction) 
        {
            if (neighbour != null && neighbour.GetPiece() != null)
            {
                switch (direction)
                {
                    case "Left":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() - 1 && o.GetVertical() == neighbour.GetVertical());
                        break;
                    case "Right":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() + 1 && o.GetVertical() == neighbour.GetVertical());
                        break;
                    case "Up":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() && o.GetVertical() == neighbour.GetVertical() - 1);
                        break;
                    case "Down":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() && o.GetVertical() == neighbour.GetVertical() + 1);
                        break;
                    case "UpRight":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() + 1 && o.GetVertical() == neighbour.GetVertical() - 1);
                        break;
                    case "UpLeft":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() - 1 && o.GetVertical() == neighbour.GetVertical() - 1);
                        break;
                    case "DownRight":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() + 1 && o.GetVertical() == neighbour.GetVertical() + 1);
                        break;
                    case "DownLeft":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() - 1 && o.GetVertical() == neighbour.GetVertical() + 1);
                        break;
                    default:
                        break;
                }
            }

            if (forbidden != null)
            {
                pbxForbidden = (PictureBox)gbxBoard.Controls.Find(forbidden.GetPictureName(), false)[0];
                pbxForbidden.BackColor = Color.White;
            }
        }
        public void UpdatePieceColor()
        {
            if (selectedPieceColor == "White")
            {
                pcbKnight.Image = Properties.Resources.white_knight;
                pcbQueen.Image = Properties.Resources.white_queen;
                pcbRook.Image = Properties.Resources.white_rook;
            }
            else if (selectedPieceColor == "Black")
            {
                pcbQueen.Image = Properties.Resources.black_queen;
                pcbRook.Image = Properties.Resources.black_rook;
                pcbKnight.Image = Properties.Resources.black_knight;
            }
        }
        public void UpdateBoardpieceOptions()
        {

            for (int i = 0; i < pieceOptions.Length; i += 2)
            {
                foreach (PictureBox pb in gbxBoard.Controls.OfType<PictureBox>())
                {
                    if (pb.Tag?.ToString() == pieceOptions[i].ToString() + pieceOptions[i + 1].ToString() && pb.Image == null)
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
        /* Setup Game */
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
            boardList.Add(new Board(3, 1, "pcbThree"));
            boardList.Add(new Board(1, 2, "pcbFour"));
            boardList.Add(new Board(2, 2, "pcbFive"));
            boardList.Add(new Board(3, 2, "pcbSix"));
            boardList.Add(new Board(1, 3, "pcbSeven"));
            boardList.Add(new Board(2, 3, "pcbEight"));
            boardList.Add(new Board(3, 3, "pcbNine"));
        }
        /* Before calculating a pieceoptions the old ones have to be cleared */
        public void ResetBoardOptions()
        {
            foreach (PictureBox pb in gbxBoard.Controls.OfType<PictureBox>())
            {
                pb.BackColor = Color.White;
            }
        }

        public void UpdatePieceOnBoardColors()
        {
            if (pieceList != null)
            {
                foreach (Piece item in pieceList)
                {
                    foreach (PictureBox pb in gbxPieces.Controls.OfType<PictureBox>())
                    {
                        if (item.GetBasePictureBoxName() == pb.Name && item.GetColor() == selectedPieceColor)
                        {
                            if (item.GetIsOnBoard())
                            {
                                pb.BackColor = Color.Red;
                            }
                            else
                            {
                                pb.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
        }

        private void pcbBoard_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && ((PictureBox)sender).BackColor == Color.Green)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                UpdateAllBoardColors();
            }
        }

        public void UpdateAllBoardColors() 
        {
            foreach (PictureBox pb in gbxBoard.Controls.OfType<PictureBox>())
            {
                Board b = boardList.FirstOrDefault(x => x.GetPictureName() == pb.Name);
                if (b.GetPiece() != null)
                {
                    if (b.GetPiece().GetColor() == turnColor)
                    {
                        pb.BackColor = Color.White;
                    }
                    else
                    {
                        pb.BackColor = Color.Gray;
                    }
                }
            }
        }
    }
}
