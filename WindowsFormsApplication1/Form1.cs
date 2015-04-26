using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Humanizer;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static string language = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("Spanish");
            comboBox1.Items.Add("French");
            comboBox1.Items.Add("German");
            comboBox1.Items.Add("Russian");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                textBox1.Text = Convert.ToInt32(textBox1.Text).ToWords(new CultureInfo(language));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "English")
            {
                language = "en";
            }
            else if (comboBox1.SelectedItem.ToString() == "Spanish")
            {
                language = "es-ES";
            }
            else if (comboBox1.SelectedItem.ToString() == "French")
            {
                language = "fr-FR";
            }
            else if (comboBox1.SelectedItem.ToString() == "German")
            {
                language = "de";
            }
            else if (comboBox1.SelectedItem.ToString() == "Russian")
            {
                language = "ru";
            }
        }

    }
}
