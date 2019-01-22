using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OcampoElective2Project.Helpers;

namespace OcampoElective2Project.Models
{
    public class Others : OcampoElective2ProjectViewModel
    {

        public ObservableCollection<Others> OthersList = new ObservableCollection<Others>();
        
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
