namespace Helios.Web.Controller {
	public class UsuarioController : BaseController {
		private int _count = 0;

		public UsuarioController() {
		}

		public JsonResult Index() {
			return View("Inicio");
		}
	}
}
