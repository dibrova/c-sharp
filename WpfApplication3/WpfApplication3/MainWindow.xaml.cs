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
using System.Data;
using System.Xml.Linq;
using System.Data.OleDb;
using System.Data.Odbc;
using System.IO;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var context = new DataClasses1DataContext(@"
            Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\source\Database1.mdf;
            Integrated Security=True");
            questionNo = 1;
            Update(questionNo);
            AddHotKeys();
        }

        private string trueAnswer { get; set; }

        private int questionNo { get; set; } 

        private void Update(int quest) {
            var cont = new DataClasses1DataContext();
            resetButtons();
            var rand = new Random().Next(1, cont.TableQs.Where(q => q.Difficult == quest).Count());
            var question = cont.TableQs.Where(i => i.Difficult == quest).Skip(rand).FirstOrDefault();
            textBlock.Text = question.Question;
                buttonA.Content = "A: " + question.Ans1;
                buttonB.Content = "B: " + question.Ans2;
                buttonC.Content = "C: " + question.Ans3;
                buttonD.Content = "D: " + question.Ans4;
                trueAnswer = question.True;
        }

        private void ellise_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var ellipse = sender as Ellipse;
            ellipse.IsEnabled = false;
            fiftyHelp();
            MessageBox.Show("Подсказка "+ellipse.ToolTip+"!");
        }

        private void fiftyHelp (){
            if (trueAnswer == "A" || trueAnswer == "B")            {
                buttonC.Background = Brushes.Coral;
                buttonD.Background = Brushes.Coral;
            }
            else            {
                buttonA.Background = Brushes.Coral;
                buttonB.Background = Brushes.Coral;
            }
        }

        private void resetButtons()
        {
            buttonA.ClearValue(Control.BackgroundProperty);
            buttonB.ClearValue(Control.BackgroundProperty);
            buttonC.ClearValue(Control.BackgroundProperty);
            buttonD.ClearValue(Control.BackgroundProperty);
        }

        private void resetHelp()
        {
            fifty.IsEnabled = true;
            help.IsEnabled = true;
            call.IsEnabled = true;
        }

        private void resetGames() {
            scroll.SetValue(Grid.RowProperty, (Grid.GetRow(scroll) + questionNo));
            resetHelp();
            resetButtons();
            questionNo = 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            

            if (button ==  buttonA && trueAnswer == "A")           {
                button.Background = Brushes.LawnGreen;
                MessageBox.Show("Поздравляю! Это верный ответ!");
            }
            else if (button == buttonB && trueAnswer == "B")            {
                button.Background = Brushes.LawnGreen;
                MessageBox.Show("Поздравляю! Это верный ответ!");
            }
            else if (button == buttonC && trueAnswer == "C")            {
                button.Background = Brushes.LawnGreen;
                MessageBox.Show("Поздравляю! Это верный ответ!");
            }
            else if (button == buttonD && trueAnswer == "D")            {
                button.Background = Brushes.LawnGreen;
                MessageBox.Show("Поздравляю! Это верный ответ!");
            }
            else            {
                button.Background = Brushes.Red;
                MessageBox.Show("Очень жаль! Это не верный ответ! \nПопробуйте ещё раз!");
                resetGames();
            }
            
            if (questionNo < 15) scroll.SetValue(Grid.RowProperty, (Grid.GetRow(scroll) - 1)) ;
            Update(++questionNo);
        }

        private void AddHotKeys()
        {
            try
            {
                RoutedCommand firstSettings = new RoutedCommand();
                firstSettings.InputGestures.Add(new KeyGesture(Key.F1));
                CommandBindings.Add(new CommandBinding(firstSettings, hotkey_event_handler));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void hotkey_event_handler(object sender, ExecutedRoutedEventArgs e)
        {
            var cont = new DataClasses1DataContext();
            MessageBox.Show("О счасливчик! 12.2017\n" + "вопросов в базе: " + cont.TableQs.Count());
        }

    }
}
