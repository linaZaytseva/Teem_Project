using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeemProject
{
    public class EatingTime
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EatingTime(string Name)
        {
            this.Name = Name;
        }
    }
}
