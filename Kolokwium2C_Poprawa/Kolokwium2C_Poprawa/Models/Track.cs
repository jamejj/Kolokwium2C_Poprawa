﻿using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2C_Poprawa.Models;

public class Track
{
    [Key] 
    public int TrackId { get; set; }
    [MaxLength(100)] 
    public string Name { get; set; } = null!;
    [Precision(5, 2)]
    public decimal LengthInKm { get; set; }

    public ICollection<TrackRace> TrackRaces { get; set; } = new List<TrackRace>();
}