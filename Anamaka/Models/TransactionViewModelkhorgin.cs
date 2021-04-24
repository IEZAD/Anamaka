using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anamaka.Models
{
    public class TransactionViewModelkhorgin
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public long Toman { get; set; }
        public string TerminalName { get; set; }
        public int CustomerId { get; set; }
    }
}
