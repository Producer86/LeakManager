﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace LeakManager.Model
{
    public class DataService : IDataService
    {
        public void GetLeaks(Action<ObservableCollection<Leak>, Exception> callback)
        {
            // Use this to connect to the actual data service

            var serializer = new XmlSerializer(typeof(ObservableCollection<Leak>));
            var reader = new FileStream("leaks.xml", FileMode.Open);
            var leaks = (ObservableCollection<Leak>)serializer.Deserialize(reader);
            reader.Close();
            callback(leaks, null);            
        }
        public void SetLeaks(ObservableCollection<Leak> leaks)
        {
            var serializer = new XmlSerializer(typeof(ObservableCollection<Leak>));
            var writer = File.AppendText("leaks.xml");
            serializer.Serialize(writer, leaks);
        }
    }    
}