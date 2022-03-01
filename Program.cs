using System;

namespace bubbleSort
{
    class Program
    {
        static int bubbleSort(int[] anArray){
            for(int i=0; i < anArray.Length-1; i++){
                for (int x=0; x<anArray.Length-i-1; x++){
                    if (anArray[x] > anArray[x+1]){
                        int t = anArray[x];
                        anArray[x] = anArray[x+1];
                        anArray[x+1] = t;
                    } 
                }
            }
            foreach (int x in anArray)
                Console.Write(x + "  ");
            Console.WriteLine();
            return 0;
        }

        static int bubbleSortStr(String[] anArray){
            for(int i=0; i < anArray.Length-1; i++){
                for (int x=0; x<anArray.Length-i-1; x++){
                    if (anArray[x].CompareTo(anArray[x + 1]) > 0){
                        string t = anArray[x];
                        anArray[x] = anArray[x+1];
                        anArray[x+1] = t;
                    } 
                }
            }
            foreach (string x in anArray)
                Console.Write(x + "  ");
            Console.WriteLine();
            return 0;
        }

        static void Main(string[] args)
        {
        int[] nums = {10, 70, 30, 100, 40, 45, 90, 80, 85};
        bubbleSort(nums);
        string[] words = {"dog","at", "good", "eye", "cat", "ball", "fish"};
        Console.WriteLine(bubbleSortStr(words));
        }

    }
}
