using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBodyScanner.Views.Bases
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            ImagenLoading.Load("Img/cargando.gif");
            ImagenLoading.Location = new Point(this.Width/2-ImagenLoading.Width/2,
                this.Height / 2 - ImagenLoading.Height / 2);
        }
    }
}
