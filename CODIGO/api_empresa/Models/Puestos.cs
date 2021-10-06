using System.ComponentModel.DataAnnotations;
namespace api_empresa.Models{
    public class Puestos{
        [Key]
        public int id_puesto { get; set; }
        public string puesto { get; set; }

    }
}