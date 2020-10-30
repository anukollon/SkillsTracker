using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2> Coding skills to learn:</h2>" +
                "<h3><ol><li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li></ol></h3>";
            return Content(html,"text/html");
        }

        [HttpGet]
        public IActionResult Form()
        {
            string html = "";
            html += "<form method='post' action='/skills/submit'> " +
                "<label for='date'>Date: </label><br>" +
                "<input type = 'date' name='date'><br>" +
                "<label for='csharp'>C#: </label>"+
                "<select label='C#: ' name=csharp> " +
                     "<option value ='Learning Basics' selected>Learning Basics</option>" +
                     "<option value ='Making Apps'>Making Apps</option>" +
                     "<option value ='Master Coder'>Master Coder</option>" +
                "</select > <br>" +
                "<label for='javascript'>JavaScript: </label>" +
                "<select label='JavaScript: ' name='javascript'> " +
                     "<option value ='Learning Basics' selected>Learning Basics</option>" +
                     "<option value ='Making Apps'>Making Apps</option>" +
                     "<option value ='Master Coder'>Master Coder</option>" +
                "</select > <br>" +
                 "<label for='python'>Python: </label>" +
                "<select label='Python: ' name='python'> " +
                     "<option value ='Learning Basics' selected>Learning Basics</option>" +
                     "<option value ='Making Apps'>Making Apps</option>" +
                     "<option value ='Master Coder'>Master Coder</option>" +
                "</select > <br>" +
                "<input type='submit' value='Submit'>" +
                "</form>";

                  return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/submit")]
        public IActionResult Submit(string date, string csharp, string javascript, string python)
        {
            string html = "<h1>" + date + "</h1>"+
                "<br> <ol> <li> C#: " + csharp + "</li>"+
                 " <li> JavaScript#: " + javascript + "</li>" +
                  " <li> Python: " + python + "</li></ol>";

            return Content(html, "text/html");
        }
        }
}
