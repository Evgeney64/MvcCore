﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hcs.Model
{
    public partial class PaymentImportResultError
    {
        public long uniqueId { get; set; }
        public Guid TransactionGUID { get; set; }
        [StringLength(32)]
        public string objectId { get; set; }
        [Key]
        public Guid TransportGUID { get; set; }
        public Guid PaymentImportTransportGUID { get; set; }
        [Required]
        [StringLength(32)]
        public string ErrorCode { get; set; }
        [Required]
        public string ErrorDescription { get; set; }

        [ForeignKey(nameof(PaymentImportTransportGUID))]
        [InverseProperty(nameof(PaymentImportResult.PaymentImportResultErrors))]
        public virtual PaymentImportResult PaymentImportTransportGU { get; set; }
    }
}