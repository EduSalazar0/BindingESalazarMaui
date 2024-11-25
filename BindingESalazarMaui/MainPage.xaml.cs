using BindingESalazarMaui.Interfaces;
using BindingESalazarMaui.Models;
using BindingESalazarMaui.Repositories;

namespace BindingESalazarMaui
{
    public partial class MainPage : ContentPage
    {
        IEstudianteUdlaRepository _estudianteUdlaRepository;
        EstudianteUdla estudiante = new EstudianteUdla();

        public MainPage()
        {
            _estudianteUdlaRepository = new EstudianteUdlaPorArchivosRepository();
            InitializeComponent();
            estudiante = _estudianteUdlaRepository.DevuelveEstudianteUdla();
            BindingContext = estudiante;
        }
        private async void GuardarEstudiante_Clicked(object sender, EventArgs e)
        {
            EstudianteUdla estu = new EstudianteUdla
            {
                Id = "1",
                Name="Eduardo",
                Carrera="Ingenieria de Software"

            };
            bool guardar_estudiante = _estudianteUdlaRepository.CrearEstudianteUdla(estu);

            if (guardar_estudiante)
            {
                await DisplayAlert("Alerta", "Todo muy bien", "Ok");
            }
            else
            {
                await DisplayAlert("Alerta", "Negado papa", "Ok");
            }
            
        }


    }
}
