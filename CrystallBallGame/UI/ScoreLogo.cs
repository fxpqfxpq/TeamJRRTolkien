using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystallBallGame.UI
{
    public class ScoreLogo : Logo
    {
        private const int matrixRows = 3;
        private const int matrixCols = 11;
        public ScoreLogo()
            : base(matrixRows, matrixCols)
        {
            this.matrix = CreateLogo();
        }

        private static char[,] CreateLogo()
        {
            return new char[matrixRows, matrixCols] {{'+','-','+','-','+','-','+','-','+','-','+'},
                                                     {'|','S','|','c','|','o','|','r','|','e','|'},
                                                     {'+','-','+','-','+','-','+','-','+','-','+'}};
        }

    }
}