using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    // autor: Leon Raknić
    public class CriteriaRepository : IDisposable
    {
        private WinatjecajModel Context { get; set; }
        private DbSet<Criterion> Entities { get; set; }
        private DbSet<Competition> EntitiesCompetition { get; set; }
        public CriteriaRepository()
        {
            Context = new WinatjecajModel();
            Entities = Context.Set<Criterion>();
            EntitiesCompetition = Context.Set<Competition>();
        }
        public IQueryable<Criterion> GetAllCriterias()
        {
            var query = from c in Entities
                        select c;
            return query;
        }
        public IQueryable<Criterion> GetCriteriasForCompetition(Competition competition)
        {
            var query = from c in Entities
                        where c.Competitions.Any(x => x.id == competition.id)
                        select c;
            return query;
        }
        public int AddCriteria(Criterion criterion)
        {
            Criterion newCriteria = new Criterion
            {
                name = criterion.name,
                description = criterion.description,
                grade = criterion.grade
            };
            Entities.Add(newCriteria);
            return Context.SaveChanges();
        }
        public int DeleteCriteria(Criterion criterion)
        {
            try
            {
                Entities.Attach(criterion);
                Entities.Remove(criterion);
                return Context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                return 0;
            }
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
