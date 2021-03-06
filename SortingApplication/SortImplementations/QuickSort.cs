﻿using SortingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class QuickSort : SortImplementations.AbstractAlgorithm
    {
   
        public QuickSort()
        {
            algoParams["Param1"] = new Model.Parameter("Param1", 5, new List<Object>() { 1, 2, 3, 4, 5 }, 3, Model.ParameterType.ComboBox);
            algoParams["Param2"] = new Model.Parameter("Param2", true, new List<Object>() { true, false }, true, Model.ParameterType.CheckBox);
            algoParams["sliderParam"] = new Model.Parameter("sliderParam", 15, new List<Object>() { 10, 20 }, 10, Model.ParameterType.Slider);
        }

        public override string getName()
        {
            return "Quick Sort";
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
