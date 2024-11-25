using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Polimorfismo.Abstract;
using Polimorfismo.clases;

namespace Polimorfismo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DEBUG.AppendText($"Debug Iniciado.\n\n");
            
            List<Nota> notas = new()
            {
                //PolimorfismoDock por inclusão
            new NotaAmarela(1, "nota00", "#ft5675","Preciso fazer um trabalho para faculdade"),
                //PolimorfismoDock por inclusão
            new NotaVermelha(1, "nota00", "#ft5675","Preciso beber agua")
            };

            TextBox text = new TextBox();

            foreach (var nota in notas)
            {
                //PolimorfismoDock
                nota.GravarNotaNoBanco(this, text);
            }

        }

    }
}