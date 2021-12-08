using AlgorithmicDesktopClient.ViewModels.Base;

namespace AlgorithmicDesktopClient.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Algorithmic";

        public string Title
        {
            get => _Title;
            /*set
            {
                //if (Equals(_Title, value)) return;
                //_Title = value;
                //OnPropertyChanged();

                Set(ref _Title, value);
            }*/
            set => Set(ref _Title, value);
        }
    }
}
