using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goldennn.Database;
using Goldennn.Entities;

namespace Goldennn.Services
{

    //services
    //dokimasa na paro ola ta prahmata se lidta. ta pira ola. Get all loipon. 
    //GetAll // de 8a sundeetai me to datadata base alla 8a ta pairnei apo to service
    //periame//leitoyrgo//anagnotisa//toxw
    //erxomai sto sevices kai tha ftiakso mia klass pou tja tin po   MovieRepository
    public class MovieRepository //giati o apo8ikarios fernei apo to repositoty tainiew. service apo8ikis

    {
        public IEnumerable<Movie> GetAll()
            {
        using (MyDatabase db = new MyDatabase())
        {
                return db.Movies.ToList();
        }
    }
}
}
