using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCOREMVC.Models
{
    public class HomeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<HomeModel> GetAll()
        {
            HomeModel item;
            List<HomeModel> lista = new List<HomeModel>();

            item = new HomeModel();
            item.Id = 1;
            item.Name = "Georg Lc.";
            lista.Add(item);

            item = new HomeModel();
            item.Id = 2;
            item.Name = "Junior Analyst";
            lista.Add(item);

            return lista;
        }
    }
}
