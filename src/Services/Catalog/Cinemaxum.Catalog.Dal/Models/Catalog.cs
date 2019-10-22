using System;
using System.Collections.Generic;
using System.Text;

namespace Cinemaxum.Catalog.Dal.Models
{
    public class Catalog
    {
        public int CatalogId { get; set; }
        public DateTime ShowTime { get; set; }
        public int MovieId { get; set; }
        public string LanguageType { get; set; }
        public string ShowType { get; set; }
        public string Localisation { get; set; }
    }
}
