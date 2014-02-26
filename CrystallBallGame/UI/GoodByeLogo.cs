namespace CrystallBallGame.UI
{
    using System.Text;
    public class GoodByeLogo : Logo
    {
        private const int matrixRows = 16;
        private const int matrixCols = 46;
        public GoodByeLogo()
            : base(matrixRows, matrixCols)
        {
            this.matrix = CreateLogo();
        }

        private static char[,] CreateLogo()
        {
            StringBuilder result = new StringBuilder();
            char[,] gbL = new char[16, 45];
            result.AppendLine("********** **                         **     ");
            result.AppendLine("/////**/// /**                        /**    ");
            result.AppendLine("    /**    /**       ******   ******* /**  **");
            result.AppendLine("    /**    /******  //////** //**///**/** ** ");
            result.AppendLine("    /**    /**///**  *******  /**  /**/****  ");
            result.AppendLine("    /**    /**  /** **////**  /**  /**/**/** ");
            result.AppendLine("    /**    /**  /**//******** ***  /**/**//**");
            result.AppendLine("    //     //   //  //////// ///   // //  // ");
            result.AppendLine("                                   **        ");
            result.AppendLine("          **   **                 /**        ");
            result.AppendLine("         //** **   ******  **   **/**        ");
            result.AppendLine("          //***   **////**/**  /**/**        ");
            result.AppendLine("           /**   /**   /**/**  /**/**        ");
            result.AppendLine("           **    /**   /**/**  /**//         ");
            result.AppendLine("          **     //****** //****** **        ");
            result.AppendLine("         //       //////   ////// //         ");

            int index = 0;

            for (int row = 0; row < gbL.GetLength(0); row++)
            {
                for (int col = 0; col < gbL.GetLength(1); col++)
                {
                    gbL[row, col] = result[index];
                    index++;
                }
            }

            return gbL;

        }

    }
}