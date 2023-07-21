namespace TestTask
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int sortNum = 0;

            if (RadioName.Checked)
            {
                sortNum = 0;
            }
            else if (RadioRkk.Checked)
            {
                sortNum = 1;
            }
            else if (RadioObr.Checked)
            {
                sortNum = 2;
            }
            else { sortNum = 3; }

            var outPutForm = new OutPutForm(RKKPath.Text, ObrPath.Text, sortNum);
            outPutForm.Show();
        }

        private void SelectRKKPathButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Multiselect = false;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                RKKPath.Text = selectedFile;
            }
        }

        private void SelectPathObrButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Multiselect = false;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                ObrPath.Text = selectedFile;
            }
        }

    }
}