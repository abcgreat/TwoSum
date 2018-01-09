using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenArray = { 2, 7, 11, 15 };
            int[] arrayTwoValues = new int[2];

            //arrayTwoValues = GetIndices(givenArray, 9);

            //arrayTwoValues = GetIndices(givenArray, 18);


            arrayTwoValues = GetIndicesWithDictionary(givenArray, 18);

            Console.Write(arrayTwoValues[0]);
            Console.Write(", ");
            Console.Write(arrayTwoValues[1]);
            Console.ReadKey();


        }


        public static int[] GetIndicesWithDictionary(int[] givenArray, int target)
        {
            IDictionary<int, int> h = new Dictionary<int, int>();

            int[] arrayTwoValues = new int[2];


            if (givenArray.Length >= 2)
            {
                for (int i = 0; i < givenArray.Length; i++)
                {
                    //Console.Write(i);
                    //Console.Write(", ");
                    //Console.Write(givenArray[i]);
                    //Console.Write(", ");
                    //Console.Write(target - givenArray[i]);
                    //Console.Write("; ");

                    //Console.Write("count: ");
                    //Console.Write(h.Count + "; ");
                    //Console.Write(h.ContainsKey(target - givenArray[i]) + "; ");
                    if (h.Count > 0 && h.ContainsKey(target - givenArray[i]))
                    {
                        //Console.Write(i);
                        //Console.Write(", ");
                        //Console.Write(givenArray[i]);
                        //Console.Write(", ");
                        //Console.Write(target - givenArray[i]);
                        //Console.Write("; ");

                        Console.Write(h[target - givenArray[i]] + "; ");
                        Console.Write(i + "; ");

                        Console.ReadKey();



                        //int[] k = { h.(target - givenArray[i]).Key, i + 1 };
                        //return k;
                    }

                    //h.Add(i, givenArray[i]);
                    h.Add(givenArray[i], i);
                }

                Console.ReadKey();
            }

            int[] y = { -1, -1 };
            return y;

            //dict.Add(1, "One");
            //dict.Add(2, "Two");
            //dict.Add(3, "Three");
            //dict.Contains
            //foreach (KeyValuePair<int, string> item in dict)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            //}

            //foreach(string value in dict.Values)
            //{
            //    Console.WriteLine(value);
            //}



            //for (int i = 0; i < givenArray.Length - 1; i++)
            //{
            //    for (int j = 1; j < givenArray.Length; j++)
            //    {
            //        if (i != j)
            //        {
            //            if (givenArray[i] + givenArray[j] == targetNum)
            //            {
            //                arrayTwoValues[0] = i;
            //                arrayTwoValues[1] = j;
            //                return arrayTwoValues;
            //            }
            //        }
            //    }
            //}

            //return arrayTwoValues;
        }

        public static int[] GetIndices(int [] givenArray, int targetNum)
        {
            int[] arrayTwoValues = new int[2];

            for (int i = 0; i < givenArray.Length - 1; i++)
            {
                for (int j = 1; j < givenArray.Length; j++)
                {
                    if (i != j)
                    {
                        if (givenArray[i] + givenArray[j] == targetNum)
                        {
                            arrayTwoValues[0] = i;
                            arrayTwoValues[1] = j;
                            return arrayTwoValues;
                        }
                    }
                }
            }

            return arrayTwoValues;
        }
    }
}
