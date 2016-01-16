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
            algoParams["Pivot"] = new Model.Parameter("Pivot", "middle", null, "middle", Model.ParameterType.TextBox);
            algoParams["Speed"] = new Model.Parameter("Speed", "fast", new List<Object>() { "fast", "middle", "slow" }, "middle", Model.ParameterType.ComboBox);
            algoParams["greeting"] = new Model.Parameter("greeting", "hi", null, "hi", Model.ParameterType.TextBox);
            algoParams["mac value"] = new Model.Parameter("mac value", 3.4, new List<Object> { 1.0, 2.0, 3.4, 3.6, 4.0, 5.0 }, 5.0, Model.ParameterType.ComboBox);
            algoParams["Param2"] = new Model.Parameter("Param2", true, new List<Object>() { true, false }, true, Model.ParameterType.CheckBox);
        }

        public override string getName()
        {
            return "Merge Sort";
        }

        public override void sort(ProblemToAlgorithm data)
        {

            for (int i = 0; i < data.getData().Count; i++)
            {
                for (int j = i + 1; j < data.getData().Count; j++)
                {
                    if (data.getData()[j].Item2 > data.getData()[i].Item2)
                    {
                        if (numberSwapListener != null)
                            numberSwapListener.onNumberSwapped(j, i);

                        Tuple<String, int> temp = data.getData()[j];
                        data.getData().RemoveAt(j);
                        data.getData().Insert(j, data.getData()[i]);
                        data.getData().RemoveAt(i);
                        data.getData().Insert(i, temp);
                    }
                }
            }
        }
        
    }
}
