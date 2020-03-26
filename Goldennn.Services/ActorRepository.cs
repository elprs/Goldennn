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
    ////erxomai sto sevices kai tha ftiakso mia klass pou tja tin po   ActorRepository
    //public class ActorRepository //giati o apo8ikarios fernei apo to repositoty tainiew. service k

    //{
    //    public IEnumerable<Actor> GetAll()
    //    {
    //        using (MyDatabase db = new MyDatabase())
    //        {
    //            return db.Actors.ToList(); // sto run time se mi alista n aeinai sumbato me to ienumerable

    //        }
    //    }

    //    public Actor GetById(int? id)
    //    {
    //        using (MyDatabase db = new MyDatabase())
    //        {
    //            return db.Actors.Find(id);
    //        }
    //    }

    //    //public IQueryable<Actor> GetAll()
    //    //{
    //    //    using (MyDatabase db = new MyDatabase())
    //    //    {
    //    //        return db.Actors;
    //    //    }
    //    //}



    //    public void Insert(Actor Actor) //fere mou mi atainia pao ton ourano na tin pro8seo sti lista pragmaton
    //                                    //exo 2 tropous
    //    {
    //        ////1
    //        //using (MyDatabase db = new MyDatabase())
    //        //{
    //        //    db.Actors.Add(Actor);
    //        //    db.SaveChanges();
    //        //}

    //        //2os kai kaluteros tropos
    //        using (MyDatabase db = new MyDatabase())//to antikeimeno einai etoimo gia na ginei commit, gia na paei sti basi
    //        {
    //            db.Entry(Actor).State = EntityState.Added; //ela bale to o Actor pou ir8e apo to diastima se katastasi. poioa katasasti? entity state (einai ena enum tis .panw) poia katastasi? .added
    //            db.SaveChanges();
    //        }

    //    }

    //    public void Update(Actor Actor)
    //    {
    //        using (MyDatabase db = new MyDatabase())
    //        {
    //            db.Entry(Actor).State = EntityState.Modified;
    //            db.SaveChanges();

    //        }
    //    }
    //    public void Delete(Actor Actor)
    //    {
    //        using (MyDatabase db = new MyDatabase())
    //        {
    //            db.Entry(Actor).State = EntityState.Deleted;
    //            db.SaveChanges();

    //        }
    //    }

    // ==================== ΠΡΟΤΙΜΑΩ τον παρακατω τροπο ΟΤΑΝ θελω να μεταβω σε Iqueryable ==============
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


    public class ActorRepository
    {
        MyDatabase db = new MyDatabase();
        //GetAll
        public IEnumerable<Actor> GetAll()
        {
            return db.Actors.ToList();
        }
        //GetById
        public Actor GetById(int? id)
        {
            return db.Actors.Find(id);
        }

        //Insert
        public void Insert(Actor actor)
        {
            db.Entry(actor).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(Actor actor)
        {
            db.Entry(actor).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete
        public void Delete(Actor actor)
        {
            db.Entry(actor).State = EntityState.Deleted;
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

