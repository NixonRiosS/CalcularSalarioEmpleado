﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioConCondicionales2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double horast, valorh, salariob, salud, incremento, salariof;

            horast = double.Parse(txt_horast.Text);
            valorh = double.Parse(txt_valorh.Text);

            salariob = horast * valorh;

            switch (cmb_empleadoadmin.SelectedItem) {
                case "No":
                    if (salariob > 1000000)
                    {
                        salud = salariob * 0.04;
                        incremento = 0;

                    }
                    else
                    {
                        incremento = salariob * 0.02;
                        salud = 0;
                    }
                    salariof = salariob - salud + incremento;


                    lbl_salariob.Text = Convert.ToString("$" + String.Format("{0:n0}", salariob));
                    lbl_descuentosalud.Text = Convert.ToString("$" + String.Format("{0:n0}", salud));
                    lbl_incremento.Text = Convert.ToString("$" + String.Format("{0:n0}", incremento));
                    lbl_salariof.Text = Convert.ToString("$" + String.Format("{0:n0}", salariof));
                    break;

                case "Si":
                    if (salariob > 1000000)
                    {
                        salud = salariob * 0.08;
                        incremento = 0;

                    }
                    else
                    {
                        incremento = salariob * 0.01;
                        salud = 0;
                    }
                    salariof = salariob - salud + incremento;


                    lbl_salariob.Text = Convert.ToString("$" + String.Format("{0:n0}", salariob));
                    lbl_descuentosalud.Text = Convert.ToString("$" + String.Format("{0:n0}", salud));
                    lbl_incremento.Text = Convert.ToString("$" + String.Format("{0:n0}", incremento));
                    lbl_salariof.Text = Convert.ToString("$" + String.Format("{0:n0}", salariof));
                    break;

            }
                       
            gb_resumenpago.Visible = true;

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_horast.Text = String.Empty;
            txt_valorh.Text = String.Empty;
            gb_resumenpago.Visible = false;
            txt_horast.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_empleadoadmin.SelectedIndex = 0;
        }
    }
}
