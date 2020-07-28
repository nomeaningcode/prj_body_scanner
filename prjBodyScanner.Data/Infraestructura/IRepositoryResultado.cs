using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using prjBodyScanner.Data.Modelo;

namespace prjBodyScanner.Data.Infraestructura
{
    public interface IRepositoryResultado
    {
        EnfermedadesBD GetEnfermedadById(int id);
        AutoCompleteStringCollection LoadAutoComplete();
        PacientesBD GetPacienteByMail(String _mail);
        bool InsertarBitEnf(ResultadosBD _bita);
    }
}
