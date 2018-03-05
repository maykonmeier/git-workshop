namespace Helios.Web.Controller {
	public class UsuarioController : BaseController {
		private static int _count = 0;

		public UsuarioController() {
		}

		public JsonResult Index() {
			this._count++;
			return View("Inicio", new { counter = this._count });
		}
	}
}
