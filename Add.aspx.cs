using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitGatunek();
                InitRezyser();
            }
        }

        private void InitGatunek()
        {
            using (var session = NHibernateSession.OpenSession())
            {
                var dataResponse = session.Query<GatunekFilmu>()
                    .Where(x => x.Aktywny == 0)
                    .ToList();
                ddlRodzaj.DataSource = dataResponse;
                ddlRodzaj.DataTextField = "Nazwa";
                ddlRodzaj.DataValueField = "Id";
                ddlRodzaj.DataBind();
            }
        }

        private void InitRezyser()
        {
            using (var session = NHibernateSession.OpenSession())
            {
                var dataResponse = session.Query<Rezyser>()
                    .ToList();

                ddlRezyser.DataSource = dataResponse;
                ddlRezyser.DataTextField = "Imie";
                ddlRezyser.DataValueField = "Id";
                ddlRezyser.DataBind();
            }
        }

        private void AddFilm(Film film)
        {
            using (var session = NHibernateSession.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(film);
                    transaction.Commit();
                }
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            AddFilm(new Film()
            {
                Nazwa = Nazwa.Text,
                Rok = Int32.Parse(Rok.Text),
                Ocena = Convert.ToDecimal(Ocena.Text, new CultureInfo("en-US")),
                Jezyk = Int32.Parse(ddlJezyk.SelectedItem.Value),
                RodzajId = new GatunekFilmu()
                {
                    Id = Int32.Parse(ddlRodzaj.SelectedItem.Value)
                },
                RezyserId = new Rezyser
                {
                    Id = Int32.Parse(ddlRezyser.SelectedItem.Value)
                }
            });
        }
    }
}