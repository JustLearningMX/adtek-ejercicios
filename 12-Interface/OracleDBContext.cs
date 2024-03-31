using System;

namespace _12_Interface
{
    public class OracleDBContext : IDBContext
    {
        public void insert()
        {
            Console.WriteLine("Insertando desde Oracle DB...");
        }

        public void delete()
        {
            Console.WriteLine("Borrando desde Oracle DB...");
        }

        public void update()
        {
            Console.WriteLine("Actualizando desde Oracle DB...");
        }

        public void select()
        {
            Console.WriteLine("Seleccionando desde Oracle DB...");
        }
    }
}