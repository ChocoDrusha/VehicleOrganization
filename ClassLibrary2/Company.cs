using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Company
    {
        public string Name { get; }
        private List<AutoPark> _autoParks = new List<AutoPark>();
        public IEnumerable<AutoPark> AutoParks => _autoParks;
        private Company()
        {
        }

        public Company(string name)
        {
            
            Name = name;
        }

        public AutoPark CreateAutoPark(string nameOfPark)
        {
            var autoPark = new AutoPark(nameOfPark, this);
            _autoParks.Add(autoPark);
            return autoPark;
        }
    }
}
