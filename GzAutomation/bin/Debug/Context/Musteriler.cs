//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GzAutomation.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musteriler
    {
        public Musteriler()
        {
            this.Randevulars = new HashSet<Randevular>();
        }
    
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string TelCep { get; set; }
        public string Adres { get; set; }
        public string Eposta { get; set; }
    
        public virtual Borclar Borclar { get; set; }
        public virtual IslemKaydi IslemKaydi { get; set; }
        public virtual ICollection<Randevular> Randevulars { get; set; }
    }
}
