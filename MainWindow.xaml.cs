using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double brushSize = 5;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            switch ((sender as FrameworkElement).Tag.ToString())
            {
                case "1":
                    gr.Background = Brushes.Yellow;
                    break;
                case "2":
                    gr.Background = Brushes.Red;
                    break;
                case "3":
                    gr.Background = Brushes.Blue;
                    break;
                case "4":
                    MessageBox.Show("Разработал студент вки");
                    break;
                case "5":
                    Canv_1.Visibility = Visibility.Visible;
                    Canv_1.DefaultDrawingAttributes.Width = brushSize;
                    Canv_1.DefaultDrawingAttributes.Height = brushSize;

                    if (lbEditingMod.SelectedValue != null)
                    {
                        Canv_1.EditingMode = (InkCanvasEditingMode)lbEditingMod.SelectedValue;
                    }
                    if (Canv_1.EditingMode == InkCanvasEditingMode.Ink)
                    {
                        Canv_1.DefaultDrawingAttributes = (DrawingAttributes)lbClolors.SelectedValue;
                    }
                    break;
            }
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            switch ((sender as FrameworkElement).Tag.ToString())
            {
                case "0":
                    TextBlock_1.Text = "Эта кнопка открывае меню взаимодействия";
                    break;
                case "1":
                    TextBlock_1.Text = "изменить фон на Жёлтый";
                    break;
                case "2":
                    TextBlock_1.Text = "Изменить фон на красный";
                    break;
                case "3":
                    TextBlock_1.Text = "Изменить фон на синий";
                    break;
                case "4":
                    TextBlock_1.Text = "Узнать информацию о разработчике";
                    break;
            }
        }

        private void SizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            brushSize = double.Parse((sender as RadioButton).Content.ToString());
        }
    }
}