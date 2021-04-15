using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TournamentTracker.Shared.Models
{
    public class Prize
    {
        public int Id { get; set; }
        [Required]
        public int PlaceNumber { get; set; }
        [Required]        
        public string PlaceName { get; set; }

        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }
        public int TournamentId { get; set; }

        public Prize()
        {

        }

        public Prize(int placeNumber, string placeName, decimal prizeAmount, double prizePercentage)
        {
            PlaceName = placeName;
            PlaceNumber = placeNumber;
            PrizeAmount = prizeAmount;
            PrizePercentage = prizePercentage;
        }
    }
}
