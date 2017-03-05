using CdrParser.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvReadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CsvFile.DefaultCsvDefinition.FieldSeparator = '\t';
            //var data = CsvFile.Read<MyData>(new CsvSource("insurance_sample_t.csv")).ToList();
            
            var data = CsvFile.Read<MyData>(new CsvSource("insurance_sample.csv")).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }
    }
}
