using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class IhtıyacKrediManager : IKrediManager
    {
        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredi ödeme planı hesaplandı.");
           
        }
    }
}
