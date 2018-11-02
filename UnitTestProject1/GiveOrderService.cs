using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class GiveOrderService
    {
        private OICPenDbContext context;

        public GiveOrderService(OICPenDbContext context)
        {
            this.context = context;
        }

        /*---------------------------------------------------------------
         AddGiveOrder(発注の追加)
         引数 staffId: 発注する担当社員のID. int型
         返り値 giveOrder: 追加した情報. GiveOrder型
         ---------------------------------------------------------------*/
        public GiveOrder AddGiveOrderst(int staffId)
        {
            var giveOrder = context.GiveOrders.Add(new GiveOrder { StaffId = staffId, GiveOrdDate = DateTime.Now});
            context.SaveChanges();

            return giveOrder;
        }

        /*---------------------------------------------------------------
         GetAllGiveOrders(すべての発注の表示)
         引数 なし
         返り値 query.ToList(): すべての発注情報. List型
         ---------------------------------------------------------------*/
        public List<GiveOrder> GetAllGiveOrders()
        {
            var query = from c in context.GiveOrders
                        orderby c.Id
                        select c;

            return query.ToList();
        }

        /*---------------------------------------------------------------
         
         ---------------------------------------------------------------*/
    }
}
