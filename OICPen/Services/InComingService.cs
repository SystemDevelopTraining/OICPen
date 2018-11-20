using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Services
{
    class InComingService
    {
        private OICPenDbContext context;

        public InComingService(OICPenDbContext context)
        {
            this.context = context;
        }

        //未入庫をすべて返す
        public List<GiveOrderT> GetNotYetInComing()
        {
            var orders = from i in context.GiveOrders
                         orderby i.GiveOrdDate
                         where i.CompleteDate == null
                         select i;

            return orders.ToList();
        }

        //入庫済みをすべて返す
        public List<GiveOrderT> GetAlreadyInComming()
        {
            var orders = from i in context.GiveOrders
                         orderby i.CompleteDate
                         where i.CompleteDate != null
                         select i;

            return orders.ToList();
        }

        //発注IDで検索
        public GiveOrderT SearchByGiveOrderId(int id)
        {
            return context.GiveOrders.Single(x => x.GiveOrderTID == id) ;
        }

        //入庫日を設定する
        public void InComining(Models.GiveOrderT g)
        {
            var giveOrder = context.GiveOrders.Single(x => x.GiveOrderTID == g.GiveOrderTID);
            giveOrder.CompleteDate = DateTime.Now;
            context.SaveChanges();
        }

        //入庫を取り消す
        public void CancelInComming(GiveOrderT g)
        {
            var order = context.GiveOrders.Single(x => x.GiveOrderTID == g.GiveOrderTID);
            order.CompleteDate = null;
            context.SaveChanges();
        }
        
    }
}
