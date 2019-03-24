using DevExpress.Mvvm;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandap.Logic.Model.MusteriTakip
{
    public class Gorusme : BindableBase
    {
     

        [Key]
        public int Id { get; set; }


        public string KullanimAlanTipKod
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string MusteriCariKod
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string CariIsim
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


        public string PlasiyerAdSoyad
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

  
  

    }
}
