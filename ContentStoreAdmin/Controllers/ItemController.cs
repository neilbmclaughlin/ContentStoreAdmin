using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ContentStoreAdmin.Models;

namespace ContentStoreAdmin.Controllers
{
    public class ItemController : Controller
    {
    [ActionName("Index")]
    public async Task<ActionResult> IndexAsync()
    {
      var items = await DocumentDbRepository<Item>.GetItemsAsync(d => !d.Completed);
      return View(items);
    }
  }
}