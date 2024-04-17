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

namespace InterfazInicial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //btn C# example
            //Grid gridBtn = new Grid();
            //this.Content = gridBtn;
            //Button btn3 = new Button();
            //btn3.Width = 166;
            //btn3.Height = 70;
            //gridBtn.Children.Add(btn3);
            //WrapPanel wrapPanelBtn = new WrapPanel();
            //btn3.Content = wrapPanelBtn;

            //TextBlock txtBlock1 = new TextBlock();
            //txtBlock1.Text = "txt 1";
            //txtBlock1.FontSize = 18;
            //wrapPanelBtn.Children.Add(txtBlock1);

            //TextBlock txtBlock2 = new TextBlock();
            //txtBlock2.Text = "txt 2";
            //txtBlock2.FontSize = 18;
            //wrapPanelBtn.Children.Add(txtBlock2);

        }

        // my property
        public int myProperty
        {
            get => (int)GetValue(myDependencyProperty);
            set => SetValue(myDependencyProperty, value);
        }
        //my Dependecy property
        public static readonly DependencyProperty myDependencyProperty = DependencyProperty.Register("myProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("click test for alert");
        }
    }
}