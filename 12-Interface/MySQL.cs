using System;

namespace _12_Interface
{
    public class MySQL : IDBContext
    {
        public void insert()
        {
            Console.WriteLine("Insertando desde MySQL DB...");
        }

        public void delete()
        {
            Console.WriteLine("Borrando desde MySQL DB...");
        }

        public void update()
        {
            Console.WriteLine("Actualizando desde MySQL DB...");
        }

        public void select()
        {
            Console.WriteLine("Seleccionando desde MySQL DB...");
        }
    }
}