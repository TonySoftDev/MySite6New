using Microsoft.AspNetCore.Mvc;
using MySite6New.Shared;

namespace MySite6New.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //Dovrebbero essere 111
        private static readonly string[] Cities = new[]
        {
            "Agrigento","Alessandria","ANCONA","Andria","AOSTA","Arezzo","Ascoli Piceno","Asti","Avellino","BARI",
            "Barletta","Belluno","Benevento","Bergamo","Biella","BOLOGNA","Bolzano","Brescia","Brindisi","CAGLIARI",
            "Caltanissetta","CAMPOBASSO","Carbonia","Caserta","Catania","CATANZARO","Cesena","Chieti","Como","Cosenza",
            "Cremona","Crotone","Cuneo","Enna","Fermo","Ferrara","FIRENZE","Foggia","Forlì","Frosinone",
            "GENOVA","Gorizia","Grosseto","Imperia","Isernia","L'AQUILA","La Spezia","Latina","Lecce","Lecco",
            "Livorno","Lodi","Lucca","Macerata","Mantova","Massa","Matera","Messina","MILANO","Modena",
            "Monza","NAPOLI","Novara","Nuoro","Oristano","Padova","PALERMO","Parma","Pavia","PERUGIA",
            "Pesaro","Pescara","Piacenza","Pisa","Pistoia","Pordenone","POTENZA","Prato","Ragusa","Ravenna",
            "Reggio Calabria","Reggio Emilia","Rieti","Rimini","ROMA","Rovigo","Salerno","Sassari","Savona","Siena",
            "Siracusa","Sondrio","Taranto","Teramo","Terni","TORINO","Trani","Trapani","TRENTO","Treviso",
            "TRIESTE","Udine","Urbino","Varese","VENEZIA","Verbania","Vercelli","Verona","Vibo Valentia","Vicenza",
            "Viterbo"
        };

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 10).Select(index => new WeatherForecast
            {
                City = Cities[Random.Shared.Next(0, Cities.Length)],    
                Date = DateTime.Now,
                TemperatureMin = Random.Shared.Next(-10, 10),
                TemperatureMax = Random.Shared.Next(15, 30)
            })
            .ToArray();
        }
    }
}