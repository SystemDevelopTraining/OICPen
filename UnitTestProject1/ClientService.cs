using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class ClientService
    {
        private OICPenDbContext context;

        public ClientService(OICPenDbContext context)
        {
            this.context = context;
        }

        public Client AddClient(int id, string name, string hurigana, string address, string postNum, string phoneNum)
        {
            var client = context.Clients.Add(new Client {Name = name, Hurigana = hurigana, Address = address, PostNum = postNum, PhoneNum = phoneNum });
            context.SaveChanges();

            return client;
        }

        public List<Client> GetAllClients()
        {
            var query = from c in context.Clients
                        orderby c.Id
                        select c;

            return query.ToList();
        }

        public async Task<List<Client>> GetAllClientsAsync()
        {
            var query = from c in context.Clients
                        orderby c.Name
                        select c;
            return await query.ToListAsync();
        }
    }
}
