using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity.Migrations;
using WebAppActor.DataLayer.DatabaseLayer;
using WebAppActor.DataLayer.BusinessLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public class PhotoRepository : IPhotoRepository
    {
        private Actor context; //= new Actor();
        public PhotoRepository() { }
        public PhotoRepository(Actor context) 
        {
            this.context = context;
        }
        public List<PhotoActor> GetPhotoActor(int ActorId)
        {
            return context.PhotoActor.Where(p => p.ActorId == ActorId).ToList();
        }
        public PhotoActor GetPhoto(int PhotoId)
        {
            return context.PhotoActor.Find(PhotoId);
        }
        public int CountPhoto(int ActorId)
        {
            return context.PhotoActor.Where(p => p.ActorId == ActorId).Count();
        }

        public byte[] GetPhotoLarge(int PhotoId)
        {
            return (byte[])context.PhotoActor.Find(PhotoId).PhotoTrue;
        }

        public byte[] GetPhotoSmall(int PhotoId)
        {
            return (byte[])context.PhotoActor.Find(PhotoId).PhotoSmall;
        }
        public  void Delete(int PhotoId)
        {
            PhotoActor photo = GetPhoto(PhotoId);
            context.PhotoActor.Remove(photo);
            context.SaveChanges();
        }
        public void AddPhotoActor(int ActorId, HttpPostedFile image)
        {
            PhotoActor obj = new PhotoActor() {  ActorId = ActorId};

            byte[] temp = new byte[image.ContentLength];
            image.InputStream.Read(temp, 0, image.ContentLength);
            
            
            obj.PhotoTrue = temp;

            obj.PhotoSmall = PhotoUtils.ResizeImageFile(temp, (int)PhotoSize.Small);
            context.PhotoActor.AddOrUpdate(obj);
        }

    }
}
