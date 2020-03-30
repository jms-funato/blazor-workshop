using System;
using System.Collections.Generic;
using System.Text;

namespace ADPHI.Shared.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<State> States { get; set; }
    }
}
