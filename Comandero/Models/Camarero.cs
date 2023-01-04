using System;
using System.Collections.Generic;
using System.Text;
using Comandero.EventHandler;

namespace Comandero.Models
{
    public class Camarero
    {
        public string Bebida() {
            return "¿Qué quieres beber?";
        }

        public string Comida()
        {
            return "¿Qué quieres comer?";
        }

        public string Postre()
        {
            return "¿Qué quieres de postre?";
        }

        public void RecibidoEnCocina(object sender, Pedido pedido)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("::::::::::::::::::: RECIBIDO DESDE COCINA ::::::::::::::::::::::");
            Console.WriteLine("Pedido recibido:");
            Console.WriteLine($"Bebida : {pedido.Bebida}, Comida : {pedido.Comida}, Postre : {pedido.Postre}");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
        }

        public Notificar notificar = new Notificar();
    }
}
