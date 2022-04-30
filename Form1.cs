using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    
    public partial class Form1 : Form
    {
        public Button button1;
        private TextBox textBox1;
        Label label1;
        CheckBox checkbox1;
        public Form1()
        {
            // Hier Objekte anlegen
            InitializeComponent();
            
            string v = "Hello there";


            // Buttons
            button1 = new Button();
            button1.Size = new Size(50, 40);
            button1.Location = new Point(30, 30);
            button1.Text = "Click me";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);
            
            //Textboxes
            TextBox textBox1 = new TextBox();
            textBox1.Text = "Hello World!";
            textBox1.Size = new Size(80, 30);
            textBox1.Location = new Point(100, 30);
            this.Controls.Add(textBox1);

            label1 = new Label();
            label1.Size = new Size(60,40);
            label1.Location = new Point(200,200);
            label1.Text = v;
            this.Controls.Add(label1);

            checkbox1 = new CheckBox();
            checkbox1.Location = new Point(300,300);
            checkbox1.Height = 40;
            checkbox1.Width = 100;
            checkbox1.Text= "Moin";
            this.Controls.Add(checkbox1);

        }

        // Hier Events 
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        //Test
    }
}
