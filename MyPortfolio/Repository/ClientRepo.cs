using System.Collections.Generic;
using MyPortfolio.Models;

namespace MyPortfolio.Repository
{
    public class ClientRepo : IClientRepo
    {
        public List<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client(){Name = "Olisa Nwike", Brief = "Excellent design, great communication, fast turnaround of revisions. I had a clear vision of what I wanted. Ranaroy did not just deliver it he a improved upon it substantially. Recommended!"},
                new Client(){Name = "Chioma Nwike", Brief = "Commendable design, great communication, fast turnaround of revisions. I had a clear vision of what I wanted. Ranaroy did not just deliver it he a improved upon it substantially. Recommended!"},
                new Client(){Name = "Vincent Nwike", Brief = "Outstanding design, great communication, fast turnaround of revisions. I had a clear vision of what I wanted. Ranaroy did not just deliver it he a improved upon it substantially. Recommended!"}
            };
        }
    }
}