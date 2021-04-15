using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TournamentTracker.Shared.Models
{
     public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int? TeamId { get; set; }
        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }

    }
}
