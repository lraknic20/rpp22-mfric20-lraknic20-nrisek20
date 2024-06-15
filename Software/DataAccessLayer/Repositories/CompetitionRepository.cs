using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer.Repositories
{
    public class CompetitionRepository : IDisposable
    {
        private WinatjecajModel Context { get; set; }
        private DbSet<Competition> Entities { get; set; }
        private DbSet<EntitiesLayer.Entities.Application> EntitiesApplication { get; set; }
        private DbSet<User> EntitiesUser { get; set; }

        public CompetitionRepository()
        {
            Context = new WinatjecajModel();
            Entities = Context.Set<Competition>();
            EntitiesApplication = Context.Set<EntitiesLayer.Entities.Application>();
            EntitiesUser = Context.Set<User>();
        }

        public IQueryable<Competition> GetAllCompetitions(string filter, string sort)
        {
            if(filter == "" && sort == "")
            {
                return Entities;
            }
            else if(filter != "" && sort == "")
            {
                var query = from c in Entities
                            where c.name.Contains(filter)
                            select c;
                return query;
            }
            else if(filter == "" && sort != "")
            {
                if(sort == "ID")
                {
                    var query = from c in Entities
                                orderby c.id
                                select c;
                    return query;
                }
                else if(sort == "Naziv"){
                    var query = from c in Entities
                                orderby c.name
                                select c;
                    return query;
                }
                else if (sort == "Datum kreiranja")
                {
                    var query = from c in Entities
                                orderby c.creation_date
                                select c;
                    return query;
                }
                else if (sort == "Datum dospijeća")
                {
                    var query = from c in Entities
                                orderby c.due_date
                                select c;
                    return query;
                }
                else
                {
                    var query = from c in Entities
                                orderby c.opened descending
                                select c;
                    return query;
                }
            }
            else
            {
                var query = from c in Entities
                            where c.name.Contains(filter)
                            orderby sort
                            select c;
                return query;
            }
        }
        // Autor: nrisek
        public IQueryable<object> GetOpenCompetitions(int user_id) //IQueryable<Competition>
        {
            /*var query = from c in Entities
                        join a in EntitiesApplication on c.id equals a.competitions_id
                        join u in EntitiesUser on a.users_id equals u.id
                        where c.opened == true && u.id == user_id
                        select c;*/
            var query = from c in Entities
                        join a in EntitiesApplication on c.id equals a.competitions_id
                        join u in EntitiesUser on a.users_id equals u.id
                        where c.opened == true && u.id == user_id
                        select new
                        {
                            c.id,
                            c.name,
                            c.description,
                            c.creation_date,
                            c.due_date,
                            c.needed_documentation,
                            c.opened,
                        };

            return query;
        }
        // Autor: nrisek
        public IQueryable<object> GetClosedCompetitions(int user_id)
        {
            var query = from c in Entities
                        join a in EntitiesApplication on c.id equals a.competitions_id
                        join u in EntitiesUser on a.users_id equals u.id
                        where c.opened == false && u.id == user_id
                        select new
                        {
                            c.id,
                            c.name,
                            c.description,
                            c.creation_date,
                            c.due_date,
                            c.needed_documentation,
                            c.opened,
                        };
            return query;
        }
        // Autor: nrisek
        public IQueryable<object> GetWonCompetitions(int user_id)
        {
            var query = from c in Entities
                        join a in EntitiesApplication on c.id equals a.competitions_id
                        join u in EntitiesUser on a.users_id equals u.id
                        where u.id == user_id && a.application_won == true
                        select new
                        {
                            c.id,
                            c.name,
                            c.description,
                            c.creation_date,
                            c.due_date,
                            c.needed_documentation,
                            c.opened,
                        };
            return query;
        }
        // autor: Leon Raknić
        public int CreateCompetition(Competition competition)
        {
            List<Criterion> criterias = new List<Criterion>();

            foreach (var criteria in competition.Criteria)
            {
                criterias.Add(Context.Criteria.SingleOrDefault(c => c.id == criteria.id));
            }

            Competition newcompetition = new Competition
            {
                name = competition.name,
                description = competition.description,
                creation_date = competition.creation_date,
                due_date = competition.due_date,
                needed_documentation = competition.needed_documentation,
                opened = competition.opened,
                Criteria = criterias
            };

            Entities.Add(newcompetition);

            return Context.SaveChanges();
        }
        // autor: Leon Raknić
        public int UpdateCompetition(Competition currentCompetition)
        {
            var competition = Context.Competitions.FirstOrDefault(c => c.id == currentCompetition.id);
            Context.Competitions.Attach(competition);

            competition.opened = currentCompetition.opened;

            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

    }
}
