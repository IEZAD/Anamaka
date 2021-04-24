using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anamaka.Models;
using Anamaka.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Anamaka.Pages.ReadFile
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public IFormFile Upload1 { get; set; }
        [BindProperty]
        public IFormFile Upload2 { get; set; }
        private IHostingEnvironment _environment;
        [BindProperty]
        public List<TransactionViewModel> ResultsTasviye { get; set; }
        public List<TransactionViewModelkhorgin> ResultsTasviyeKhorgin { get; set; }
        public IndexModel(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public void OnPost()
        {
            try
            {
                if (Upload1 != null)
                {
                    var fileName = Service1.SaveFile(_environment, Upload1);
                    var data = Service2.ReadExcelFile("sheet1", fileName);
                    //var result = Method.GetListOfTransactions(data);
                    ResultsTasviye = Service3.GetListOfTransactions(data);

                }
                if (Upload2 != null)
                {
                    var fileName = Service1.SaveFile(_environment, Upload2);
                    var data = Service2.ReadExcelFile("sheet1", fileName);
                    ResultsTasviyeKhorgin = Service4.GetListOfTransactionskhorgin(data);
                    ResultsTasviyeKhorgin.Count();
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        public void OnGet(List<TransactionViewModel> resultsTasviye, List<TransactionViewModelkhorgin> resultsTasviyeKhorgin)
        {

        }
    }
}
