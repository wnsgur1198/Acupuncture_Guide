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
using System.Windows.Media.Animation;
namespace Acupucnture
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool num2 = false;  //손 발      

        public MainWindow()
        {
            InitializeComponent();
            Foot.Children.Clear();         
        }
                
        private void hand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {           
            DoubleAnimation heightani = new DoubleAnimation(Canvas.GetTop(hand), 
                Canvas.GetTop(hand)-1020,new Duration(TimeSpan.FromMilliseconds(5000)));
            TranslateTransform translate = new TranslateTransform();
            hand.RenderTransform = translate;
            translate.BeginAnimation(TranslateTransform.YProperty, heightani);            
        }

        private void foot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation heightani = new DoubleAnimation(Canvas.GetTop(foot),
                 Canvas.GetTop(foot)+1200, new Duration(TimeSpan.FromMilliseconds(5000)));
            TranslateTransform translate = new TranslateTransform();
            foot.RenderTransform = translate;
            translate.BeginAnimation(TranslateTransform.YProperty, heightani);
        }
       
        private void draw1()    //눈그리기
        {
            if (num2 == false)
            {
                Ellipse dot = new Ellipse();
                dot.Stroke = Brushes.Blue;
                dot.Fill = Brushes.Blue;
                dot.Width = 10;
                dot.Height = 10;
                canvas1.Children.Add(dot);

                Ellipse dot1 = new Ellipse();
                dot1.Stroke = Brushes.Blue;
                dot1.Fill = Brushes.Blue;
                dot1.Width = 10;
                dot1.Height = 10;
                canvas01.Children.Add(dot1);
                eye1.Text = "눈 피로 완화";
            }
            else
            {
                Ellipse dot = new Ellipse();
                dot.Stroke = Brushes.Red;
                dot.Fill = Brushes.Red;
                dot.Width = 10;
                dot.Height = 10;
                canvas1_1.Children.Add(dot);

                Ellipse dot1 = new Ellipse();
                dot1.Stroke = Brushes.Red;
                dot1.Fill = Brushes.Red;
                dot1.Width = 10;
                dot1.Height = 10;
                canvas1_2.Children.Add(dot1);

                Ellipse dot2 = new Ellipse();
                dot2.Stroke = Brushes.Red;
                dot2.Fill = Brushes.Red;
                dot2.Width = 10;
                dot2.Height = 10;
                canvas1_3.Children.Add(dot2);

                Ellipse dot3 = new Ellipse();
                dot3.Stroke = Brushes.Red;
                dot3.Fill = Brushes.Red;
                dot3.Width = 10;
                dot3.Height = 10;
                canvas1_4.Children.Add(dot3);
                eye2.Text = "눈 피로 완화";
            }
        }
        private void draw2()    //코그리기
        {
            if (num2 == false)
            {
                Ellipse dot = new Ellipse();
                dot.Stroke = Brushes.Blue;
                dot.Fill = Brushes.Blue;
                dot.Width = 10;
                dot.Height = 10;
                canvas2.Children.Add(dot);

                nose1.Text = "비염 완화";
            }
            else
            {
                Ellipse dot = new Ellipse();
                dot.Stroke = Brushes.Red;
                dot.Fill = Brushes.Red;
                dot.Width = 10;
                dot.Height = 10;
                canvas2_1.Children.Add(dot);

                Ellipse dot1 = new Ellipse();
                dot1.Stroke = Brushes.Red;
                dot1.Fill = Brushes.Red;
                dot1.Width = 10;
                dot1.Height = 10;
                canvas2_2.Children.Add(dot1);

                nose1.Text = "비염 완화";
            }
        }
        private void draw3()    //심장그리기
        {
            if (num2 == false)
            {
                Ellipse dot = new Ellipse();
                dot.Stroke = Brushes.Blue;
                dot.Fill = Brushes.Blue;
                dot.Width = 10;
                dot.Height = 10;
                canvas3.Children.Add(dot);

                heart1.Text = "가슴 통증 완화";
            }
            else
            {
                Ellipse dot = new Ellipse();
                dot.Stroke = Brushes.Red;
                dot.Fill = Brushes.Red;
                dot.Width = 10;
                dot.Height = 10;
                canvas3_1.Children.Add(dot);

                heart2.Text = "가슴 통증 완화";
            }
        }
        private void draw4()    //폐그리기
        {
            if (num2 == false)
            {
                Ellipse dot = new Ellipse();
                dot.Stroke = Brushes.Blue;
                dot.Fill = Brushes.Blue;
                dot.Width = 10;
                dot.Height = 10;
                canvas4.Children.Add(dot);

                lung1.Text = "가슴 답답함 완화";
            }
            else
            {
                Ellipse dot = new Ellipse(); ;
                dot.Stroke = Brushes.Red;
                dot.Fill = Brushes.Red;
                dot.Width = 220;
                dot.Height = 60;
                canvas4_1.Children.Add(dot);

                Ellipse dot1 = new Ellipse();
                dot1.Stroke = Brushes.Red;
                dot1.Fill = Brushes.Red;
                dot1.Width = 220;
                dot1.Height = 60;
                canvas4_2.Children.Add(dot1);

                lung2.Text = "가슴 답답함 완화";
            }
        }
        private void draw5()    //위그리기
        {
            if (num2 == false)
            {
                Ellipse dot = new Ellipse();
                dot.Stroke = Brushes.Blue;
                dot.Fill = Brushes.Blue;
                dot.Width = 10;
                dot.Height = 10;
                canvas5.Children.Add(dot);

                stomach1.Text = "복통 완화";
            }
            else
            {
                Ellipse dot = new Ellipse(); ;
                dot.Stroke = Brushes.Red;
                dot.Fill = Brushes.Red;
                dot.Width = 30;
                dot.Height = 30;
                canvas5_1.Children.Add(dot);

                Ellipse dot1 = new Ellipse();
                dot1.Stroke = Brushes.Red;
                dot1.Fill = Brushes.Red;
                dot1.Width = 30;
                dot1.Height = 30;
                canvas5_2.Children.Add(dot1);

                stomach2.Text = "복통 완화";
            }
        }
        private void draw6()    //이자그리기
        {
            if (num2 == false)
            {
                Ellipse dot = new Ellipse();
                dot.Stroke = Brushes.Blue;
                dot.Fill = Brushes.Blue;
                dot.Width = 10;
                dot.Height = 10;
                canvas6.Children.Add(dot);

                pancreas1.Text = "메스꺼움 완화";
            }
            else
            {
                Ellipse dot = new Ellipse(); ;
                dot.Stroke = Brushes.Red;
                dot.Fill = Brushes.Red;
                dot.Width = 20;
                dot.Height = 20;
                canvas6_1.Children.Add(dot);

                Ellipse dot1 = new Ellipse();
                dot1.Stroke = Brushes.Red;
                dot1.Fill = Brushes.Red;
                dot1.Width = 20;
                dot1.Height = 20;
                canvas6_2.Children.Add(dot1);

                pancreas2.Text = "메스꺼움 완화";
            }
        }
        private void draw7()    //방광그리기
        {
            if (num2 == false)
            {
                Ellipse dot = new Ellipse();
                dot.Stroke = Brushes.Blue;
                dot.Fill = Brushes.Blue;
                dot.Width = 10;
                dot.Height = 10;
                canvas7.Children.Add(dot);

                bladder1.Text = "배뇨 기능 활성";
            }
            else
            {
                Ellipse dot = new Ellipse(); ;
                dot.Stroke = Brushes.Red;
                dot.Fill = Brushes.Red;
                dot.Width = 20;
                dot.Height = 20;
                canvas7_1.Children.Add(dot);

                Ellipse dot1 = new Ellipse();
                dot1.Stroke = Brushes.Red;
                dot1.Fill = Brushes.Red;
                dot1.Width = 20;
                dot1.Height = 20;
                canvas7_2.Children.Add(dot1);

                bladder2.Text = "배뇨 기능 활성";
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)    //초기화
        {

            heart1.Text = "";
            lung1.Text = "";
            nose1.Text = "";
            eye1.Text = "";
            bladder1.Text = "";
            pancreas1.Text = "";
            stomach1.Text = "";

            heart2.Text = "";
            lung2.Text = "";
            nose2.Text = "";
            eye2.Text = "";
            bladder2.Text = "";
            pancreas2.Text = "";
            stomach2.Text = "";

            canvas1.Children.Clear();
            canvas01.Children.Clear();
            canvas2.Children.Clear();
            canvas3.Children.Clear();
            canvas4.Children.Clear();
            canvas5.Children.Clear();
            canvas6.Children.Clear();
            canvas7.Children.Clear();
            canvas1_1.Children.Clear();
            canvas1_2.Children.Clear();
            canvas1_3.Children.Clear();
            canvas1_4.Children.Clear();
            canvas2_1.Children.Clear();
            canvas2_2.Children.Clear();
            canvas3_1.Children.Clear();
            canvas4_1.Children.Clear();
            canvas4_2.Children.Clear();
            canvas5_1.Children.Clear();
            canvas5_2.Children.Clear();
            canvas6_1.Children.Clear();
            canvas6_2.Children.Clear();
            canvas7_1.Children.Clear();
            canvas7_2.Children.Clear();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            heart1.Text = "";
            lung1.Text = "";
            nose1.Text = "";
            // eye1.Text = "";
            bladder1.Text = "";
            pancreas1.Text = "";
            stomach1.Text = "";

            heart2.Text = "";
            lung2.Text = "";
            nose2.Text = "";
            // eye2.Text = "";
            bladder2.Text = "";
            pancreas2.Text = "";
            stomach2.Text = "";

            // canvas1.Children.Clear();
            //canvas01.Children.Clear();
            canvas2.Children.Clear();
            canvas3.Children.Clear();
            canvas4.Children.Clear();
            canvas5.Children.Clear();
            canvas6.Children.Clear();
            canvas7.Children.Clear();
            // canvas1_1.Children.Clear();
            //  canvas1_2.Children.Clear();
            // canvas1_3.Children.Clear();
            //  canvas1_4.Children.Clear();
            canvas2_1.Children.Clear();
            canvas2_2.Children.Clear();
            canvas3_1.Children.Clear();
            canvas4_1.Children.Clear();
            canvas4_2.Children.Clear();
            canvas5_1.Children.Clear();
            canvas5_2.Children.Clear();
            canvas6_1.Children.Clear();
            canvas6_2.Children.Clear();
            canvas7_1.Children.Clear();
            canvas7_2.Children.Clear();
            draw1();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            heart1.Text = "";
            lung1.Text = "";
            // nose1.Text = "";
            eye1.Text = "";
            bladder1.Text = "";
            pancreas1.Text = "";
            stomach1.Text = "";

            heart2.Text = "";
            lung2.Text = "";
            // nose2.Text = "";
            eye2.Text = "";
            bladder2.Text = "";
            pancreas2.Text = "";
            stomach2.Text = "";

            canvas1.Children.Clear();
            canvas01.Children.Clear();
            //  canvas2.Children.Clear();
            canvas3.Children.Clear();
            canvas4.Children.Clear();
            canvas5.Children.Clear();
            canvas6.Children.Clear();
            canvas7.Children.Clear();
            canvas1_1.Children.Clear();
            canvas1_2.Children.Clear();
            canvas1_3.Children.Clear();
            canvas1_4.Children.Clear();
            // canvas2_1.Children.Clear();
            // canvas2_2.Children.Clear();
            canvas3_1.Children.Clear();
            canvas4_1.Children.Clear();
            canvas4_2.Children.Clear();
            canvas5_1.Children.Clear();
            canvas5_2.Children.Clear();
            canvas6_1.Children.Clear();
            canvas6_2.Children.Clear();
            canvas7_1.Children.Clear();
            canvas7_2.Children.Clear();
            draw2();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            // heart1.Text = "";
            lung1.Text = "";
            nose1.Text = "";
            eye1.Text = "";
            bladder1.Text = "";
            pancreas1.Text = "";
            stomach1.Text = "";

            // heart2.Text = "";
            lung2.Text = "";
            nose2.Text = "";
            eye2.Text = "";
            bladder2.Text = "";
            pancreas2.Text = "";
            stomach2.Text = "";

            canvas1.Children.Clear();
            canvas01.Children.Clear();
            canvas2.Children.Clear();
            // canvas3.Children.Clear();
            canvas4.Children.Clear();
            canvas5.Children.Clear();
            canvas6.Children.Clear();
            canvas7.Children.Clear();
            canvas1_1.Children.Clear();
            canvas1_2.Children.Clear();
            canvas1_3.Children.Clear();
            canvas1_4.Children.Clear();
            canvas2_1.Children.Clear();
            canvas2_2.Children.Clear();
            // canvas3_1.Children.Clear();
            canvas4_1.Children.Clear();
            canvas4_2.Children.Clear();
            canvas5_1.Children.Clear();
            canvas5_2.Children.Clear();
            canvas6_1.Children.Clear();
            canvas6_2.Children.Clear();
            canvas7_1.Children.Clear();
            canvas7_2.Children.Clear();
            draw3();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

            heart1.Text = "";
            //lung1.Text = "";
            nose1.Text = "";
            eye1.Text = "";
            bladder1.Text = "";
            pancreas1.Text = "";
            stomach1.Text = "";

            heart2.Text = "";
            //  lung2.Text = "";
            nose2.Text = "";
            eye2.Text = "";
            bladder2.Text = "";
            pancreas2.Text = "";
            stomach2.Text = "";

            canvas1.Children.Clear();
            canvas01.Children.Clear();
            canvas2.Children.Clear();
            canvas3.Children.Clear();
            // canvas4.Children.Clear();
            canvas5.Children.Clear();
            canvas6.Children.Clear();
            canvas7.Children.Clear();
            canvas1_1.Children.Clear();
            canvas1_2.Children.Clear();
            canvas1_3.Children.Clear();
            canvas1_4.Children.Clear();
            canvas2_1.Children.Clear();
            canvas2_2.Children.Clear();
            canvas3_1.Children.Clear();
            // canvas4_1.Children.Clear();
            // canvas4_2.Children.Clear();
            canvas5_1.Children.Clear();
            canvas5_2.Children.Clear();
            canvas6_1.Children.Clear();
            canvas6_2.Children.Clear();
            canvas7_1.Children.Clear();
            canvas7_2.Children.Clear();
            draw4();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {

            heart1.Text = "";
            lung1.Text = "";
            nose1.Text = "";
            eye1.Text = "";
            bladder1.Text = "";
            pancreas1.Text = "";
            //  stomach1.Text = "";

            heart2.Text = "";
            lung2.Text = "";
            nose2.Text = "";
            eye2.Text = "";
            bladder2.Text = "";
            pancreas2.Text = "";
            // stomach2.Text = "";

            canvas1.Children.Clear();
            canvas01.Children.Clear();
            canvas2.Children.Clear();
            canvas3.Children.Clear();
            canvas4.Children.Clear();
            //canvas5.Children.Clear();
            canvas6.Children.Clear();
            canvas7.Children.Clear();
            canvas1_1.Children.Clear();
            canvas1_2.Children.Clear();
            canvas1_3.Children.Clear();
            canvas1_4.Children.Clear();
            canvas2_1.Children.Clear();
            canvas2_2.Children.Clear();
            canvas3_1.Children.Clear();
            canvas4_1.Children.Clear();
            canvas4_2.Children.Clear();
            //  canvas5_1.Children.Clear();
            // canvas5_2.Children.Clear();
            canvas6_1.Children.Clear();
            canvas6_2.Children.Clear();
            canvas7_1.Children.Clear();
            canvas7_2.Children.Clear();
            draw5();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {

            heart1.Text = "";
            lung1.Text = "";
            nose1.Text = "";
            eye1.Text = "";
            bladder1.Text = "";
            //pancreas1.Text = "";
            stomach1.Text = "";

            heart2.Text = "";
            lung2.Text = "";
            nose2.Text = "";
            eye2.Text = "";
            bladder2.Text = "";
            // pancreas2.Text = "";
            stomach2.Text = "";

            canvas1.Children.Clear();
            canvas01.Children.Clear();
            canvas2.Children.Clear();
            canvas3.Children.Clear();
            canvas4.Children.Clear();
            canvas5.Children.Clear();
            // canvas6.Children.Clear();
            canvas7.Children.Clear();
            canvas1_1.Children.Clear();
            canvas1_2.Children.Clear();
            canvas1_3.Children.Clear();
            canvas1_4.Children.Clear();
            canvas2_1.Children.Clear();
            canvas2_2.Children.Clear();
            canvas3_1.Children.Clear();
            canvas4_1.Children.Clear();
            canvas4_2.Children.Clear();
            canvas5_1.Children.Clear();
            canvas5_2.Children.Clear();
            // canvas6_1.Children.Clear();
            //  canvas6_2.Children.Clear();
            canvas7_1.Children.Clear();
            canvas7_2.Children.Clear();
            draw6();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {

            heart1.Text = "";
            lung1.Text = "";
            nose1.Text = "";
            eye1.Text = "";
            //  bladder1.Text = "";
            pancreas1.Text = "";
            stomach1.Text = "";

            heart2.Text = "";
            lung2.Text = "";
            nose2.Text = "";
            eye2.Text = "";
            // bladder2.Text = "";
            pancreas2.Text = "";
            stomach2.Text = "";

            canvas1.Children.Clear();
            canvas01.Children.Clear();
            canvas2.Children.Clear();
            canvas3.Children.Clear();
            canvas4.Children.Clear();
            canvas5.Children.Clear();
            canvas6.Children.Clear();
            //canvas7.Children.Clear();
            canvas1_1.Children.Clear();
            canvas1_2.Children.Clear();
            canvas1_3.Children.Clear();
            canvas1_4.Children.Clear();
            canvas2_1.Children.Clear();
            canvas2_2.Children.Clear();
            canvas3_1.Children.Clear();
            canvas4_1.Children.Clear();
            canvas4_2.Children.Clear();
            canvas5_1.Children.Clear();
            canvas5_2.Children.Clear();
            canvas6_1.Children.Clear();
            canvas6_2.Children.Clear();
            // canvas7_1.Children.Clear();
            // canvas7_2.Children.Clear();
            draw7();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) //발
        {
            heart1.Text = "";
            lung1.Text = "";
            nose1.Text = "";
            eye1.Text = "";
            bladder1.Text = "";
            pancreas1.Text = "";
            stomach1.Text = "";

            heart2.Text = "";
            lung2.Text = "";
            nose2.Text = "";
            eye2.Text = "";
            bladder2.Text = "";
            pancreas2.Text = "";
            stomach2.Text = "";

            canvas1.Children.Clear();
            canvas01.Children.Clear();
            canvas2.Children.Clear();
            canvas3.Children.Clear();
            canvas4.Children.Clear();
            canvas5.Children.Clear();
            canvas6.Children.Clear();
            canvas7.Children.Clear();
            canvas1_1.Children.Clear();
            canvas1_2.Children.Clear();
            canvas1_3.Children.Clear();
            canvas1_4.Children.Clear();
            canvas2_1.Children.Clear();
            canvas2_2.Children.Clear();
            canvas3_1.Children.Clear();
            canvas4_1.Children.Clear();
            canvas4_2.Children.Clear();
            canvas5_1.Children.Clear();
            canvas5_2.Children.Clear();
            canvas6_1.Children.Clear();
            canvas6_2.Children.Clear();
            canvas7_1.Children.Clear();
            canvas7_2.Children.Clear();

            Hand.Children.Clear();
            Foot.Children.Add(foot);

            num2 = true;
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e) //손
        {
            heart1.Text = "";
            lung1.Text = "";
            nose1.Text = "";
            eye1.Text = "";
            bladder1.Text = "";
            pancreas1.Text = "";
            stomach1.Text = "";

            heart2.Text = "";
            lung2.Text = "";
            nose2.Text = "";
            eye2.Text = "";
            bladder2.Text = "";
            pancreas2.Text = "";
            stomach2.Text = "";

            canvas1.Children.Clear();
            canvas01.Children.Clear();
            canvas2.Children.Clear();
            canvas3.Children.Clear();
            canvas4.Children.Clear();
            canvas5.Children.Clear();
            canvas6.Children.Clear();
            canvas7.Children.Clear();
            canvas1_1.Children.Clear();
            canvas1_2.Children.Clear();
            canvas1_3.Children.Clear();
            canvas1_4.Children.Clear();
            canvas2_1.Children.Clear();
            canvas2_2.Children.Clear();
            canvas3_1.Children.Clear();
            canvas4_1.Children.Clear();
            canvas4_2.Children.Clear();
            canvas5_1.Children.Clear();
            canvas5_2.Children.Clear();
            canvas6_1.Children.Clear();
            canvas6_2.Children.Clear();
            canvas7_1.Children.Clear();
            canvas7_2.Children.Clear();

            Foot.Children.Clear();
            Hand.Children.Add(hand);

            num2 = false;
        }

        private void b_MouseDown(object sender, MouseButtonEventArgs e) //표지
        {
            b.Children.Clear();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
