using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anamaka.Models
{
    public class TransactionViewModel
    {
        public long TotalAmount { get; set; }
        public long RRN { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public int Datefa { get; set; }
        public int PsbId { get; set; }
    }
}
