﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FirstTask2023.DAL.Models
{
    public partial class DeviceTBL
    {
        public DeviceTBL()
        {
            DevicePropertyDetailTBL = new HashSet<DevicePropertyDetailTBL>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string SerialNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AcquisitionDate { get; set; }
        [StringLength(50)]
        public string Memo { get; set; }
        public int? DeviceCategoryId { get; set; }
        public int? CurrentUserId { get; set; }
        public int? BrandId { get; set; }

        [ForeignKey("BrandId")]
        [InverseProperty("DeviceTBL")]
        public virtual BrandTBL Brand { get; set; }
        [ForeignKey("CurrentUserId")]
        [InverseProperty("DeviceTBL")]
        public virtual UserTBL CurrentUser { get; set; }
        [ForeignKey("DeviceCategoryId")]
        [InverseProperty("DeviceTBL")]
        public virtual DeviceCategoryTBL DeviceCategory { get; set; }
        [InverseProperty("Device")]
        public virtual ICollection<DevicePropertyDetailTBL> DevicePropertyDetailTBL { get; set; }
    }
}