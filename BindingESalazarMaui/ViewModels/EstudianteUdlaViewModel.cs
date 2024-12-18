using BindingESalazarMaui.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BindingESalazarMaui.ViewModels
{
    public class EstudianteUdlaViewModel : INotifyPropertyChanged
    {
        private List<EstudianteUdla> _estudiantesUdla; //MVVM

        public List<EstudianteUdla> estudianteUdla
        {
            get => _estudiantesUdla;

            set
            {
                if (_estudiantesUdla != value)
                {
                    _estudiantesUdla = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CommandGuardarEstudianteUdla { get; set; } //Regula el guardar estudiante
        public event Action ShowAlert;
        public EstudianteUdlaViewModel()
        {
            CommandGuardarEstudianteUdla = new Command(GuardarEstudianteUdla);
        }

        public void GuardarEstudianteUdla()
        {
            ShowAlert?.Invoke();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
