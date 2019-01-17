﻿using System;
using System.Collections.Generic;
using System.Text;
using OcampoElective2Project.Models;

namespace OcampoElective2Project.Repository.OnlineRepository
{
    public class OnlineRepository : IRepository
    {
        public IDataService<UserAccount> Account { get; } = new OnlineDataService<UserAccount>();
    }
}
