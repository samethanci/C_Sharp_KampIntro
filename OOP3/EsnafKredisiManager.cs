using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class EsnafKredisiManager : IKrediManager
    {
        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredi ödeme planı hesaplandı.");
        }
    }
}
