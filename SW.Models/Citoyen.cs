using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SW.Models
{
    public class Citoyen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public Espece? Espece { get; set; }
        public int? PereBiologiqueID { get; set; }
        public Citoyen? PereBiologique { get; set; }
        public int? MereBiologiqueID { get; set; }
        public Citoyen? MereBiologique { get; set; }
        public int? Bonheur { get; set; }
        public int? Fertilite { get; set; }
        public int? PointsDeMerites { get; set; }

        public List<Citoyen> Citoyens { get; set; }




    }
}