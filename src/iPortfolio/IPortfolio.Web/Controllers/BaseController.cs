using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IPortfolio.Model;
using IPortfolio.BLL;

namespace IPortfolio.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly OrganizationBll orgBll = new OrganizationBll();

        public BaseController()
        {
            ViewBag.OrgList = orgBll.GetAll();
        }
    }
}