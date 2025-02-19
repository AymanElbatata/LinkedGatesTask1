﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FirstTask2023.DAL.Models
{
    public partial class DevicePropertyDetailTBL
    {
        [Key]
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int DeviceId { get; set; }
        [StringLength(50)]
        public string Value { get; set; }

        [ForeignKey("DeviceId")]
        [InverseProperty("DevicePropertyDetailTBL")]
        public virtual DeviceTBL Device { get; set; }
        [ForeignKey("PropertyId")]
        [InverseProperty("DevicePropertyDetailTBL")]
        public virtual PropertiesTBL Property { get; set; }
    }
}