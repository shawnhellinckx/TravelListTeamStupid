﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace TravelListTeamStupid.Model
{
    public class Item : INotifyPropertyChanged
    {
        private int _Count;
        private bool _Done;

        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; set; }
        public String Name { get; set; }
        public int Count
        {
            get
            {
                return _Count;
            }
            set
            {
                _Count = value;
                NotifyPropertyChanged("Count");
            }
        }

        public bool Done
        {
            get { return _Done; }
            set
            {
                _Done = value;
                NotifyPropertyChanged("Done");
            }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
