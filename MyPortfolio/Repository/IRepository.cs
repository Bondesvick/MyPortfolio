using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPortfolio.Models;

namespace MyPortfolio.Repository
{
    public interface IRepository
    {
        public MyDetails GetAllData();
    }
}