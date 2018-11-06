using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Services
{
    public class TakeOrderDetailService
    {
        private OICPenDbContext context;

        public TakeOrderDetailService(OICPenDbContext context)
        {
            this.context = context;
        }


        /*---------------------------------------------------------------
         [役割] 注文明細の登録
         [引数] item: 登録する商品
                quantity: 数量
                order: 登録したい注文
         [返り値] なし
         ---------------------------------------------------------------*/
        public void AddTakeOrderDetail(ItemT item, int quantity, Models.TakeOrderT order)
        {
            var orderDetails = new TakeOrderDetailT { ItemTID = item.ItemTID, Quantity = (uint)quantity, TakeOrderTID = order.TakeOrderTID };
            context.SaveChanges();
        }
    }
}
