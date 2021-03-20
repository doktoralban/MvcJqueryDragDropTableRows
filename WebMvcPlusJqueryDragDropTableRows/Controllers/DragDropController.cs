using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvcPlusJqueryDragDropTableRows.Models;
using System.Data.SqlClient;
//using System.Web.Mvc;

namespace WebMvcPlusJqueryDragDropTableRows.Controllers
{
    public class DragDropController : Controller
    {

     
        
        private readonly MvcDragDropDbContext _context;

        public DragDropController(MvcDragDropDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items0 = _context.tbMvcDragDropTableRows.ToList();
            var items = items0.OrderBy(p => p.RowNo).ToList();

            return View(items );
        }

        
        public JsonResult KaydetDragDrop(string ItemIDs)
        {
            int count = 1;

            List<int> lstItms = new List<int>();
            lstItms = ItemIDs.Split(",".ToCharArray()
                , StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            try
            {
                foreach (var itemID in lstItms)
                {
                    tbMvcDragDropTableRows dr = _context.tbMvcDragDropTableRows.Where(p => p.id == itemID).FirstOrDefault();
                    dr.RowNo = count;
                    _context.tbMvcDragDropTableRows.Update(dr);

                    _context.SaveChanges();

                    count++;
                }
            }
            catch (Exception ex)
            {
                var er = ex;
            }
            return new JsonResult(true);
        }




    }
}
