using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandap.Logic.MusteriTakipData
{
    public class Result
    {
        public int ResultCode { get; set; }
    }

    public class MusteriTakipService
    {
        

        public int MusteriBilgileriGuncelle(string cariKod, string tel, string adres, string kullanimAlanTipKod, int? yillikTonaj)
        {
            //3 iş merkezi
            //4FirmaGrupTip,
            //5AktifPasifDurum

            MusteriTakipDbContext dc = new MusteriTakipDbContext();

            var str = $"UPDATE PANDA2019.dbo.TBLCASABIT SET  CARI_TEL = '{tel}', RAPOR_KODU1 = '{kullanimAlanTipKod}', " +
                      $"RAPOR_KODU2 = '{yillikTonaj}', " +
                      $" CARI_ADRES = '{adres}' WHERE(CARI_KOD = '{cariKod}')";

            var x=dc.Database.ExecuteSqlCommand(str);

            dc.Database.ExecuteSqlCommandAsync("exec Satis.Upsert_PandapCari");



            return 0;


        }
    }
}
