using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using prjBodyScanner.Data.Modelo;
using prjBodyScanner.Data.Infraestructura;
using System.Linq.Expressions;

namespace prjBodyScanner.Data.Repository
{
    public class RepositoryPaciente : IRepositoryPaciente
    {
        GestionBodyscannerEntities contexto = new GestionBodyscannerEntities();
        public bool InsertarPaciente(PacientesBD _pacientes)
        {

            bool respuesta = false;

            try
            {
                contexto.PacientesBD.Add(_pacientes);
                contexto.SaveChanges();

                respuesta = true;
            }
            catch (Exception ex)
            {
                string em = ex.Message;
            }

            return respuesta;
        }
        public List<PacientesBD> GetPacientes()
        {

            List<PacientesBD> LisPac = null;

            try
            {
                LisPac = contexto.PacientesBD.ToList();
            }
            catch (Exception ex)
            {
                string mse = ex.Message;
            }
            return LisPac;

        }
        public PacientesBD GetPacienteById(int id)
        {

            PacientesBD paciente = null;

            try
            {
                Expression<Func<PacientesBD, bool>> expression = e => e.IDPacienteBD.Equals(id);
                paciente = contexto.PacientesBD.Where(expression).FirstOrDefault<PacientesBD>();
            }
            catch (Exception ex)
            {
                string errM = ex.Message;
            }

            return paciente;
        }
        public bool ActualizarPaciente(PacientesBD _emp)
        {

            PacientesBD objAct = null;
            bool resultado = false;

            try
            {
                Expression<Func<PacientesBD, bool>> expression = e => e.IDPacienteBD.Equals(_emp.IDPacienteBD);
                objAct = contexto.PacientesBD.Where(expression).FirstOrDefault<PacientesBD>();

                objAct.NombPCBD = _emp.NombPCBD;
                objAct.APaterBD = _emp.APaterBD;
                objAct.AMaterBD = _emp.AMaterBD;
                objAct.TelPCBD = _emp.TelPCBD;
                objAct.CorreoPCBD = _emp.CorreoPCBD;
                objAct.EdadBD = _emp.EdadBD;
                objAct.IDSexo = _emp.IDSexo;
                objAct.IDTipoSangre = _emp.IDTipoSangre;
                objAct.IDOcupBD = _emp.IDOcupBD;

                contexto.PacientesBD.Attach(objAct);
                contexto.Entry(objAct).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

                resultado = true;
            }
            catch (Exception ex)
            {
                string em = ex.Message;
            }

            return resultado;
        }
        public bool EliminarPaciente(int _idPaciente)
        {

            bool respuesta = false;
            PacientesBD paciente = null;

            try
            {
                Expression<Func<PacientesBD, bool>> expression = e => e.IDPacienteBD.Equals(_idPaciente);
                paciente = contexto.PacientesBD.Where(expression).FirstOrDefault<PacientesBD>();

                contexto.PacientesBD.Remove(paciente);
                contexto.SaveChanges();

                respuesta = true;

            }
            catch (Exception ex)
            {
                string em = ex.Message;
            }

            return respuesta;
        }

    }
}
