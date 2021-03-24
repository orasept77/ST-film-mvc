using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test.Models;

namespace test
{
    public partial class Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitFilm();
            }
        }

        private void InitFilm()
        {
            using (var session = NHibernateSession.OpenSession())
            {
                var film = session.Query<Film>().ToList();
                gvFilm.DataSource = film;
                gvFilm.DataBind();
            }
        }
    }
}