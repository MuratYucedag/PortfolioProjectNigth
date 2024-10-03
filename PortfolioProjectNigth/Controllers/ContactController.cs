using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNigth.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public PartialViewResult PartialContactSidebar()
        {
            return PartialView();
        }
    }
}