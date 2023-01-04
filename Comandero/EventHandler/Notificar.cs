using Comandero.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comandero.EventHandler
{
    public class Notificar
    {
        public event EventHandler<Pedido> NotificarPedido;

        public event EventHandler<Pedido> OidoCocina;

        /// <summary>
        /// Se notifica a cocina
        /// </summary>
        /// <param name="pedido"></param>
        public void OnNotificarPedido(Pedido pedido)
        {
            NotificarPedido.Invoke(this, pedido);
        }

        /// <summary>
        /// Se recibe en cocina y se manda a TPV
        /// </summary>
        /// <param name="pedido"></param>
        public void OnOidoCocina(Pedido pedido)
        {
            OidoCocina.Invoke(this, pedido);
        }
    }
}