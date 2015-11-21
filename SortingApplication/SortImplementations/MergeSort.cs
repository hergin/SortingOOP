using SortingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class MergeSort : SortImplementations.AbstractAlgorithm
    {

        public MergeSort()
        {
            algoParams["Param1"] = "5";
            algoParams["Param2"] = "paramVal";
        }

        public override string getName()
        {
            return "Merge Sort";
        }

        public override List<int> sort(ProblemToAlgorithm data)
        {
            int[] arrayEquivalent = data.getData().ToArray<int>();

            for (int i = 0; i < arrayEquivalent.Length; i++)
            {
                for (int j = i + 1; j < arrayEquivalent.Length; j++)
                {
                    if (arrayEquivalent[j] > arrayEquivalent[i])
                    {
                        if (numberSwapListener != null)
                            numberSwapListener.onNumberSwapped(j, i);

                        //swap with temp
                        //int temp = arrayEquivalent[j];
                        //arrayEquivalent[j] = arrayEquivalent[i];
                        //arrayEquivalent[i] = temp;

                        //swap without temp
                        arrayEquivalent[j] = arrayEquivalent[j] ^ arrayEquivalent[i];
                        arrayEquivalent[i] = arrayEquivalent[j] ^ arrayEquivalent[i];
                        arrayEquivalent[j] = arrayEquivalent[j] ^ arrayEquivalent[i];
                    }
                }
            }
            //Array.Sort(arrayEquivalent);
            return new List<int>(arrayEquivalent);
        }
        
    }
}
