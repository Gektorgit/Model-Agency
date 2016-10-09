using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebAppActor.StiReport;

namespace WebAppActor.Models
{
    public class StiTempProject
    {
        public int ActorId { get; set; }
        public int Age { get; set; }
        public int ActorHeght { get; set; }
        public int PhotoId { get; set; }
        public byte[] PhotoLarge { get; set; }
    }
    public class StiTempDataTable
    {
        private List<StiTempProject> list = new List<StiTempProject>();

        public void AddItem(StiTempProject obj)
        {
            list.Add(obj);
        }
        void Clear()
        {
            list.Clear();
        }
        public IEnumerable<StiTempProject> stiTempProject
        {
            get { return list; }
        }
        public DataTable GetDataTable()
        {
            return IEnumerableToDataTable<StiTempProject>.LINQToDataTable(stiTempProject);
        }
    }
}