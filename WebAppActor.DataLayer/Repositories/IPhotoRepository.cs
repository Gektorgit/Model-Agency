using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebAppActor.DataLayer.DatabaseLayer;

namespace WebAppActor.DataLayer.Repositories
{
    public interface IPhotoRepository
    {
        List<PhotoActor> GetPhotoActor(int ActorId);
        PhotoActor GetPhoto(int PhotoId);
        int CountPhoto(int ActorId);
        byte[] GetPhotoLarge(int PhotoId);
        byte[] GetPhotoSmall(int PhotoId);
        void Delete(int PhotoId);
        void AddPhotoActor(int ActorId, HttpPostedFile image);
    }
}
