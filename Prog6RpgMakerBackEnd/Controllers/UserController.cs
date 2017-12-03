using System.Collections.Generic;
using System.Web.Http;
using RpgMaker.Data;
using RpgMaker.Model;
using RpgMaker.ModelImplementation;

namespace Prog6RpgMakerBackEnd.Controllers {
  public class UserController : ApiController {

    private IUserRepository repository;

    public UserController(IUserRepository repository)
      : base() {
      this.repository = repository;
    }

    // GET: api/User
    public IEnumerable<IUser> Get() {
      return repository.FindAll();
    }

    // GET: api/User/5
    public IUser Get(long id) {
      return repository.Find(id);
    }

    // POST: api/User
    public void Post([FromBody]IUser value) {
      value.Id = 0;
      repository.Save(value);
    }

    // PUT: api/User/5
    public void Put(long id, [FromBody]IUser value) {
      value.Id = id;
      repository.Update(value);
    }

    // DELETE: api/User/5
    public void Delete(long id) {
      repository.Delete(new User { Id = id });
    }
  }
}
