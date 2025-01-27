﻿using System.ComponentModel.DataAnnotations;
using TravelsFreak.Data;

namespace TravelsFreak.Models.DataTransferObject
{
    public class TourPackageDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter price...")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please enter days...")]
        public int Days { get; set; }

        [Required(ErrorMessage = "Please enter description...")]
        public string? TourPackageDescription { get; set; }

        [Required(ErrorMessage = "Please enter Location...")]
        public string? TourPackageLocation { get; set; }

        [Required]
        public string? TourPackageImageUrl { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select destination...")]
        public int DestinationsId { get; set; }
        public Destinations? Destinations { get; set; }
    }
}
