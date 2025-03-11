using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Variable variable = new Variable();
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = variable;
            
            timer.Interval = TimeSpan.FromSeconds(1); // 设置定时器间隔为1秒
            timer.Tick += Timer_Tick;
            timer.Start();

            for (int i = 0; i < 10; i++)
            {
                variable.LogList.Add(new ListModel() { Index =i, Message = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")});
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Title = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            variable.UpdateTextArray(0, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //foreach (var item in variable.LogList)
            //{
            //    if (item.Message.Contains("2025"))
            //    {
            //        variable.LogList.Remove(item);
            //        break;
            //    }
            //}
            var itemToRemove = variable.LogList.FirstOrDefault(item => item.Message.Contains("2025"));
            if (itemToRemove != null)
            {
                variable.LogList.Remove(itemToRemove);
            }
        }
    }
}
