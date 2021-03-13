using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

    }
}
