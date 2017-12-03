using System.Collections.Generic;
using System.Web.Http;
using RpgMaker.Data;
using RpgMaker.Model;
using RpgMaker.ModelImplementation;

namespace Prog6RpgMakerBackEnd.Controllers {
  public class GameCharacterController : ApiController {

    private IGameCharacterRepository repository;

    public GameCharacterController(IGameCharacterRepository repository)
      : base() {
      this.repository = repository;
    }

    // GET: api/GameCharacter
    public IEnumerable<IGameCharacter> Get() {
      return repository.FindAll();
    }

    // GET: api/GameCharacter/5
    public IGameCharacter Get(long id) {
      return repository.Find(id);
    }

    // POST: api/GameCharacter
    public void Post([FromBody]IGameCharacter value) {
      value.Id = 0;
      repository.Save(value);
    }

    // PUT: api/GameCharacter/5
    public void Put(long id, [FromBody]IGameCharacter value) {
      value.Id = id;
      repository.Update(value);
    }

    // DELETE: api/GameCharacter/5
    public void Delete(long id) {
      repository.Delete(new GameCharacter { Id = id });
    }
  }
}
