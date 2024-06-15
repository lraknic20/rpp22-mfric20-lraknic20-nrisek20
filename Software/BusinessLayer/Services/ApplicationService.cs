using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer.Services
{
    public class ApplicationService
    {

        public bool CreateApplication(Application _newApplication, List<Documentation> documents)
        {
            using (var repo = new ApplicationRepository())
            {
                int affectedRows = repo.CreateApplication(_newApplication, documents);
                return affectedRows > 0;
            }
        }

        public bool FindApplication(Competition selectedCompetition, User currentUser)
        {
            using (var repo = new ApplicationRepository())
            {
                var application = repo.FindApplication(selectedCompetition, currentUser).ToList();
                if (application.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        // autor: Leon Raknić
        public List<Application> GetApplicationsForCompetition(Competition selectedCompetition)
        {
            using (var repo = new ApplicationRepository())
            {
                List<Application> applications = repo.GetApplicationsForCompetition(selectedCompetition).ToList();
                return applications;
            }
        }
        // autor: Leon Raknić
        public bool UpdateApplication(Application updatedApplication, string info)
        {
            using (var repo = new ApplicationRepository())
            {
                int affectedRows = repo.UpdateApplication(updatedApplication, info);
                return affectedRows > 0;
            }
        }
    }
}
