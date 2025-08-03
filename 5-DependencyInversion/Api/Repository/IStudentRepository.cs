using DependencyInversion;
using System.Collections.Generic;

namespace Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        void Add(Student student);
    }
}