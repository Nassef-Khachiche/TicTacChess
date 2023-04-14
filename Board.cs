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
        private int arduinoHor;
        private int arduinoRot;

        public Board(int aHorizontal, int aVertical, string aPictureName, int aArduinoHor, int aArduinoRot) 
        {
            horizontal = aHorizontal;
            vertiacal = aVertical;
            pictureName = aPictureName;
            arduinoHor = aArduinoHor;
            arduinoRot = aArduinoRot;
        }

        // Gets
        public string GetPictureName() { return pictureName; }
        public int GetHorizontal() { return horizontal; }
        public int GetVertical() { return vertiacal; }

        public int GetArduinoVer() { return 1150; }
        public int GetArduinoRot() { return arduinoRot; }
        public int GetArduinoHor() { return arduinoHor; }
        public Piece GetPiece() { return currentPiece; }

        //Sets
        public void SetPiece(Piece piece) { currentPiece = piece; }

    }
}
