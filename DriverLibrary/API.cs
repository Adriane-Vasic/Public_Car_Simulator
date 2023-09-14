using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLibrary
{
    public class API
    {
        public class ResponseData
        {
            public List<Result> Results { get; set; }
         
        }

        public class Result
        {
            public string Gender { get; set; }
            public Name Name { get; set; }
            public string Email { get; set; }
            public Dob Dob { get; set; }
        }

        public class Name
        {
            public string Title { get; set; }
            public string First { get; set; }
            public string Last { get; set; }
        }

        public class Dob
        {
            public string Age { get; set; }
        }

    }
}
