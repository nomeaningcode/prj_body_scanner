using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using prjBodyScanner.Data.Modelo;

namespace prjBodyScanner.Data.Infraestructura
{
    public interface IRepositoryList
    {
        List<TipoSangreBD> GetTipoSangre();
        List<SexoBD> GetSexo();
        List<OcupacionesBD> GetOcupacion();
    }
}
