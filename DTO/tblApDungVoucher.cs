//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblApDungVoucher
    {
        public string MaHDB { get; set; }
        public string MaV { get; set; }
        public string GhiChu { get; set; }
    
        public virtual tblHoaDonBan tblHoaDonBan { get; set; }
        public virtual tblVoucher tblVoucher { get; set; }
    }
}
