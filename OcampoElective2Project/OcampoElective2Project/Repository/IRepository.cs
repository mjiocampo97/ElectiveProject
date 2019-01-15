using System;
using System.Collections.Generic;
using System.Text;
using OcampoElective2Project.Models;

namespace OcampoElective2Project.Repository
{
    public interface IRepository
    {
        IDataService<UserAccount> Account { get; }
    }
}
