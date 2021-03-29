using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrnaWeb.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public DateTime DateRegister { get; set; }
        public int Amount { get; set; }
        public Candidate CandidateId { get; set; }


        public Vote()
        {
        }

        public Vote(int id, DateTime dateRegister, Candidate candidateId)
        {
            Id = id;
            DateRegister = dateRegister;
            candidateId = CandidateId;
        }
    }
}
