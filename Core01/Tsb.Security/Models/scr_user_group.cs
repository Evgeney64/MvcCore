//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tsb.Security.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class scr_user_group
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public scr_user_group()
        {
            this.scr_user = new HashSet<scr_user>();
            //this.scr_user_group1 = new HashSet<scr_user_group>();
        }

        [Key]
        public int user_group_id { get; set; }
        public string user_group_name { get; set; }
        public Nullable<int> parent_id { get; set; }
        public short is_fixed { get; set; }
    
        //public virtual scr_principal scr_principal { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<scr_user> scr_user { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<scr_user_group> scr_user_group1 { get; set; }
        //public virtual scr_user_group scr_user_group2 { get; set; }
    }
}
