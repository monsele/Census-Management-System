using CensusManagement_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CensusManagement_System.Services
{
    public interface IFeedBack
    {
        void Create(FeedBack feedback);
        void Delete(int? id);
        IEnumerable<FeedBack> GetFeedBacks();
    }
}
