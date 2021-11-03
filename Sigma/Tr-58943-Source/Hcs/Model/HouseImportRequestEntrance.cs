﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hcs.Model
{
    public partial class HouseImportRequestEntrance
    {
        public HouseImportRequestEntrance()
        {
            HouseImportRequestPremises = new HashSet<HouseImportRequestPremise>();
        }

        public long uniqueId { get; set; }
        public Guid TransactionGUID { get; set; }
        [StringLength(32)]
        public string objectId { get; set; }
        [Key]
        public Guid TransportGUID { get; set; }
        public Guid HouseImportTransportGUID { get; set; }
        public Guid? EntranceGUID { get; set; }
        [Required]
        [StringLength(255)]
        public string EntranceNum { get; set; }
        [StringLength(20)]
        public string AnnulmentReasonCode { get; set; }
        public Guid? AnnulmentReasonGUID { get; set; }
        [StringLength(1024)]
        public string AnnulmentInfo { get; set; }

        [ForeignKey(nameof(HouseImportTransportGUID))]
        [InverseProperty(nameof(HouseImportRequest.HouseImportRequestEntrances))]
        public virtual HouseImportRequest HouseImportTransportGU { get; set; }
        [InverseProperty(nameof(HouseImportRequestPremise.HouseImportEntranceTransportGU))]
        public virtual ICollection<HouseImportRequestPremise> HouseImportRequestPremises { get; set; }
    }
}