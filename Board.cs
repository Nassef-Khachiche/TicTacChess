using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacChess
{
    
    internal class Board
    {
        private int horizontal;
        private int vertiacal;
        private Piece currentPiece;
        private string pictureName;

        public Board(int aHorizontal, int aVertical, string aPictureName) 
        {
            horizontal = aHorizontal;
            vertiacal = aVertical;
            pictureName = aPictureName;

        }

        // Gets
        public string GetPictureName() { return pictureName; }
        public int GetHorizontal() { return horizontal; }
        public int GetVertical() { return vertiacal; }
        public Piece GetPiece() { return currentPiece; }

        //Sets
        public void SetPiece(Piece piece) { currentPiece = piece; }

    }
}
