using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingsConunter.Models
{
    public  class Test
    {
        //public int Ratings { get; set; }

        int Ratings = 10;

        public int RatingWidth
        {
            get
            {
                int y = (143 * Ratings) / 100;
                return y;
            }
        }
    }
}
