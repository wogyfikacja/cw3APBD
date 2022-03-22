using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3APBD.Models;

namespace Cw3APBD.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}