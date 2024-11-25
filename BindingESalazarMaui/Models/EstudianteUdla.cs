using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingESalazarMaui.Models
{
    public class EstudianteUdla
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Carrera { get; set; }


    }
}
