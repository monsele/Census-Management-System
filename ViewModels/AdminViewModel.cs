using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CensusManagement_System.ViewModels
{
    public class AdminViewModel
    {
        public int CensusCount { get; set; }
        public int CountState { get; set; }
        public int ThoseInTheCountry { get; set; }
        public int ThoseNotInCountry { get; set; }
        public int NumberOfStates { get; set; }
    }
}
