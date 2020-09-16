using System.Collections.Generic;
using MyPortfolio.Models;

namespace MyPortfolio.Repository
{
    public class General : IGeneralRepo
    {
        public MyDetails MyDetails { get; set; }
        public List<Client> Clients { get; set; }
    }
}