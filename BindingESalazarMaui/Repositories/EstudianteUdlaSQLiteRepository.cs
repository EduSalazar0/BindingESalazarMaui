using BindingESalazarMaui.Interfaces;
using BindingESalazarMaui.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingESalazarMaui.Repositories
{
    public class EstudianteUdlaSQLiteRepository : IEstudianteUdlaRepository
    {
        private static string NombreBD = "EstudianteUDLA.db3";
        private SQLiteConnection _connection;

        public EstudianteUdlaSQLiteRepository() //Constructor
        {
            Init();
        }

        public void Init() //Metodo de definicion del path donde se guardara el archivo referente a la base de datos
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory,NombreBD);
            _connection = new SQLiteConnection(dbPath); //Valida si existe, si no existe crea y si si existe solo lo abre o valida
            _connection.CreateTable<EstudianteUdla>();
        }
        public bool ActualizarEstudianteUdla(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUdla(EstudianteUdla estudiante)
        {
            try
            {
                int insert = _connection.Insert(estudiante);
                if(insert > 0)
                {
                    return true;
                }
                return false;
            }
            catch 
            {
                throw;
            }
            
        }

        public EstudianteUdla DevuelveEstudianteUdla()
        {

            throw new NotImplementedException();
        }

        public IEnumerable<EstudianteUdla> DevuelveListadoEstudiantes()
        {
            var listadoEstudiantes = _connection.Table<EstudianteUdla>().ToList();
            return listadoEstudiantes;
            
        }

        public bool EliminarEstudianteUdla(int id)
        {
            try
            {
                int eliminar = _connection.Delete(id);
                if (eliminar > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
            
        }
    }
}
