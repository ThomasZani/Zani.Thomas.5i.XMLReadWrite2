using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Zani.Thomas._5i.XMLReadWrite2.Controllers
{
    public class DefaultController : Controller
    {
      
        string nomeFilee =@"~/App_Data/dati.xml";
        // GET: Default
        public ActionResult Index()
        {
            string nomeFile = HostingEnvironment.MapPath(@"~/App_Data/dati.xml");
            Persone p = new Persone(nomeFile);
            return View(p);
        }

        public ActionResult Aggiungi()
        {
            Persone p = new Persone(HostingEnvironment.MapPath(nomeFilee));
            p.Aggiungi();
            return View("Index", p);

        }

        public ActionResult Dettagli(int id)
        {
            Persone persone = new Persone(HostingEnvironment.MapPath(nomeFilee));
            return View(persone.FirstOrDefault(x => x.id == id));
        }

    
    }
}