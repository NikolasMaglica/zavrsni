using aplikacija_server.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nikolas.Contracts;
using nikolas.Entities.DTO;
using Server.Contracts;

namespace nikolas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly RepositoryContext _dataContext;
        private ILoggerManager _logger;
        private IMapper _mapper;
        private IUser _user;
        public UsersController(RepositoryContext dataContext, ILoggerManager logger,
                    IMapper mapper, IUser user)
        {
            _dataContext = dataContext;
            _logger = logger;
            _mapper = mapper;
            _user = user;

        }

        [HttpGet]
        public IActionResult GetAllOwners()
        {
            var owners = _user.GetAllUsers();
            _logger.LogInfo($"Vraceni su svi zaposlenici iz baze podataka.");
            return Ok(owners);
        }
        [HttpPost]
        public IActionResult UserCreate([FromBody] UserCreation model)
        {

            _user.Registration(model);
            _logger.LogInfo($"Uspješno je kreiran novi zaposlenik");
            return Ok(new { message = "Uspješan unos novog zaposlenika" });
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult UserDelete([FromRoute] int id)
        {
            _user.DeleteUser(id);
            return Ok(new { message = "Uspješan ste izbrisali zaposlenika" });
        }

        [HttpGet]
        [Route("{id:int}")]

        public IActionResult GetOwner([FromRoute] int id)
        {
            var owners = _dataContext.Users.FirstOrDefault(x => x.id == id);
            _logger.LogInfo($"Vracen je zaposlenik iz baze podataka.");
            return Ok(owners);
        }
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateUser(int id, [FromBody] UserUpdate model)
        {
            _user.UpdateUser(id, model);
            return Ok(new { message = "Podaci o ponudi  su ažurirani" });
        }
    }
}
