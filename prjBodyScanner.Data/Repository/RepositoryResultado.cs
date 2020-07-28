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
    public class RepositoryResultado : IRepositoryResultado
    {
        GestionBodyscannerEntities contexto = new GestionBodyscannerEntities();
        public EnfermedadesBD GetEnfermedadById(int id)
        {

            EnfermedadesBD enfermedad = null;

            try
            {
                Expression<Func<EnfermedadesBD, bool>> expression = e => e.IDEnfermedadBD.Equals(id);
                enfermedad = contexto.EnfermedadesBD.Where(expression).FirstOrDefault<EnfermedadesBD>();
            }
            catch (Exception ex)
            {
                string errM = ex.Message;
            }

            return enfermedad;
        }
    }
}