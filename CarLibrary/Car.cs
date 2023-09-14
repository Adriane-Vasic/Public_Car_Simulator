using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public enum DirectionEnum
    {
        NotDefined,
        North,
        West,
        South,
        East
    }
    public class Car
    {
        public int Gas { get; set; }

        public DirectionEnum Direction { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsBacking { get; set; }


    }
}
