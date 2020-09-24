﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSort
{
    public partial class AboutForm : Form
    {

        public AboutForm()
        {
            InitializeComponent();
        }


        private void Back_Button_Click(object sender, EventArgs e)
        {
            MainForm Menu = new MainForm();
            Menu.Show();
            this.Hide();
        }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }



        // Move the MainForm
        Point LastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y); // Saves last coordinates of the pointer
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // If left mouse button is pressed
            {
                this.Left += e.X - LastPoint.X; // Add to "X coord." a subtraction between current and next points
                this.Top += e.Y - LastPoint.Y; // Add to "Y coord." a subtraction between current and next points
            }
        }
        private void MergeSort_label_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y); // Saves last coordinates of the pointer
        }
        private void MergeSort_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // If left mouse button is pressed
            {
                this.Left += e.X - LastPoint.X; // Add to "X coord." a subtraction between current and next points
                this.Top += e.Y - LastPoint.Y; // Add to "Y coord." a subtraction between current and next points
            }
        }
    }
}
