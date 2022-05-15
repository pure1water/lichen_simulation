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
using System.Windows.Shapes;
using System.Windows.Threading;


namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>

    public class buton : Button
    {
        
        public bool IsInfected;

        
        

        

        public void isInfected()
        {
            this.IsInfected = true;
            this.Content = "";
            this.Background = Brushes.Red;
            
            int ID = Convert.ToInt32(this.Name.Remove(0, 1));
        }
    }
        
        
    
        
    public partial class Game : Window
    {
        

        




        public Game()
        {
            InitializeComponent();

            Random rand = new Random();

            int[,] setka = new int[11, 11] {      { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,10,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                { 0,0,0,0,0,0,0,0,0,0,0},
                                                                 { 0,0,0,0,0,0,0,0,0,0,0}};


        //buton but1 = new buton();
        //but1.Content = "";
        //but1.Background = Brushes.Red;


        //Grid.SetColumn(but1, 11 / 2);
        //Grid.SetRow(but1, 11 / 2);
        //myGrid.Children.Add(but1);
        b60.isInfected();
            timer okno3 = new timer();
            okno3.Show();
            okno3.textblock.Text = Convert.ToString(0);
            
            
            void timerTick(object sender, EventArgs e)
            {
                okno3.textblock.Text = Convert.ToString(Convert.ToInt32(okno3.textblock.Text) + 1);
                
            }
            
            System.Windows.Threading.DispatcherTimer timer1 = new System.Windows.Threading.DispatcherTimer();
            timer1.Tick += new EventHandler(timerTick);
            timer1.Interval = new TimeSpan(0, 0, 1);
            timer1.Start();




            void zaraza()
            {
                if (setka[i,j]<= 10 & setka[i,j] > 4)
                {
                    int verZarazheniya = rand.Next(0,2);
                    int viborKletki = rand.Next(0,8);
                    if(verZarazheniya == 1)
                    {
                        if(viborKletki == 1)
                        {
                            int n = 
                        }else if(viborKletki == 2)
                        {

                        }else if(viborKletki== 3)
                        {

                        }
                        else if (viborKletki == 4)
                        {

                        }
                        else if (viborKletki == 5)
                        {

                        }
                        else if (viborKletki == 6)
                        {

                        }
                        else if (viborKletki == 7)
                        {

                        }
                        else if (viborKletki == 0)
                        {

                        }
                    }
                }
            }

        }






    }
}
