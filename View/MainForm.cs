using skillTestVillon.Controller;
using skillTestVillon.Model;
using skillTestVillon.Strategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skillTestVillon.View
{
    public partial class MainForm : Form
    {
        private SortModel _model;
        private SortController _controller;
        private SortContext _context;

        public MainForm()
        {
            InitializeComponent();
            _model = new SortModel();
            _context = new SortContext();
            _controller = new SortController(_model, _context);

            comboBoxSortStrategy.Items.Add("BubbleSort");
            comboBoxSortStrategy.Items.Add("QuickSort");
            comboBoxSortStrategy.Items.Add("MergeSort");
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            _model.InputString = textBoxInput.Text;
            string selectedStrategy = comboBoxSortStrategy.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(_model.InputString))
            {
                MessageBox.Show("Input is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(selectedStrategy))
            {
                MessageBox.Show("Please select a sorting strategy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (selectedStrategy)
            {
                case "BubbleSort":
                    _context.SetSortStrategy(new BubbleSortStrategy());
                    break;
                case "QuickSort":
                    _context.SetSortStrategy(new QuickSortStrategy());
                    break;
                case "MergeSort":
                    _context.SetSortStrategy(new MergeSortStrategy());
                    break;
                default:
                    MessageBox.Show("Invalid sorting strategy selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            _controller.SortString();
            labelOutput.Text ="Sorted String:"+ _model.SortedString;
        }

    }
}