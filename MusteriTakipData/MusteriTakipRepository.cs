using Microsoft.EntityFrameworkCore;
using Pandap.Logic.Model.MusteriTakip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandap.Logic.MusteriTakipData
{
    public class MusteriTakipRepository
    {
        MusteriTakipDbContext db = new MusteriTakipDbContext();

        public List<Gorusme> GorusmeListe()
        {
            var s= db.Gorusmeler

                .AsNoTracking()
                .ToList();

            return s;
        }

        public Task<List<Gorusme>> GorusmeleriGetir()
        {
            return db.Gorusmeler

                .AsNoTracking()
                .ToListAsync();
        }


    

        public Gorusme GorusmeGetir(int id)
        {
            return
                db.Gorusmeler
                .Where(c => c.Id == id).First();
        }

        public Gorusme GorusmeGetir_NoTrack(int id)
        {
            return
                db.Gorusmeler
                .AsNoTracking()
                .Where(c => c.Id == id).First();
        }


        public void GorusmeEkle(Gorusme gorusme)
        {
            db.Gorusmeler.Add(gorusme);
        }

        public void Kaydet()
        {
            db.SaveChanges();
        }


      

    }
}
