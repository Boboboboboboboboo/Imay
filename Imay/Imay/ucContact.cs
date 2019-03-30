using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imay.Model;

namespace Imay
{
    public partial class ucContact : UserControl
    {
        private readonly Contact _contact;
        public string ContactName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public ucContact(Contact contact) : this()
        {
            _contact = contact;
        }
        public ucContact()
        {
            InitializeComponent();
        }
    }
}
