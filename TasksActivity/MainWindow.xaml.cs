using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TasksActivity
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

        public struct Range
        {
            public Range(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            public int X { get; set; }
            public int Y { get; set; }
        }
        private int End { get; set; }
        private  void Button_Click(object sender, RoutedEventArgs e)
        {
          
            try
            {
               End = int.Parse(range.Text);
            }
          
            catch (FormatException) { MessageBox.Show("Wprowadzono błędną wartość"); }
            firstNumbers.Document.Blocks.Clear();

            int amountOfTasks = 0;
            try
            {
                amountOfTasks = int.Parse(amount.Text);
            }
            catch (FormatException) { }
         

            if (amountOfTasks == 0)
            {

                Task<string> task = new Task<string>(FindNumber,new Range(2,End));
                task.Start();
                comments.Text = "Rozpoczęto szukanie liczb pierwszych";
                task.ContinueWith(x =>
                {
                    this.Dispatcher.Invoke(() => firstNumbers.Document.Blocks.Add(new Paragraph(new Run(x.Result))));
                });
                comments.Text = "Poszukiwanie liczb pierwszych zakończono";
            }
            else
            {
                List<Task<string>> tasks = new List<Task<string>>();
               
                int temp = End;
                int[] ranges = new int[amountOfTasks];
                for(int i=amountOfTasks-1; i>=0; i--)
                {
                    temp /= amountOfTasks;
                    ranges[i] = temp;
                }
                   

                var test = ranges;

                for (int i=0; i<amountOfTasks; i++)
                {
                      if(i==0)  tasks.Add(new Task<string>(FindNumber,new Range(2,ranges[i])));
                      else tasks.Add(new Task<string>(FindNumber, new Range(ranges[i-1], ranges[i])));
                }
                for(int i=0; i<tasks.Count; i++)
                {
                    tasks[i].Start();
                    if (i == 0) comments.Text = "Poszukiwanie liczb z zakresu od 2 do " + ranges[i];
                    else  comments.Text = "Poszukiwanie liczb z zakresu od "+ranges[i-1] +" do " + ranges[i];
                    tasks[i].ContinueWith(x =>
                    {
                        this.Dispatcher.Invoke(() => firstNumbers.Document.Blocks.Add(new Paragraph(new Run(x.Result))));
                    });
                    comments.Text = "Poszukiwanie zakońćzono";
                }
            }

        }

        private string  FindNumber(object range)
        {
            string s = "";
            Range currentRange =(Range)range;
          bool[] liczby = EratotenesSieve(currentRange.Y);
            for (int i = (int)currentRange.X; i < (int)currentRange.Y; i++)
            {
                if (liczby[i]) s += i + " "; 
            }
            return s;
        }
        private bool[] EratotenesSieve(int zakres)
        {
            bool[] liczby = new bool[zakres];
            for (int i = 2; i < zakres; i++)
            {
                liczby[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(zakres); i++)
            {
                if (liczby[i] == true)
                {
                    for (int j = i + i; j < zakres; j += i)
                    {
                        liczby[j] = false;
                    }
                }
            }
            return liczby;
        }


    }
}
