using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        #region Busqueda Auto Completado
        private string GetCadenaConexion()
        {
            Configuration config;

            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string cadenaOr = config.ConnectionStrings.ConnectionStrings["GestionBodyscannerEntities"].ConnectionString;
            string cadenaDataSE = "";
            string ParaElim = "";
            string retornable = "";
            int indexPE, letrapE;

            cadenaDataSE = cadenaOr.Substring(cadenaOr.IndexOf("data source="), cadenaOr.Length - cadenaOr.IndexOf("data source="));
            ParaElim = cadenaDataSE.Substring(cadenaDataSE.IndexOf("Multi"), cadenaDataSE.Length - cadenaDataSE.IndexOf("Multi"));
            indexPE = cadenaDataSE.IndexOf("Multi");
            letrapE = ParaElim.Length;
            retornable = cadenaDataSE.Remove(indexPE, letrapE);

            return retornable;
        }
        public DataTable LoadDataTable()
        {

            DataTable dt = new DataTable();
            string conectionString = GetCadenaConexion();

            try
            {

                SqlConnection con = new SqlConnection(conectionString);

                SqlCommand comand = new SqlCommand();
                comand.Connection = con;
                comand.CommandText = "Select * from PacientesBD";

                SqlDataAdapter da = new SqlDataAdapter(comand);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                string errm = ex.Message;
            }


            return dt;
        }

        public AutoCompleteStringCollection LoadAutoComplete()
        {

            DataTable dt = LoadDataTable();

            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCollection.Add(Convert.ToString(row["CorreoPCBD"]));
            }

            return stringCollection;
        }

        #endregion

        #region Obtener correo mail
        public PacientesBD GetPacienteByMail(String _mail)
        {

            PacientesBD paciente = null;

            try
            {
                Expression<Func<PacientesBD, bool>> expression = e => e.CorreoPCBD.Equals(_mail);
                paciente = contexto.PacientesBD.Where(expression).FirstOrDefault<PacientesBD>();
            }
            catch (Exception ex)
            {
                string errM = ex.Message;
            }

            return paciente;
        }

        #endregion

        #region Guardar

        public bool InsertarBitEnf(ResultadosBD _bita)
        {

            bool respuesta = false;

            try
            {
                contexto.ResultadosBD.Add(_bita);
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