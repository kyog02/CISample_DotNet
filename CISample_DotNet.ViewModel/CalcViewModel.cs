using CISample_DotNet.Moidel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CISample_DotNet.ViewModel
{
    public partial class CalcViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Output))]
        private string input1 = "0";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Output))]
        private string input2 = "0";

        public string Output => CalcModel.Add(int.Parse(Input1), int.Parse(Input2)).ToString();
    }
}
