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
    
    public partial class SYS_BASE_RELATION : IEntityObject, IEntityLog
    {
        #region Columns
        long IEntityObject.Id { get { return SBASE_RELATION_ID; } }//;
        [KeyAttribute()]
        public long SBASE_RELATION_ID { get; set; }//;
        public System.Nullable<int> STABLE_ID { get; set; }//;
        public System.Nullable<long> ID { get; set; }//;
        public System.Nullable<long> SOURCE_ID { get; set; }//;
        public System.Nullable<int> SOURCE_TYPE_ID { get; set; }//;
        public System.Nullable<int> NDATA_SOURCE_ID { get; set; }//;
        public System.Nullable<long> PARENT_ID { get; set; }//;
        public System.Nullable<long> BINARY_SUMM { get; set; }//;
        public System.Nullable<System.DateTime> CRT_DATE { get; set; }//;
        public System.Nullable<System.DateTime> MFY_DATE { get; set; }//;
        public System.Nullable<int> MFY_SUSER_ID { get; set; }//;
        #endregion
        #region Navigation - parents
        // 
        // FK_SYS_BASE_RELATION_NSI_DATA_SOURCE   [NSI_DATA_SOURCE.NDATA_SOURCE_ID]
        [ForeignKey("NDATA_SOURCE_ID")]
        public virtual NSI_DATA_SOURCE NSI_DATA_SOURCE { get; set; }//;
        #endregion
    }
}
