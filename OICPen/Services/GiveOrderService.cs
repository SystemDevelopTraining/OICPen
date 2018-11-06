using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Services
{
    public class GiveOrderService
    {
        private OICPenDbContext context;

        public GiveOrderService(OICPenDbContext context)
        {
            this.context = context;
        }

        /*---------------------------------------------------------------
         [役割] 発注情報の追加
         [引数] g: 追加する発注情報
         [返り値] 追加した発注情報
         ---------------------------------------------------------------*/
        public GiveOrderT AddGiveOrderst(Models.GiveOrderT g)
        {
            var giveOrder = context.GiveOrders.Add(g);
            context.SaveChanges();

            return giveOrder;
        }

        /*---------------------------------------------------------------
         [役割] すべての発注情報をGiveOrder型のListにして返す
         [引数] なし
         [返り値] すべての発注情報
         ---------------------------------------------------------------*/
        public List<Models.GiveOrderT> GetGiveOrders()
        {
            var giveOrders = from c in context.GiveOrders
                        orderby c.Id
                        select c;

            return giveOrders.ToList();
        }

        /*---------------------------------------------------------------
         [役割] すべての発注情報をGiveOrder型のListにして返す
         [引数] なし
         [返り値] すべての発注情報
         ---------------------------------------------------------------*/

        public void InComining(Models.GiveOrderT g)
        {
            var giveOrder = context.GiveOrders.Single(x => x.Id == g.Id);
            giveOrder.CompleteDate = DateTime.Now;
        }
    }
}
