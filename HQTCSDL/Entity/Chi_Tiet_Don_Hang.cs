//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HQTCSDL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chi_Tiet_Don_Hang
    {
        public int Ma_Don_Hang { get; set; }
        public int Ma_item { get; set; }
        public int Ma_SP { get; set; }
        public int So_Luong { get; set; }
        public decimal Gia_Ca { get; set; }
        public decimal Mien_Giam { get; set; }
    
        public virtual Don_Hang Don_Hang { get; set; }
        public virtual San_Pham San_Pham { get; set; }
    }
}
