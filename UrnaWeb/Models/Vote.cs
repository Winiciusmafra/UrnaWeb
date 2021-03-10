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
        public Candidate IdCanditade { get; set; }


        public Vote()
        {
        }

        public Vote(int id, DateTime dateRegister, Candidate idCanditade)
        {
            Id = id;
            DateRegister = dateRegister;
            IdCanditade = idCanditade;
        }
    }
}
