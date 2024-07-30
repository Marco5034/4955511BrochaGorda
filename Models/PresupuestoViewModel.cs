using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4955511BrochaGorda.Models
{
    partial class PresupuestoViewModel : ObservableObject
    {
        [ObservableProperty]
        public string metros;
        [ObservableProperty]
        public string precioxmetro;
        [ObservableProperty]
        public string total;

        [RelayCommand]
        private void Presupuesto()
        {
            if (double.TryParse(Metros, out double v1) && double.TryParse(Precioxmetro, out double v2))
            {
                Total = (v1 * v2).ToString("$0.00");
            }
            else
            {
                Total = "Ingrese números válidos";
            }
        }
    }
}
