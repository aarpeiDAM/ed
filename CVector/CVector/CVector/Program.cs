using System;

namespace CVector
{
    class Vector
    {
        public static void Main(string[] args)
        {
            int[] orderedArray = { 12, 13, 33, 36, 47, 52, 74,95};
            Console.WriteLine(BinarySearch(orderedArray,12));
  
        }
        public static int BinarySearch(int[] v, int x){
            int indexOfX = v.Length/2;
            if (v.Length == 0)
                return -1;
            for(int w = 0; w < v.Length; w++){
                if (v[indexOfX] == x)
                {
                    return indexOfX;

                }
                else if (v[indexOfX] < x)
                {
                    if (indexOfX / 2 == 0)
                        indexOfX += 1;
                    else
                        indexOfX += indexOfX / 2;
                }
                else
                {
                    if (indexOfX / 2 == 0)
                        indexOfX -= 1;
                    else
                        indexOfX -= indexOfX / 2;
                }
            }
            return -1;
        }

    }
}
