using System;
using System.Collections.Generic;
using System.Text;

namespace RpgMaker.Model {

  public interface IEntity<T> {

    T Id { get; set; }

  }

}
