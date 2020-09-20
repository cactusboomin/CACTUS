using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Entities
{
    public static class Themes
    {
        public static List<string> List { get; set; } = new List<string>
        {
            "ALCOHOL",
            "BOOKS",
            "MOVIES",
            "MUSIC",
            "ART",
            "HOBBY",
            "FOOD",
            "OTHER"
        };
    }
}
