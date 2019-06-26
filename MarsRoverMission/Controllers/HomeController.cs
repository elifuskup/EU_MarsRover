using MarsRoverMission.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.IO;
using System.Threading.Tasks;
using static MarsRoverMission.Models.Rover;

namespace MarsRoverMission.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Rover(string coordinates, string pos_r_1, string move_r_1)
        {
            var coords = coordinates.Split(' ');
            var list_pos_r_1 = pos_r_1.Split(' ');

            Rover rv = new Rover(Convert.ToInt16(coords[0]), Convert.ToInt16(coords[1]));
            rv.LandRover(Convert.ToInt16(list_pos_r_1[0]), Convert.ToInt16(list_pos_r_1[1]), (Directions)Enum.Parse(typeof(Directions), list_pos_r_1[2].ToString(), true));
            rv.OperateRover(move_r_1);

            return new PartialViewResult()
            {
                ViewName = "Rover",
                ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                {
                    Model = rv,
                }
            };
        }
    }
}
