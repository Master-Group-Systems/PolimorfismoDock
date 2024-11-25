using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Polimorfismo.Abstract
{
    public abstract class Nota
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        
        public string BGcolor { get; set; }
        
        public string Text { get; set; }

        public Nota(int id, string nome, string bgcolor, string text)
        {
            ID = id;
            Nome = nome;
            BGcolor = bgcolor;
            Text = text;
        }

        //Metodo base do PolimorfismoDock
        public abstract void GravarNotaNoBanco(Window window, TextBox Text);
    }

}
