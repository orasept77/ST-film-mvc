using NHibernate;
using NHibernate.Cfg;
using System.Web;

namespace test
{
    public class NHibernateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var filmConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Mapping\Film.hbm.xml");
            var gatunekFilmuPrzedmiotuConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Mapping\GatunekFilmu.hbm.xml");
            var rezysterPrzedmiotuConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Mapping\Rezyser.hbm.xml");

            configuration.AddFile(filmConfigurationFile);
            configuration.AddFile(gatunekFilmuPrzedmiotuConfigurationFile);
            configuration.AddFile(rezysterPrzedmiotuConfigurationFile);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}