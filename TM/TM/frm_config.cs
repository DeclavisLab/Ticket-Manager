﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TM
{
    public partial class frm_config : Form
    {
        public frm_config()
        {
            InitializeComponent();
            this.CancelButton = btn_can;
            LoadContent();
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveContent();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        void LoadContent()
        {
            textBox1.Text = Form1.conf.gitpath;
            checkBox1.Checked = Form1.conf.git_e;
            CValidater();
        }

        void CValidater()
        {
            if (!checkBox1.Checked) { textBox1.Enabled = false; } else { textBox1.Enabled = true; }
        }

        void SaveContent()
        {
            Form1.conf.gitpath = textBox1.Text;
            Form1.conf.git_e = checkBox1.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CValidater();
        }
    }
}