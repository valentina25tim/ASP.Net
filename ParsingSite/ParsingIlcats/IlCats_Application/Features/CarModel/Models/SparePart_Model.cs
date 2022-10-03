using System;
using System.Collections.Generic;
using System.Text;

namespace IlCats_Application.Features.CarModel.Models
{
    public class SparePart_Model
    {
        public string Name { get; set; }

        public IEnumerable<SpareTypeDetail_Model>? SpareTypeDetails { get; set; }
        public int ComplectationVariableId { get; set; }
    }
}
