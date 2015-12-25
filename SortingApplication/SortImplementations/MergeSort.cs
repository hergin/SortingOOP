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
            algoParams["Pivot"] = new Model.Parameter("Pivot", "middle", null, "middle");
            algoParams["Speed"] = new Model.Parameter("Speed", "fast", new List<Object>() { "fast", "middle", "slow" }, "middle");
            algoParams["greeting"] = new Model.Parameter("greeting", "hi", null, "hi");
            algoParams["mac value"] = new Model.Parameter("mac value", 3.4, new List<Object> { 1.0, 2.0, 3.4, 3.6, 4.0, 5.0 }, 5.0);
            algoParams["Param2"] = new Model.Parameter("Param2", true, new List<Object>() { true, false }, true);
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
