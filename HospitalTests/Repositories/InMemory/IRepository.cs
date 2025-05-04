using System;
using System.Collections.Generic;

namespace HospitalManagementSystem.Repositories.InMemory
{
    public interface IRepository<T, ID>
    {
        void Save(T entity);
        T FindById(ID id);
        List<T> FindAll();
        void Delete(ID id);
    }
}