using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTest.Models
{
    public class Barrel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string ConstructionMaterial { get; set; }
        public string Contents { get; set; }
        public string CurrentLocation { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
