using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using prjBodyScanner.Data.Infraestructura;
using prjBodyScanner.Data.Modelo;

namespace prjBodyScanner.Data.Repository
{
    public class RepositoryList : IRepositoryList
    {
        GestionBodyscannerEntities contexto = new GestionBodyscannerEntities();

        public List<TipoSangreBD> GetTipoSangre()
        {

            List<TipoSangreBD> tipoSangre = null;

            try
            {
                tipoSangre = contexto.TipoSangreBD.ToList();
            }
            catch (Exception ex)
            {
                string EM = ex.Message;
            }

            return tipoSangre;
        }
        public List<SexoBD> GetSexo()
        {

            List<SexoBD> sexo = null;

            try
            {
                sexo = contexto.SexoBD.ToList();
            }
            catch (Exception ex)
            {
                string EM = ex.Message;
            }

            return sexo;
        }
        public List<OcupacionesBD> GetOcupacion()
        {

            List<OcupacionesBD> ocupacion = null;

            try
            {
                ocupacion = contexto.OcupacionesBD.ToList();
            }
            catch (Exception ex)
            {
                string EM = ex.Message;
            }

            return ocupacion;
        }
    }
}
