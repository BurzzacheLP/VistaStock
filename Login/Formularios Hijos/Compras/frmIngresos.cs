﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmIngresos : Form
    {
        public int IdTrabajador;
        private bool IsNuevo;

        private DataTable dtDetalle;

        private decimal totalPagado = 0;


        private void setProveedor(string idproveedor, string nombre)
        {
            this.txtProveedorId.Text = idproveedor;
            this.txtProveedorName.Text = nombre;
        }

        private void setArticulo(string idarticulo, string nombre)
        {
            this.;
        }


        public frmIngresos()
        {
            InitializeComponent();
        }
    }
}