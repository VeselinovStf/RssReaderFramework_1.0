using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRF.Web.Controllers
{
    public class ProfileController : Controller
    {
        public async Task<IActionResult> Wellcome()
        {
            return View();
        }

        public async Task<IActionResult> AddRssChannel(string rssChannel)
        {
            return View();
        }

        public async Task<IActionResult> AddFormattingElement(string element)
        {
            return View();
        }

        
    }
}
