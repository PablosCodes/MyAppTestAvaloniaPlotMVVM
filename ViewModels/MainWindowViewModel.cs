using System;
using System.Globalization;
using System.Threading.Tasks;
using ReactiveUI;
using ScottPlot;
using ScottPlot.Avalonia;



namespace MyAppTestAvaloniaPlotMVVM.ViewModels

{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _clock;
        private string _message;
        public string Clock
        {
            get => _clock;
            set => this.RaiseAndSetIfChanged(ref _clock, value);
        }

        public string Message
        {
            get => _message;
            set => this.RaiseAndSetIfChanged(ref _message, value);
        }

        public MainWindowViewModel()
        {
            _message = "Tekst początkowy";
            _clock = DateTime.Now.ToString("HH:m:s");
            Task.Run(() =>
            {
                while (true)
                {
                    Clock = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                    Task.Delay(1000).Wait();
                }
            });
        }
        public void ButtonClicked() => Message = "Tekst drugi!";
        public void ButtonClicked2() => Message = "Tekst pierwszy!";



    }

}