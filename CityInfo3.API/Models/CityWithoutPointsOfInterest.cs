﻿namespace CityInfo3.API.Models
{
    public class CityWithoutPointsOfInterest
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
