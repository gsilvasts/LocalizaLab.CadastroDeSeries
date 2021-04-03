using LocalizaLabSeries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizaLabSeries.Data
{
    public class SeriesDbContext
    {
        public SeriesDbContext()
        {
            Series = new List<Serie>
            {
                new Serie(1, "O grande dragão branco", "O grande dragão branco", 2005, false, GeneroEnum.Acao),
                new Serie(2, "Strange Things", "Strange Things", 2018, false, GeneroEnum.Suspense)
            };
        }

        public List<Serie> Series { get; set; }
    }
}
