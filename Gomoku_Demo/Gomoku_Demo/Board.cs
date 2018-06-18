using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku_Demo
{
    class Board
    {
        private static readonly int Node_Count = 9;
        private static readonly Point NO_MATCH_NODE = new Point(-1, -1);
        private static readonly int Offset = 48;
        private static readonly int Node_R = 10;
        private static readonly int Node_Dist = 49;

        private Piece[,] pieces = new Piece[Node_Count, Node_Count];
        
        public PieceType GetPieceType(int nodeIdX,int nodeIdY)
        {
            if(pieces[nodeIdX, nodeIdY]==null)
                return PieceType.NONE;
            else
                return pieces[nodeIdX, nodeIdY].GetPieceType();
        }
         
        public bool CanBePlaced(int x, int y)
        {
            //Find the close Node
            Point nodeId = FindTheCloseNode(x, y);

            //If YES,return false
            if (nodeId == NO_MATCH_NODE)
                return false;
            //If NO, check whether there has piece
            if (pieces[nodeId.X, nodeId.Y] != null)
                return false;

            return true;
        }
        public Piece PlaceAPiece(int x, int y,PieceType type)
        {
            //Find the close Node
            Point nodeId = FindTheCloseNode(x, y);
            //If YES,return false
            if (nodeId == NO_MATCH_NODE)
                return null;
            //If NO, check whether there has piece
            if (pieces[nodeId.X, nodeId.Y] != null)
                return null;
            //according to Type and use what color of piece
            Point formPos = convertToFormPosition(nodeId);
            if (type == PieceType.BLACK)
                pieces[nodeId.X, nodeId.Y] = new BlackPiece(formPos.X,formPos.Y);
            else if (type==PieceType.WHITE)
                pieces[nodeId.X, nodeId.Y] = new WhitePiece(formPos.X, formPos.Y);

            return pieces[nodeId.X, nodeId.Y];
        }
        private Point convertToFormPosition(Point nodeId)
        {
            Point formPosition = new Point();
            formPosition.X = nodeId.X * Node_Dist + Offset-2;
            formPosition.Y = nodeId.Y * Node_Dist + Offset-11;
            return formPosition;
        }
        private Point FindTheCloseNode(int x,int y)
        {
            int nodeIdX = FindTheCloseNode(x);
            if (nodeIdX == -1 || nodeIdX>=Node_Count)
                return NO_MATCH_NODE;
            int nodeIdY = FindTheCloseNode(y);
            if (nodeIdY == -1 || nodeIdX >= Node_Count)
                return NO_MATCH_NODE;

            return new Point(nodeIdX, nodeIdY);
        }
        
        private int FindTheCloseNode(int pos)
        {
            pos -= Offset;
            int quotient = pos / Node_Dist;
            int remainder = pos % Node_Dist;
            if (remainder <= Node_R)
            {
                return quotient;
            }
            else if (remainder >= Node_Dist - Node_R)
            {
                return quotient + 1;
            }
            else
                return -1;
        }
    }
}
