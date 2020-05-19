using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalSharp.Data
{
    class Doctor
    {
        public string Name { get; set; }

        public List<int> Specialties { get; set; }

        public Category Category { get; set; }

        public List<Direction> Directions { get; set; }

        public List<Worktime> Worktimes { get; set; }
    }
}
