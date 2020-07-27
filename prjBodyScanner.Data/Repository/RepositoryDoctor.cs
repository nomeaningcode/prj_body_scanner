using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using prjBodyScanner.Data.Infraestructura;
using prjBodyScanner.Data.Modelo;

namespace prjBodyScanner.Data.Repository
{
    public class RepositoryDoctor : IRepositoryDoctores
    {

        private GestionBodyscannerEntities contexto = new GestionBodyscannerEntities();
        public bool InsertarDoctor(DoctorBD _doctor)
        {

            bool respuesta = false;

            try
            {
                contexto.DoctorBD.Add(_doctor);
                contexto.SaveChanges();

                respuesta = true;
            }
            catch (Exception ex)
            {
                string em = ex.Message;
            }

            return respuesta;
        }
        public List<DoctorBD> GetDoctores()
        {

            List<DoctorBD> LisDoc = null;

            try
            {
                LisDoc = contexto.DoctorBD.ToList();
            }
            catch (Exception ex)
            {
                string mse = ex.Message;
            }
            return LisDoc;

        }
        public DoctorBD GetDoctorById(int id)
        {

            DoctorBD doctor = null;

            try
            {
                Expression<Func<DoctorBD, bool>> expression = e => e.IDDoctor.Equals(id);
                doctor = contexto.DoctorBD.Where(expression).FirstOrDefault<DoctorBD>();
            }
            catch (Exception ex)
            {
                string errM = ex.Message;
            }

            return doctor;
        }
        public bool ActualizarDoctor(DoctorBD _emp)
        {

            DoctorBD objAct = null;
            bool resultado = false;

            try
            {
                Expression<Func<DoctorBD, bool>> expression = e => e.IDDoctor.Equals(_emp.IDDoctor);
                objAct = contexto.DoctorBD.Where(expression).FirstOrDefault<DoctorBD>();

                objAct.Matricula = _emp.Matricula;
                objAct.NombreEBD = _emp.NombreEBD;
                objAct.APaternoBD = _emp.APaternoBD;
                objAct.AMarteno = _emp.AMarteno;
                objAct.TelefonoEBD = _emp.TelefonoEBD;
                objAct.CorreoEBD = _emp.CorreoEBD;
                objAct.ContraseniaBD = _emp.ContraseniaBD;

                contexto.DoctorBD.Attach(objAct);
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
        public bool EliminarDoctor(int _iddoctor)
        {

            bool respuesta = false;
            DoctorBD doctor = null;

            try
            {
                Expression<Func<DoctorBD, bool>> expression = e => e.IDDoctor.Equals(_iddoctor);
                doctor = contexto.DoctorBD.Where(expression).FirstOrDefault<DoctorBD>();

                contexto.DoctorBD.Remove(doctor);
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
