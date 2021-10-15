using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dz3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            tbotv.Text = "";
            for (int i = 0; i < tb.Text.Length; i++)
            {
                if (tb.Text[i] == 'а' || tb.Text[i] == 'А')
                    tbotv.Text += ".-";
                if (tb.Text[i] == 'б' || tb.Text[i] == 'Б')
                    tbotv.Text += "-...";
                if (tb.Text[i] == 'в' || tb.Text[i] == 'В')
                    tbotv.Text += ".--";
                if (tb.Text[i] == 'г' || tb.Text[i] == 'Г')
                    tbotv.Text += "--.";
                if (tb.Text[i] == 'д' || tb.Text[i] == 'Д')
                    tbotv.Text += "-..";
                if (tb.Text[i] == 'е' || tb.Text[i] == 'Е')
                    tbotv.Text += ".";
                if (tb.Text[i] == 'ё' || tb.Text[i] == 'Ё')
                    tbotv.Text += ".";
                if (tb.Text[i] == 'ж' || tb.Text[i] == 'Ж')
                    tbotv.Text += "...-";
                if (tb.Text[i] == 'з' || tb.Text[i] == 'З')
                    tbotv.Text += "--..";
                if (tb.Text[i] == 'и' || tb.Text[i] == 'И')
                    tbotv.Text += "..";
                if (tb.Text[i] == 'й' || tb.Text[i] == 'Й')
                    tbotv.Text += ".---";
                if (tb.Text[i] == 'к' || tb.Text[i] == 'К')
                    tbotv.Text += "-.-";
                if (tb.Text[i] == 'л' || tb.Text[i] == 'Л')
                    tbotv.Text += ".-..";
                if (tb.Text[i] == 'м' || tb.Text[i] == 'М')
                    tbotv.Text += "--";
                if (tb.Text[i] == 'н' || tb.Text[i] == 'Н')
                    tbotv.Text += "-.";
                if (tb.Text[i] == 'о' || tb.Text[i] == 'О')
                    tbotv.Text += "---";
                if (tb.Text[i] == 'п' || tb.Text[i] == 'П')
                    tbotv.Text += ".--.";
                if (tb.Text[i] == 'р' || tb.Text[i] == 'Р')
                    tbotv.Text += ".-.";
                if (tb.Text[i] == 'с' || tb.Text[i] == 'С')
                    tbotv.Text += "...";
                if (tb.Text[i] == 'т' || tb.Text[i] == 'Т')
                    tbotv.Text += "-";
                if (tb.Text[i] == 'у' || tb.Text[i] == 'У')
                    tbotv.Text += "..-";
                if (tb.Text[i] == 'ф' || tb.Text[i] == 'Ф')
                    tbotv.Text += "..-.";
                if (tb.Text[i] == 'х' || tb.Text[i] == 'Х')
                    tbotv.Text += "....";
                if (tb.Text[i] == 'ц' || tb.Text[i] == 'Ц')
                    tbotv.Text += "-.-.";
                if (tb.Text[i] == 'ч' || tb.Text[i] == 'Ч')
                    tbotv.Text += "---.";
                if (tb.Text[i] == 'ш' || tb.Text[i] == 'Ш')
                    tbotv.Text += "----";
                if (tb.Text[i] == 'щ' || tb.Text[i] == 'Щ')
                    tbotv.Text += "--.-";
                if (tb.Text[i] == 'ы' || tb.Text[i] == 'Ы')
                    tbotv.Text += "-.--";
                if (tb.Text[i] == 'ь' || tb.Text[i] == 'Ь')
                    tbotv.Text += "-..-";
                if (tb.Text[i] == 'ъ' || tb.Text[i] == 'Ъ')
                    tbotv.Text += "--.--";
                if (tb.Text[i] == 'э' || tb.Text[i] == 'Э')
                    tbotv.Text += "..-..";
                if (tb.Text[i] == 'ю' || tb.Text[i] == 'Ю')
                    tbotv.Text += "..--";
                if (tb.Text[i] == 'я' || tb.Text[i] == 'Я')
                    tbotv.Text += ".-.-";
                ///////////////////////////////////////////////////////////
                if (tb.Text[i] == 'a' || tb.Text[i] == 'A')
                    tbotv.Text += ".-";
                if (tb.Text[i] == 'b' || tb.Text[i] == 'B')
                    tbotv.Text += "-...";
                if (tb.Text[i] == 'w' || tb.Text[i] == 'W')
                    tbotv.Text += ".--";
                if (tb.Text[i] == 'g' || tb.Text[i] == 'G')
                    tbotv.Text += "--.";
                if (tb.Text[i] == 'd' || tb.Text[i] == 'D')
                    tbotv.Text += "-..";
                if (tb.Text[i] == 'e' || tb.Text[i] == 'E')
                    tbotv.Text += ".";               
                if (tb.Text[i] == 'v' || tb.Text[i] == 'V')
                    tbotv.Text += "...-";
                if (tb.Text[i] == 'z' || tb.Text[i] == 'Z')
                    tbotv.Text += "--..";
                if (tb.Text[i] == 'i' || tb.Text[i] == 'I')
                    tbotv.Text += "..";
                if (tb.Text[i] == 'j' || tb.Text[i] == 'J')
                    tbotv.Text += ".---";
                if (tb.Text[i] == 'k' || tb.Text[i] == 'K')
                    tbotv.Text += "-.-";
                if (tb.Text[i] == 'l' || tb.Text[i] == 'L')
                    tbotv.Text += ".-..";
                if (tb.Text[i] == 'm' || tb.Text[i] == 'M')
                    tbotv.Text += "--";
                if (tb.Text[i] == 'n' || tb.Text[i] == 'N')
                    tbotv.Text += "-.";
                if (tb.Text[i] == 'o' || tb.Text[i] == 'O')
                    tbotv.Text += "---";
                if (tb.Text[i] == 'p' || tb.Text[i] == 'P')
                    tbotv.Text += ".--.";
                if (tb.Text[i] == 'r' || tb.Text[i] == 'R')
                    tbotv.Text += ".-.";
                if (tb.Text[i] == 's' || tb.Text[i] == 'S')
                    tbotv.Text += "...";
                if (tb.Text[i] == 't' || tb.Text[i] == 'T')
                    tbotv.Text += "-";
                if (tb.Text[i] == 'u' || tb.Text[i] == 'U')
                    tbotv.Text += "..-";
                if (tb.Text[i] == 'f' || tb.Text[i] == 'F')
                    tbotv.Text += "..-.";
                if (tb.Text[i] == 'h' || tb.Text[i] == 'H')
                    tbotv.Text += "....";
                if (tb.Text[i] == 'c' || tb.Text[i] == 'C')
                    tbotv.Text += "-.-.";               
                if (tb.Text[i] == 'q' || tb.Text[i] == 'Q')
                    tbotv.Text += "--.-";
                if (tb.Text[i] == 'y' || tb.Text[i] == 'Y')
                    tbotv.Text += "-.--";
                if (tb.Text[i] == 'x' || tb.Text[i] == 'X')
                    tbotv.Text += "-..-";
                if (tb.Text[i] == ' ')
                    tbotv.Text += "  ";               
            }
            
        }
    }
}
