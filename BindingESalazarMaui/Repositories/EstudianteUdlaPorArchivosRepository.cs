using BindingESalazarMaui.Interfaces;
using BindingESalazarMaui.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BindingESalazarMaui.Repositories
{
    public class EstudianteUdlaPorArchivosRepository : IEstudianteUdlaRepository
    {
        private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");
        public bool ActualizarEstudianteUdla(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUdla(EstudianteUdla estudiante)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public EstudianteUdla DevuelveEstudianteUdla()
        {
            EstudianteUdla estudiante = new EstudianteUdla();
            if (File.Exists(_fileName))
            {
                string json_data = File.ReadAllText(_fileName);
                estudiante = JsonConvert.DeserializeObject<EstudianteUdla>(json_data);
            }

            return estudiante;
        }
                

        public IEnumerable<EstudianteUdla> DevuelveListadoEstudiantes()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudianteUdla(int id)
        {
            throw new NotImplementedException();
        }
    }
}
