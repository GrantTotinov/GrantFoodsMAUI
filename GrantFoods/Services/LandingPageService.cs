using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrantFoods.Services
{
    public class LandingPageService
    {
        public IEnumerable<string> GetArtCollection01()
        {
            return new List<string>
            {
                "beefdeluxe.jpg",
                "nelgium.jpg",
                "carnitasdeserdo.jpg",
                "cesar.png",
                "chillikonkarne.jpg",
                "chocolate.jpg",
            };
        }

        public IEnumerable<string> GetArtCollection02()
        {
            return new List<string>
            {
                "jam.jpg",
                "salmon.png",
                "supreme.png",
                "redvelvet.jpg",
                "marina.png",
                "garlicgambero.png",
            };
        }

        public IEnumerable<string> GetArtCollection03()
        {
            return new List<string>
            {
                "chocolate.jpg",
                "chickenrioshti.jpg",
                "cheese2.jpg",
                "hawaiian.png",
                "gansh.jpg",
                "fishRioshti",
            };
        }
    }
}
