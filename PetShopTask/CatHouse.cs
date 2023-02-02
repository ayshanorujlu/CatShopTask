using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PetShopTask;

namespace PetShopTask
{
    internal class CatHouse
    {
        public string Name { get; set; }

        public List<Cat> Cats { get; set; } = new();
        public int CatCount{get=>Cats.Count; }

        public void AddCat(Cat cat)
        {
            foreach (var item in Cats) {
                if (item.NickName == cat.NickName)
                {
                    throw new Exception("We have cat like that");
                }
                Cats.Add(cat);
            }
        }
        public void RemoveCatByNickName(string nickname) 
        {
            foreach(var item in Cats)
            {
                if(item.NickName == nickname)
                {
                    Cats.Remove(item);
                }
            }
        }
    }
}
