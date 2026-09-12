using System.ComponentModel.DataAnnotations;

namespace AirportIncidentSystem.Models
{
    public class Incident
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string IncidentType { get; set; } = string.Empty;

        [Required]
        public DateTime IncidentDate { get; set; }

        [Required]
        public TimeSpan IncidentTime { get; set; }

        public string? FlightNumber { get; set; }

        public string? Location { get; set; }

        [Required]
        public string ReportedBy { get; set; } = string.Empty;

        // Dynamic fields JSON format mein save honge
        public string? DynamicDetails { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}