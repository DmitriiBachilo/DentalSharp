using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalSharp.Data
{
    class Database
    {
        public List<Category> Categories { get; set; }

        public List<Doctor> Doctors { get; set; } 

        public List<Speciality> Specialties { get; set; }

        public List<Direction> Directions { get; set; }

        public static Database ParseData()
        {
            string json = File.ReadAllText(@".\Data\dental.json");
            return JsonConvert.DeserializeObject<Database>(json, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.All });
        }

        public List<Doctor> FindDoctorsByDirections(int directionId)
        {
            return Doctors.Where(doctor => doctor.Directions.Any(direction => directionId == direction.Id)).ToList();
        }
    }
}
