using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using prjBodyScanner.Data.Modelo;

namespace prjBodyScanner.Data.Infraetructura
{
    public interface IRepositorioDoctorUs
    {
        DoctorBD GetDoctorByMatricula(string _mat);
        bool InsertarRegistro(BitacoraBD _bD);
        List<BitacoraBD> GetEntradas(int _idUser);
        bool LimpiarBitacoraBeforeDeleteUser(int _id);
    }
}
