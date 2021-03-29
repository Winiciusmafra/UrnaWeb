using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrnaWeb.Models.ViewModels
{
    public class VoteViewModel
    {
        public Candidate Candidate { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
