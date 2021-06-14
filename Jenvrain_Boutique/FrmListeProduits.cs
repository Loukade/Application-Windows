using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestProduits;

namespace Jenvrain_Boutique
{
    public partial class FrmListeProduits : Form
    {
        public FrmListeProduits()
        {
            InitializeComponent();
        }

        private void FrmListeProduits_Load(object sender, EventArgs e)
        {
            dgvListeProduits.DataSource = GestionProduits.getLesProduitsDG();
        }
    }
}
