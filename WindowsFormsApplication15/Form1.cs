using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Entities11 m = new WindowsFormsApplication15.Entities11())
            using (var t = m.Database.BeginTransaction())
            {
                var r = m.JZHZ_RELATION.FirstOrDefault(a => a.ID == "123");
                if (r != null)
                {
                    m.JZHZ_RELATION.Remove(r);
                }

                var r1 = m.JZHZ.FirstOrDefault(a => a.ID == "1");
                if (r1 != null)
                {
                    r1.VNAME = "asd";
                }

                m.SaveChanges();
                t.Commit();

                MessageBox.Show("sss212");
            }

            using (Entities11 m = new WindowsFormsApplication15.Entities11())
            {
                var r = m.JZHZ_RELATION.FirstOrDefault(a => a.ID == "123");
                if (r != null)
                {
                    m.JZHZ_RELATION.Remove(r);
                }
                m.SaveChanges();
            }

            MessageBox.Show("sss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entities11 m = new WindowsFormsApplication15.Entities11();


            var rr = m.V_MZSF_PRESC.FirstOrDefault(a => a.VCLINICNO == "00000305");

            MessageBox.Show(rr.VNAME);

        }
    }
}
