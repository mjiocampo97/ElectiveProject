using System;
using System.Collections.Generic;
using System.Text;

namespace OcampoElective2Project.Repository.LocalRepository
{
    public class LocalDataService<T> : IDataService<T> where T : class, new()
    {
        public void Add(T record)
        {
            throw new NotImplementedException();
        }

        public T Get()
        {
            throw new NotImplementedException();
        }

        public int Update()
        {
            throw new NotImplementedException();
        }

        public int Delete()
        {
            throw new NotImplementedException();
        }
    }
}
