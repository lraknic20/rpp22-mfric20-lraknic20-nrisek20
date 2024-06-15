using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ApplicationRepository : IDisposable
    {
        private WinatjecajModel Context { get; set; }
        private DbSet<Application> Entities { get; set; }
        public ApplicationRepository()
        {
            Context = new WinatjecajModel();
            Entities = Context.Set<Application>();
        }

        public int CreateApplication(Application _newApplication, List<Documentation> documents)
        {
            var competition = Context.Competitions.FirstOrDefault(c => c.id == _newApplication.competitions_id);
            var user = Context.Users.FirstOrDefault(u => u.id == _newApplication.users_id);

            Application newApplication = new Application
            {
                competitions_id = competition.id,
                users_id = user.id,
                application_date = _newApplication.application_date,
                application_won = _newApplication.application_won,
                grade = _newApplication.grade,
                Competition = competition,
                User = user,
                Documentations = documents
            };

            Entities.Add(newApplication);
            return Context.SaveChanges();
        }

        public IQueryable<Application> FindApplication(Competition selectedCompetition, User currentUser)
        {
            var query = from a in Entities
                        where a.competitions_id == selectedCompetition.id && a.users_id == currentUser.id
                        select a;
            return query;
        }
        // autor: Leon Raknić
        public IQueryable<Application> GetApplicationsForCompetition(Competition selectedCompetition)
        {
            var query = from a in Entities.Include("User").Include("Documentations").Include("Competition")
                        where a.competitions_id == selectedCompetition.id
                        select a;
            return query;
        }
        // autor: Leon Raknić
        public int UpdateApplication(Application updatedApplication, string info)
        {
            var application = Entities.SingleOrDefault(a => a.users_id == updatedApplication.users_id && a.competitions_id == updatedApplication.competitions_id);
            if(info == "grade")
            {
                application.grade = updatedApplication.grade;
            }
            if(info == "won")
            {
                application.application_won = updatedApplication.application_won;
            }
            return Context.SaveChanges();
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
