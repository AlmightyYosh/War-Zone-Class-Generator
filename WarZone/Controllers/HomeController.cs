using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WarZone.Models;
using Microsoft.EntityFrameworkCore;
using WarZone.ViewModel;

namespace WarZone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ConnectionString _DataContext;

        public HomeController(ILogger<HomeController> logger, ConnectionString DataContext)
        {
            _logger = logger;
            _DataContext = DataContext;
        }

        public IActionResult Index()
        {
            var _Primary = _DataContext.Primary;
            var _Secondary = _DataContext.Secondary;
            var _Perks = _DataContext.Perks;
            var _Lethal = _DataContext.Lethal;
            var _Tactical = _DataContext.Tactical;

            AllDataModel dto = new AllDataModel();

            dto.Primary = _Primary.ToList();
            dto.Secondary = _Secondary.ToList();
            dto.Perks = _Perks.ToList();
            dto.Lethal = _Lethal.ToList();
            dto.Tactical = _Tactical.ToList();


            return View(dto);
        }

        public IActionResult List()
        {
            //GENERATE RAND NUMBER FOR ID
            Random rand = new Random();
            int PrId = rand.Next(1,_DataContext.Primary.Count() + 1);
            var _Primary = _DataContext.Primary.Find(PrId);

            int SeId = rand.Next(1, _DataContext.Secondary.Count() + 1);
            var _Secondary = _DataContext.Secondary.Find(SeId);

            int LeId = rand.Next(1, _DataContext.Lethal.Count() + 1);
            var _Lethal = _DataContext.Lethal.Find(LeId);

            int TacId = rand.Next(1, _DataContext.Tactical.Count() + 1);
            var _Tactical = _DataContext.Tactical.Find(TacId);

          
            var _Perks = _DataContext.Perks;

            SingleModel dto = new SingleModel();

            dto.PriName = _Primary.Name;
            dto.PriImage = _Primary.Image;
            dto.SecName = _Secondary.Name;
            dto.SecImage = _Secondary.Image;
            dto.TecName = _Tactical.Name;
            dto.TecImage = _Tactical.Image;
            dto.LethName = _Lethal.Name;
            dto.LethImage = _Lethal.Image;


            //TRY TO ADD THREE PERKS BUT RANDOM TO A LIST 
            List<PerksModel> p = new List<PerksModel>();
            for (int i = 0; i < _DataContext.Perks.Count() + 1; i++)
            {
                
                
                int PeId = rand.Next(1, _DataContext.Perks.Count() + 1);

                //CHECKS IF THE PERKS IS ALREADY IN THE P LIST
                
                if (!p.Contains(_Perks.Find(PeId)) && p.Count() < 3)
                {
                    p.Add(_Perks.Find(PeId));

                }
                

            }
            //NOW I NEED TO FIND A AWAY TO NOT GET THE SAME ONE FROM THE SAME PERKNUM.

            dto.perks = p;

            


            return View(dto);
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
