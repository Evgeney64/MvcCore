﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hcs.Model
{
    public partial class DeviceValueImportResult
    {
        public DeviceValueImportResult()
        {
            DeviceValueImportResultErrors = new HashSet<DeviceValueImportResultError>();
        }

        public long uniqueId { get; set; }
        public Guid TransactionGUID { get; set; }
        [StringLength(32)]
        public string objectId { get; set; }
        [Key]
        public Guid TransportGUID { get; set; }
        public Guid? DeviceValueGUID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }

        [InverseProperty(nameof(DeviceValueImportResultError.DeviceValueImportTransportGU))]
        public virtual ICollection<DeviceValueImportResultError> DeviceValueImportResultErrors { get; set; }
    }
}