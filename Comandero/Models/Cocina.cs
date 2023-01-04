using System;
using System.Collections.Generic;
using System.Text;
using Comandero.EventHandler;

namespace Comandero.Models
{
    public class Cocina
    {
        public void MostrarPedido(object sender, Pedido pedido)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(":::::::::::::::::::::: PEDIDO A COCINA ::::::::::::::::::::::");
            Console.WriteLine($"Bebida : {pedido.Bebida}");
            Console.WriteLine($"Comida : {pedido.Comida}");
            Console.WriteLine($"Postre : {pedido.Postre}");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("Confirme recepción del pedido (Pulse Intro).");
            ConsoleKeyInfo pressedKey = Console.ReadKey();

            if(pressedKey.Key == ConsoleKey.Enter)
            {
                notificar.OnOidoCocina(pedido);
            }
        }

        public Notificar notificar = new Notificar();
    }
}
