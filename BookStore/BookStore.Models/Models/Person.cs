﻿
namespace BookStore.Models.Models
{
    public record Person 
    {
        public int ID { get; set; }
        public string Name { get; init; }
        public int Age { get; init; }
        public DateTime DateOfBirth { get; init; }
    }
}