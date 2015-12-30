using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication.Interfaces
{
    public interface ProblemChangedListener
    {
        void onProblemChanged(ProblemToAlgorithm data);
    }
}
