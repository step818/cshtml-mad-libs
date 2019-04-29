using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index() { return View(); }

        [Route("/sicknote")]
        public ActionResult SickNote(string word1, string word2, string word3, string word4, string word5, string word6, string word7, string word8, string word9, string word10) 
        { 
            MadLibsVariable madlibs = new MadLibsVariable();
            madlibs.word1 = word1;
            madlibs.word2 = word2;
            madlibs.word3 = word3;
            madlibs.word4 = word4;
            madlibs.word5 = word5;
            madlibs.word6 = word6;
            madlibs.word7 = word7;
            madlibs.word8 = word8;
            madlibs.word9 = word9;
            madlibs.word10 = word10;

            return View(madlibs); 
        }

        [Route("/walmart")]
        public ActionResult Walmart(string word1, string word2, string word3, string word4, string word5, string word6, string word7, string word8, string word9, string word10, string word11, string word12, string word13, string word14, string word15)
        {
            MadLibsVariable madlibs = new MadLibsVariable();
            madlibs.word1 = word1;
            madlibs.word2 = word2;
            madlibs.word3 = word3;
            madlibs.word4 = word4;
            madlibs.word5 = word5;
            madlibs.word6 = word6;
            madlibs.word7 = word7;
            madlibs.word8 = word8;
            madlibs.word9 = word9;
            madlibs.word10 = word10;
            madlibs.word11 = word11;
            madlibs.word12 = word12;
            madlibs.word13 = word13;
            madlibs.word14 = word14;
            madlibs.word15 = word15;

            return View(madlibs);
        }

        [Route("/sicknoteform")]
        public ActionResult SickNoteForm() { return View(); }

        [Route("/walmartform")]
        public ActionResult WalmartForm() { return View(); }
    }
}

