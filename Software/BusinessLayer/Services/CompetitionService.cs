using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class CompetitionService
    {
        public List<Competition> GetAllCompetitions(string filter, string sort)
        {
            using (var repo = new CompetitionRepository())
            {
                List<Competition> competitions = repo.GetAllCompetitions(filter, sort).ToList();
                return competitions;
            }
        }
        // Autor: nrisek
        public List<object> GetClosedCompetitions(int user_id)
        {
            using (var repo = new CompetitionRepository())
            {
                List<object> closedCompetitions = repo.GetClosedCompetitions(user_id).ToList();
                return closedCompetitions;
            }
        }
        // Autor: nrisek
        public List<object> GetOpenCompetitions(int user_id)
        {
            using (var repo = new CompetitionRepository())
            {
                List<object> openCompetitions = repo.GetOpenCompetitions(user_id).ToList();
                return openCompetitions;
            }
        }
        // Autor: nrisek
        public List<object> GetWonCompetitions(int user_id)
        {
            using (var repo = new CompetitionRepository())
            {
                List<object> wonCompetitions = repo.GetWonCompetitions(user_id).ToList();
                return wonCompetitions;
            }
        }
        // autor: Leon Raknić
        public bool CreateCompetition(Competition competition)
        {
            using (var repo = new CompetitionRepository())
            {
                int affectedRows = repo.CreateCompetition(competition);
                return affectedRows > 0;
            }
        }
        // autor: Leon Raknić
        public bool UpdateCompetition(Competition currentCompetition)
        {
            using (var repo = new CompetitionRepository())
            {
                int affectedRows = repo.UpdateCompetition(currentCompetition);
                return affectedRows > 0;
            }
        }
    }
}
