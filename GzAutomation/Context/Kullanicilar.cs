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
    
    public partial class Kullanicilar
    {
        public Kullanicilar()
        {
            this.IslemKaydis = new HashSet<IslemKaydi>();
        }
    
        public int Id { get; set; }
        public string Kuladi { get; set; }
        public string Sifre { get; set; }
        public string Unvan { get; set; }
        public string AdSoyad { get; set; }
    
        public virtual ICollection<IslemKaydi> IslemKaydis { get; set; }
    }
}
