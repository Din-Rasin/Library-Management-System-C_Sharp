﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Assignment_13
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            using System;
            using System.IO;

class Program
        {
            static void Main()
            {
                string path = @"C:\path\to\your\file.txt";

                if (File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
        }

        InitializeComponent();
        }
    }
}
