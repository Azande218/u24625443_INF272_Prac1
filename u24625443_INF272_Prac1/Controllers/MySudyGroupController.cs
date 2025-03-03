using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24625443_INF272_Prac1.Controllers
{
    public class MySudyGroupController : Controller
    {
        // GET: MySudyGroup
        public ActionResult View()
        {
            List<Models.myStudyGroupClass> myStudyGroup = new List<Models.myStudyGroupClass>();
            myStudyGroup.Add(new Models.myStudyGroupClass { StudentNumber = 24625443, Name = "Azande", Surname = "Zulu", EmailAddress = "u24625443@tuks.co.za" });
            myStudyGroup.Add(new Models.myStudyGroupClass { StudentNumber = 23625145, Name = "Lerato", Surname = "Maponya", EmailAddress = "u23625145@tuks.co.za" });
            myStudyGroup.Add(new Models.myStudyGroupClass { StudentNumber = 24829543, Name = "Mbali", Surname = "Masemula", EmailAddress = "u24829543@tuks.co.za" });
            myStudyGroup.Add(new Models.myStudyGroupClass { StudentNumber = 24128427, Name = "Cameron", Surname = "Victor", EmailAddress = "u24128427@tuks.co.za" });
            myStudyGroup.Add(new Models.myStudyGroupClass { StudentNumber = 23925452, Name = "Luca", Surname = "Marais", EmailAddress = "u23925452@tuks.co.za" });

            return View(myStudyGroup);
        }
    }
}