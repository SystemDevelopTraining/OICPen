using OICPen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICPen.Services
{
    class StockService
    {
        private OICPenDbContext context;

        public StockService(OICPenDbContext context)
        {
            this.context = context;
        }
        /*---------------------------------------------------------------
        [役割] 在庫情報一覧を表示する
        [引数] なし
        [返り値] 在庫情報一覧
        ---------------------------------------------------------------*/
        public List<StockT> GetAllStocks()
        {
            var stocks = from i in context.Stocks
                        orderby i.Date
                        select i;

            return stocks.ToList();
        }

        /*---------------------------------------------------------------
        [役割] 新たな在庫を追加する
        [引数] 新しく登録する在庫データ
        [返り値] 登録した在庫データ
        ---------------------------------------------------------------*/
        public StockT AddStock(StockT s)
        {
            var stock = context.Stocks.Add(s);
            context.SaveChanges();
            return stock;
        }
      
    }
}
