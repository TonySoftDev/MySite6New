using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite6New.Shared.CarouselModel
{
    public class CarouselData
    {
        public int MillisecondsInterval { get; set; } = 2000;
        public bool IsSliding { get; set; } = true;
        public bool IsCyclingContinous { get; set; } = true;
        //public List<ItemCarouselModel> ListItems { get; set; } = new List<ItemCarouselModel>();
        public IEnumerable<ItemCarouselModel>? ListItems { get; set; }
    }
}
