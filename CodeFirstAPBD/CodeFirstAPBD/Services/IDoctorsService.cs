using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstAPBD.Entities;

namespace CodeFirstAPBD.Services
{
    public interface IDoctorsService
    {
        void AddDefault();

        List<Doctor> GetDoctors();

        bool AddDoctor(Doctor doctor);

        bool UpdateDoctor(Doctor doctor);

        bool DeleteDoctor(int id);
    }
}
