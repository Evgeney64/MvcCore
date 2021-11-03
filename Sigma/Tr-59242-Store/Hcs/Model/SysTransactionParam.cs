﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hcs.Model
{
    public partial class SysTransactionParam
    {
        [Key]
        public long TransactionParamId { get; set; }
        public Guid TransactionGUID { get; set; }
        [Required]
        [StringLength(128)]
        public string ParamName { get; set; }
        [StringLength(1024)]
        public string ParamValue { get; set; }

        [ForeignKey(nameof(TransactionGUID))]
        [InverseProperty(nameof(SysTransaction.SysTransactionParams))]
        public virtual SysTransaction TransactionGU { get; set; }
    }
}