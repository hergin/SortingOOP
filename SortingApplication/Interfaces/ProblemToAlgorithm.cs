using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication.Interfaces
{
    /*
        I had to make this a class, since C# doesn't
        let anonymous classes to implement an interface,
        furthermore it doesn't let anonymous classes.
    */
    public class ProblemToAlgorithm
    {
        List<Tuple<String,int>> data;

        public ProblemToAlgorithm(List<Tuple<String, int>> l)
        {
            data = l;
        }

        public List<Tuple<String, int>> getData()
        {
            return data;
        }

      
        override public String ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Tuple<String,int> t in data)
            {
                if(t.Item1 != "")
                    sb.Append(t.Item1 + ":" + t.Item2 + ",");
                else
                    sb.Append(t.Item2 + ",");
            }

            return sb.ToString();
        }
    }
}
