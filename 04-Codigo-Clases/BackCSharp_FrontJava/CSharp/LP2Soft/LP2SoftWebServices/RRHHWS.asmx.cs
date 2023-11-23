using LP2SoftRRHHController.DAO;
using LP2SoftRRHHController.MySQL;
using LP2SoftRRHHModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.HtmlControls;

namespace LP2SoftWebServices
{
    /// <summary>
    /// Descripción breve de RRHHWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class RRHHWS : System.Web.Services.WebService
    {
        private AreaDAO daoArea = new AreaMySQL();

        [WebMethod]
        public BindingList<Area> listarTodasAreas()
        {
            BindingList<Area> areas = null;
            try
            {
                areas = daoArea.listarTodas();
            } catch(Exception ex)
            {
                
            }
            return areas;
        }
    }
}
