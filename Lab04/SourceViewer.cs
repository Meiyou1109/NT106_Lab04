﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class SourceViewer : Form
    {
        public SourceViewer(string htmlContent)
        {
            InitializeComponent();
            txtSource.Text = htmlContent;
        }
    }
}
