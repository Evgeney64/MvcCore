﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hcs.Model
{
    public partial class NsiExportRequest
    {
        public long uniqueId { get; set; }
        public Guid TransactionGUID { get; set; }
        [Key]
        public Guid TransportGUID { get; set; }
        public int RegistryNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedAfter { get; set; }
    }
}