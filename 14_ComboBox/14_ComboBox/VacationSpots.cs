using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ComboBox
{
    class VacationSpots : ObservableCollection<string>
    {
        public VacationSpots()
        {

            Add("Spain");
            Add("France");
            Add("Japanese");
            Add("Mexico");
            Add("Italy");
            Add("Chinese");
        }
    }
}
