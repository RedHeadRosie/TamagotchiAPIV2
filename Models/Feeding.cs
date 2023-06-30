using System;

namespace TamagotchiAPIV2.Models
{
    public class Feeding
    {
        public int Id { get; set; }
        public DateTime When { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }
}