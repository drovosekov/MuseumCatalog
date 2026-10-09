using System.Windows.Forms;

namespace MuseumCatalog.Views
{
    public partial class InputDialogForm : Form
    {
        public string ResultText { get; private set; }

        public InputDialogForm()
        {
            InitializeComponent();
        }

        public InputDialogForm(string title, string prompt, string defaultValue = "") : this()
        {
            this.Text = title;
            lblPrompt.Text = prompt;
            txtInput.Text = defaultValue;
            txtInput.Focus();
            txtInput.SelectAll();
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            ResultText = txtInput.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
