using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goldennn.Database;
using Goldennn.Entities;
using System.Data.Entity;

namespace Goldennn.Services
{

    ////services
    ////dokimasa na paro ola ta prahmata se lidta. ta pira ola. Get all loipon. 
    ////GetAll // de 8a sundeetai me to datadata base alla 8a ta pairnei apo to service
    ////periame//leitoyrgo//anagnotisa//toxw
    ////erxomai sto sevices kai tha ftiakso mia klass pou tja tin po   GenreRepository
    //public class GenreRepository //giati o apo8ikarios fernei apo to repositoty tainiew. service k

    //{
    //    public IEnumerable<Genre> GetAll()
    //    {
    //        using (MyDatabase db = new MyDatabase())
    //        {
    //            return db.Genres.ToList(); // sto run time se mi alista n aeinai sumbato me to ienumerable

    //        }
    //    }

    //    public Genre GetById(int? id)
    //    {
    //        using (MyDatabase db = new MyDatabase())
    //        {
    //            return db.Genres.Find(id);
    //        }
    //    }

    //    //public IQueryable<Genre> GetAll()
    //    //{
    //    //    using (MyDatabase db = new MyDatabase())
    //    //    {
    //    //        return db.Genres;
    //    //    }
    //    //}



    //    public void Insert(Genre Genre) //fere mou mi atainia pao ton ourano na tin pro8seo sti lista pragmaton
    //                                    //exo 2 tropous
    //    {
    //        ////1
    //        //using (MyDatabase db = new MyDatabase())
    //        //{
    //        //    db.Genres.Add(Genre);
    //        //    db.SaveChanges();
    //        //}

    //        //2os kai kaluteros tropos
    //        using (MyDatabase db = new MyDatabase())//to antikeimeno einai etoimo gia na ginei commit, gia na paei sti basi
    //        {
    //            db.Entry(Genre).State = EntityState.Added; //ela bale to o Genre pou ir8e apo to diastima se katastasi. poioa katasasti? entity state (einai ena enum tis .panw) poia katastasi? .added
    //            db.SaveChanges();
    //        }

    //    }

    //    public void Update(Genre Genre)
    //    {
    //        using (MyDatabase db = new MyDatabase())
    //        {
    //            db.Entry(Genre).State = EntityState.Modified;
    //            db.SaveChanges();

    //        }
    //    }
    //    public void Delete(Genre Genre)
    //    {
    //        using (MyDatabase db = new MyDatabase())
    //        {
    //            db.Entry(Genre).State = EntityState.Deleted;
    //            db.SaveChanges();

    //        }
    //    }

    // ==================== ΠΡΟΤΙΜΑΩ τον παρακατω τροπο ΟΤΑΝ θελω να μεταβω σε Iqueryable ==============
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


    public class GenreRepository
    {
        MyDatabase db = new MyDatabase();
        //GetAll
        public IEnumerable<Genre> GetAll()
        {
            return db.Genres.ToList();
        }
        //GetById
        public Genre GetById(int? id)
        {
            return db.Genres.Find(id);
        }

        //Insert
        public void Insert(Genre genre)
        {
            db.Entry(genre).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(Genre genre)
        {
            db.Entry(genre).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete
        public void Delete(Genre genre)
        {
            db.Entry(genre).State = EntityState.Deleted;
            db.SaveChanges();
        }


        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

