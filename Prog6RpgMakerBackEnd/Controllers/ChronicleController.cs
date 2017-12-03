﻿using System.Collections.Generic;
using System.Web.Http;
using RpgMaker.Data;
using RpgMaker.Model;
using RpgMaker.ModelImplementation;

namespace Prog6RpgMakerBackEnd.Controllers {
  public class ChronicleController : ApiController {

    private IChronicleRepository repository;

    public ChronicleController(IChronicleRepository repository)
      : base() {
      this.repository = repository;
    }

    // GET: api/Chronicle
    public IEnumerable<IChronicle> Get() {
      return repository.FindAll();
    }

    // GET: api/Chronicle/5
    public IChronicle Get(long id) {
      return repository.Find(id);
    }

    // POST: api/Chronicle
    public void Post([FromBody]IChronicle value) {
      value.Id = 0;
      repository.Save(value);
    }

    // PUT: api/Chronicle/5
    public void Put(long id, [FromBody]IChronicle value) {
      value.Id = id;
      repository.Update(value);
    }

    // DELETE: api/Chronicle/5
    public void Delete(long id) {
      repository.Delete(new Chronicle { Id = id });
    }
  }
}