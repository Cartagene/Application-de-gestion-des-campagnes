﻿using GesCampagneBLL;
using GesCampagneBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesCampagneGUI
{
    public partial class FrmConsultArtistes : Form
    {
        public FrmConsultArtistes()
        {
            InitializeComponent();
            List<Artiste> lesArtistes;
            lesArtistes = ArtisteManager.GetInstance().GetArtistes();
            dtgArtiste.DataSource = lesArtistes;
            dtgArtiste.Columns["id"].Visible = false;
            dtgArtiste.Columns[3].Visible = false;
            

        }
    }
}
