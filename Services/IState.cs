using CensusManagement_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CensusManagement_System.Services
{
    public interface IState
    {
        void Create(State state);
        void Delete(int? id);
        IEnumerable<State> GetStates();
        State GetState(int? id);
        IQueryable<State> DropDownListt();
        void Update(int? id,State state);
        
    }
}
