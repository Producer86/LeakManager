﻿using System;
using System.Collections.Generic;
using LeakManager.Model;
using System.Collections.ObjectModel;

namespace LeakManager.Design
{
    public class DesignDataService : IDataService
    {
        public void GetLeaks(Action<ObservableCollection<Leak>, Exception> callback)
        {
            // Use this to create design time data

            //var item = new DataItem("Welcome to MVVM Light [design]");
            //callback(item, null);
        }

        public void SetLeaks(ObservableCollection<Leak> leaks)
        {
            throw new NotImplementedException();
        }
    }
}