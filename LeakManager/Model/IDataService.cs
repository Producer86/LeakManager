﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LeakManager.Model
{
    public interface IDataService
    {
        void GetLeaks(Action<ObservableCollection<Leak>, Exception> callback);
        void SetLeaks(ObservableCollection<Leak> leaks);
    }
}
