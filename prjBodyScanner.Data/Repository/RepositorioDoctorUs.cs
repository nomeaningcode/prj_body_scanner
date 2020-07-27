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
    public class RepositorioDoctorUs : IRepositorioDoctorUs
    {
        private GestionBodyscannerEntities contexto = new GestionBodyscannerEntities();

        #region elementos de usuario de usuario
        public DoctorBD GetDoctorByMatricula(string _mat)
        {
            DoctorBD doctorBD = null;

            try
            {
                Expression<Func<DoctorBD, bool>> expression = e => e.Matricula.ToLower().Equals(_mat.ToLower());
                doctorBD = contexto.DoctorBD.Where(expression).FirstOrDefault<DoctorBD>();
            }
            catch (Exception ex)
            {
                string esm = ex.Message;
            }

            return doctorBD;
        }
        public bool ActualizarEmpleadoFB(DoctorBD _doc)
        {

            DoctorBD objDoc = null;
            bool resultado = false;

            try
            {
                Expression<Func<DoctorBD, bool>> expression = e => e.IDDoctor.Equals(_doc.IDDoctor);
                objDoc = contexto.DoctorBD.Where(expression).FirstOrDefault<DoctorBD>();

                objDoc.CorreoEBD = _doc.CorreoEBD;
                objDoc.TelefonoEBD = _doc.TelefonoEBD;

                contexto.DoctorBD.Attach(objDoc);
                contexto.Entry(objDoc).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

                resultado = true;
            }
            catch (Exception ex)
            {
                string em = ex.Message;
            }

            return resultado;
        }


        #endregion

        #region bicora

        public bool InsertarRegistro(BitacoraBD _bD)
        {

            bool respusta = false;

            try
            {
                contexto.BitacoraBD.Add(_bD);
                contexto.SaveChanges();
                respusta = true;
            }
            catch (Exception ex)
            {
                string em = ex.Message;
            }

            return respusta;

        }
        public List<BitacoraBD> GetEntradas(int _idUser)
        {

            List<BitacoraBD> eT = null;
            List<BitacoraBD> dis = null;
            List<BitacoraBD> Retornable = null;

            try
            {
                eT = contexto.BitacoraBD.ToList();
                dis = eT.Where(b => b.IDDorctorBD.Equals(_idUser)).ToList();
                Retornable = dis.OrderByDescending(p => p.IDEntradaBD).ToList();
            }
            catch (Exception ex)
            {
                string em = ex.Message;
            }

            return Retornable;

        }

        public bool LimpiarBitacoraBeforeDeleteUser(int _id)
        {

            bool respuesta = true;
            List<BitacoraBD> todasE = null;
            List<BitacoraBD> enUser = null;

            try
            {
                todasE = contexto.BitacoraBD.ToList();
                enUser = todasE.Where(b => b.IDDorctorBD.Equals(_id)).ToList();
                contexto.BitacoraBD.RemoveRange(enUser);
                contexto.SaveChanges();

                respuesta = true;
            }
            catch (Exception ex)
            {
                string em = ex.Message;
            }
            return respuesta;

        }

        #endregion

    }
}
