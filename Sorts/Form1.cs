using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
namespace Sorts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitArray();
            
        }

        int[] arreglo10 = new int[10];
        int[] arreglo100 = new int[100];
        int[] arreglo1000 = new int[1000];
        int[] arreglo10000 = new int[10000];
        int[] arreglo100000 = new int[100000];
        int[] arreglo1000000 = new int[1000000];
        int[] arregloDe10;
        int[] arregloDe100;
        int[] arregloDe1000;
        int[] arregloDe10000; 
        int[] arregloDe100000; 
        int[] arregloDe1000000;


        private void rbBubble_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                BubbleStadistics();
            }
        }

        private void BubbleStadistics()
        {
            int temp;
            //this.tbResult.Clear();

            for (int k = 0; k < 10; k++)
            {
                arregloDe10 = arreglo10;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int pass = 1; pass <= arregloDe10.Length - 2; pass++)
                {
                    for (int i = 0; i <= arregloDe10.Length - 2; i++)
                    {
                        if (arregloDe10[i] > arregloDe10[i + 1])
                        {
                            temp = arregloDe10[i + 1];
                            arregloDe10[i + 1] = arregloDe10[i];
                            arregloDe10[i] = temp;
                        }

                    }
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Bubble Sort en milisegundos con un arreglo de " + arreglo10.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds +"\n");
                foreach (var i in arregloDe10)
                {
                    Console.WriteLine(i);
                }
            }

            //CON 100
            for (int k = 0; k < 10; k++)
            {
                arregloDe100 = arreglo100;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int pass = 1; pass <= arregloDe100.Length - 2; pass++)
                {
                    for (int i = 0; i <= arregloDe100.Length - 2; i++)
                    {
                        if (arregloDe100[i] > arregloDe100[i + 1])
                        {
                            temp = arregloDe100[i + 1];
                            arregloDe100[i + 1] = arregloDe100[i];
                            arregloDe100[i] = temp;
                        }

                    }
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Bubble Sort en milisegundos con un arreglo de " + arreglo100.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //CON 1000
            for (int k = 0; k < 10; k++)
            {
                arregloDe1000 = arreglo1000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int pass = 1; pass <= arregloDe1000.Length - 2; pass++)
                {
                    for (int i = 0; i <= arregloDe1000.Length - 2; i++)
                    {
                        if (arregloDe1000[i] > arregloDe1000[i + 1])
                        {
                            temp = arregloDe1000[i + 1];
                            arregloDe1000[i + 1] = arregloDe1000[i];
                            arregloDe1000[i] = temp;
                        }

                    }
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Bubble Sort en milisegundos con un arreglo de " + arreglo1000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //CON 10000
            for (int k = 0; k < 10; k++)
            {
                arregloDe10000 = arreglo10000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int pass = 1; pass <= arregloDe10000.Length - 2; pass++)
                {
                    for (int i = 0; i <= arregloDe10000.Length - 2; i++)
                    {
                        if (arregloDe10000[i] > arregloDe10000[i + 1])
                        {
                            temp = arregloDe10000[i + 1];
                            arregloDe10000[i + 1] = arregloDe10000[i];
                            arregloDe10000[i] = temp;
                        }

                    }
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Bubble Sort en milisegundos con un arreglo de " + arreglo10000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //CON 100000
            for (int k = 0; k < 10; k++)
            {
                arregloDe100000 = arreglo100000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int pass = 1; pass <= arregloDe100000.Length - 2; pass++)
                {
                    for (int i = 0; i <= arregloDe100000.Length - 2; i++)
                    {
                        if (arregloDe100000[i] > arregloDe100000[i + 1])
                        {
                            temp = arregloDe100000[i + 1];
                            arregloDe100000[i + 1] = arregloDe100000[i];
                            arregloDe100000[i] = temp;
                        }

                    }
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Bubble Sort en milisegundos con un arreglo de " + arreglo100000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //CON 1000000
            for (int k = 0; k < 10; k++)
            {
                arregloDe1000000 = arreglo1000000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int pass = 1; pass <= arregloDe1000000.Length - 2; pass++)
                {
                    for (int i = 0; i <= arregloDe1000000.Length - 2; i++)
                    {
                        if (arregloDe1000000[i] > arregloDe1000000[i + 1])
                        {
                            temp = arregloDe1000000[i + 1];
                            arregloDe1000000[i + 1] = arregloDe1000000[i];
                            arregloDe1000000[i] = temp;
                        }

                    }
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Bubble Sort en milisegundos con un arreglo de " + arregloDe1000000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

        }

        private void rbInsertion_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                InsertionStadistics();
            }
        }

        private void InsertionStadistics()
        {
            //this.tbResult.Clear();
            int temp, j;

            //Con 10
            for (int k = 0; k < 10; k++)
            {
                arregloDe10 = arreglo10;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 1; i < arregloDe10.Length; i++)
                {
                    temp = arregloDe10[i];
                    j = i - 1;

                    while (j >= 0 && arregloDe10[j] > temp)
                    {
                        arregloDe10[j + 1] = arregloDe10[j];
                        j--;
                    }

                    arregloDe10[j + 1] = temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Insertion Sort en milisegundos con un arreglo de " + arregloDe10.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100
            for (int k = 0; k < 10; k++)
            {
                arregloDe100 = arreglo100;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 1; i < arregloDe100.Length; i++)
                {
                    temp = arregloDe100[i];
                    j = i - 1;

                    while (j >= 0 && arregloDe100[j] > temp)
                    {
                        arregloDe100[j + 1] = arregloDe100[j];
                        j--;
                    }

                    arregloDe100[j + 1] = temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Insertion Sort en milisegundos con un arreglo de " + arregloDe100.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //con1000
            for (int k = 0; k < 10; k++)
            {
                arregloDe1000 = arreglo1000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 1; i < arregloDe1000.Length; i++)
                {
                    temp = arregloDe1000[i];
                    j = i - 1;

                    while (j >= 0 && arregloDe1000[j] > temp)
                    {
                        arregloDe1000[j + 1] = arregloDe1000[j];
                        j--;
                    }

                    arregloDe1000[j + 1] = temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Insertion Sort en milisegundos con un arreglo de " + arregloDe1000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con10000
            for (int k = 0; k < 10; k++)
            {
                arregloDe10000 = arreglo10000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 1; i < arregloDe10000.Length; i++)
                {
                    temp = arregloDe10000[i];
                    j = i - 1;

                    while (j >= 0 && arregloDe10000[j] > temp)
                    {
                        arregloDe10000[j + 1] = arregloDe10000[j];
                        j--;
                    }

                    arregloDe10000[j + 1] = temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Insertion Sort en milisegundos con un arreglo de " + arregloDe10000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100000
            for (int k = 0; k < 10; k++)
            {
                arregloDe100000 = arreglo100000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 1; i < arregloDe100000.Length; i++)
                {
                    temp = arregloDe100000[i];
                    j = i - 1;

                    while (j >= 0 && arregloDe100000[j] > temp)
                    {
                        arregloDe100000[j + 1] = arregloDe100000[j];
                        j--;
                    }

                    arregloDe100000[j + 1] = temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Insertion Sort en milisegundos con un arreglo de " + arregloDe100000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con1000000
            for (int k = 0; k < 10; k++)
            {
                arregloDe1000000 = arreglo1000000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 1; i < arregloDe1000000.Length; i++)
                {
                    temp = arregloDe1000000[i];
                    j = i - 1;

                    while (j >= 0 && arregloDe1000000[j] > temp)
                    {
                        arregloDe1000000[j + 1] = arregloDe1000000[j];
                        j--;
                    }

                    arregloDe1000000[j + 1] = temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Insertion Sort en milisegundos con un arreglo de " + arregloDe1000000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }
        }

        private void rbSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                SelectionStadistics();
            }
        }

        private void SelectionStadistics()
        {
           // this.tbResult.Clear();

            //Con10
            for (int k = 0; k < 10; k++)
            {
                int _min = 0;
                arregloDe10 = arreglo10;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 0; i < arregloDe10.Length; i++)
                {
                    _min = i;
                    for (int j = i; j < arregloDe10.Length; j++)
                    {
                        if (arregloDe10[j] < arregloDe10[_min])
                            _min = j;
                    }
                    int _temp = arregloDe10[i];
                    arregloDe10[i] = arregloDe10[_min];
                    arregloDe10[_min] = _temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Selection Sort en milisegundos con un arreglo de " + arregloDe10.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100
            for (int k = 0; k < 10; k++)
            {
                int _min = 0;
                arregloDe100 = arreglo100;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 0; i < arregloDe100.Length; i++)
                {
                    _min = i;
                    for (int j = i; j < arregloDe100.Length; j++)
                    {
                        if (arregloDe100[j] < arregloDe100[_min])
                            _min = j;
                    }
                    int _temp = arregloDe100[i];
                    arregloDe100[i] = arregloDe100[_min];
                    arregloDe100[_min] = _temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Selection Sort en milisegundos con un arreglo de " + arregloDe100.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //con1000
            for (int k = 0; k < 10; k++)
            {
                int _min = 0;
                arregloDe1000 = arreglo1000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 0; i < arregloDe1000.Length; i++)
                {
                    _min = i;
                    for (int j = i; j < arregloDe1000.Length; j++)
                    {
                        if (arregloDe1000[j] < arregloDe1000[_min])
                            _min = j;
                    }
                    int _temp = arregloDe1000[i];
                    arregloDe1000[i] = arregloDe1000[_min];
                    arregloDe1000[_min] = _temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Selection Sort en milisegundos con un arreglo de " + arregloDe1000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con10000
            for (int k = 0; k < 10; k++)
            {
                int _min = 0;
                arregloDe10000 = arreglo10000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 0; i < arregloDe10000.Length; i++)
                {
                    _min = i;
                    for (int j = i; j < arregloDe10000.Length; j++)
                    {
                        if (arregloDe10000[j] < arregloDe10000[_min])
                            _min = j;
                    }
                    int _temp = arregloDe10000[i];
                    arregloDe10000[i] = arregloDe10000[_min];
                    arregloDe10000[_min] = _temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Selection Sort en milisegundos con un arreglo de " + arregloDe10000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100000
            for (int k = 0; k < 10; k++)
            {
                int _min = 0;
                arregloDe100000 = arreglo100000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 0; i < arregloDe100000.Length; i++)
                {
                    _min = i;
                    for (int j = i; j < arregloDe100000.Length; j++)
                    {
                        if (arregloDe100000[j] < arregloDe100000[_min])
                            _min = j;
                    }
                    int _temp = arregloDe100000[i];
                    arregloDe100000[i] = arregloDe100000[_min];
                    arregloDe100000[_min] = _temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Selection Sort en milisegundos con un arreglo de " + arregloDe100000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con1000000
            for (int k = 0; k < 10; k++)
            {
                int _min = 0;
                arregloDe1000000 = arreglo1000000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                for (int i = 0; i < arregloDe1000000.Length; i++)
                {
                    _min = i;
                    for (int j = i; j < arregloDe1000000.Length; j++)
                    {
                        if (arregloDe1000000[j] < arregloDe1000000[_min])
                            _min = j;
                    }
                    int _temp = arregloDe1000000[i];
                    arregloDe1000000[i] = arregloDe1000000[_min];
                    arregloDe1000000[_min] = _temp;
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Selection Sort en milisegundos con un arreglo de " + arregloDe1000000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }
        }

        private void rbMerge_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                MergeStadistics();
            }
        }

        private void MergeStadistics()
        {
           // this.tbResult.Clear();

            //Con10
            for (int k = 0; k < 10; k++)
            {
                
                arregloDe10 = arreglo10;
                var tiempo = new Stopwatch();
                tiempo.Start();
                MergeSort(arregloDe10, 0, arregloDe10.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Merge Sort en milisegundos con un arreglo de " + arregloDe10.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100
            for (int k = 0; k < 10; k++)
            {

                arregloDe100 = arreglo100;
                var tiempo = new Stopwatch();
                tiempo.Start();
                MergeSort(arregloDe100, 0, arregloDe100.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Merge Sort en milisegundos con un arreglo de " + arregloDe100.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con1000
            for (int k = 0; k < 10; k++)
            {

                arregloDe1000 = arreglo1000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                MergeSort(arregloDe1000, 0, arregloDe1000.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Merge Sort en milisegundos con un arreglo de " + arregloDe1000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con10000
            for (int k = 0; k < 10; k++)
            {

                arregloDe10000 = arreglo10000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                MergeSort(arregloDe10000, 0, arregloDe10000.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Merge Sort en milisegundos con un arreglo de " + arregloDe10000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100000
            for (int k = 0; k < 10; k++)
            {

                arregloDe100000 = arreglo100000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                MergeSort(arregloDe100000, 0, arregloDe100000.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Merge Sort en milisegundos con un arreglo de " + arregloDe100000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con1000000
            for (int k = 0; k < 10; k++)
            {

                arregloDe1000000 = arreglo1000000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                MergeSort(arregloDe1000000, 0, arregloDe1000000.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Merge Sort en milisegundos con un arreglo de " + arregloDe1000000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }
        }

        public static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                //Merge
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
            }
        }

        private void rbHeap_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                HeapStadistics();
            }
        }

        private void HeapStadistics()
        {
            //this.tbResult.Clear();

            //Con10
            for (int k = 0; k < 10; k++)
            {
                arregloDe10 = arreglo10;
                var tiempo = new Stopwatch();
                tiempo.Start();
                
                for (int i = arregloDe10.Length/2 - 1; i >= 0; i--)
                {
                    repairTop(arregloDe10, arregloDe10.Length - 1, i);
                }
                for (int i = arregloDe10.Length - 1; i > 0; i--)
                {
                    swap(arregloDe10, 0, i);
                    repairTop(arregloDe10, i - 1, 0);
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Heap Sort en milisegundos con un arreglo de " + arregloDe10.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100
            for (int k = 0; k < 10; k++)
            {
                arregloDe100 = arreglo100;
                var tiempo = new Stopwatch();
                tiempo.Start();

                for (int i = arregloDe100.Length / 2 - 1; i >= 0; i--)
                {
                    repairTop(arregloDe100, arregloDe100.Length - 1, i);
                }
                for (int i = arregloDe100.Length - 1; i > 0; i--)
                {
                    swap(arregloDe100, 0, i);
                    repairTop(arregloDe100, i - 1, 0);
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Heap Sort en milisegundos con un arreglo de " + arregloDe100.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con1000
            for (int k = 0; k < 10; k++)
            {
                arregloDe1000 = arreglo1000;
                var tiempo = new Stopwatch();
                tiempo.Start();

                for (int i = arregloDe1000.Length / 2 - 1; i >= 0; i--)
                {
                    repairTop(arregloDe1000, arregloDe1000.Length - 1, i);
                }
                for (int i = arregloDe1000.Length - 1; i > 0; i--)
                {
                    swap(arregloDe1000, 0, i);
                    repairTop(arregloDe1000, i - 1, 0);
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Heap Sort en milisegundos con un arreglo de " + arregloDe1000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con10000
            for (int k = 0; k < 10; k++)
            {
                arregloDe10000 = arreglo10000;
                var tiempo = new Stopwatch();
                tiempo.Start();

                for (int i = arregloDe10000.Length / 2 - 1; i >= 0; i--)
                {
                    repairTop(arregloDe10000, arregloDe10000.Length - 1, i);
                }
                for (int i = arregloDe10000.Length - 1; i > 0; i--)
                {
                    swap(arregloDe10000, 0, i);
                    repairTop(arregloDe10000, i - 1, 0);
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Heap Sort en milisegundos con un arreglo de " + arregloDe10000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100000
            for (int k = 0; k < 10; k++)
            {
                arregloDe100000 = arreglo100000;
                var tiempo = new Stopwatch();
                tiempo.Start();

                for (int i = arregloDe100000.Length / 2 - 1; i >= 0; i--)
                {
                    repairTop(arregloDe100000, arregloDe100000.Length - 1, i);
                }
                for (int i = arregloDe100000.Length - 1; i > 0; i--)
                {
                    swap(arregloDe100000, 0, i);
                    repairTop(arregloDe100000, i - 1, 0);
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Heap Sort en milisegundos con un arreglo de " + arregloDe100000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con1000000
            for (int k = 0; k < 10; k++)
            {
                arregloDe1000000 = arreglo1000000;
                var tiempo = new Stopwatch();
                tiempo.Start();

                for (int i = arregloDe1000000.Length / 2 - 1; i >= 0; i--)
                {
                    repairTop(arregloDe1000000, arregloDe1000000.Length - 1, i);
                }
                for (int i = arregloDe1000000.Length - 1; i > 0; i--)
                {
                    swap(arregloDe1000000, 0, i);
                    repairTop(arregloDe1000000, i - 1, 0);
                }
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Heap Sort en milisegundos con un arreglo de " + arregloDe1000000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }
        }

        private void repairTop(int[] array, int bottom, int topIndex)
        {
            int tmp = array[topIndex];
            int succ = topIndex*2 + 1;
            if (succ < bottom && array[succ] > array[succ + 1]) succ++;

            while (succ <= bottom && tmp > array[succ])
            {
                array[topIndex] = array[succ];
                topIndex = succ;
                succ = succ*2 + 1;
                if (succ < bottom && array[succ] > array[succ + 1]) succ++;
            }
            array[topIndex] = tmp;
        }


        private void swap(int[] array, int left, int right)
        {
            int tmp = array[right];
            array[right] = array[left];
            array[left] = tmp;
        }


        private void rbQuick_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                QuickStadistic();
            }
        }

        private void QuickStadistic()
        {
           // this.tbResult.Clear();

            //Con10
            for (int k = 0; k < 10; k++)
            {
                arregloDe10 = arreglo10;
                var tiempo = new Stopwatch();
                tiempo.Start();
                quicksort(arregloDe10,0,arregloDe10.Length-1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Quick Sort en milisegundos con un arreglo de " + arregloDe10.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100
            for (int k = 0; k < 10; k++)
            {
                arregloDe100 = arreglo100;
                var tiempo = new Stopwatch();
                tiempo.Start();
                quicksort(arregloDe100, 0, arregloDe100.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Quick Sort en milisegundos con un arreglo de " + arregloDe100.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con1000
            for (int k = 0; k < 10; k++)
            {
                arregloDe1000 = arreglo1000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                quicksort(arregloDe1000, 0, arregloDe1000.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Quick Sort en milisegundos con un arreglo de " + arregloDe1000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con10000
            for (int k = 0; k < 10; k++)
            {
                arregloDe10000 = arreglo10000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                quicksort(arregloDe10000, 0, arregloDe10000.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Quick Sort en milisegundos con un arreglo de " + arregloDe10000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100000
            for (int k = 0; k < 10; k++)
            {
                arregloDe100000 = arreglo100000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                quicksort(arregloDe100000, 0, arregloDe100000.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Quick Sort en milisegundos con un arreglo de " + arregloDe100000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con1000000
            for (int k = 0; k < 10; k++)
            {
                arregloDe1000000 = arreglo1000000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                quicksort(arregloDe1000000, 0, arregloDe1000000.Length - 1);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Quick Sort en milisegundos con un arreglo de " + arregloDe1000000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }
        }

        private void quicksort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }

        private void rbRadix_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RadixStadistics();
            }
        }

        private void RadixStadistics()
        {
            // this.tbResult.Clear();

            //Con10
            for (int k = 0; k < 10; k++)
            {
                arregloDe10 = arreglo10;
                var tiempo = new Stopwatch();
                tiempo.Start();
                RadixSort(ref arregloDe10);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Radix Sort en milisegundos con un arreglo de " + arregloDe10.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100
            for (int k = 0; k < 10; k++)
            {
                arregloDe100 = arreglo100;
                var tiempo = new Stopwatch();
                tiempo.Start();
                RadixSort(ref arregloDe100);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Radix Sort en milisegundos con un arreglo de " + arregloDe100.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con1000
            for (int k = 0; k < 10; k++)
            {
                arregloDe1000 = arreglo1000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                RadixSort(ref arregloDe1000);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Radix Sort en milisegundos con un arreglo de " + arregloDe1000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con10000
            for (int k = 0; k < 10; k++)
            {
                arregloDe10000 = arreglo10000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                RadixSort(ref arregloDe10000);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Radix Sort en milisegundos con un arreglo de " + arregloDe10000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con100000
            for (int k = 0; k < 10; k++)
            {
                arregloDe100000 = arreglo100000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                RadixSort(ref arregloDe100000);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Radix Sort en milisegundos con un arreglo de " + arregloDe100000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }

            //Con1000000
            for (int k = 0; k < 10; k++)
            {
                arregloDe1000000 = arreglo1000000;
                var tiempo = new Stopwatch();
                tiempo.Start();
                RadixSort(ref arregloDe1000000);
                tiempo.Stop();
                this.tbResult.AppendText("El tiempo de Radix Sort en milisegundos con un arreglo de " + arregloDe1000000.Length +
                                         " elementos es:" + tiempo.ElapsedMilliseconds + "\n");
            }
        }

        public static void RadixSort(ref int[] data)
        {
            int i, j;
            int[] temp = new int[data.Length];

            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;

                for (i = 0; i < data.Length; ++i)
                {
                    bool move = (data[i] << shift) >= 0;

                    if (shift == 0 ? !move : move)
                        data[i - j] = data[i];
                    else
                        temp[j++] = data[i];
                }

                Array.Copy(temp, 0, data, data.Length - j, j);
            }
        }
        void InitArray()
        {         
                this.Enabled = false;
                Random r = new Random();
                for (int i = 0; i < arreglo10.Length; i++)
                {
                    arreglo10[i] = r.Next(0, arreglo10.Length);
                }

                for (int i = 0; i < arreglo100.Length; i++)
                {
                    arreglo100[i] = r.Next(0, arreglo100.Length);
                }

                for (int i = 0; i < arreglo1000.Length; i++)
                {
                    arreglo1000[i] = r.Next(0, arreglo1000.Length);
                }

                for (int i = 0; i < arreglo10000.Length; i++)
                {
                    arreglo10000[i] = r.Next(0, arreglo10000.Length);
                }

                for (int i = 0; i < arreglo100000.Length; i++)
                {
                    arreglo100000[i] = r.Next(0, arreglo100000.Length);
                }

                for (int i = 0; i < arreglo1000000.Length; i++)
                {
                    arreglo1000000[i] = r.Next(0, arreglo1000000.Length);
                }

                Console.WriteLine("Termino proceso");
                this.Enabled = true;
       }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BubbleStadistics();
            InsertionStadistics();
            SelectionStadistics();
            MergeStadistics();
            HeapStadistics();
            QuickStadistic();
            RadixStadistics();
        }

    }
}
