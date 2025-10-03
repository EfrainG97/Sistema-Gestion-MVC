using System.ComponentModel.DataAnnotations;

namespace P2_SistemaDeGestion.Models
{
    public class Cliente
    {
        [Display(Name = "ID Cliente")]
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        public string? Nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string? ApellidoPaterno { get; set; }
        [Display(Name ="Apellido Materno")]
        public string? ApellidoMaterno { get; set; }
        [Display(Name = "Telefono")]
        public string? Telefono { get; set; }

    }
}
