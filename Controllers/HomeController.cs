using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))


                .ToList();
            
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
             //DataController dbctrl = new DataController(_context);
             //dbctrl.GetData();
            //  ViewBag.BaseballLeagues = _context.Leagues
            //     .Where(l => l.Sport.Contains("Baseball"))
            //     .Select(n =>n.Name)
            //     .ToList();
            ViewBag.women = _context.Leagues
               .Where(w => w.Name.Contains("Womens'")).ToList();
            ViewBag.hockey = _context.Leagues
               .Where(l => l.Sport.Contains("Hockey")).ToList();
            ViewBag.notfootball = _context.Leagues
                .Where(n => !n.Sport.Contains("Football")).ToList();

            ViewBag.conf = _context.Leagues
               .Where(c => c.Name.Contains("Conference")).ToList();
            ViewBag.alt = _context.Leagues
               .Where(c => c.Name.Contains("Atlantic")).ToList();
            
            ViewBag.dl = _context.Teams
               .Where(c => c.Location.Contains("Dallas")).ToList();
            
            ViewBag.t1 = _context.Teams
               .Where(c => c.TeamName.Contains("Raptors")).ToList();

            ViewBag.t2 = _context.Teams.Where(name => name.TeamName.StartsWith("T")).ToList();

            ViewBag.t3 = _context.Teams
               //.Where(c => c.Location.Substring(0, c.Location.Length).Equals("Mexico")).ToList();
               .Where(c => c.Location.Contains("City")).ToList();
            ViewBag.t4 = _context.Teams.OrderByDescending(l => l.Location).ToList();
            ViewBag.t5 = _context.Players.Where(l => l.LastName.Contains("Cooper")).ToList();
            ViewBag.t6 = _context.Players.Where(l => l.FirstName.Contains("Joshua")).ToList();
            ViewBag.t7 = _context.Players.Where(l => l.LastName.Contains("Cooper")&& !l.FirstName.Contains("Joshua")).ToList();
            ViewBag.t8 = _context.Players.Where(l => l.FirstName.Contains("Alexander") || l.FirstName.Contains("Wyatt")).ToList()
           .ToList();


            
            
           

            
        

            
            return View("Level1");

            
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}