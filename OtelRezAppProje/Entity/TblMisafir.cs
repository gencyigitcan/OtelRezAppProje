//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelRezAppProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblMisafir
    {
        public int MisafirId { get; set; }
        public string AdSoyad { get; set; }
        public string TCKimlikNo { get; set; }
        public string MailAdresi { get; set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
        public string KimlikFoto1 { get; set; }
        public string KimlikFoto2 { get; set; }
        public Nullable<int> Ulke { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
        public virtual TblUlke TblUlke { get; set; }
    }
}
