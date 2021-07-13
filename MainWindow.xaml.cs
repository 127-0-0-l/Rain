using System;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Rain
{
    public partial class MainWindow : Window
    {
        public SolidColorBrush ColorBackground { get; private set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eeeeee"));
        public SolidColorBrush ColorRain { get; private set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#23049d"));

        private Canvas[] canvases;
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            cnvBackground.Background = ColorBackground;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeCanvases();
            DrawDrops();
            InitializeTimer();
            RunRain();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < canvases.Length; i++)
            {
                canvases[i].Margin = new Thickness(0, canvases[i].Margin.Top + i, 0, 0);
            }
        }

        private void InitializeCanvases()
        {
            canvases = new Canvas[20];

            for (int i = 0; i < canvases.Length; i++)
            {
                canvases[i] = new Canvas();
                cnvBackground.Children.Add(canvases[i]);
            }
        }

        private void DrawDrops()
        {
            foreach (var item in canvases)
            {
                for (int i = 0; i < 5000; i++)
                {
                    //Line line = new Line();
                    //line.X1 = line.X2 = i * 10;
                    //line.Y1 = 10;
                    //line.Y2 = 20;
                    //line.StrokeThickness = 1;
                    //line.Stroke = Brushes.Black;
                    //item.Children.Add(line);
                    PointF p = new PointF()
                }
            }
        }

        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 20);
            timer.Tick += Timer_Tick;
        }

        private void RunRain()
        {
            timer.Start();
        }
    }
}
