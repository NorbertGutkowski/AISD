using System;
using System.Diagnostics;

namespace Algorytmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] convert(string text)
        {
            int[] tab = text.Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();
            return tab;
        }
        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random rand = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(minValue, maxValue + 1);
            }

            return array;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] tab;

            if (!checkBox1.Checked)
            {
                tab = convert(textBox1.Text);
            }
            else
            {
                tab = convert(textBox3.Text);
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int n = tab.Length;
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (tab[i - 1] > tab[i])
                    {
                        int temp = tab[i - 1];
                        tab[i - 1] = tab[i];
                        tab[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);

            stopwatch.Stop();
            long elapsedSeconds = stopwatch.ElapsedMilliseconds / 1000;
            textBox2.Text = string.Join(" ", tab);
            textBox4.Text = string.Join(" ", elapsedSeconds);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] tab;

            if (!checkBox1.Checked)
            {
                tab = convert(textBox1.Text);
            }
            else
            {
                tab = convert(textBox3.Text);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int n = tab.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (tab[j] < tab[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = tab[i];
                    tab[i] = tab[minIndex];
                    tab[minIndex] = temp;
                }
            }

            stopwatch.Stop();
            long elapsedSeconds = stopwatch.ElapsedMilliseconds / 1000;
            textBox2.Text = string.Join(" ", tab);
            textBox4.Text = string.Join(" ", elapsedSeconds);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] tab;

            if (!checkBox1.Checked)
            {
                tab = convert(textBox1.Text);
            }
            else
            {
                tab = convert(textBox3.Text);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int n = tab.Length;

            for (int i = 1; i < n; i++)
            {
                int key = tab[i];
                int j = i - 1;

                while (j >= 0 && tab[j] > key)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }

                tab[j + 1] = key;
            }

            stopwatch.Stop();
            long elapsedSeconds = stopwatch.ElapsedMilliseconds / 1000;
            textBox2.Text = string.Join(" ", tab);
            textBox4.Text = string.Join(" ", elapsedSeconds);
        }

        static void MergeSort(int[] tab)
        {
            int n = tab.Length;
            if (n < 2)
            {
                return;
            }

            int[] left = new int[n / 2];
            int[] right = new int[n - n / 2];

            for (int i = 0; i < n / 2; i++)
            {
                left[i] = tab[i];
            }
            for (int i = n / 2; i < n; i++)
            {
                right[i - n / 2] = tab[i];
            }

            MergeSort(left);
            MergeSort(right);
            Merge(tab, left, right);
        }
        static void Merge(int[] tab, int[] left, int[] right)
        {
            int n1 = left.Length;
            int n2 = right.Length;
            int i = 0, j = 0, k = 0;

            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    tab[k] = left[i];
                    i++;
                }
                else
                {
                    tab[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                tab[k] = left[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                tab[k] = right[j];
                j++;
                k++;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int[] tab;

            if (!checkBox1.Checked)
            {
                tab = convert(textBox1.Text);
            }
            else
            {
                tab = convert(textBox3.Text);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            MergeSort(tab);

            stopwatch.Stop();
            long elapsedSeconds = stopwatch.ElapsedMilliseconds / 1000;
            textBox2.Text = string.Join(" ", tab);
            textBox4.Text = string.Join(" ", elapsedSeconds);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] tab = GenerateRandomArray(150000, 1, 2000000);
            textBox3.Text = string.Join(" ", tab);
        }
    }
}