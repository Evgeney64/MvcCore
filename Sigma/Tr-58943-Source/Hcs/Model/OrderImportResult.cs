﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hcs.Model
{
    public partial class OrderImportResult
    {
        public OrderImportResult()
        {
            OrderImportResultErrors = new HashSet<OrderImportResultError>();
        }

        public long uniqueId { get; set; }
        public Guid TransactionGUID { get; set; }
        [StringLength(32)]
        public string objectId { get; set; }
        [Key]
        public Guid TransportGUID { get; set; }
        public Guid? OrderGUID { get; set; }
        [StringLength(32)]
        public string OrderID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }

        [InverseProperty(nameof(OrderImportResultError.OrderImportTransportGU))]
        public virtual ICollection<OrderImportResultError> OrderImportResultErrors { get; set; }
    }
}