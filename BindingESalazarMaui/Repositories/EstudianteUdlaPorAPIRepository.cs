using BindingESalazarMaui.Interfaces;
using BindingESalazarMaui.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BindingESalazarMaui.Repositories
{
    public class EstudianteUdlaPorAPIRepository : IEstudianteUdlaRepository
    {
        public string _urlEndpoint = "https://www.freetestapi.com/api/v1/students";
        public bool ActualizarEstudianteUdla(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUdla(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public EstudianteUdla DevuelveEstudianteUdla()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EstudianteUdla> DevuelveListadoEstudiantes()
        {
            using (HttpClient httpClient = new HttpClient())  //Permite realizar consultas
            {
                var response = httpClient.GetAsync(_urlEndpoint).Result; // Todas las respuestas 
                var json_data = response.Content.ReadAsStringAsync().Result; // Obtenemos el contenido y lo transformamos en string
                List<EstudianteAPI> estudiantesAPI = JsonConvert.DeserializeObject<List<EstudianteAPI>>(json_data); // Se convierte en un listado de tipo Json
            }
        }

        public bool EliminarEstudianteUdla(int id)
        {
            throw new NotImplementedException();
        }
    }
}
