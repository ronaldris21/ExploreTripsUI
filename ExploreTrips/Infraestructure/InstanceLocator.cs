using System;
using System.Collections.Generic;
using System.Text;

namespace ExploreTrips.Infraestructure
{
    public class InstanceLocator
    {
        public Infraestructure.Singleton Instance { get; set; }
        public InstanceLocator()
        {
            Instance = new Singleton();
        }
    }
}
