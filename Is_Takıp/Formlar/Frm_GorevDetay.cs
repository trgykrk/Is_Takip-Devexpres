using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Is_Takıp.Entity;

namespace Is_Takıp.Formlar
{
    public partial class Frm_GorevDetay : Form
    {
        public Frm_GorevDetay()
        {
            InitializeComponent();
        }

        DBTakipEntities db = new DBTakipEntities();

        private void Frm_GorevDetay_Load(object sender, EventArgs e)
        {
            db.GorevDetay.Load();
            bindingSource1.DataSource = db.GorevDetay.Local;

        }
    }
}
