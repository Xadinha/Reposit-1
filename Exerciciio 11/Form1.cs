namespace Exerciciio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void corDaLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK) label1.ForeColor = colorDialog.Color;

        }

        private void tipoDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}