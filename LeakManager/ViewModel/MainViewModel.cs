﻿using GalaSoft.MvvmLight;
using LeakManager.Model;
using System;
using System.Collections.ObjectModel;

namespace LeakManager.ViewModel
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

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        
        private ObservableCollection<Leak> _leaks;
       
        public ObservableCollection<Leak> Leaks
        {
             get{ return _leaks; }
            set { Set(ref _leaks, value); }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetLeaks(
                (leaks, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    Leaks = leaks;
                });

            

        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}