using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UrnaWeb.Models;
using UrnaWeb.Models.ViewModels;
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
            return View();
        }

        public IActionResult Create()
        {
            var candidates = _voteService.FindAll();
            return View(candidates);
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
