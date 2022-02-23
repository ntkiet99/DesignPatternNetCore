using DesignPatternNetCore.Interfaces;
using DesignPatternNetCore.Models;
using DesignPatternNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            this._userService = userService;
        }

        public IActionResult Index()
        {
            //var data = _userService.Get();
            var data = new DSSinhVienVM();
            data.ChuNhiemKhoa = "kiet";
            data.TenKhoa = "Kiet 1";
            data.ListSV = _userService.Get();
                        return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
