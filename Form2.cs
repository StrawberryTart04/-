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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ювелирная_мастерскаяDataSet.Slygba_torgovli". При необходимости она может быть перемещена или удалена.
            this.slygba_torgovliTableAdapter.Fill(this.ювелирная_мастерскаяDataSet.Slygba_torgovli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ювелирная_мастерскаяDataSet.Proizvodstvo_uvelirnux_izdelii". При необходимости она может быть перемещена или удалена.
            this.proizvodstvo_uvelirnux_izdeliiTableAdapter.Fill(this.ювелирная_мастерскаяDataSet.Proizvodstvo_uvelirnux_izdelii);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ювелирная_мастерскаяDataSet.Slygba_bezopastnostu". При необходимости она может быть перемещена или удалена.
            this.slygba_bezopastnostuTableAdapter.Fill(this.ювелирная_мастерскаяDataSet.Slygba_bezopastnostu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ювелирная_мастерскаяDataSet.Color". При необходимости она может быть перемещена или удалена.
            this.colorTableAdapter.Fill(this.ювелирная_мастерскаяDataSet.Color);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
