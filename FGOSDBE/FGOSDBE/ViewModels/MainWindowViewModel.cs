using Prism.Mvvm;

namespace FGOSDBE.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "FGOSimluator ServantDataBaseEditor";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
