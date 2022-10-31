using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ювелирная_мастерская
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ювелирная_мастерскаяDataSet.Slygba_torgovli". При необходимости она может быть перемещена или удалена.
            this.slygba_torgovliTableAdapter.Fill(this.ювелирная_мастерскаяDataSet.Slygba_torgovli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ювелирная_мастерскаяDataSet.Slygba_bezopastnostu". При необходимости она может быть перемещена или удалена.
            this.slygba_bezopastnostuTableAdapter.Fill(this.ювелирная_мастерскаяDataSet.Slygba_bezopastnostu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ювелирная_мастерскаяDataSet.Proizvodstvo_uvelirnux_izdelii". При необходимости она может быть перемещена или удалена.
            this.proizvodstvo_uvelirnux_izdeliiTableAdapter.Fill(this.ювелирная_мастерскаяDataSet.Proizvodstvo_uvelirnux_izdelii);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
