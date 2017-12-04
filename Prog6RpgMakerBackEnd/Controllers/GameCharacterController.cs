using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using RpgMaker.Data;
using RpgMaker.Injection;
using RpgMaker.Model;
using RpgMaker.ModelImplementation;

namespace Prog6RpgMakerBackEnd.Controllers {

  [EnableCors("*", "*", "*")]
  public class GameCharacterController : ApiController {

    private IGameCharacterRepository repository = ContainerFactory.Container.GetInstance<IGameCharacterRepository>();

    // GET: api/GameCharacter
    public IEnumerable<IGameCharacter> Get() {
      return repository.FindAll();
    }

    // GET: api/GameCharacter/5
    public IGameCharacter Get(long id) {
      return repository.Find(id);
    }

    // POST: api/GameCharacter
    public void Post([FromBody]GameCharacter value) {
      value.Id = 0;
      repository.Save(value);
    }

    // PUT: api/GameCharacter/5
    public void Put(long id, [FromBody]GameCharacter value) {
      value.Id = id;
      repository.Update(value);
    }

    // DELETE: api/GameCharacter/5
    public void Delete(long id) {
      repository.Delete(new GameCharacter { Id = id });
    }
  }
}
