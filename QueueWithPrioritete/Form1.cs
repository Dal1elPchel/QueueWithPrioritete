using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueWithPrioritete
{
    public partial class Form1: Form
    {
        private int[] Heap;
        private int size;
        private const int CAPACITY = 15;
        private Random random;

        public Form1()
        {
            InitializeComponent();

            ArrayDataGridView.ColumnHeadersVisible = false;
            ArrayDataGridView.RowHeadersVisible = false;
            ArrayDataGridView.RowCount = 1;
            ArrayDataGridView.ColumnCount = 15;
            ArrayDataGridView.Rows[0].Height = 45;

            for (int i = 0; i < ArrayDataGridView.ColumnCount; i++)
            {
                ArrayDataGridView.Columns[i].Width = 55;
            }

            ChooseResultdataGridView.ColumnHeadersVisible = false;
            ChooseResultdataGridView.RowHeadersVisible = false;
            ChooseResultdataGridView.RowCount = 1;
            ChooseResultdataGridView.ColumnCount = 15;
            ChooseResultdataGridView.Rows[0].Height = 45;

            for (int i = 0; i < ChooseResultdataGridView.ColumnCount; i++)
            {
                ChooseResultdataGridView.Columns[i].Width = 55;
            }

            HeapDataGridView.ColumnHeadersVisible = false;
            HeapDataGridView.RowHeadersVisible = false;
            HeapDataGridView.RowCount = 4;
            HeapDataGridView.ColumnCount = 15;

            for (int i = 0; i < HeapDataGridView.RowCount; i++)
            {
                HeapDataGridView.Rows[i].Height = 41;
            }


            for (int i = 0; i < HeapDataGridView.ColumnCount; i++)
            {
                HeapDataGridView.Columns[i].Width = 55;
            }

            Heap = new int[CAPACITY];
            size = 0;
            random = new Random();
        }

        private int ParentElem(int i) => (i - 1) / 2;
        private int LeftChild(int i) => 2 * i + 1;
        private int RightChild(int i) => 2 * i + 2;

        private void Up(int index)
        {

            while (index > 0 && Heap[ParentElem(index)] < Heap[index])
            {
                int parent = ParentElem(index);
                (Heap[index], Heap[parent]) = (Heap[parent], Heap[index]);

                index = parent;
            }

        }

        private void Down(int index)
        {

            while (LeftChild(index) < size)
            {
                int left = LeftChild(index);
                int right = RightChild(index);
                int largest = left;

                if (right < size && Heap[right] > Heap[left])
                {
                    largest = right;
                }

                if (Heap[index] >= Heap[largest]) break;


                (Heap[index], Heap[largest]) = (Heap[largest], Heap[index]);

                index = largest;
            }

        }

        private void Insert(int value)
        {
            if (size >= CAPACITY)
            {
                throw new Exception("Очередь переполнена!");
            }

            Heap[size] = value;
            Up(size);
            size++;
        }

        private void CreateRandQueue()
        {

            for (int i = 0; i < CAPACITY; ++i)
            {
                int value = random.Next(10, 100);
                Insert(value);
            }
        }

        public void ClearQueue()
        {
            for (int i = 0; i < size; i++)
                Heap[i] = 0;
        }

        public void print(int[] a)
        {
            HeapDataGridView.Rows[0].Cells[7].Value = a[0];

            if (1 < a.Length && a[1] != 0)
                HeapDataGridView.Rows[1].Cells[3].Value = a[1];

            if (2 < a.Length && a[2] != 0)
                HeapDataGridView.Rows[1].Cells[11].Value = a[2];

            if (3 < a.Length && a[3] != 0)
                HeapDataGridView.Rows[2].Cells[1].Value = a[3];

            if (4 < a.Length && a[4] != 0)
                HeapDataGridView.Rows[2].Cells[5].Value = a[4];

            if (a[5] != 0)
                HeapDataGridView.Rows[2].Cells[9].Value = a[5];

            if (a[6] != 0)
                HeapDataGridView.Rows[2].Cells[13].Value = a[6];

            if (a[7] != 0)
                HeapDataGridView.Rows[3].Cells[0].Value = a[7];

            if (a[8] != 0)
                HeapDataGridView.Rows[3].Cells[2].Value = a[8];

            if (a[9] != 0)
                HeapDataGridView.Rows[3].Cells[4].Value = a[9];

            if (a[10] != 0)
                HeapDataGridView.Rows[3].Cells[6].Value = a[10];

            if (a[11] != 0)
                HeapDataGridView.Rows[3].Cells[8].Value = a[11];

            if (a[12] != 0)
                HeapDataGridView.Rows[3].Cells[10].Value = a[12];

            if (a[13] != 0)
                HeapDataGridView.Rows[3].Cells[12].Value = a[13];

            if (a[14] != 0)
                HeapDataGridView.Rows[3].Cells[14].Value = a[14];
        }

        public void Clear_Tab()
        {
            for (int i = 0; i < ArrayDataGridView.ColumnCount; i++)
            {
                ArrayDataGridView.Rows[0].Cells[i].Value = "";
            }

            for (int i = 0; i < HeapDataGridView.RowCount; i++)
            {
                for (int j = 0; j < HeapDataGridView.ColumnCount; j++)
                {
                    HeapDataGridView.Rows[i].Cells[j].Value = "";
                }
            }

            for (int i = 0; i < ChooseResultdataGridView.ColumnCount; i++)
            {
                ChooseResultdataGridView.Rows[0].Cells[i].Value = "";
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateQueueBtn_Click(object sender, EventArgs e)
        {
            CreateRandQueue();
            for (int i = 0; i < CAPACITY; i++)
            {
                if (Heap[i] != 0)
                    ArrayDataGridView.Rows[0].Cells[i].Value = Heap[i];
            }

            print(Heap);
        }

        private void ClearQueueBtn_Click(object sender, EventArgs e)
        {
            ClearQueue();
            Clear_Tab();
        }

        private void GetLargestBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
