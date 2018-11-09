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

        public void WriteStock(StockT s)
        {
            var stock = context.Stocks.Add(s);
        }
      
    }
}
