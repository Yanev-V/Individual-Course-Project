using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1Cafe.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace F1Cafe.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area(GlobalConstants.AdminAreaName)]
    public class AdminsController : Controller
    {

    }
}