using APIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Services
{
    public interface IUserFeedbackService
    {
        List<MobileRND_UserFeedbackCriteria_Dto> GetCriteria(string ModelID, string EnOrBN);

        //IEnumerable<HrmAtdManual> GetManualAttendence();
        //void UpdateManualAttendence(HrmAtdManual hrmAtdManual);
        //void DeleteManualAttendence(HrmAtdManual hrmAtdManual);
        //void AddManualAttendence(HrmAtdManual hrmAtdManual, string type);
        //bool ManualAttendenceExists(string salseDaliveryLocation);
        //bool Save();
    }
}
