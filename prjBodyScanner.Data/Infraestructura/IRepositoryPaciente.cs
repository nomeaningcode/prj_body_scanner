using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using prjBodyScanner.Data.Modelo;

namespace prjBodyScanner.Data.Infraestructura
{
    public interface IRepositoryPaciente
    {
        bool InsertarPaciente(PacientesBD _pacientes);
        List<PacientesBD> GetPacientes();
        PacientesBD GetPacienteById(int id);
        bool ActualizarPaciente(PacientesBD _emp);
        bool EliminarPaciente(int _idPaciente);
    }
}
