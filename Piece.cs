using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacChess
{
    internal class Piece
    {
        private string name = "";
        private string color = "";
        private string basePictureBoxName = "";
        private string currentPictureBoxName = "";

        private string moveOptions;
        int oldHor, oldVer, newHor, newVer;

        private bool IsOnBoard = false;


        //Constructor
        public Piece(string aName, string aColor) 
        {
            name = aName;
            color = aColor;
            basePictureBoxName = "pcb" + name;
        }

        
        public void SetCurrentPictureBox(string newCurrentPictureBoxName) 
        {
            currentPictureBoxName = newCurrentPictureBoxName;
        }
        
        #region Values
        public string GetName() { return name; }
        public string GetColor() { return color; }
        public string GetBasePictureBoxName() { return basePictureBoxName; }
        public string GetCurrentPictureBox() { return currentPictureBoxName; }
        public void SetIsOnBoard(bool onBoard) 
        {
            IsOnBoard = onBoard;
        }
        public bool GetIsOnBoard() 
        {
            return IsOnBoard;
        }
        #endregion

        #region Movement
        public string GetMoveOptions(int curHor, int curVer, int _newHor, int _newVer) 
        {
            oldHor = curHor;
            oldVer = curVer;
            newVer = _newVer;
            newHor = _newHor;
            moveOptions = "";

            switch (name)
            {
                case "Rook": MoveRook(); break;
                case "Knight": MoveKnight(); break;
                case "Queen": MoveQueen(); break;
                case "King": MoveKing(); break;
                default:
                    break;
            }

            return moveOptions;
        }
        public void MoveRook() 
        {
            int tempHor = Math.Abs(newHor - oldHor);
            int tempVer = Math.Abs(newVer - oldVer);

            if (tempVer == 2 || tempVer == 1)
            {
                if (tempHor == 0)
                {
                    moveOptions = newHor.ToString() + newVer.ToString();
                }
            }
            else if (tempHor == 2 || tempHor == 1) 
            {
                if (tempVer == 0)
                {
                    moveOptions = newHor.ToString() + newVer.ToString();

                }
            }
        }
        public void MoveQueen()
        {
            int tempHor = Math.Abs(newHor - oldHor);
            int tempVer = Math.Abs(newVer - oldVer);

            if (tempHor == tempVer)
            {
                moveOptions = newHor.ToString() + newVer.ToString();
            }
            else if (tempVer == 2 || tempVer == 1)
            {
                if (tempHor == 0)
                {
                    moveOptions = newHor.ToString() + newVer.ToString();
                }
            }
            else if (tempHor == 2 || tempHor == 1)
            {
                if (tempVer == 0)
                {
                    moveOptions = newHor.ToString() + newVer.ToString();

                }
            }
        }

        public void MoveKing()
        {
            int tempHor = Math.Abs(newHor - oldHor);
            int tempVer = Math.Abs(newVer - oldVer);

            /* Check if the king can move one square in any direction, including diagonally */
            if (tempHor <= 1 && tempVer <= 1 && (tempHor != 0 || tempVer != 0))
            {
                moveOptions = newHor.ToString() + newVer.ToString();
            }
        }

        public void MoveKnight()
        {
            int tempHor = Math.Abs(newHor - oldHor);
            int tempVer = Math.Abs(newVer - oldVer);

            if (tempHor == 2)
            {
                if (tempVer == 1)
                {
                    moveOptions = newHor.ToString() + newVer.ToString();
                }
            }
            else
            {
                if (tempVer == 2)
                {
                    if (tempHor == 1)
                    {
                        moveOptions = newHor.ToString() + newVer.ToString();
                    }
                }
            }
        }

        #endregion
    }
}
