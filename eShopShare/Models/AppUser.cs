using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class AppUser : IdentityUser
{
    [Column(TypeName = "nvarchar")]
    [StringLength(400)]
    public string HomeAddress { get; set; }
    [DataType(DataType.Date)]
    public DateTime? DayOfBirth { get; set; }
    [StringLength(100)]
    public string Name { get; set; }
    public DateTime ParticipationDate { get; set; }
    //[JsonIgnore]
    public List<DonHang> DonHang { get; set; }
}

    