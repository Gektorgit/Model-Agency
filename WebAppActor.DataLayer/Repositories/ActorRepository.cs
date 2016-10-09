using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAppActor.DataLayer.BusinessLayer;
using WebAppActor.DataLayer.DatabaseLayer;
using System.Data.Entity.Migrations;
using LinqKit;

namespace WebAppActor.DataLayer.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private Actor context ;//= new Actor();
        public ActorRepository() { }
        public ActorRepository(Actor context) 
        {
            this.context = context;
        }

        public ActorsFilter actorsFilter { get; set; }
        
        public PagingInfo pagingInfo{ get; set; }

        private System.Linq.Expressions.Expression<Func<ActorInfo, bool>> Predicate
        {
            get
            {
                var predicate = PredicateBuilder.True<ActorInfo>();
                if (actorsFilter.ActorId != null)
                    predicate = predicate.And(p => p.ActorId == actorsFilter.ActorId);
                if (actorsFilter.ActorFirstName != null)
                    predicate = predicate.Or(p => p.ActorFirstName.Contains(actorsFilter.ActorFirstName));
                if (actorsFilter.ActorLastName != null)
                    predicate = predicate.And(p => p.ActorLastName.Contains(actorsFilter.ActorLastName));
                if (actorsFilter.AgeFrom != null)
                    predicate = predicate.And(p => (DateTime.Now.Year - p.ActorBirthday.Year) >= actorsFilter.AgeFrom);
                if (actorsFilter.AgeTo != null)
                    predicate = predicate.And(p => (DateTime.Now.Year - p.ActorBirthday.Year) <= actorsFilter.AgeTo);
                if (actorsFilter.HeightFrom != null)
                    predicate = predicate.And(p => p.Heigth >= actorsFilter.HeightFrom);
                if (actorsFilter.HeightTo != null)
                    predicate = predicate.And(p => p.Heigth <= actorsFilter.HeightTo);

                //if (actorsFilter.EyesId != null)
                //    predicate = predicate.And(p => p.EyesId == actorsFilter.EyesId);

                if (actorsFilter.IsMan)
                    predicate = predicate.And(p => p.Male == true);
                if (actorsFilter.IsWoman)
                    predicate = predicate.And(p => p.Male == false);
                if (actorsFilter.IsActor)
                    predicate = predicate.And(p => p.IsActor == true);
                if (actorsFilter.IsModel)
                    predicate = predicate.And(p => p.IsModel == true);
                if (actorsFilter.IsSportsman)
                    predicate = predicate.And(p => p.IsSportman == true);
                if (actorsFilter.IsExpirience)
                    predicate = predicate.And(p => p.IsExperience == true);
                if (actorsFilter.IsCrowdScene)
                    predicate = predicate.And(p => p.IsCrowdScene == true);

                return predicate;
            }

        }

        public IEnumerable<ActorInfo> Actors
        {
            get 
            {
                var model = context.ActorInfo.AsExpandable().Where(Predicate).OrderBy(p => p.ActorId)
                    .Skip(pagingInfo.ItemsPerPage * (pagingInfo.CurrentPage - 1)).Take(pagingInfo.ItemsPerPage).ToList();
                return model; 
            }
        }

        public int CountActorByFilter
        {
            get 
            {
                var model = context.ActorInfo.AsExpandable().Where(Predicate);
                return model.Count(); 
            }
        }

        public ActorInfo Get(int? id)
        {
            return context.ActorInfo.Find(id);
        }
        public ActorInfo GetByPhoto(int? Photoid)
        {
            return context.PhotoActor.Find(Photoid).ActorInfo;
        }
        public List<Eyes> GetEyes()
        {
            return context.Eyes.ToList();
        }
        public void Update(ActorInfo actor)
        {
            try
            {
                //context.Set<ActorInfo>().AddOrUpdate(actor);
                context.ActorInfo.AddOrUpdate(actor);
                //context.Entry(actor).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception exc)
            {
                string err = exc.Message;
            }
        }
    }
}
