using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingESalazarMaui.Models
{
    [Table("EstudiantesUDLA")]
    public class EstudianteUdla
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage ="El nombre es necesario")]
        public string Name { get; set; }
        [Required(ErrorMessage ="La carrera es necesaria")]

        public string Carrera { get; set; }


    }
}
