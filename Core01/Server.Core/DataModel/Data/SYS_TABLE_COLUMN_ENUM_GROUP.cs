//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class SYS_TABLE_COLUMN_ENUM_GROUP : IEntityObject, IEntityLog
    {
        #region Columns
        long IEntityObject.Id { get { return STABLE_COLUMN_ENUM_GROUP_ID; } }//;
        [KeyAttribute()]
        public int STABLE_COLUMN_ENUM_GROUP_ID { get; set; }//;
        public string STABLE_COLUMN_ENUM_GROUP_NAME { get; set; }//;
        public System.Nullable<System.DateTime> CRT_DATE { get; set; }//;
        public System.Nullable<System.DateTime> MFY_DATE { get; set; }//;
        public System.Nullable<int> MFY_SUSER_ID { get; set; }//;
        #endregion
        #region Navigation - children
        // 
        // FK_NSI_PARAM_SYS_TABLE_COLUMN_ENUM_GROUP   [NSI_PARAM.STABLE_COLUMN_ENUM_GROUP_ID]
        public virtual ICollection<NSI_PARAM> NSI_PARAM { get; set; }//;
        // 
        // FK_SYS_TABLE_COLUMN_SYS_TABLE_COLUMN_ENUM_GROUP   [SYS_TABLE_COLUMN.STABLE_COLUMN_ENUM_GROUP_ID]
        public virtual ICollection<SYS_TABLE_COLUMN> SYS_TABLE_COLUMN { get; set; }//;
        // 
        // FK_SYS_TABLE_COLUMN_ENUM_GROUP_SYS_TABLE_COLUMN_ENUM   [SYS_TABLE_COLUMN_ENUM.STABLE_COLUMN_ENUM_GROUP_ID]
        public virtual ICollection<SYS_TABLE_COLUMN_ENUM> SYS_TABLE_COLUMN_ENUM { get; set; }//;
        #endregion
        #region Constructor
        public SYS_TABLE_COLUMN_ENUM_GROUP()
        {
            this.SYS_TABLE_COLUMN_ENUM = new HashSet<SYS_TABLE_COLUMN_ENUM>();
            this.NSI_PARAM = new HashSet<NSI_PARAM>();
            this.SYS_TABLE_COLUMN = new HashSet<SYS_TABLE_COLUMN>();
        }
        #endregion
    }
}
