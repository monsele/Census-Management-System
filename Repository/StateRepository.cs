using CensusManagement_System.Data;
using CensusManagement_System.Models;
using CensusManagement_System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CensusManagement_System.Repository
{
    public class StateRepository : IState
    {
        private readonly ApplicationDbContext context;
        public StateRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Create(State state)
        {
            context.Set<State>().Add(state);
            context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var entity=context.Set<State>().Find(id);
            context.Set<State>().Remove(entity);
            context.SaveChanges();
        }

        public IQueryable<State> DropDownListt()
        {
            return context.Set<State>();
        }

        public State GetState(int? id)
        {
            var entity = context.Set<State>().Find(id);
            return entity;
        }

        public IEnumerable<State> GetStates()
        {
            return context.Set<State>().ToList();
        }

        public void Update(int? id, State state)
        {
            context.Entry<State>(context.Set<State>().FirstOrDefault(x => x.Id == id)).CurrentValues.SetValues(state);
            context.SaveChanges();
        }
    }
}
