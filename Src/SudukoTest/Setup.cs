﻿namespace SudukoTest
{
    using System;
    using System.Collections.Generic;

    public class Setup
    {
        public static int[,] validMatrix = new int[9, 9]
       {
                { 0,0,0,2,0,4,8,1,0 },
                { 0,4,0,0,0,8,2,6,3 },
                { 3,0,0,1,6,0,0,0,4 },
                { 1,0,0,0,4,0,5,8,0 },
                { 6,3,5,8,2,0,0,0,7 },
                { 2,0,0,5,9,0,1,0,0 },
                { 9,1,0,7,0,0,0,4,0 },
                { 0,0,0,6,8,0,7,0,1 },
                { 8,0,0,4,0,3,0,5,0 },
       };

        public static int[,] matrixWithNegativeelement = new int[9, 9]
          {
                { 0,0,0,2,0,4,8,1,-1 },
                { 0,4,0,0,0,8,2,6,3 },
                { 3,0,0,1,6,0,0,0,4 },
                { 1,0,0,0,4,0,5,8,0 },
                { 6,3,5,8,2,0,0,0,7 },
                { 2,0,0,5,9,0,1,0,0 },
                { 9,1,0,7,0,0,0,4,0 },
                { 0,0,0,6,8,0,7,0,1 },
                { 8,0,0,4,0,3,0,5,0 },
          };

        public static int[,] matrixWithelementOverNine = new int[9, 9]
         {
                { 0,0,0,2,0,4,8,1,11 },
                { 0,4,0,0,0,8,2,6,3 },
                { 3,0,0,1,6,0,0,0,4 },
                { 1,0,0,0,4,0,5,8,0 },
                { 6,3,5,8,2,0,0,0,7 },
                { 2,0,0,5,9,0,1,0,0 },
                { 9,1,0,7,0,0,0,4,0 },
                { 0,0,0,6,8,0,7,0,1 },
                { 8,0,0,4,0,3,0,5,0 },
         };

        public static int[,] matrixNotPerfectSquare = new int[8, 9]
        {
                { 0,0,0,2,0,4,8,1,11 },
                { 0,4,0,0,0,8,2,6,3 },
                { 3,0,0,1,6,0,0,0,4 },
                { 1,0,0,0,4,0,5,8,0 },
                { 6,3,5,8,2,0,0,0,7 },
                { 2,0,0,5,9,0,1,0,0 },
                { 9,1,0,7,0,0,0,4,0 },
                { 0,0,0,6,8,0,7,0,1 },
        };

        public static int[,] matrixWithAllTypeOfDuplicates = new int[9, 9]
          {
                { 0,0,0,2,0,4,2,1,0 },
                { 0,4,0,0,0,8,8,6,3 },
                { 3,0,0,1,6,0,0,0,4 },
                { 1,0,0,0,0,4,5,8,0 },
                { 6,3,5,8,2,0,0,0,7 },
                { 2,0,0,5,9,0,1,0,0 },
                { 9,1,0,7,0,0,0,4,0 },
                { 0,0,0,6,8,7,0,0,1 },
                { 8,0,0,4,0,3,0,5,0 },
          };

        public static int[,] sudokoMatrixDeadEnd = new int[9, 9]
          {
                { 0,0,0,2,0,4,8,1,0 },
                { 0,4,0,0,0,8,2,6,3 },
                { 3,0,0,1,6,0,0,0,4 },
                { 1,0,0,0,4,0,5,8,0 },
                { 0,0,0,0,2,0,0,0,7 },
                { 2,0,0,5,9,0,1,0,0 },
                { 9,1,0,7,0,0,0,4,0 },
                { 0,0,0,6,8,0,7,0,1 },
                { 8,0,0,4,0,3,0,5,0 },
          };

        public static int[,] sudukoEmpty = new int[9, 9]
            {
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 }
            };

        public static int[,] sudukoWithOneCompleteRow = new int[9, 9]
    {
                { 1,2,3,4,5,6,7,8,9 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 }
    };

        public static int[,] sudukoWithOneCompleteRowAndAHalf = new int[9, 9]
        {
                { 1,2,3,4,5,6,7,8,9 },
                { 4,5,6,1,2,0,0,0,0 },  // 4,5,6,1,2  -=> 3,7,8,9
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0 }
        };

        public static int[] perfect = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public static List<List<List<int>>> solutions = new List<List<List<int>>>
        {
           new List<List<int>> {
    new List<int> {9,5,4,6,1,2,7,3,8 },
    new List<int> {2,1,8,9,7,3,4,6,5 },
    new List<int> {6,3,7,8,5,4,1,2,9 },
    new List<int> {1,4,9,2,3,5,6,8,7 },
    new List<int> {3,6,5,7,4,8,9,1,2 },
    new List<int> {8,7,2,1,6,9,5,4,3 },
    new List<int> {7,9,1,3,2,6,8,5,4 },
    new List<int> {5,8,3,4,9,1,2,7,6 },
    new List<int> {4,2,6,5,8,7,3,9,1 }
},
new List<List<int>> {
    new List<int> {8,3,2,5,1,7,9,4,6 },
    new List<int> {5,9,4,6,8,3,2,1,7 },
    new List<int> {6,7,1,2,4,9,8,3,5 },
    new List<int> {2,8,9,1,7,6,4,5,3 },
    new List<int> {4,1,5,3,2,8,6,7,9 },
    new List<int> {7,6,3,4,9,5,1,8,2 },
    new List<int> {1,4,6,7,3,2,5,9,8 },
    new List<int> {3,2,8,9,5,1,7,6,4 },
    new List<int> {9,5,7,8,6,4,3,2,1 }
},
new List<List<int>> {
    new List<int> {7,8,1,3,6,5,9,4,2 },
    new List<int> {4,6,2,1,9,8,3,5,7 },
    new List<int> {5,3,9,7,4,2,6,8,1 },
    new List<int> {3,4,5,6,7,9,1,2,8 },
    new List<int> {9,1,8,5,2,4,7,6,3 },
    new List<int> {2,7,6,8,3,1,5,9,4 },
    new List<int> {6,9,3,4,8,7,2,1,5 },
    new List<int> {1,2,4,9,5,3,8,7,6 },
    new List<int> {8,5,7,2,1,6,4,3,9 }
},
new List<List<int>> {
    new List<int> {4,8,2,5,6,7,3,1,9 },
    new List<int> {6,9,5,1,2,3,8,7,4 },
    new List<int> {1,3,7,9,8,4,2,5,6 },
    new List<int> {2,1,9,6,3,5,4,8,7 },
    new List<int> {3,7,4,2,1,8,9,6,5 },
    new List<int> {8,5,6,7,4,9,1,2,3 },
    new List<int> {9,2,1,4,5,6,7,3,8 },
    new List<int> {5,4,3,8,7,1,6,9,2 },
    new List<int> {7,6,8,3,9,2,5,4,1 }
},
new List<List<int>> {
    new List<int> {1,2,7,5,6,3,4,8,9 },
    new List<int> {8,3,4,2,9,7,1,5,6 },
    new List<int> {9,6,5,4,1,8,2,3,7 },
    new List<int> {4,8,3,6,5,2,7,9,1 },
    new List<int> {6,5,1,7,8,9,3,2,4 },
    new List<int> {7,9,2,1,3,4,8,6,5 },
    new List<int> {2,7,6,8,4,5,9,1,3 },
    new List<int> {3,1,8,9,7,6,5,4,2 },
    new List<int> {5,4,9,3,2,1,6,7,8 }
},
new List<List<int>> {
    new List<int> {5,1,2,3,8,6,4,7,9 },
    new List<int> {9,3,4,1,5,7,8,2,6 },
    new List<int> {8,7,6,4,2,9,5,3,1 },
    new List<int> {2,4,5,7,1,3,6,9,8 },
    new List<int> {1,6,3,2,9,8,7,5,4 },
    new List<int> {7,8,9,5,6,4,3,1,2 },
    new List<int> {4,5,8,9,7,1,2,6,3 },
    new List<int> {3,2,1,6,4,5,9,8,7 },
    new List<int> {6,9,7,8,3,2,1,4,5 }
},
new List<List<int>> {
    new List<int> {1,2,3,9,8,4,5,7,6 },
    new List<int> {5,6,8,7,2,3,9,4,1 },
    new List<int> {9,4,7,5,1,6,8,3,2 },
    new List<int> {8,9,2,1,4,7,6,5,3 },
    new List<int> {7,3,1,2,6,5,4,8,9 },
    new List<int> {6,5,4,3,9,8,2,1,7 },
    new List<int> {3,8,5,6,7,9,1,2,4 },
    new List<int> {4,1,6,8,3,2,7,9,5 },
    new List<int> {2,7,9,4,5,1,3,6,8 }
},
new List<List<int>> {
    new List<int> {6,4,3,9,5,7,1,2,8 },
    new List<int> {7,5,1,2,8,6,9,3,4 },
    new List<int> {8,9,2,1,3,4,5,6,7 },
    new List<int> {3,2,4,6,1,5,7,8,9 },
    new List<int> {9,6,5,3,7,8,2,4,1 },
    new List<int> {1,8,7,4,9,2,6,5,3 },
    new List<int> {2,1,8,7,6,3,4,9,5 },
    new List<int> {4,3,9,5,2,1,8,7,6 },
    new List<int> {5,7,6,8,4,9,3,1,2 }
},
new List<List<int>> {
    new List<int> {8,7,2,3,6,5,4,1,9 },
    new List<int> {3,1,5,7,9,4,8,6,2 },
    new List<int> {6,4,9,8,1,2,5,7,3 },
    new List<int> {1,9,4,2,3,8,7,5,6 },
    new List<int> {7,2,3,4,5,6,1,9,8 },
    new List<int> {5,8,6,9,7,1,2,3,4 },
    new List<int> {4,5,7,6,8,9,3,2,1 },
    new List<int> {9,3,8,1,2,7,6,4,5 },
    new List<int> {2,6,1,5,4,3,9,8,7 }
},
new List<List<int>> {
    new List<int> {3,4,5,9,7,6,1,2,8 },
    new List<int> {7,6,2,1,8,5,9,3,4 },
    new List<int> {9,8,1,2,3,4,7,5,6 },
    new List<int> {2,1,3,4,5,8,6,7,9 },
    new List<int> {6,5,4,3,9,7,2,8,1 },
    new List<int> {8,9,7,6,2,1,5,4,3 },
    new List<int> {1,2,8,7,6,3,4,9,5 },
    new List<int> {4,3,9,5,1,2,8,6,7 },
    new List<int> {5,7,6,8,4,9,3,1,2 }
},
new List<List<int>> {
    new List<int> {3,5,2,9,4,6,8,7,1 },
    new List<int> {4,7,6,1,5,8,9,2,3 },
    new List<int> {1,9,8,2,7,3,6,4,5 },
    new List<int> {8,2,1,4,9,7,5,3,6 },
    new List<int> {5,3,4,6,2,1,7,9,8 },
    new List<int> {7,6,9,8,3,5,2,1,4 },
    new List<int> {2,1,5,7,8,4,3,6,9 },
    new List<int> {6,8,7,3,1,9,4,5,2 },
    new List<int> {9,4,3,5,6,2,1,8,7 }
},
new List<List<int>> {
    new List<int> {7,5,8,1,2,9,4,6,3 },
    new List<int> {1,9,6,7,3,4,5,2,8 },
    new List<int> {2,3,4,8,5,6,9,7,1 },
    new List<int> {4,2,5,3,1,7,8,9,6 },
    new List<int> {9,8,3,6,4,2,1,5,7 },
    new List<int> {6,1,7,5,9,8,2,3,4 },
    new List<int> {8,7,1,2,6,5,3,4,9 },
    new List<int> {3,4,2,9,7,1,6,8,5 },
    new List<int> {5,6,9,4,8,3,7,1,2 }
},
new List<List<int>> {
    new List<int> {5,7,4,8,6,9,3,2,1 },
    new List<int> {1,9,6,7,2,3,4,8,5 },
    new List<int> {8,2,3,4,5,1,6,7,9 },
    new List<int> {2,4,5,3,1,6,8,9,7 },
    new List<int> {3,6,8,9,7,2,1,5,4 },
    new List<int> {7,1,9,5,8,4,2,3,6 },
    new List<int> {6,8,2,1,9,7,5,4,3 },
    new List<int> {9,3,1,2,4,5,7,6,8 },
    new List<int> {4,5,7,6,3,8,9,1,2 }
},
new List<List<int>> {
    new List<int> {5,6,7,8,9,4,1,3,2 },
    new List<int> {1,2,8,6,7,3,4,9,5 },
    new List<int> {3,4,9,5,2,1,8,7,6 },
    new List<int> {9,1,5,3,4,2,6,8,7 },
    new List<int> {4,3,6,7,5,8,2,1,9 },
    new List<int> {7,8,2,1,6,9,5,4,3 },
    new List<int> {8,7,3,2,1,6,9,5,4 },
    new List<int> {2,9,1,4,3,5,7,6,8 },
    new List<int> {6,5,4,9,8,7,3,2,1 }
},
new List<List<int>> {
    new List<int> {6,4,8,1,2,9,7,5,3 },
    new List<int> {1,7,5,8,3,4,9,6,2 },
    new List<int> {3,2,9,5,6,7,1,8,4 },
    new List<int> {4,5,6,7,1,2,3,9,8 },
    new List<int> {9,8,7,4,5,3,2,1,6 },
    new List<int> {2,1,3,6,9,8,5,4,7 },
    new List<int> {7,6,1,2,8,5,4,3,9 },
    new List<int> {8,9,2,3,4,1,6,7,5 },
    new List<int> {5,3,4,9,7,6,8,2,1 }
},
new List<List<int>> {
    new List<int> {6,5,8,7,1,2,3,4,9 },
    new List<int> {1,2,7,4,9,3,8,6,5 },
    new List<int> {3,4,9,8,5,6,7,2,1 },
    new List<int> {5,1,4,6,2,7,9,8,3 },
    new List<int> {9,3,6,5,8,4,2,1,7 },
    new List<int> {7,8,2,1,3,9,6,5,4 },
    new List<int> {2,7,1,3,4,8,5,9,6 },
    new List<int> {4,9,3,2,6,5,1,7,8 },
    new List<int> {8,6,5,9,7,1,4,3,2 }
},
new List<List<int>> {
    new List<int> {3,5,7,6,4,2,8,9,1 },
    new List<int> {4,6,9,5,1,8,2,7,3 },
    new List<int> {1,2,8,9,3,7,6,4,5 },
    new List<int> {6,1,3,4,2,5,9,8,7 },
    new List<int> {2,9,4,7,8,1,3,5,6 },
    new List<int> {7,8,5,3,6,9,4,1,2 },
    new List<int> {8,7,2,1,9,6,5,3,4 },
    new List<int> {9,3,1,2,5,4,7,6,8 },
    new List<int> {5,4,6,8,7,3,1,2,9 }
},
new List<List<int>> {
    new List<int> {6,3,4,1,5,9,8,7,2 },
    new List<int> {9,7,5,3,8,2,1,6,4 },
    new List<int> {8,1,2,6,7,4,3,5,9 },
    new List<int> {3,2,1,7,4,5,6,9,8 },
    new List<int> {4,8,6,9,3,1,5,2,7 },
    new List<int> {7,5,9,2,6,8,4,3,1 },
    new List<int> {1,6,7,4,2,3,9,8,5 },
    new List<int> {2,9,8,5,1,6,7,4,3 },
    new List<int> {5,4,3,8,9,7,2,1,6 }
},
new List<List<int>> {
    new List<int> {1,5,8,4,2,7,6,3,9 },
    new List<int> {4,7,3,6,5,9,8,1,2 },
    new List<int> {9,6,2,1,3,8,7,4,5 },
    new List<int> {8,2,1,3,9,5,4,6,7 },
    new List<int> {3,4,5,2,7,6,9,8,1 },
    new List<int> {7,9,6,8,4,1,5,2,3 },
    new List<int> {2,1,9,7,8,4,3,5,6 },
    new List<int> {5,3,4,9,6,2,1,7,8 },
    new List<int> {6,8,7,5,1,3,2,9,4 }
},
new List<List<int>> {
    new List<int> {1,4,7,5,3,2,8,6,9 },
    new List<int> {3,5,8,4,9,6,7,1,2 },
    new List<int> {9,6,2,1,8,7,5,3,4 },
    new List<int> {7,9,1,2,6,4,3,8,5 },
    new List<int> {2,3,6,8,7,5,9,4,1 },
    new List<int> {5,8,4,3,1,9,6,2,7 },
    new List<int> {6,1,9,7,4,3,2,5,8 },
    new List<int> {8,2,3,9,5,1,4,7,6 },
    new List<int> {4,7,5,6,2,8,1,9,3 }
},
new List<List<int>> {
    new List<int> {1,2,3,6,8,7,9,4,5 },
    new List<int> {4,8,7,2,5,9,3,1,6 },
    new List<int> {5,9,6,3,1,4,2,7,8 },
    new List<int> {8,7,1,4,3,5,6,2,9 },
    new List<int> {9,4,2,1,6,8,7,5,3 },
    new List<int> {3,6,5,7,9,2,4,8,1 },
    new List<int> {2,1,9,8,4,3,5,6,7 },
    new List<int> {6,3,4,5,7,1,8,9,2 },
    new List<int> {7,5,8,9,2,6,1,3,4 }
},
new List<List<int>> {
    new List<int> {6,7,2,1,3,8,9,4,5 },
    new List<int> {1,8,9,5,4,2,7,3,6 },
    new List<int> {3,4,5,7,9,6,8,1,2 },
    new List<int> {4,6,8,9,5,7,1,2,3 },
    new List<int> {7,2,1,4,6,3,5,8,9 },
    new List<int> {5,9,3,2,8,1,4,6,7 },
    new List<int> {9,3,4,6,1,5,2,7,8 },
    new List<int> {2,5,6,8,7,4,3,9,1 },
    new List<int> {8,1,7,3,2,9,6,5,4 }
},
new List<List<int>> {
    new List<int> {6,8,4,2,3,5,7,9,1 },
    new List<int> {2,1,5,4,9,7,8,3,6 },
    new List<int> {3,9,7,6,8,1,4,5,2 },
    new List<int> {1,7,8,3,2,4,9,6,5 },
    new List<int> {9,2,3,5,7,6,1,8,4 },
    new List<int> {4,5,6,8,1,9,3,2,7 },
    new List<int> {5,6,9,7,4,3,2,1,8 },
    new List<int> {7,3,2,1,6,8,5,4,9 },
    new List<int> {8,4,1,9,5,2,6,7,3 }
},
new List<List<int>> {
    new List<int> {7,3,4,5,9,1,2,6,8 },
    new List<int> {6,9,8,7,3,2,4,1,5 },
    new List<int> {5,2,1,8,6,4,3,9,7 },
    new List<int> {2,1,3,9,4,5,7,8,6 },
    new List<int> {4,5,6,2,8,7,1,3,9 },
    new List<int> {8,7,9,6,1,3,5,4,2 },
    new List<int> {3,6,5,4,7,8,9,2,1 },
    new List<int> {1,8,7,3,2,9,6,5,4 },
    new List<int> {9,4,2,1,5,6,8,7,3 }
},
new List<List<int>> {
    new List<int> {8,6,2,3,1,9,5,4,7 },
    new List<int> {4,9,7,2,6,5,3,8,1 },
    new List<int> {5,1,3,4,7,8,6,9,2 },
    new List<int> {1,2,9,5,3,4,8,7,6 },
    new List<int> {3,7,8,1,2,6,4,5,9 },
    new List<int> {6,5,4,9,8,7,1,2,3 },
    new List<int> {2,4,5,6,9,1,7,3,8 },
    new List<int> {9,8,6,7,5,3,2,1,4 },
    new List<int> {7,3,1,8,4,2,9,6,5 }
},
new List<List<int>> {
    new List<int> {3,2,6,8,4,9,1,5,7 },
    new List<int> {5,8,1,2,7,3,6,4,9 },
    new List<int> {9,4,7,5,6,1,2,8,3 },
    new List<int> {2,1,9,4,3,5,8,7,6 },
    new List<int> {4,3,5,7,8,6,9,1,2 },
    new List<int> {7,6,8,9,1,2,5,3,4 },
    new List<int> {8,5,3,6,9,7,4,2,1 },
    new List<int> {1,9,4,3,2,8,7,6,5 },
    new List<int> {6,7,2,1,5,4,3,9,8 }
},
new List<List<int>> {
    new List<int> {8,1,2,9,5,7,3,4,6 },
    new List<int> {9,4,3,1,8,6,5,2,7 },
    new List<int> {5,7,6,3,4,2,9,8,1 },
    new List<int> {6,8,1,2,7,3,4,9,5 },
    new List<int> {2,3,4,6,9,5,1,7,8 },
    new List<int> {7,5,9,8,1,4,6,3,2 },
    new List<int> {3,6,7,5,2,9,8,1,4 },
    new List<int> {4,9,8,7,6,1,2,5,3 },
    new List<int> {1,2,5,4,3,8,7,6,9 }
},
new List<List<int>> {
    new List<int> {3,2,4,8,1,5,6,9,7 },
    new List<int> {7,8,5,9,6,4,3,2,1 },
    new List<int> {1,6,9,3,2,7,8,5,4 },
    new List<int> {2,9,3,4,8,1,5,7,6 },
    new List<int> {5,4,7,6,3,2,1,8,9 },
    new List<int> {8,1,6,5,7,9,2,4,3 },
    new List<int> {6,7,2,1,9,8,4,3,5 },
    new List<int> {9,5,1,2,4,3,7,6,8 },
    new List<int> {4,3,8,7,5,6,9,1,2 }
},
new List<List<int>> {
    new List<int> {7,2,3,9,5,1,8,4,6 },
    new List<int> {5,4,9,8,7,6,3,2,1 },
    new List<int> {1,8,6,4,2,3,9,7,5 },
    new List<int> {2,9,4,3,1,8,5,6,7 },
    new List<int> {3,1,5,6,9,7,4,8,2 },
    new List<int> {8,6,7,5,4,2,1,9,3 },
    new List<int> {6,5,2,1,8,9,7,3,4 },
    new List<int> {9,7,1,2,3,4,6,5,8 },
    new List<int> {4,3,8,7,6,5,2,1,9 }
},
new List<List<int>> {
    new List<int> {7,5,4,3,8,9,1,6,2 },
    new List<int> {2,9,6,4,1,7,3,5,8 },
    new List<int> {3,1,8,6,5,2,7,9,4 },
    new List<int> {1,8,7,2,3,6,5,4,9 },
    new List<int> {4,2,3,8,9,5,6,1,7 },
    new List<int> {5,6,9,7,4,1,2,8,3 },
    new List<int> {8,7,5,9,6,3,4,2,1 },
    new List<int> {6,4,2,1,7,8,9,3,5 },
    new List<int> {9,3,1,5,2,4,8,7,6 }
},
new List<List<int>> {
    new List<int> {8,5,3,4,9,2,1,6,7 },
    new List<int> {9,7,4,6,5,1,2,8,3 },
    new List<int> {1,2,6,8,7,3,4,9,5 },
    new List<int> {2,1,7,9,3,6,8,5,4 },
    new List<int> {3,4,9,5,1,8,7,2,6 },
    new List<int> {5,6,8,7,2,4,9,3,1 },
    new List<int> {4,8,5,1,6,9,3,7,2 },
    new List<int> {6,3,1,2,8,7,5,4,9 },
    new List<int> {7,9,2,3,4,5,6,1,8 }
},
new List<List<int>> {
    new List<int> {2,1,3,5,8,9,7,6,4 },
    new List<int> {9,6,4,2,7,3,8,1,5 },
    new List<int> {7,8,5,4,6,1,2,9,3 },
    new List<int> {1,2,9,3,4,8,6,5,7 },
    new List<int> {3,4,6,7,2,5,1,8,9 },
    new List<int> {5,7,8,9,1,6,4,3,2 },
    new List<int> {6,5,7,8,9,4,3,2,1 },
    new List<int> {8,9,2,1,3,7,5,4,6 },
    new List<int> {4,3,1,6,5,2,9,7,8 }
},
new List<List<int>> {
    new List<int> {8,1,3,5,2,6,4,9,7 },
    new List<int> {2,4,5,7,9,1,6,3,8 },
    new List<int> {7,9,6,3,4,8,5,2,1 },
    new List<int> {1,8,7,2,3,4,9,6,5 },
    new List<int> {6,3,2,1,5,9,7,8,4 },
    new List<int> {9,5,4,8,6,7,3,1,2 },
    new List<int> {4,6,8,9,7,2,1,5,3 },
    new List<int> {5,7,1,6,8,3,2,4,9 },
    new List<int> {3,2,9,4,1,5,8,7,6 }
},
new List<List<int>> {
    new List<int> {6,9,5,4,8,2,7,3,1 },
    new List<int> {3,4,8,7,9,1,6,5,2 },
    new List<int> {1,2,7,6,5,3,4,8,9 },
    new List<int> {2,1,3,9,6,4,8,7,5 },
    new List<int> {5,6,4,2,7,8,1,9,3 },
    new List<int> {8,7,9,3,1,5,2,6,4 },
    new List<int> {7,5,1,8,4,9,3,2,6 },
    new List<int> {9,8,2,1,3,6,5,4,7 },
    new List<int> {4,3,6,5,2,7,9,1,8 }
},
new List<List<int>> {
    new List<int> {1,3,4,6,9,2,8,5,7 },
    new List<int> {2,5,6,8,7,1,3,9,4 },
    new List<int> {7,8,9,4,5,3,1,6,2 },
    new List<int> {3,1,2,9,8,4,6,7,5 },
    new List<int> {4,7,5,1,2,6,9,3,8 },
    new List<int> {6,9,8,5,3,7,4,2,1 },
    new List<int> {5,4,3,7,6,8,2,1,9 },
    new List<int> {8,6,7,2,1,9,5,4,3 },
    new List<int> {9,2,1,3,4,5,7,8,6 }
},
new List<List<int>> {
    new List<int> {9,8,4,2,3,1,6,5,7 },
    new List<int> {2,1,6,7,9,5,3,4,8 },
    new List<int> {3,7,5,4,6,8,2,9,1 },
    new List<int> {1,9,8,3,2,4,7,6,5 },
    new List<int> {6,2,3,5,1,7,9,8,4 },
    new List<int> {5,4,7,6,8,9,1,2,3 },
    new List<int> {7,6,9,8,4,3,5,1,2 },
    new List<int> {8,5,2,1,7,6,4,3,9 },
    new List<int> {4,3,1,9,5,2,8,7,6 }
},
new List<List<int>> {
    new List<int> {7,2,1,3,8,4,5,6,9 },
    new List<int> {5,4,3,6,9,2,1,8,7 },
    new List<int> {8,6,9,7,1,5,4,2,3 },
    new List<int> {1,8,6,9,7,3,2,4,5 },
    new List<int> {4,3,2,5,6,8,9,7,1 },
    new List<int> {9,7,5,2,4,1,8,3,6 },
    new List<int> {6,5,8,4,3,9,7,1,2 },
    new List<int> {2,1,7,8,5,6,3,9,4 },
    new List<int> {3,9,4,1,2,7,6,5,8 }
},
new List<List<int>> {
    new List<int> {4,3,2,1,8,9,6,5,7 },
    new List<int> {8,7,5,4,3,6,2,1,9 },
    new List<int> {6,9,1,2,7,5,3,4,8 },
    new List<int> {1,2,3,9,5,4,8,7,6 },
    new List<int> {9,4,8,7,6,2,5,3,1 },
    new List<int> {7,5,6,3,1,8,9,2,4 },
    new List<int> {5,8,7,6,2,1,4,9,3 },
    new List<int> {2,1,9,8,4,3,7,6,5 },
    new List<int> {3,6,4,5,9,7,1,8,2 }
},
new List<List<int>> {
    new List<int> {1,2,3,4,6,7,9,8,5 },
    new List<int> {4,5,6,8,3,9,1,2,7 },
    new List<int> {9,8,7,5,2,1,4,3,6 },
    new List<int> {2,3,4,6,5,8,7,9,1 },
    new List<int> {5,9,1,7,4,3,8,6,2 },
    new List<int> {7,6,8,1,9,2,5,4,3 },
    new List<int> {6,7,9,2,8,5,3,1,4 },
    new List<int> {8,1,2,3,7,4,6,5,9 },
    new List<int> {3,4,5,9,1,6,2,7,8 }
},
new List<List<int>> {
    new List<int> {1,5,2,4,3,8,7,6,9 },
    new List<int> {8,9,4,6,7,5,2,1,3 },
    new List<int> {6,7,3,1,2,9,8,4,5 },
    new List<int> {7,3,1,9,5,4,6,8,2 },
    new List<int> {2,4,6,7,8,3,5,9,1 },
    new List<int> {5,8,9,2,1,6,4,3,7 },
    new List<int> {9,1,7,8,6,2,3,5,4 },
    new List<int> {3,2,8,5,4,1,9,7,6 },
    new List<int> {4,6,5,3,9,7,1,2,8 }
},
new List<List<int>> {
    new List<int> {8,5,2,6,7,9,4,3,1 },
    new List<int> {4,9,6,1,2,3,7,5,8 },
    new List<int> {1,3,7,8,4,5,2,9,6 },
    new List<int> {2,1,9,4,3,6,5,8,7 },
    new List<int> {6,7,4,5,1,8,3,2,9 },
    new List<int> {3,8,5,7,9,2,1,6,4 },
    new List<int> {9,2,1,3,6,7,8,4,5 },
    new List<int> {5,4,3,9,8,1,6,7,2 },
    new List<int> {7,6,8,2,5,4,9,1,3 }
},
new List<List<int>> {
    new List<int> {3,2,4,5,6,9,7,8,1 },
    new List<int> {9,7,5,8,1,2,6,4,3 },
    new List<int> {1,6,8,7,4,3,2,9,5 },
    new List<int> {8,1,3,4,2,5,9,7,6 },
    new List<int> {2,5,6,9,7,1,4,3,8 },
    new List<int> {7,4,9,3,8,6,5,1,2 },
    new List<int> {6,9,2,1,3,7,8,5,4 },
    new List<int> {5,8,1,2,9,4,3,6,7 },
    new List<int> {4,3,7,6,5,8,1,2,9 }
},
new List<List<int>> {
    new List<int> {6,5,1,3,8,4,2,7,9 },
    new List<int> {7,3,2,1,9,6,8,4,5 },
    new List<int> {8,9,4,2,5,7,6,1,3 },
    new List<int> {4,2,3,5,6,1,7,9,8 },
    new List<int> {9,6,5,7,4,8,3,2,1 },
    new List<int> {1,7,8,9,3,2,5,6,4 },
    new List<int> {2,1,9,8,7,3,4,5,6 },
    new List<int> {3,4,7,6,1,5,9,8,2 },
    new List<int> {5,8,6,4,2,9,1,3,7 }
},
new List<List<int>> {
    new List<int> {1,2,3,7,9,8,4,5,6 },
    new List<int> {8,5,9,6,3,4,1,2,7 },
    new List<int> {7,6,4,2,5,1,3,8,9 },
    new List<int> {5,1,6,3,4,7,8,9,2 },
    new List<int> {9,4,2,1,8,5,6,7,3 },
    new List<int> {3,7,8,9,6,2,5,1,4 },
    new List<int> {2,8,7,4,1,3,9,6,5 },
    new List<int> {4,9,1,5,2,6,7,3,8 },
    new List<int> {6,3,5,8,7,9,2,4,1 }
},
new List<List<int>> {
    new List<int> {7,5,8,6,3,4,2,1,9 },
    new List<int> {9,6,1,2,5,8,4,3,7 },
    new List<int> {4,2,3,9,7,1,6,5,8 },
    new List<int> {1,4,2,5,6,7,9,8,3 },
    new List<int> {3,7,5,4,8,9,1,6,2 },
    new List<int> {8,9,6,3,1,2,7,4,5 },
    new List<int> {2,1,7,8,4,3,5,9,6 },
    new List<int> {5,3,9,1,2,6,8,7,4 },
    new List<int> {6,8,4,7,9,5,3,2,1 }
},
new List<List<int>> {
    new List<int> {8,3,1,4,6,2,7,9,5 },
    new List<int> {9,4,6,8,5,7,3,1,2 },
    new List<int> {5,7,2,1,3,9,6,8,4 },
    new List<int> {1,9,3,2,8,4,5,6,7 },
    new List<int> {4,2,5,7,1,6,9,3,8 },
    new List<int> {7,6,8,3,9,5,2,4,1 },
    new List<int> {6,8,7,9,2,1,4,5,3 },
    new List<int> {2,1,9,5,4,3,8,7,6 },
    new List<int> {3,5,4,6,7,8,1,2,9 }
},
new List<List<int>> {
    new List<int> {4,7,5,9,6,1,8,2,3 },
    new List<int> {6,3,2,7,8,5,9,4,1 },
    new List<int> {1,9,8,3,2,4,6,7,5 },
    new List<int> {2,1,9,4,3,7,5,6,8 },
    new List<int> {3,5,4,6,1,8,7,9,2 },
    new List<int> {8,6,7,5,9,2,3,1,4 },
    new List<int> {7,2,1,8,5,9,4,3,6 },
    new List<int> {9,8,3,1,4,6,2,5,7 },
    new List<int> {5,4,6,2,7,3,1,8,9 }
},
new List<List<int>> {
    new List<int> {3,2,9,8,5,7,6,1,4 },
    new List<int> {8,4,5,1,2,6,7,9,3 },
    new List<int> {1,7,6,4,3,9,8,5,2 },
    new List<int> {2,8,3,6,1,5,4,7,9 },
    new List<int> {5,1,4,7,9,2,3,8,6 },
    new List<int> {9,6,7,3,4,8,1,2,5 },
    new List<int> {7,9,1,5,6,4,2,3,8 },
    new List<int> {4,3,2,9,8,1,5,6,7 },
    new List<int> {6,5,8,2,7,3,9,4,1 }
},
new List<List<int>> {
    new List<int> {8,4,6,2,5,9,7,3,1 },
    new List<int> {5,7,1,4,3,6,8,2,9 },
    new List<int> {9,3,2,1,7,8,4,5,6 },
    new List<int> {6,1,3,9,2,4,5,7,8 },
    new List<int> {2,9,7,3,8,5,6,1,4 },
    new List<int> {4,8,5,7,6,1,2,9,3 },
    new List<int> {7,6,9,8,1,2,3,4,5 },
    new List<int> {1,2,8,5,4,3,9,6,7 },
    new List<int> {3,5,4,6,9,7,1,8,2 }
},
new List<List<int>> {
    new List<int> {9,5,4,8,6,7,1,2,3 },
    new List<int> {8,6,1,2,3,5,9,7,4 },
    new List<int> {3,2,7,9,1,4,5,8,6 },
    new List<int> {5,9,2,1,4,6,7,3,8 },
    new List<int> {7,4,6,3,8,9,2,5,1 },
    new List<int> {1,8,3,7,5,2,6,4,9 },
    new List<int> {2,1,8,6,7,3,4,9,5 },
    new List<int> {4,3,9,5,2,1,8,6,7 },
    new List<int> {6,7,5,4,9,8,3,1,2 }
},
new List<List<int>> {
    new List<int> {5,2,3,1,7,9,4,6,8 },
    new List<int> {8,7,4,6,5,2,9,1,3 },
    new List<int> {9,6,1,3,8,4,5,7,2 },
    new List<int> {2,1,9,8,4,3,7,5,6 },
    new List<int> {7,4,8,5,9,6,2,3,1 },
    new List<int> {3,5,6,2,1,7,8,4,9 },
    new List<int> {6,8,5,7,2,1,3,9,4 },
    new List<int> {1,9,7,4,3,8,6,2,5 },
    new List<int> {4,3,2,9,6,5,1,8,7 }
},
new List<List<int>> {
    new List<int> {8,5,3,1,9,6,2,7,4 },
    new List<int> {6,9,4,5,7,2,3,1,8 },
    new List<int> {1,2,7,8,4,3,5,9,6 },
    new List<int> {2,1,9,3,5,4,8,6,7 },
    new List<int> {3,4,5,6,8,7,1,2,9 },
    new List<int> {7,6,8,9,2,1,4,3,5 },
    new List<int> {5,8,6,2,1,9,7,4,3 },
    new List<int> {9,7,1,4,3,8,6,5,2 },
    new List<int> {4,3,2,7,6,5,9,8,1 }
},
new List<List<int>> {
    new List<int> {1,9,4,2,7,3,6,5,8 },
    new List<int> {8,5,3,4,9,6,7,1,2 },
    new List<int> {7,6,2,1,5,8,4,3,9 },
    new List<int> {9,3,1,8,2,4,5,7,6 },
    new List<int> {2,4,6,5,1,7,9,8,3 },
    new List<int> {5,7,8,6,3,9,2,4,1 },
    new List<int> {6,1,5,7,8,2,3,9,4 },
    new List<int> {3,2,7,9,4,1,8,6,5 },
    new List<int> {4,8,9,3,6,5,1,2,7 }
},
new List<List<int>> {
    new List<int> {8,5,2,4,1,6,9,7,3 },
    new List<int> {4,6,3,7,5,9,8,1,2 },
    new List<int> {1,7,9,2,3,8,6,4,5 },
    new List<int> {9,2,1,3,8,5,4,6,7 },
    new List<int> {3,4,5,1,6,7,2,9,8 },
    new List<int> {7,8,6,9,4,2,5,3,1 },
    new List<int> {2,1,8,6,7,4,3,5,9 },
    new List<int> {5,3,4,8,9,1,7,2,6 },
    new List<int> {6,9,7,5,2,3,1,8,4 }
},
new List<List<int>> {
    new List<int> {1,2,4,7,8,9,3,6,5 },
    new List<int> {8,5,6,4,3,1,2,7,9 },
    new List<int> {3,7,9,6,2,5,8,1,4 },
    new List<int> {9,1,2,3,7,8,4,5,6 },
    new List<int> {4,3,5,2,1,6,7,9,8 },
    new List<int> {7,6,8,9,5,4,1,3,2 },
    new List<int> {2,4,1,5,6,7,9,8,3 },
    new List<int> {5,9,7,8,4,3,6,2,1 },
    new List<int> {6,8,3,1,9,2,5,4,7 }
},
new List<List<int>> {
    new List<int> {6,3,4,8,9,5,7,1,2 },
    new List<int> {9,8,1,2,3,7,6,5,4 },
    new List<int> {2,5,7,6,4,1,8,9,3 },
    new List<int> {7,9,2,3,8,4,1,6,5 },
    new List<int> {4,1,3,5,7,6,2,8,9 },
    new List<int> {8,6,5,9,1,2,4,3,7 },
    new List<int> {1,2,8,4,5,3,9,7,6 },
    new List<int> {3,7,6,1,2,9,5,4,8 },
    new List<int> {5,4,9,7,6,8,3,2,1 }
},
new List<List<int>> {
    new List<int> {1,3,2,5,4,9,7,6,8 },
    new List<int> {9,4,6,3,7,8,1,5,2 },
    new List<int> {7,8,5,1,2,6,9,3,4 },
    new List<int> {8,9,1,2,3,7,5,4,6 },
    new List<int> {4,2,3,6,5,1,8,9,7 },
    new List<int> {6,5,7,9,8,4,2,1,3 },
    new List<int> {5,6,4,8,9,2,3,7,1 },
    new List<int> {2,1,9,7,6,3,4,8,5 },
    new List<int> {3,7,8,4,1,5,6,2,9 }
},
new List<List<int>> {
    new List<int> {7,5,1,3,2,8,6,9,4 },
    new List<int> {2,6,9,1,4,5,8,3,7 },
    new List<int> {3,4,8,6,9,7,5,2,1 },
    new List<int> {5,9,7,4,6,2,3,1,8 },
    new List<int> {8,1,2,9,5,3,7,4,6 },
    new List<int> {6,3,4,8,7,1,2,5,9 },
    new List<int> {9,2,3,7,8,4,1,6,5 },
    new List<int> {1,8,6,5,3,9,4,7,2 },
    new List<int> {4,7,5,2,1,6,9,8,3 }
},
new List<List<int>> {
    new List<int> {4,3,5,7,6,9,8,2,1 },
    new List<int> {8,9,6,1,2,3,5,7,4 },
    new List<int> {1,7,2,4,5,8,9,3,6 },
    new List<int> {2,1,3,5,4,6,7,8,9 },
    new List<int> {5,4,8,2,9,7,6,1,3 },
    new List<int> {9,6,7,3,8,1,2,4,5 },
    new List<int> {3,2,1,9,7,5,4,6,8 },
    new List<int> {6,5,4,8,3,2,1,9,7 },
    new List<int> {7,8,9,6,1,4,3,5,2 }
},
new List<List<int>> {
    new List<int> {1,4,2,9,3,5,7,8,6 },
    new List<int> {8,6,3,7,2,4,5,1,9 },
    new List<int> {7,5,9,1,6,8,2,3,4 },
    new List<int> {9,3,1,2,8,6,4,5,7 },
    new List<int> {4,2,5,3,7,9,8,6,1 },
    new List<int> {6,7,8,4,5,1,3,9,2 },
    new List<int> {5,8,7,6,9,2,1,4,3 },
    new List<int> {2,1,6,8,4,3,9,7,5 },
    new List<int> {3,9,4,5,1,7,6,2,8 }
},
new List<List<int>> {
    new List<int> {2,1,7,8,5,3,4,9,6 },
    new List<int> {9,3,5,7,6,4,2,1,8 },
    new List<int> {8,4,6,1,2,9,5,3,7 },
    new List<int> {6,5,2,4,9,8,3,7,1 },
    new List<int> {1,7,4,2,3,6,9,8,5 },
    new List<int> {3,9,8,5,7,1,6,4,2 },
    new List<int> {4,2,1,9,8,5,7,6,3 },
    new List<int> {5,6,9,3,1,7,8,2,4 },
    new List<int> {7,8,3,6,4,2,1,5,9 }
},
        };
    }
}