﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EfCore.Models;

public partial class department
{
    public int Dept_id { get; set; }

    public string Dept_Name { get; set; }

    public int? Hos_id { get; set; }

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    public virtual Hospital Hos { get; set; }
}