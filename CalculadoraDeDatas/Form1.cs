namespace CalculadoraDeDatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculaDiferenca_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(dtpInicial.Value.ToString(), out DateTime dti);
            DateTime.TryParse(dtpFinal.Value.ToString(), out DateTime dtf);

            TimeSpan dias = dtf - dti;
            lbResultado.Text = dias.Days.ToString();
        }

        private void btnAdicionaSubtrai_Click(object sender, EventArgs e)
        {
            DateTime.TryParse(dtpDataAdicionaSubtrai.Value.ToString(), out DateTime dt);
            if (!string.IsNullOrEmpty(tbDias.Text) && !string.IsNullOrWhiteSpace(tbDias.Text))
            {
                int.TryParse(tbDias.Text, out int dias);

                if (rbAdiciona.Checked)
                {
                    dt = dt.AddDays(dias);
                }
                else
                {
                    dt = dt.AddDays(-dias);
                }
            }
            if (!string.IsNullOrEmpty(tbMeses.Text) && !string.IsNullOrWhiteSpace(tbMeses.Text))
            {
                int.TryParse(tbMeses.Text, out int meses);

                if (rbAdiciona.Checked)
                {
                    dt = dt.AddMonths(meses);
                }
                else
                {
                    dt = dt.AddMonths(meses);
                }
            }
            if (!string.IsNullOrEmpty(tbAnos.Text) && !string.IsNullOrWhiteSpace(tbAnos.Text))
            {
                int.TryParse(tbAnos.Text, out int anos);

                if (rbAdiciona.Checked)
                {
                    dt = dt.AddYears(anos);
                }
                else
                {
                    dt = dt.AddYears(anos);
                }
            }
            lbResultado.Text = dt.ToString("dd/MM/yyyy");
        }

    }
}
