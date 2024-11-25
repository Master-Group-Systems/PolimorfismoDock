using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Polimorfismo.Abstract;

namespace Polimorfismo.clases
{
    public class NotaVerde : Nota
    {
        public NotaVerde(int id, string nome, string bgcolor, string text) : base(id, nome, bgcolor, text)
        {
        }

        //Polimorfismo
        public override void GravarNotaNoBanco(Window window,TextBox text)
        {
            window.Title = $"{Nome}";
            text.AppendText($"{Text}");
        }
    }
}