using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OcampoElective2Project.Helpers;

namespace OcampoElective2Project.Models
{
    public class Clothes : OcampoElective2ProjectViewModel
    {
        public ObservableCollection<Clothes> ClothesList = new ObservableCollection<Clothes>();
        public string Cloth { get; set; }
        public double Price { get; set; }



    }
}
