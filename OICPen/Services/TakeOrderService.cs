using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Services
{
    public class TakeOrderService
    {
        private OICPenDbContext context;

        public TakeOrderService(OICPenDbContext context)
        {
            this.context = context;
        }

        /*---------------------------------------------------------------
        [役割] すべての注文情報をTakeOrder型のListにして返す
        [引数] なし
        [返り値] すべての注文情報
        ---------------------------------------------------------------*/
        public List<TakeOrderT> GetAllTakeOrders()
        {
            var query = from c in context.TakeOrders
                        orderby c.TakeOrderTID
                        select c;

            return query.ToList();
        }

        /*---------------------------------------------------------------
        [役割] 出庫済みの注文情報をTakeOrder型のListにして返す
        [引数] なし
        [返り値] 出庫済みの注文情報
        ---------------------------------------------------------------*/
        public List<TakeOrderT> GetShipedTakeOrders()
        {
            var query = from c in context.TakeOrders
                        orderby c.TakeOrderTID
                        where c.ShipDate!=null
                        select c;

            return query.ToList();
        }

        /*---------------------------------------------------------------
        [役割] 未出庫の注文情報をTakeOrder型のListにして返す
        [引数] なし
        [返り値] 出庫済みの注文情報
        ---------------------------------------------------------------*/
        public List<TakeOrderT> GetNoShipedTakeOrders()
        {
            var query = from c in context.TakeOrders
                        orderby c.TakeOrderTID
                        where c.ShipDate == null
                        select c;

            return query.ToList();
        }

        /*---------------------------------------------------------------
         [役割] 受け取った注文情報をDBに登録する
         [引数] g: 追加する注文情報
         [返り値] 追加した情報
         ---------------------------------------------------------------*/
        public Models.TakeOrderT AddTakeOrder(Models.TakeOrderT g)
        {
            var takeOrder = context.TakeOrders.Add(g);
            context.SaveChanges();

            return takeOrder;
        }

        /*---------------------------------------------------------------
         [役割] 受け取った注文情報の出庫日時を入力する
         [引数] t: 出庫する注文情報
         [返り値] なし
         ---------------------------------------------------------------*/
        public void Shiping(int id)
        {
            var takeOrder = context.TakeOrders.Single(x => x.TakeOrderTID == id);
            takeOrder.ShipDate = DateTime.Now;
            context.SaveChanges();
        }

        /*---------------------------------------------------------------
         [役割] 受け取った注文情報の出庫日時を削除する
         [引数] t: 出庫する注文情報
         [返り値] なし
         ---------------------------------------------------------------*/
        public void ClearShiping(int id)
        {
            var takeOrder = context.TakeOrders.Single(x => x.TakeOrderTID == id);
            takeOrder.ShipDate = null;
            context.SaveChanges();
        }
    }
}
