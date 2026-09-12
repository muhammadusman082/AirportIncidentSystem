using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using AirportIncidentSystem.Models;

namespace AirportIncidentSystem.Controllers
{
    public class IncidentController : Controller
    {
        private readonly IConfiguration _configuration;

        public IncidentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Incident model)
        {
            string? connectionString = _configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                ViewBag.Message = "Error: Connection string not found!";
                return View();
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Incidents (IncidentType, IncidentDate, IncidentTime, FlightNumber, Location, ReportedBy, DynamicDetails) 
                                 VALUES (@Type, @Date, @Time, @Flight, @Loc, @By, @Details)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Type", model.IncidentType ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Date", model.IncidentDate);
                    cmd.Parameters.AddWithValue("@Time", model.IncidentTime);
                    cmd.Parameters.AddWithValue("@Flight", (object?)model.FlightNumber ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Loc", (object?)model.Location ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@By", model.ReportedBy ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Details", (object?)model.DynamicDetails ?? DBNull.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            ViewBag.Message = "Incident recorded successfully!";
            return View();
        }
    }
}