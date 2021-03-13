using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrnaWeb.Models;
using UrnaWeb.Data;


namespace UrnaWeb.Services
{
    public class VoteService
    {
        private readonly UrnaWebContext _context;

        public VoteService(UrnaWebContext context)
        {
            _context = context;
        }

        public List<Vote> FindAll()
        {
            return _context.Vote.ToList();
        }

    }
}
