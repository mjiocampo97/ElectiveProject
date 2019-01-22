using System;
using System.Collections.Generic;
using System.Text;
using OcampoElective2Project.Models;

namespace OcampoElective2Project.Repository.LocalRepository
{
    public class LocalRepository : IRepository

    {
        public IDataService<UserAccount> UserAccount { get; } = new LocalDataService<UserAccount>();
    }
}
