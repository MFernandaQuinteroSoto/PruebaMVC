using asp_y_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_y_mvc.Controllers
{
    public class DefaultController : Controller //clase que hereda de controller
    {
        //
        // GET: /Default/
        public ActionResult Index()
        {
            //Cuando retornamos una vista y no especificamos cuál se debe mostrar, el framework busca
            //en la carpeta views una vista con el mismo nombre del método.

            //El controlador no debe saber de donde viene los datos, él solo se los pide al modelo.

            Repository R = new Repository();
            var model = R.getDemo(); //permite acomodar el tipo de dato. multi uso. como js.
            return View(model); //primero especifical la vista y luego el modelo.
        }
	}
}