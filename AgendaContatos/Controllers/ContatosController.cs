using AgendaContatos.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AgendaContatos.Controllers
{
    public class ContatosController : Controller
    {
        // GET: Contatos/AdicionarContato
        public ActionResult AdicionarContato()
        {
            var contato = new Contato();
            return View(contato);
        }

        // GET: Contatos/RemoverContato
        public ActionResult RemoverContato()
        {
            var contato = new Contato();
            return View(contato);
        }

        // GET: Contatos/EditarContato
        public ActionResult EditarContato()
        {
            var contato = new Contato();
            return View(contato);
        }

        // GET: Contatos/ListarContatos
        public ActionResult ListarContatos()
        {
            var contatos = GetContatos();
            return View(contatos);
        }

        private IEnumerable<Contato> GetContatos()
        {
            return new List<Contato>
            {
                new Contato {Id = 1, Nome = "Roberto", Numero = "35997054048"},
                new Contato {Id = 2, Nome = "Felipe", Numero = "35998003141"}
            };
        }
    }
}