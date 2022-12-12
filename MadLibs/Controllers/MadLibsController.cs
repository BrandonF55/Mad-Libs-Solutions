using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
    public class MadLibsController : Controller
    {

        [Route("/")]
        public ActionResult Form() { return View(); }

        [Route("/Story")]
        public ActionResult Story(string nouns, string adjectives, string adverbs, string exclamations)
        {
            MadLibsVariable myMadLibsVariable = new MadLibsVariable();
            myMadLibsVariable.nouns = nouns;
            myMadLibsVariable.adjectives = adjectives;
            myMadLibsVariable.adverbs = adverbs;
            myMadLibsVariable.exclamations = exclamations;
            return View(myMadLibsVariable);
        }

    }
}




