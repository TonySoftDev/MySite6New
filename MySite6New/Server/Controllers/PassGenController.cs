using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordGenerator;

namespace MySite6New.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassGenController : ControllerBase
    {
        /// <summary>
        /// Genera password di 8 caratteri casuali
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            var passGen = new Password();
            string newPassword = passGen.Next();
            return Ok(newPassword);
        }

        [HttpGet("Custom1")]
        public string Get(int lunghezza = 8, bool usaMinuscole = true, bool usaMaiuscole = true, bool usaNumeri = true, bool usaSpeciali = true)
        {
            if (!usaMinuscole && !usaMaiuscole && !usaNumeri)
            {
                return "Parametri incoerenti: consentire almeno un tipo tra minuscole, maiuscole e numeri.";
            }
            var passGen = new Password(
                passwordLength: lunghezza,
                includeLowercase: usaMinuscole,
                includeUppercase: usaMaiuscole,
                includeNumeric: usaNumeri,
                includeSpecial: usaSpeciali);

            string newPassword = passGen.Next();
            return newPassword;
        }

        /// <summary>
        /// Genera password di lunghezza "lung"
        /// </summary>
        /// <param name="lung">lunghezza della password</param>
        /// <returns>Ritorna password della lunghezza richiesta</returns>
        [HttpGet("{lunghezza}")]
        public string Get(int lunghezza)
        {
            var passGen = new Password(lunghezza);
            string newPassword = passGen.Next();
            return newPassword;
        }

        [HttpGet("{lunghezza}/{numpasswords}")]
        public IEnumerable<string> Get(int lunghezza, int numpasswords = 2)
        {
            var passGen = new Password(lunghezza);
            var elenco = passGen.NextGroup(numpasswords);
            return elenco;
        }

        [HttpGet("Custom2/{numpasswords}")]
        public IEnumerable<string> Get(int numpasswords, int lunghezza, bool usaMinuscole = true, bool usaMaiuscole = true, bool usaNumeri = true, bool usaSpeciali = true)
        {
            if (!usaMinuscole && !usaMaiuscole && !usaNumeri && !usaSpeciali)
            {
                return new string[] { "Parametri incoerenti." };
            }
            var passGen = new Password(
                passwordLength: lunghezza,
                includeLowercase: usaMinuscole,
                includeUppercase: usaMaiuscole,
                includeNumeric: usaNumeri,
                includeSpecial: usaSpeciali);

            var elenco = passGen.NextGroup(numpasswords);
            return elenco;
        }

    }
}
