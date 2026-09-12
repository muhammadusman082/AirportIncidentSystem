using System;
using System.ComponentModel.DataAnnotations;

namespace AirportIncidentSystem.Models
{
    public class IncidentReport
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Incident Type")]
        public string IncidentType { get; set; } // E.g., "Luggage Lost", "Flight Delay", "Medical Emergency"

        // Common Fields
        [Required]
        [DataType(DataType.Date)]
        public DateTime IncidentDate { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Flight Number")]
        public string FlightNumber { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        // Dynamic Fields (Stored as JSON in SQL Server)
        public string DynamicDataJson { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}