namespace Helios.Web.Controller {
	public class UsuarioController : BaseController {
		private static int _count = 0;
		private static string _constructorCount = 0;

		public UsuarioController() {
			this._constructorCount++;
		}

		public JsonResult Index() {
			this._count++;
			return View("Inicio", new { Counter = this._count, ConstructorCount = this._constructorCount });
		}
	}
}
