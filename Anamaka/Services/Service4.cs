using Anamaka.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Anamaka.Services
{
    public class Service4
    {
        public static List<TransactionViewModelkhorgin> GetListOfTransactionskhorgin(DataTable data)
        {
            var result = new List<TransactionViewModelkhorgin>();
            var cols = new List<string>();

            foreach (DataColumn item in data.Columns)
            {
                cols.Add(item.ColumnName);
            }
            var x = cols[3].Length;
            foreach (DataRow row in data.Rows)
            {
                var transactionViewModelkhorgin = new TransactionViewModelkhorgin();
                //============convert data===================
                transactionViewModelkhorgin.Date = DateTime.Parse(row["Date"].ToString());
                transactionViewModelkhorgin.Time = DateTime.Parse(row["Time"].ToString());
                transactionViewModelkhorgin.Toman = long.Parse(row["Toman"].ToString());
                transactionViewModelkhorgin.TerminalName = row["Terminal Name"].ToString();
                transactionViewModelkhorgin.CustomerId = int.Parse(row["Customer Id"].ToString());
                //============convert data===================
                result.Add(transactionViewModelkhorgin);
            }
            return result;
        }
    }
}
