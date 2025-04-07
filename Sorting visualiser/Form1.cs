using Sorting_visualiser.SortingAlgorithms.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_visualiser
{
    public partial class mainWindow: Form
    {
        private static int ArrayLength = 100;
        private int[] generatedArray = new int[ArrayLength];
        private Dictionary<string, ISortingAlgorithms> sortingAlgorithm = new Dictionary<string, ISortingAlgorithms> { { "Bubble sort", new BubbleSort()}, { "Selection sort", new SelectionSort() }, { "Insertion sort", new InsertionSort()}, { "Quick sort", new QuickSort()}, { "Merge sort", new MergeSort()} };
        public mainWindow()
        {
            InitializeComponent();
            int[] generatedArray = ArrayGenerator.GenerateArray(ArrayLength);
            this.generatedArray = generatedArray;
            Visualiser.SetGraph(generatedArray, ArrayLength, VisualisingChart);
            sortSelector.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generateTabButton_Click(object sender, EventArgs e)
        {
            int[] generatedArray = ArrayGenerator.GenerateArray(ArrayLength);
            this.generatedArray = generatedArray;
            Visualiser.SetGraph(generatedArray, ArrayLength, VisualisingChart);
        }

        private void runVisualisation_Click(object sender, EventArgs e)
        {
            string selectedSort = sortSelector.Text;
            ISortingAlgorithms sortAlgorithm = sortingAlgorithm[selectedSort];
            List<List<SetValue>> valuesOrder = sortAlgorithm.Sort(generatedArray, ArrayLength);
            Visualiser.Visualise(VisualisingChart, valuesOrder);
        }
    }
}
