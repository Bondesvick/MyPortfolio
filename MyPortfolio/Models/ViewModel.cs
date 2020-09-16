using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class ViewModel
    {
        public MyDetails MyDetails { get; set; }
        public List<Client> Clients { get; set; }
    }
}