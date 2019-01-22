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
        public void AddTakeOrderDetail(ItemT item, int quantity, int TakeOrderTID)
        {
            var orderDetails = new TakeOrderDetailT { ItemTID = item.ItemTID, Quantity = (int)quantity, TakeOrderTID = TakeOrderTID, TakeOrderPrice = item.Price };
            context.TakeOrderDetails.Add(orderDetails);
            context.SaveChanges();
        }

        public void AddTakeOrderDetail( Models.TakeOrderDetailT orderDetail)
        {
            var item = context.Items.Single(x => x.ItemTID == orderDetail.ItemTID && x.IsDeleted == false);
            AddTakeOrderDetail(item, orderDetail.Quantity, orderDetail.TakeOrderTID);
        }
    }
}
