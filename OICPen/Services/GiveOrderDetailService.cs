using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Services
{
    class GiveOrderDetailService
    {
        private OICPenDbContext context;

        public GiveOrderDetailService(OICPenDbContext context)
        {
            this.context = context;
        }


        /*---------------------------------------------------------------
         [役割] 発注明細の登録
         [引数] item: 登録する商品
                quantity: 数量
                order: 登録したい注文
         [返り値] なし
         ---------------------------------------------------------------*/
        public void AddTakeOrderDetail(ItemT item, int quantity, Models.GiveOrderT order)
        {
            var orderDetails = new GiveOrderDetailT { Itemid = item.Id, Quantity = (uint)quantity, GiveOrderId = order.Id };
            context.SaveChanges();
        }

    }
}
