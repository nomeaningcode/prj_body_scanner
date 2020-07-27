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
    public class RepositoryBitacoraResultados : IRepositoryBitacoraResultados
    {
        private GestionBodyscannerEntities contexto = new GestionBodyscannerEntities();
        public List<ResultadosBD> GetBitacora()
        {

            List<ResultadosBD> bitacora = null;

            try
            {
                bitacora = contexto.ResultadosBD.ToList();
            }
            catch (Exception ex)
            {
                string mse = ex.Message;
            }
            return bitacora;

        }
        public ResultadosBD GetBitacoraById(int id)
        {

            ResultadosBD bitacora = null;

            try
            {
                Expression<Func<ResultadosBD, bool>> expression = e => e.IDResultado.Equals(id);
                bitacora = contexto.ResultadosBD.Where(expression).FirstOrDefault<ResultadosBD>();
            }
            catch (Exception ex)
            {
                string errM = ex.Message;
            }

            return bitacora;
        }
        public bool EliminarBitacora(int _idBitacora)
        {

            bool respuesta = false;
            ResultadosBD bitacora = null;

            try
            {
                Expression<Func<ResultadosBD, bool>> expression = e => e.IDResultado.Equals(_idBitacora);
                bitacora = contexto.ResultadosBD.Where(expression).FirstOrDefault<ResultadosBD>();

                contexto.ResultadosBD.Remove(bitacora);
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
