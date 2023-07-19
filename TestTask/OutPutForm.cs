namespace TestTask
{
    public partial class OutPutForm : Form
    {
        private string _rkkPath;
        private string _obrPath;
        private int _sortNum;

        public OutPutForm(string rkkPath, string obrPath, int sortNum)
        {
            InitializeComponent();
            _rkkPath = rkkPath;
            _obrPath = obrPath;
            _sortNum = sortNum;
        }

        private void OutPutForm_Load(object sender, EventArgs e)
        {
            (Dictionary<string, int> RKKperformers, Dictionary<string, int> ObrPerformers, Dictionary<string, int> totalPerformers)
                = SearchPerformrs.GetPerforms(_rkkPath, _obrPath);

            LabelTotalSum.Text = $"Не исполнено в срок {SearchPerformrs.CalculateTotalSum(totalPerformers)} документов, из них:";
            LabelRKKSum.Text = $"- количество неисполненных входящих документов: {SearchPerformrs.CalculateTotalSum(RKKperformers)};";
            LabelObrSum.Text = $"- количество неисполненных письменных обращений граждан: {SearchPerformrs.CalculateTotalSum(ObrPerformers)}.";

            DateTime now = DateTime.Now;

            string formattedDateTime = now.ToString("dd.MM.yyyy");

            LabelData.Text = $"Дата составления справки: {formattedDateTime}";

            switch (_sortNum)
            {
                case 0:
                    (RKKperformers, ObrPerformers, totalPerformers) = SearchPerformrs.SortingByName(RKKperformers, ObrPerformers, totalPerformers);
                    LabelSortType.Text = "Сортировка: по фамилии ответственного исполнителя.";
                    break;

                case 1:
                    (RKKperformers, ObrPerformers, totalPerformers) = SearchPerformrs.SortingByRkk(RKKperformers, ObrPerformers, totalPerformers);
                    LabelSortType.Text = "Сортировка: по количеству РКК.";
                    break;

                case 2:
                    (RKKperformers, ObrPerformers, totalPerformers) = SearchPerformrs.SortingByObr(RKKperformers, ObrPerformers, totalPerformers);
                    LabelSortType.Text = "Сортировка: по количеству обращений.";
                    break;

                case 3:
                    (RKKperformers, ObrPerformers, totalPerformers) = SearchPerformrs.SortingByTotal(RKKperformers, ObrPerformers, totalPerformers);
                    LabelSortType.Text = "Сортировка: по общему количеству документов.";
                    break;

                default:
                    break;
            }

            int rowIndex = OutPutTable.RowCount;

            foreach (var kvp in RKKperformers)
            {
                string key = kvp.Key;
                int value = kvp.Value;

                string secondValue = ObrPerformers.ContainsKey(key) ? ObrPerformers[key].ToString() : "";
                string totalValue = totalPerformers.ContainsKey(key) ? totalPerformers[key].ToString() : "";

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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}