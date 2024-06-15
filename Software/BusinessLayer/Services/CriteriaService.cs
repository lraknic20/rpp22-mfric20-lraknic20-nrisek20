using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    // autor: Leon Raknić
    public class CriteriaService
    {
        public List<Criterion> GetAllCriterias()
        {
            using (var repo = new CriteriaRepository())
            {
                List<Criterion> criterias = repo.GetAllCriterias().ToList();
                return criterias;
            }
        }
        public List<Criterion> GetCriteriasForCompetition(Competition competition)
        {
            using (var repo = new CriteriaRepository())
            {
                List<Criterion> criterias = repo.GetCriteriasForCompetition(competition).ToList();
                return criterias;
            }
        }
        public bool AddCriteria(Criterion criterion)
        {
            using (var repo = new CriteriaRepository())
            {
                int affectedRows = repo.AddCriteria(criterion);
                return affectedRows > 0;
            }
        }
        public bool DeleteCriteria(Criterion criterion)
        {
            using (var repo = new CriteriaRepository())
            {
                int affectedRows = repo.DeleteCriteria(criterion);
                return affectedRows > 0;
            }
        }
    }
}
