using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class TakeOrderService
    {
        private OICPenDbContext context;

        public TakeOrderService(OICPenDbContext context)
        {
            this.context = context;
        }

        public TakeOrder AddTakeOrder(int  clientId)
        {
            var takeOrder = context.TakeOrders.Add(new TakeOrder {ClientId = clientId, TakeOrdDate = DateTime.Now});
            context.SaveChanges();

            return takeOrder;
        }

        public List<TakeOrder> GetAllTakeOrders()
        {
            var query = from c in context.TakeOrders
                        orderby c.Id
                        select c;

            return query.ToList();
        }

        public async Task<List<TakeOrder>> GetAllTakeOrdersAsync()
        {
            var query = from c in context.TakeOrders
                        orderby c.Id
                        select c;
            return await query.ToListAsync();
        }
    }
}

