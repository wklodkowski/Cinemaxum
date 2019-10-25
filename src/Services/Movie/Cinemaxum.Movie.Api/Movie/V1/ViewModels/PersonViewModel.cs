using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemaxum.Movie.Api.Movie.V1.ViewModels
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}
