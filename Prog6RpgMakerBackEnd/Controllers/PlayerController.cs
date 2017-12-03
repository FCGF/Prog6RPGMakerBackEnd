using System.Collections.Generic;
using System.Web.Http;
using RpgMaker.Data;
using RpgMaker.Model;
using RpgMaker.ModelImplementation;

namespace Prog6RpgMakerBackEnd.Controllers {
  public class PlayerController : ApiController {

    private IPlayerRepository repository;

    public PlayerController(IPlayerRepository repository)
      : base() {
      this.repository = repository;
    }

    // GET: api/Player
    public IEnumerable<IPlayer> Get() {
      return repository.FindAll();
    }

    // GET: api/Player/5
    public IPlayer Get(long id) {
      return repository.Find(id);
    }

    // POST: api/Player
    public void Post([FromBody]IPlayer value) {
      value.Id = 0;
      repository.Save(value);
    }

    // PUT: api/Player/5
    public void Put(long id, [FromBody]IPlayer value) {
      value.Id = id;
      repository.Update(value);
    }

    // DELETE: api/Player/5
    public void Delete(long id) {
      repository.Delete(new Player { Id = id });
    }
  }
}
