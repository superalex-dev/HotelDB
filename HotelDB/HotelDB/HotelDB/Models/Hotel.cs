﻿using System;
using System.ComponentModel.DataAnnotations;

public class Hotel
{
    [Key]
    public int HotelID { get; set; }
    public string HotelName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public virtual ICollection<Room> Rooms { get; set; }
}