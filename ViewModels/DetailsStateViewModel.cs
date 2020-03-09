using CensusManagement_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CensusManagement_System.ViewModels
{
    public class DetailsStateViewModel
    {
        public State State { get; set; }
        public int? StateId { get; set; }
        public int NumberOfCitezens { get; set; }

    }
}
