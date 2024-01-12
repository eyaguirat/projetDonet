using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SW.Models
{
    public class EvenementAleatoire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-incrémentation
        public int Id { get; set; } 
        public TypeEvenementAleatoire Type { get; set; }

        public EvenementAleatoire() { }

      
        public EvenementAleatoire(TypeEvenementAleatoire type)
        {
            Type = type;
        }

       
    }
}
