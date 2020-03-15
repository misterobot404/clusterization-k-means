using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K_means
{
    public partial class WndMain : Form
    {
        public WndMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numbCernel.Text == "" || numbPoits.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(numbCernel.Text, "[^0-9]") &&
                System.Text.RegularExpressions.Regex.IsMatch(numbPoits.Text, "[^0-9]"))
            {
                MessageBox.Show("Обнаружены недопустимые символы. Вводите только цифры", "Ошибка");
                return;
            }
            
            string startTime = DateTime.Now.ToString();
            Data obj = new Data();
            Data.element[] Elements = new Data.element[100000];
            Data.element[] Kernels = new Data.element[1000];
            Data.NumbKernel = Convert.ToInt32(numbCernel.Text);
            Data.NumbPoints = Convert.ToInt32(numbPoits.Text);
            pictureBox1.Image = Data.Img;
            Random rand = new Random();
            RandomColor randColor = new RandomColor();
            Data.Finish = false;
            Data.ToStep1 = false;
            
            
            // Установка точкам случайного расположения

            for (int i = 0; i < Data.NumbPoints; i++)
            {
                Point tmp = new Point();
                tmp.X = rand.Next(2, 800);
                tmp.Y = rand.Next(2, 400);
                Elements[i].Pt = tmp;              
            } 
            
            //выбор кластера
            for (int i = 0; i < Data.NumbKernel; i++)
            {
                Elements[i].IsKernel = i + 1;
                Elements[i].InClass = i + 1;
                Elements[i].Pcolor = randColor.Next();
                Kernels[i] = Elements[i];
            }

            
            while (!Data.Finish) // главный цикл
            {
                // Шаг 1

                for (int i = 0; i < Data.NumbKernel; i++) //create array of kernels
                {
                    for (int j = 0; j < Data.NumbPoints; j++)
                    {
                        if (Elements[j].IsKernel == i + 1)
                        {
                            Kernels[i] = Elements[j];
                            Kernels[i].numInElements = j;
                            break;
                        }
                    }
                }
                for (int i = 0; i < Data.NumbPoints; i++) //choose class of the point
                {
                    double min = 99999999999;
                    double distance;
                    if (Elements[i].IsKernel == 0)
                    {
                        for (int j = 0; j < Data.NumbKernel; j++)
                        {
                            distance = (Elements[i].Pt.X - Kernels[j].Pt.X)*(Elements[i].Pt.X - Kernels[j].Pt.X) + (Elements[i].Pt.Y - Kernels[j].Pt.Y)*(Elements[i].Pt.Y - Kernels[j].Pt.Y);
                            if (distance < min)
                            {
                                min = distance;
                                Elements[i].InClass = j+1;
                                Elements[i].Pcolor = Kernels[j].Pcolor;
                            }
                        }
                    }
                }
                                
                obj.Fill();
                for (int i = 0; i < Data.NumbPoints; i++)
                {
                    if (Elements[i].IsKernel != 0)
                    {
                        Data.Brush = 20;
                    }
                    Data.Color = Elements[i].Pcolor;
                    obj.Draw(Elements[i]);
                    Data.Brush = 3;
                }
                pictureBox1.Refresh();
                                         
                // Шаг 2
                Data.ToStep1 = false;
               
                
                for (int i = 0; i < Data.NumbKernel; i++) 
                {
                    double distance=0; //расстояние до точки
                    double min; // минимальное расстояние
                    int oldnum;
                    int newnum;

                    // рассчёт расстояния от кластера до точек

                    oldnum = Kernels[i].numInElements;        
                    for (int k = 0; k < Data.NumbPoints; k++)
                    {
                        if ((Elements[k].InClass == i + 1)&&(Elements[k].IsKernel==0))
                        {
                            distance +=(Elements[oldnum].Pt.X - Elements[k].Pt.X)*(Elements[oldnum].Pt.X - Elements[k].Pt.X) + (Elements[oldnum].Pt.Y - Elements[k].Pt.Y)*(Elements[oldnum].Pt.Y - Elements[k].Pt.Y);
                              
                        }
                    }
                    min = distance;

                    // рассчёт расстояния от точек до ядра кластера
                    for (int j = 0; j < Data.NumbPoints; j++)
                    {
                        if ((Elements[j].InClass == i + 1) && (Elements[j].IsKernel == 0))
                        {
                            distance = 0;
                            for (int k = 0; k < Data.NumbPoints; k++)
                            {
                                if (Elements[k].InClass == i + 1)
                                {
                                    distance += (Elements[j].Pt.X - Elements[k].Pt.X) * (Elements[j].Pt.X - Elements[k].Pt.X) + (Elements[j].Pt.Y - Elements[k].Pt.Y) * (Elements[j].Pt.Y - Elements[k].Pt.Y);                
                                }
                            }
                            if (distance < min)
                            {
                                min = distance;
                                newnum = j;
                                Elements[oldnum].IsKernel = 0;
                                Elements[newnum].IsKernel = i + 1;
                                oldnum = j;                            
                                Data.ToStep1 = true;
                                break;
                            }
                        }    
                    }                                
                }
                if (!Data.ToStep1) Data.Finish = true;

            }
            MessageBox.Show("Время начала = " + startTime + " , Время конца = " + DateTime.Now.ToString(), "Кластеризация точек выполнена");
        }

    
    }
    
}
