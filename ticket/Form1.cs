using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
        }

        int seans1 = 0;
        int seans1ucreti = 0;
        int seans2 = 0;
        int seans2ucreti = 0;
        int seans3 = 0;
        int seans3ucreti = 0;
        int numberofcorn = 0;
        int priceofcorn = 0;
        int numberofcola = 0;
        int priceofcola = 0;
        int numberofwater = 0;
        int priceofwater = 0;
        int totalprice = 0;
        int totalviewers = 0;

        private void CalculateTotalViewers()
        {
            totalviewers = seans1 + seans2 + seans3;
            label11.Text = totalviewers.ToString();
        }

        private void CalculateTotalPrice()
        {
            totalprice = seans1ucreti + seans2ucreti + seans3ucreti + priceofcorn + priceofcola + priceofwater;
            label9.Text = totalprice.ToString();
        }

        private void UpdateTotalSoldProducts()
        {
            label16.Text = (numberofcola+numberofcorn+numberofwater).ToString();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            seans1++;
            seans1ucreti += 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucreti.ToString();
            if (seans1 == 30)
            {
                button1.Enabled = false;
            }
            CalculateTotalPrice();
            CalculateTotalViewers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1ucreti -= 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucreti.ToString();
            if (seans1 == 0)
            {
                button2.Enabled = false;
            }
            CalculateTotalPrice();
            CalculateTotalViewers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            seans2++;
            seans2ucreti += 12;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2ucreti.ToString();
            if (seans2 == 30)
            {
                button3.Enabled = false;
            }
            CalculateTotalPrice();
            CalculateTotalViewers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2ucreti -= 12;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2ucreti.ToString();
            if (seans2 == 0)
            {
                button4.Enabled = false;
            }
            CalculateTotalPrice();
            CalculateTotalViewers();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            seans3++;
            seans3ucreti += 16;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3ucreti.ToString();
            if (seans3 == 30)
            {
                button5.Enabled = false;
            }
            CalculateTotalPrice();
            CalculateTotalViewers();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3ucreti -= 16;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3ucreti.ToString();
            if (seans3 == 0)
            {
                button6.Enabled = false;
            }
            CalculateTotalPrice();
            CalculateTotalViewers();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numberofcorn++;
            priceofcorn += 4;
            label12.Text = priceofcorn.ToString();
            CalculateTotalPrice();
            UpdateTotalSoldProducts();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numberofcorn--;
            priceofcorn -= 4;
            label12.Text = priceofcorn.ToString();
            CalculateTotalPrice();
            UpdateTotalSoldProducts();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numberofcola++;
            priceofcola += 2;
            label13.Text = priceofcola.ToString();
            CalculateTotalPrice();
            UpdateTotalSoldProducts();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numberofcola--;
            priceofcola -= 2;
            label13.Text = priceofcola.ToString();
            CalculateTotalPrice();
            UpdateTotalSoldProducts();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numberofwater++;
            priceofwater += 1;
            label14.Text = priceofwater.ToString();
            CalculateTotalPrice();
            UpdateTotalSoldProducts();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numberofwater--;
            priceofwater -= 1;
            label14.Text = priceofwater.ToString();
            CalculateTotalPrice();
            UpdateTotalSoldProducts();
        }

        private void label11_Click(object sender, EventArgs e) { }

        private void button13_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
            CalculateTotalViewers();
            UpdateTotalSoldProducts();
        }

        private void label15_Click(object sender, EventArgs e) { }
    }
}

