using Anamaka.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Anamaka.Services
{
    public class Service3
    {
        public static List<TransactionViewModel> GetListOfTransactions(DataTable data)
        {
            var result = new List<TransactionViewModel>();
            var cols = new List<string>();

            foreach (DataColumn item in data.Columns)
            {
                cols.Add(item.ColumnName);
            }
            var x = cols[3].Length;
            foreach (DataRow row in data.Rows)
            {
                var transactionItem = new TransactionViewModel();
                //============convert data===================
                transactionItem.TotalAmount = long.Parse(row["Total Amount"].ToString());
                transactionItem.RRN = long.Parse(row["RRN"].ToString());
                transactionItem.CustomerId = int.Parse(row["Customer Id"].ToString());
                //transactionItem.Date = int.Parse(row["Date"].ToString());
                //transactionItem.Date = Convert.ToDateTime(row["Date"].ToString());
                transactionItem.Date = DateTime.Parse(row["Date "].ToString());
                transactionItem.Time = row["Time"].ToString();
                transactionItem.Datefa = int.Parse(row["Date fa"].ToString());
                transactionItem.PsbId = int.Parse(row["Psb Id"].ToString());
                //============convert data===================
                result.Add(transactionItem);
            }
            return result;
        }
    }
}
