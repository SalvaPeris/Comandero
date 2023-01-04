using System;
using System.Collections.Generic;
using System.Text;
using Comandero.EventHandler;

namespace Comandero.Models
{
    public class TPV
    {
        public void MostrarEnTPV(object sender, Pedido pedido)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(":::::::::::::::::::::: RECIBIDO EN TPV ::::::::::::::::::::::");
            Console.WriteLine($"Bebida : {pedido.Bebida} 3.80");
            Console.WriteLine($"Comida : {pedido.Comida} 12.50");
            Console.WriteLine($"Postre : {pedido.Postre} 7.00");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }

        public Notificar notificar = new Notificar();
    }
}
