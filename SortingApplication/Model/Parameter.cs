using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication.Model
{
    public class Parameter
    {

        Object value;
        List<Object> possibleValues;
        Object defaultValue;
        string ID;

        public Parameter(string id, Object val, List<Object> possibleVal, Object defVal)
        {
            this.ID = id;
            this.value = val;
            this.possibleValues = possibleVal;
            this.defaultValue = defVal;
        }

        public string getID()
        {
            return ID;
        }

        public Object getValue()
        {
            return value;
        }

        public Object getDefaultValue()
        {
            return defaultValue;
        }

        public List<Object> getPossibleValues()
        {
            return possibleValues;
        }

        public void setValue(Object val)
        {
            this.value = val;
        }

    }
}
