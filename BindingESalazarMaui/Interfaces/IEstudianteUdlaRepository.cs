using BindingESalazarMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingESalazarMaui.Interfaces
{
    public interface IEstudianteUdlaRepository
    {
        IEnumerable<EstudianteUdla> DevuelveListadoEstudiantes();
        EstudianteUdla DevuelveEstudianteUdla();
        bool CrearEstudianteUdla(EstudianteUdla estudiante);
        bool ActualizarEstudianteUdla(EstudianteUdla estudiante);
        bool EliminarEstudianteUdla(int id);

    }
}
