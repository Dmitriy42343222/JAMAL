﻿using IronBarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.BarCode;
using Aspose.BarCode.Generation;
using System.IO;

namespace QR_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeGenerator QRCodeGenerator = new BarcodeGenerator(EncodeTypes.QR);
            QRCodeGenerator.CodeText = textBox1.Text;
           
            MemoryStream save = new MemoryStream();

            QRCodeGenerator.Save(save, BarCodeImageFormat.Png);
            save.Position = 0;

            Bitmap bitmap = new Bitmap(save);

            pictureBox1.Image = bitmap;

            save.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            pictureBox1.Image = null;
        }
    }
}

