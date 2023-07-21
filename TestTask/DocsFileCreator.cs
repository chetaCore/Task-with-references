using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace TestTask
{
    public static class DocsFileCreator
    {
        public static void GenerateReport(string outputPath, Dictionary<string, int> rkkDict, Dictionary<string, int> ObrDict, Dictionary<string, int> totalDict, string sortType)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(outputPath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();

                Body body = mainPart.Document.AppendChild(new Body());

                AddHeading(body, "Справка о неисполненных документах и обращениях граждан");
                AddParagraph(body, $"Не исполнено в срок {totalDict.Values.Sum()} документов, из них:");
                AddParagraph(body, $"- количество неисполненных входящих документов: {rkkDict.Values.Sum()}");
                AddParagraph(body, $"- количество неисполненных письменных обращений граждан: {ObrDict.Values.Sum()}");

                AddParagraph(body, $"Сортировка: {sortType}");

                Table table = CreateTable(rkkDict, ObrDict, totalDict);
                body.Append(table);

                AddParagraph(body, $"Дата составления справки: {DateTime.Now.ToShortDateString()}");
            }
        }

        private static void AddHeading(Body body, string text)
        {
            Paragraph paragraph = new Paragraph()
            {
                ParagraphProperties = new ParagraphProperties(new ParagraphStyleId() { Val = "Heading1" })
            };

            Run run = new Run(new Text(text));
            RunProperties runProperties = new RunProperties();
            runProperties.Bold = new Bold();

            run.AppendChild(runProperties);
            paragraph.AppendChild(run);

            Justification justification = new Justification() { Val = JustificationValues.Center };
            paragraph.ParagraphProperties.AppendChild(justification);

            body.Append(paragraph);

            // Добавление пустой строки
            body.Append(new Paragraph(new Run(new Break())));
        }

        private static void AddParagraph(Body body, string text)
        {
            Paragraph paragraph = new Paragraph(new Run(new Text(text)))
            {
                ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Left })
            };
            body.Append(paragraph);

            body.Append(new Paragraph(new Run(new Break())));
        }

        private static Table CreateTable(Dictionary<string, int> dict1, Dictionary<string, int> dict2, Dictionary<string, int> dict3)
        {
            Table table = new Table();

            string[] columnHeaders = { "№ п.п.", "Ответственный исполнитель", "Количество неисполненных входящих документов",
                                   "Количество неисполненных письменных обращений граждан", "Общее количество документов и обращений" };

            TableRow headerRow = new TableRow();
            foreach (var columnHeader in columnHeaders)
            {
                TableCell cell = CreateTableCell(columnHeader, true);
                headerRow.AppendChild(cell);
            }
            table.AppendChild(headerRow);

            int rowCount = Math.Max(dict1.Count, Math.Max(dict2.Count, dict3.Count));
            for (int i = 0; i < rowCount; i++)
            {
                string key = GetValueFromDictionary(dict1, i);
                int value1 = dict1.ContainsKey(key) ? dict1[key] : 0;
                int value2 = dict2.ContainsKey(key) ? dict2[key] : 0;
                int value3 = dict3.ContainsKey(key) ? dict3[key] : 0;

                TableCell cell1 = CreateTableCell((i + 1).ToString(), false);
                TableCell cell2 = CreateTableCell(key, false);
                TableCell cell3 = CreateTableCell(value1.ToString(), false);
                TableCell cell4 = CreateTableCell(value2.ToString(), false);
                TableCell cell5 = CreateTableCell(value3.ToString(), false);

                TableRow row = new TableRow();
                row.Append(cell1, cell2, cell3, cell4, cell5);
                table.AppendChild(row);
            }

            return table;
        }

        private static TableCell CreateTableCell(string text, bool isHeaderCell)
        {
            TableCell cell = new TableCell();

            TableCellProperties cellProperties = new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Auto });

            if (isHeaderCell)
            {
                cellProperties.Append(new TableCellBorders(
                    new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 2 },
                    new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 2 },
                    new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 2 },
                    new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 2 }
                ));

                cellProperties.Append(new TableCellVerticalAlignment { Val = TableVerticalAlignmentValues.Center });
                cellProperties.Append(new Shading() { Val = ShadingPatternValues.Clear, Fill = "auto", Color = "auto" });
            }
            else
            {
                cellProperties.Append(new TableCellBorders(
                    new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 1 },
                    new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 1 },
                    new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 1 },
                    new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 1 }
                ));

                cellProperties.Append(new TableCellVerticalAlignment { Val = TableVerticalAlignmentValues.Center });
                cellProperties.Append(new Shading() { Val = ShadingPatternValues.Clear, Fill = "auto", Color = "auto" });
            }

            cell.Append(cellProperties);

            Paragraph paragraph = new Paragraph(new Run(new Text(text)))
            {
                ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center })
            };
            cell.Append(paragraph);

            return cell;
        }

        private static string GetValueFromDictionary(Dictionary<string, int> dictionary, int index)
        {
            if (index < dictionary.Count)
            {
                string key = dictionary.Keys.ElementAt(index);
                return key;
            }
            return string.Empty;
        }
    }
}