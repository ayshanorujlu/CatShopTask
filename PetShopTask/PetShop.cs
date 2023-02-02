using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopTask;
namespace PetShopTask
{
    internal class PetShop
    {
        public List<CatHouse> CatHouseList { get; set; }=new List<CatHouse>();
        public int CatHouseCount { get=>CatHouseList.Count;}
    }
}
