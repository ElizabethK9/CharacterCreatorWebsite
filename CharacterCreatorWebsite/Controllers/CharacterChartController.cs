using CharacterCreatorWebsite.Data;
using CharacterCreatorWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharacterCreatorWebsite.Controllers
{
    public class CharacterChartController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CharacterChartController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Action to list all character charts
        public IActionResult List()
        {
            var charts = _db.CharacterCharts.ToList(); // Ensure this retrieves data from your database
            return View("CharacterChartList", charts); // Pass the data to the view
        }


        // Action to edit a specific character chart
        public IActionResult Edit(int id)
        {
            var chart = _db.CharacterCharts.FirstOrDefault(c => c.Id == id);
            if (chart == null) return NotFound();

            return View("CharacterChartEdit", chart); // View for editing a chart
        }

        // Action to save changes to a character chart
        [HttpPost]
        public IActionResult Save(CharacterChartClass updatedChart)
        {
            var chart = _db.CharacterCharts.Find(updatedChart.Id);
            if (chart == null) return NotFound();

            // Update properties
            chart.FullName = updatedChart.FullName;
            chart.Nicknames = updatedChart.Nicknames;
            chart.Gender = updatedChart.Gender;
            chart.Species = updatedChart.Species;
            chart.PlaceOfBirth = updatedChart.PlaceOfBirth;
            chart.DateOfBirth = updatedChart.DateOfBirth;
            chart.CurrentResidence = updatedChart.CurrentResidence;
            chart.BloodStatus = updatedChart.BloodStatus;
            chart.MagicalInheritance = updatedChart.MagicalInheritance;
            chart.LordLadyShips = updatedChart.LordLadyShips;
            chart.MagicLegacy = updatedChart.MagicLegacy;
            chart.ImportantFamily = updatedChart.ImportantFamily;
            chart.Parents = updatedChart.Parents;
            chart.Siblings = updatedChart.Siblings;
            chart.MagicAbilities = updatedChart.MagicAbilities;
            chart.MagicCore = updatedChart.MagicCore;
            chart.Alignment = updatedChart.Alignment;
            chart.Appearance = updatedChart.Appearance;
            chart.Age = updatedChart.Age;
            chart.HogwartsHouse = updatedChart.HogwartsHouse;
            chart.Wand = updatedChart.Wand;
            chart.Patronus = updatedChart.Patronus;
            chart.SpecialItems = updatedChart.SpecialItems;
            chart.Style = updatedChart.Style;
            chart.Miscellaneous = updatedChart.Miscellaneous;

            _db.SaveChanges(); // Save changes to the database

            return RedirectToAction("List"); // Redirect to the list view
        }
    }
}
