using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrnaWeb.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string VicePresident { get; set; }
        public DateTime DateRegister { get; set; }
        public int subtitle { get; set; }
        public ICollection<Vote> Votes { get; set; } = new List<Vote>();
    
        public Candidate()
        {

        }

        public Candidate(int id, string vicePresident, DateTime dateRegister, int subtitle)
        {
            Id = id;
            VicePresident = vicePresident;
            DateRegister = dateRegister;
            this.subtitle = subtitle;
        }

        public void AddVotes(Vote v)
        {
            Votes.Add(v);
           
        }

        //public double TotalVotes(DateTime initial, DateTime final)
        //{
        //    return Votes.Sum(vote => vote.TotalVotes(initial, final));
        //}
    }
}
