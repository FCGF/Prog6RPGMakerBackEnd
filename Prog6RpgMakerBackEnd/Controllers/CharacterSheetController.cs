using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using RpgMaker.Data;
using RpgMaker.Injection;
using RpgMaker.Model;
using RpgMaker.ModelImplementation;

namespace Prog6RpgMakerBackEnd.Controllers {

  [EnableCors("*", "*", "*")]
  public class CharacterSheetController : ApiController {

    private ICharacterSheetRepository repository = ContainerFactory.Container.GetInstance<ICharacterSheetRepository>();

    // GET: api/CharacterSheet
    public IEnumerable<ICharacterSheet> Get() {
      return repository.FindAll();
    }

    // GET: api/CharacterSheet/5
    public ICharacterSheet Get(long id) {
      return repository.Find(id);
    }

    // POST: api/CharacterSheet
    public void Post([FromBody]CharacterSheet value) {
      value.Id = 0;
      repository.Save(value);
    }

    // PUT: api/CharacterSheet/5
    public void Put(long id, [FromBody]CharacterSheet value) {
      value.Id = id;
      repository.Update(value);
    }

    // DELETE: api/CharacterSheet/5
    public void Delete(long id) {
      repository.Delete(new CharacterSheet { Id = id });
    }
  }
}
