using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OcampoElective2Project.Helpers;

namespace OcampoElective2Project.Models
{
    public class Transportation : OcampoElective2ProjectViewModel
    {
        public ObservableCollection<Transportation> TransporationList = new ObservableCollection<Transportation>();
        public string Name { get; set; }
        public double Price { get; set; }
        public int ID { get; set; }
    }
}
