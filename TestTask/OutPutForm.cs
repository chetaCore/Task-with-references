namespace TestTask
{
    public partial class OutPutForm : Form
    {
        private string _rkkPath;
        private string _obrPath;
        private int _sortNum;

        private Dictionary<string, int> _rKKPerformers;
        private Dictionary<string, int> _obrPerformers;
        private Dictionary<string, int> _totalPerformers;

        public OutPutForm(string rkkPath, string obrPath, int sortNum)
        {
            InitializeComponent();
            _rkkPath = rkkPath;
            _obrPath = obrPath;
            _sortNum = sortNum;
        }

        private void OutPutForm_Load(object sender, EventArgs e)
        {
            (_rKKPerformers, _obrPerformers, _totalPerformers)
                = SearchPerformrs.GetPerforms(_rkkPath, _obrPath);

            LabelTotalSum.Text = $"Не исполнено в срок {SearchPerformrs.CalculateTotalSum(_totalPerformers)} документов, из них:";
            LabelRKKSum.Text = $"- количество неисполненных входящих документов: {SearchPerformrs.CalculateTotalSum(_rKKPerformers)};";
            LabelObrSum.Text = $"- количество неисполненных письменных обращений граждан: {SearchPerformrs.CalculateTotalSum(_obrPerformers)}.";

            DateTime now = DateTime.Now;

            string formattedDateTime = now.ToString("dd.MM.yyyy");

            LabelData.Text = $"Дата составления справки: {formattedDateTime}";

            switch (_sortNum)
            {
                case 0:
                    (_rKKPerformers, _obrPerformers, _totalPerformers) = SearchPerformrs.SortingByName(_rKKPerformers, _obrPerformers, _totalPerformers);
                    LabelSortType.Text = "Сортировка: по фамилии ответственного исполнителя.";
                    break;

                case 1:
                    (_rKKPerformers, _obrPerformers, _totalPerformers) = SearchPerformrs.SortingByRkk(_rKKPerformers, _obrPerformers, _totalPerformers);
                    LabelSortType.Text = "Сортировка: по количеству РКК.";
                    break;

                case 2:
                    (_rKKPerformers, _obrPerformers, _totalPerformers) = SearchPerformrs.SortingByObr(_rKKPerformers, _obrPerformers, _totalPerformers);
                    LabelSortType.Text = "Сортировка: по количеству обращений.";
                    break;

                case 3:
                    (_rKKPerformers, _obrPerformers, _totalPerformers) = SearchPerformrs.SortingByTotal(_rKKPerformers, _obrPerformers, _totalPerformers);
                    LabelSortType.Text = "Сортировка: по общему количеству документов.";
                    break;

                default:
                    break;
            }

            int rowIndex = OutPutTable.RowCount;

            foreach (var kvp in _rKKPerformers)
            {
                string key = kvp.Key;
                int value = kvp.Value;

                string secondValue = _obrPerformers.ContainsKey(key) ? _obrPerformers[key].ToString() : "";
                string totalValue = _totalPerformers.ContainsKey(key) ? _totalPerformers[key].ToString() : "";

                OutPutTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                Label numberLabel = new Label();
                numberLabel.Dock = DockStyle.Fill;
                numberLabel.Text = (rowIndex).ToString();
                numberLabel.TextAlign = ContentAlignment.TopCenter;
                OutPutTable.Controls.Add(numberLabel, 0, rowIndex);

                Label keyLabel = new Label();
                keyLabel.Dock = DockStyle.Fill;
                keyLabel.Text = key;
                keyLabel.TextAlign = ContentAlignment.TopCenter;
                OutPutTable.Controls.Add(keyLabel, 1, rowIndex);

                Label value1Label = new Label();
                value1Label.Dock = DockStyle.Fill;
                value1Label.Text = value.ToString();
                value1Label.TextAlign = ContentAlignment.TopCenter;
                OutPutTable.Controls.Add(value1Label, 2, rowIndex);

                Label value2Label = new Label();
                value2Label.Dock = DockStyle.Fill;
                value2Label.Text = secondValue;
                value2Label.TextAlign = ContentAlignment.TopCenter;
                OutPutTable.Controls.Add(value2Label, 3, rowIndex);

                Label value3Label = new Label();
                value3Label.Dock = DockStyle.Fill;
                value3Label.Text = totalValue;
                value3Label.TextAlign = ContentAlignment.TopCenter;
                OutPutTable.Controls.Add(value3Label, 4, rowIndex);

                rowIndex++;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document|*.docx";
            saveFileDialog.Title = "Save Report";
            saveFileDialog.FileName = "report.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;

                switch (_sortNum)
                {
                    case 0:
                        DocsFileCreator.GenerateReport(path, _rKKPerformers, _obrPerformers, _totalPerformers, "по фамилии ответственного исполнителя.");
                        break;

                    case 1:
                        DocsFileCreator.GenerateReport(path, _rKKPerformers, _obrPerformers, _totalPerformers, "по количеству РКК.");
                        break;

                    case 2:
                        DocsFileCreator.GenerateReport(path, _rKKPerformers, _obrPerformers, _totalPerformers, "по количеству обращений.");
                        break;

                    case 3:
                        DocsFileCreator.GenerateReport(path, _rKKPerformers, _obrPerformers, _totalPerformers, "по общему количеству документов.");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}