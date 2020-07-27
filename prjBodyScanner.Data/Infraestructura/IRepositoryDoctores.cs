using prjBodyScanner.Data.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBodyScanner.Data.Infraestructura
{
    public interface IRepositoryDoctores
    {
        bool InsertarDoctor(DoctorBD _doctor);
        List<DoctorBD> GetDoctores();
        DoctorBD GetDoctorById(int id);
        bool ActualizarDoctor(DoctorBD _emp);
        bool EliminarDoctor(int _iddoctor);
    }
}
