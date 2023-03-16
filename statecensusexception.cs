using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    public class statecensusexception : Exception
    {
        public statecensusexception(string message) : base(message) { }

    }
}
