using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace RpgMaker.Injection {
  public static class ContainerFactory {

    private static Container container;
    public static Container Container {
      get {
        if(container == null) {
          container = new Container();
        }
        return container;
      }
    }

  }
}
