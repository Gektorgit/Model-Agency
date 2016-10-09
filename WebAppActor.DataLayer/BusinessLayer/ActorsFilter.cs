using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppActor.DataLayer.BusinessLayer
{
    public enum ActorBoolean : int { IsActor = 1, IsModel = 2, IsSportsman = 4, IsExpirience = 8, IsCrowdScene = 16, IsMan = 32, IsWoman = 64 }
    //Закон 604/2012 от 19.10.2012 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    [Serializable]
    public class ActorsFilter
    {

        [DataType(DataType.Currency, ErrorMessage = "Номер актера - число!")]
        [Display(Name = "find by number")]
        public int? ActorId { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "first name")]
        public string ActorFirstName { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "last name")]
        public string ActorLastName { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "age from")]
        public int? AgeFrom { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "to")]
        public int? AgeTo { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "height from")]
        public int? HeightFrom { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "to")]
        public int? HeightTo { get; set; }
        [Display(Name = "man")]
        public Boolean IsMan { get; set; }
        [Display(Name = "women")]
        public Boolean IsWoman { get; set; }

        [Display(Name = "actor")]
        public Boolean IsActor { get; set; }
        [Display(Name = "model")]
        public Boolean IsModel { get; set; }
        [Display(Name = "sportsman")]
        public Boolean IsSportsman { get; set; }
        [Display(Name = "expirience")]
        public Boolean IsExpirience { get; set; }
        [Display(Name = "crowd scene")]
        public Boolean IsCrowdScene { get; set; }

        //[Display(Name = "Eyes")] //Добавил
        //public int? EyesId { get; set; }

        //ключевое слово
        public int? Shcala
        {
            get
            {
                int? shcala = 0;
                if (IsActor) shcala += 1;
                if (IsModel) shcala += 2;
                if (IsSportsman) shcala += 4;
                if (IsExpirience) shcala += 8;
                if (IsCrowdScene) shcala += 16;
                if (IsMan) shcala += 32;
                if (IsWoman) shcala += 64;
                return shcala == 0 ? null : shcala;
            }
        }

        [Display(Name = "keyword")]
        public string KeyWord { get; set; }
    }
}