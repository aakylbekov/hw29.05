using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficer.DAL.Module
{
    public class Region
    {
        public int IdRegion { get; set; }
        public List<Person> persons = new List<Person>();
    }
}
