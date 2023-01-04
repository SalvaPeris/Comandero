using Comandero.Models;
using System;

namespace Comandero
{
    public class Program
    {
        static void Main(string[] args)
        {
            TPV tpv = new TPV();
            Cocina cocina = new Cocina();
            Camarero camarero = new Camarero();
            Pedido pedido = new Pedido();

            camarero.notificar.NotificarPedido += cocina.MostrarPedido;
            cocina.notificar.OidoCocina += camarero.RecibidoEnCocina;
            cocina.notificar.OidoCocina += tpv.MostrarEnTPV;

            if(Comanda(camarero, pedido))
                camarero.notificar.OnNotificarPedido(pedido);
        }

        private static bool Comanda(Camarero camarero, Pedido pedido)
        {
            try
            {
                Console.WriteLine(camarero.Bebida());
                pedido.Bebida = Console.ReadLine();

                Console.WriteLine(camarero.Comida());
                pedido.Comida = Console.ReadLine();

                Console.WriteLine(camarero.Postre());
                pedido.Postre = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
      
            return true;
        }

    }
}
