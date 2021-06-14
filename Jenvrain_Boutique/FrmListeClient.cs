using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestClient;

namespace Jenvrain_Boutique
{
    public partial class FrmListeClient : Form
    {
        public FrmListeClient()
        {
            InitializeComponent();
        }

        private void FrmListeClient_Load(object sender, EventArgs e)
        {
            dgvListeClient.DataSource = GestionClient.getLesClients();
        }


    }
}
