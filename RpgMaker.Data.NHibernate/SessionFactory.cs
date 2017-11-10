using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace RpgMaker.Data.NHibernate {
  public class SessionFactory {

    private static ISessionFactory sessionFactory;
    private static readonly object factorylock = new object();

    public ISession OpenSession() {
      lock (factorylock) {
        if (sessionFactory == null) {
          string connectionString = "Server=localhost;Database=RpgMaker;Uid=root;Pwd=;";
          var cfg = Fluently.Configure().
                             Database(MySQLConfiguration.Standard.ShowSql().ConnectionString(connectionString)).
                             Mappings(m => m.FluentMappings.AddFromAssembly(this.GetType().Assembly));
          sessionFactory = cfg.BuildSessionFactory();
          BuildSchema(cfg);
        }
      }
      return sessionFactory.OpenSession();
    }

    private static void BuildSchema(FluentConfiguration configuration) {
      var sessionSource = new SessionSource(configuration);
      var session = sessionSource.CreateSession();
      sessionSource.BuildSchema(session);
    }

  }
}
