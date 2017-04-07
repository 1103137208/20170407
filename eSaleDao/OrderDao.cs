using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSaleDao
{
    public class OrderDao
    {
        public eSaleModel.Order GetOrderById(string id)
        {
            ///<summary>
            ///依訂單編號取得訂單資料
            ///</summary>
            ///<param name="id"></param>
            ///<returns><returns>
            return new eSaleModel.Order() { CustId = "GSS", CustName = "瑞陽資訊", OrderId = "1" };
        }
    }
}
