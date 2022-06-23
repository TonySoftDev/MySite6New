using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySite6New.Shared;
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

		[HttpGet("Gallery")]
		public IEnumerable<ImageModel> GetGalleryData()
		{
			List<ImageModel> data = new List<ImageModel>
			{
				new ImageModel
				{
					Id = 1015,
					Width = 6000,
					Height = 4000,
					Url = "/assets/gallery/1015-6000x4000.jpg"
				},
				new ImageModel
				{
					Id = 1019,
					Width = 5472,
					Height = 3648,
					Url = "/assets/gallery/1019-5472x3648.jpg"
				},
				new ImageModel
				{
					Id = 1039,
					Width = 6945,
					Height = 4635,
					Url = "/assets/gallery/1039-6945x4635.jpg"
				},
				new ImageModel
				{
					Id = 1057,
					Width = 6016,
					Height = 4016,
					Url = "/assets/gallery/1057-6016x4016.jpg"
				},
				new ImageModel
				{
					Id = 106,
					Width = 2597,
					Height = 1728,
					Url = "/assets/gallery/106-2592x1728.jpg"
				}

			};

			return data;
		}
    }
}
