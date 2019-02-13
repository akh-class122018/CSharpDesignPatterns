using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RoadFrame : IBikeFrame

    {
        public string BikeFrameParts
        {
            // hard code defined the the return at property level
            get { return "Frame parts for Road Bike"; }
        }
    }
}
