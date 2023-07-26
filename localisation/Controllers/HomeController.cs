using localisation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace localisation.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<UserLocation> _userLocations = new List<UserLocation>();

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    // Afficher la liste des localisations des utilisateurs
        //    return View(_userLocations);
        //}
        //[HttpPost]
        //public IActionResult SaveLocation(double latitude, double longitude, double speed)
        //{
        //    // Enregistrez les données de géolocalisation et de vitesse dans une base de données ou faites autre chose avec ces valeurs

        //    return Ok();
        //}

        //[HttpPost]
        //public IActionResult UpdateLocation(double latitude, double longitude, double speed)
        //{
        //    // Récupérer l'ID de l'utilisateur (vous pouvez utiliser un système d'authentification pour cela)
        //    string userId = "User1";

        //    // Créer un nouvel objet UserLocation
        //    var userLocation = new UserLocation
        //    {
        //        UserId = userId,
        //        Latitude = latitude,
        //        Longitude = longitude,
        //        Speed = speed,
        //        Timestamp = DateTime.UtcNow
        //    };

        //    // Ajouter la localisation à la liste (à remplacer par l'ajout dans la base de données)
        //    _userLocations.Add(userLocation);

        //    return Ok(); // Réponse HTTP 200 (OK)
        //}
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateLocation(double latitude, double longitude, double speed)
        {
            // Vous pouvez enregistrer ces données en base de données ou les traiter selon vos besoins.
            // Pour cet exemple, nous allons simplement les renvoyer en tant que données JSON.

            var locationData = new
            {
                Latitude = latitude,
                Longitude = longitude,
                Speed = speed
            };

            // Ici, nous renvoyons les données au format JSON.
            return Json(locationData);
        }
    }
}
