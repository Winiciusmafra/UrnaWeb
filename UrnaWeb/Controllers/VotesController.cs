using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrnaWeb.Models;
using UrnaWeb.Services;

namespace UrnaWeb.Controllers
{
    public class VotesController : Controller
    {

        

        private readonly VoteService _voteService;

        public VotesController(VoteService voteService)
        {
            _voteService = voteService;
        }
        public IActionResult Index()
        {
            var list = _voteService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Vote votes)
        {
            _voteService.InsetVote(votes);
            return RedirectToAction(nameof(Index));
        }
    }
}
