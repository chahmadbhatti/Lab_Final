﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace labf
{
    public partial class StudentsForm : Window
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
 
            string studentName = studentNameTextBox.Text;
            int age = int.Parse(studentAgeTextBox.Text);

        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Enter student name..." || textBox.Text == "Enter age...")
            {
                textBox.Text = "";
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "studentNameTextBox")
                    textBox.Text = "Enter student name...";
                else if (textBox.Name == "studentAgeTextBox")
                    textBox.Text = "Enter age...";
            }
        }
    }
}

