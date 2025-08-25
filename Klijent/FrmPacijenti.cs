﻿using Klijent.GUIKontroler.PacijentKontroler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmPacijenti : Form
    {

        SviPacijentiController controller;
        public FrmPacijenti()
        {
            InitializeComponent();
            controller = new SviPacijentiController(this);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controller.NadjiPacijenta();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            controller.PrikaziPacijenta();
        }
    }
}
