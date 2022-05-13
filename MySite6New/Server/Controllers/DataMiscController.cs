using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySite6New.Shared.CarouselModel;

namespace MySite6New.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DataMiscController : ControllerBase
    {
        [HttpGet("Carousel")]
        public CarouselData GetCarouselModel()
        {
			CarouselData data = new CarouselData
			{
				MillisecondsInterval = 2000,
				IsSliding = true,
				IsCyclingContinous = true,
				ListItems = new List<ItemCarouselModel>()
				{
					new ItemCarouselModel
					{
						IsActive=true,
						ImageUrl = "/assets/img/publicbackgrounds/001.jpg",
						ImageTitle = "Sfondo 1",
						ImageDescription = "Un bel tema astratto dai colori pastello. Mi piace molto."
					},
					new ItemCarouselModel
					{
						IsActive=false,
						ImageUrl = "/assets/img/publicbackgrounds/002.jpg",
						ImageTitle = "Sfondo 2",
						ImageDescription = "Mi piace molto questo tema blu e oro, interessante."
					},
					new ItemCarouselModel
					{
						IsActive=false,
						ImageUrl = "/assets/img/publicbackgrounds/003.jpg",
						ImageTitle = "Sfondo 3",
						ImageDescription = "Le fiamme della creatività."
					},
					new ItemCarouselModel
					{
						IsActive=false,
						ImageUrl = "/assets/img/publicbackgrounds/004.jpg",
						ImageTitle = "Sfondo 4",
						ImageDescription = "???"
					}

				}
			};
			return data;
		}
    }
}
