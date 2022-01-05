using APIES.Helper;
using APIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Services
{
    public class UserFeedbackService : IUserFeedbackService
    {
        private readonly DataContext _context;
        //public static string tesd;
        public string BaseURL = "http://192.168.143.103/FeedBackApi/";
        public UserFeedbackService(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<MobileRND_UserFeedbackCriteria_Dto> GetCriteria(string ModelID, string EnOrBN)
        {
            var result = (from mo in _context.MobileRND_ModelWiseCriteria.Where(x=> x.ModelID == ModelID)
                          join ci in _context.MobileRND_UserFeedbackCriteria on mo.CriteriaID equals ci.Id
                          into g
                          from d in g.DefaultIfEmpty()
                          select new MobileRND_UserFeedbackCriteria_Dto
                          {
                              Id = mo.Id,
                              CriteriaName = EnOrBN == "En" ? d.CriteriaNameEnglish : d.CriteriaNameBangla,
                              ImageUrl = BaseURL + "api/UserFeedback/ReturnImage/" + d.Id

                          }).ToList();

            return result;
        }
    }
}
