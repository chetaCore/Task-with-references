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
    }
}