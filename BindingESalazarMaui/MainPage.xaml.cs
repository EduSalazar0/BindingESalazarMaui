using BindingESalazarMaui.Interfaces;
using BindingESalazarMaui.Models;
using BindingESalazarMaui.Repositories;
using BindingESalazarMaui.ViewModels;

namespace BindingESalazarMaui
{
    public partial class MainPage : ContentPage
    {
        //IEstudianteUdlaRepository _estudianteUdlaRepository;
        //EstudianteUdla estudiante = new EstudianteUdla();

        public MainPage()
        {
            /*_estudianteUdlaRepository = new EstudianteUdlaSQLiteRepository();
            
            //estudiante = _estudianteUdlaRepository.DevuelveEstudianteUdla();
            var estudiantesUDLA = _estudianteUdlaRepository.DevuelveListadoEstudiantes().ToList();
            BindingContext = estudiante;*/
            InitializeComponent();
            var ViewModel = new EstudianteUdlaViewModel();
            BindingContext = ViewModel;

            ViewModel.ShowAlert += async () =>
            {
                await DisplayAlert("Alerta", "Se ha cambiado el mensaje", "Ok");
            };

        }
        /*private async void GuardarEstudiante_Clicked(object sender, EventArgs e)
        {
            EstudianteUdla estu = new EstudianteUdla
            {
                Id = editor_Id.Text,
                Name = editor_Name.Text,
                Carrera = editor_Carrera.Text,  

            };
            bool guardar_estudiante = _estudianteUdlaRepository.CrearEstudianteUdla(estu);

            if (guardar_estudiante)
            {
                await DisplayAlert("Alerta", "Todo muy bien", "Ok");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Alerta", "Negado papa", "Ok");
                Navigation.PushAsync(new MainPage());
            }
            
        }*/


    }
}
