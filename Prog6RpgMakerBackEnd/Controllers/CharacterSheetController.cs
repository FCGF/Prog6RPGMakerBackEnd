using System.Collections.Generic;
using System.Web.Http;
using RpgMaker.Data;
using RpgMaker.Model;
using RpgMaker.ModelImplementation;

namespace Prog6RpgMakerBackEnd.Controllers {
  public class CharacterSheetController : ApiController {

    private ICharacterSheetRepository repository;

    public CharacterSheetController(ICharacterSheetRepository repository)
      : base() {
      this.repository = repository;
    }

    // GET: api/CharacterSheet
    public IEnumerable<ICharacterSheet> Get() {
      return repository.FindAll();
    }

    // GET: api/CharacterSheet/5
    public ICharacterSheet Get(long id) {
      return repository.Find(id);
    }

    // POST: api/CharacterSheet
    public void Post([FromBody]ICharacterSheet value) {
      value.Id = 0;
      repository.Save(value);
    }

    // PUT: api/CharacterSheet/5
    public void Put(long id, [FromBody]ICharacterSheet value) {
      value.Id = id;
      repository.Update(value);
    }

    // DELETE: api/CharacterSheet/5
    public void Delete(long id) {
      repository.Delete(new CharacterSheet { Id = id });
    }
  }
}
