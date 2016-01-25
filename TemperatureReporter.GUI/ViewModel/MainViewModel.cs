using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using TemperatureReporter.Contracts.Factory;
using TemperatureReporter.Contracts.Input;
using TemperatureReporter.Exceptions.Input;
using TemperatureReporter.GUI.Model;

namespace TemperatureReporter.GUI.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        public ICommand ReadLogFile { get; private set; }

        private string _inputFilePath { get; set; }
        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        }

        public String InputFilePath 
        {
            get { return _inputFilePath; }
            set
            {
                if (_inputFilePath == value) return;
                _inputFilePath = value;
                RaisePropertyChanged("InputFilePath");
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
          this.ReadLogFile = new RelayCommand(this.ReadLogFileAction); 
        }

        public void ReadLogFileAction()
        {
            try
            {
                var fileReader = ServiceLocator.Current.GetInstance<IInputTemperatureFileReader>();
                var inputLogs = fileReader.ReadTyreTemperatures(InputFilePath);

            }
            catch (InputFileNotFoundException)
            {
                MessageBox.Show("The temperature file has not been found");
            }
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}