using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CensusManagement_System.ViewModels
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string NormalizedName { get; set; }
        public bool IsSelected { get; set; }
    }
}
