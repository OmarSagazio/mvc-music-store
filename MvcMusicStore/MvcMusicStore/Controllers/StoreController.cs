using System.Web.Mvc;

namespace MvcMusicStore.Controllers {
    public class StoreController : Controller {
        // GET: /Store/
        public string Index() {
            return "U called Store.Index() method";
        }

        // GET: /Store/Browse?genre=?Disco
        public string Browse(string genre = "") {
            string message = System.Web.HttpUtility.HtmlEncode("Store.Browse, Genre =" + genre);
            return message;
        }

        // GET: /Store/Details/5
        public string Details(int id = 0) {
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}