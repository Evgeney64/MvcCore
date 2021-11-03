﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hcs.Model
{
    public partial class HouseExportResultEntrance
    {
        public HouseExportResultEntrance()
        {
            HouseExportResultPremises = new HashSet<HouseExportResultPremise>();
        }

        public long uniqueId { get; set; }
        public Guid TransactionGUID { get; set; }
        [Key]
        public Guid TransportGUID { get; set; }
        public Guid HouseExportTransportGUID { get; set; }
        public Guid EntranceGUID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModificationDate { get; set; }
        [StringLength(255)]
        public string EntranceNum { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TerminationDate { get; set; }
        [StringLength(20)]
        public string AnnulmentReasonCode { get; set; }
        public Guid? AnnulmentReasonGUID { get; set; }
        [StringLength(1024)]
        public string AnnulmentInfo { get; set; }
        public bool? InformationConfirmed { get; set; }

        [ForeignKey(nameof(HouseExportTransportGUID))]
        [InverseProperty(nameof(HouseExportResult.HouseExportResultEntrances))]
        public virtual HouseExportResult HouseExportTransportGU { get; set; }
        [InverseProperty(nameof(HouseExportResultPremise.HouseExportEntranceTransportGU))]
        public virtual ICollection<HouseExportResultPremise> HouseExportResultPremises { get; set; }
    }
}