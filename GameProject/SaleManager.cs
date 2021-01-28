using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager:ISaleService

    {
        public void Sale(Sale sale,Gamer gamer)
        {
            Console.WriteLine(sale.GameName+" kütüphaneye eklendi");
            Console.WriteLine("İyi Oyunlar"+ gamer.FirstName);
        }
    }
}
