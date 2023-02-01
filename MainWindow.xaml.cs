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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] check = { "X", "O" };
        int value = 1;
        string xOrO = "X";
        string voi = " ";
        Random z = new();
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Button[] buttons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            (sender as Button).IsEnabled = false;
            (sender as Button).Content = xOrO;
            if (xOrO == "X")
            {
                xOrO = "O";
                if (value == 1){
                    i++;
                    value++;
                }
                else if (value == 2){
                    i++;
                    value--;
                }

                pla.Text = Convert.ToString(value);

            }
            else if (xOrO == "O")
            {
                xOrO = "X";
                if (value == 1) {
                    value++;
                }
                else if (value == 2) {
                    value--;
                }
                pla.Text = Convert.ToString(value);
            }
            int a = z.Next(0, 8);
                while (buttons[a].Content == check[0] || buttons[a].Content == check[1])
                {
                    a = z.Next(0, 8);
                }
            NewMethod(buttons);
            buttons[a].Content = xOrO;
            buttons[a].IsEnabled = false;

            if (xOrO == "X")
            {
                i++;
                xOrO = "O";
            }
            else if (xOrO == "O")
            {
                i++;
                xOrO = "X";
            }
            NewMethod(buttons);
        }
        private void NewMethod(Button[] buttons)
        {
            for (int a = 0; a < 2; a++)
            {
            if (check[a] == Convert.ToString(buttons[0].Content) && check[a] == Convert.ToString(buttons[1].Content) && check[a] == Convert.ToString(buttons[2].Content) || check[a] == Convert.ToString(buttons[3].Content) && check[a] == Convert.ToString(buttons[4].Content) && check[a] == Convert.ToString(buttons[5].Content) || check[a] == Convert.ToString(buttons[6].Content) && check[a] == Convert.ToString(buttons[7].Content) && check[a] == Convert.ToString(buttons[8].Content) || check[a] == Convert.ToString(buttons[0].Content) && check[a] == Convert.ToString(buttons[3].Content) && check[a] == Convert.ToString(buttons[6].Content) || check[a] == Convert.ToString(buttons[1].Content) && check[a] == Convert.ToString(buttons[4].Content) && check[a] == Convert.ToString(buttons[7].Content) || check[a] == Convert.ToString(buttons[2].Content) && check[a] == Convert.ToString(buttons[5].Content) && check[a] == Convert.ToString(buttons[8].Content) || check[a] == Convert.ToString(buttons[0].Content) && check[a] == Convert.ToString(buttons[4].Content) && check[a] == Convert.ToString(buttons[8].Content) || check[a] == Convert.ToString(buttons[2].Content) && check[a] == Convert.ToString(buttons[4].Content) && check[a] == Convert.ToString(buttons[6].Content))
            {
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                }
                win();
            }
            else
            {
                winner.Text = "Победа за: ";
                num.Text = "Ничья";
            }
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (Button button in buttons)
            {
                button.Content = voi;
                button.IsEnabled = true;
                winner.Text = "Победа за: ";
                num.Text = voi;
            }
        }
        public void win()
        {
            winner.Text = "Победа за: ";
            num.Text = Convert.ToString(value);
        }
        private void raian_Click(object sender, RoutedEventArgs e)
        {
            raion1.Text = "Райан Гослинг говорит: Люблю Софию Алексеевну!";
        }
    }
}
