using CensusManagement_System.Data;
using CensusManagement_System.Models;
using CensusManagement_System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CensusManagement_System.Repository
{
    public class FeedBackRepository : IFeedBack
    {
        private readonly ApplicationDbContext context;
        public FeedBackRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Create(FeedBack feedback)
        {
            context.Set<FeedBack>().Add(feedback);
            context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var entity = context.Set<FeedBack>().Find(id);
            context.Set<FeedBack>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<FeedBack> GetFeedBacks()
        {
            return context.Set<FeedBack>().ToList();
        }
    }
}
