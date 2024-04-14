using PdfiumViewer;

namespace Stamp7
{
    public partial class Stamp7_Main_Form : Form
    {
        public Stamp7_Main_Form()
        {
            InitializeComponent();
            InitializeComponent();
            // Создаем элемент управления PdfRenderer
            var pdfRenderer = new PdfRenderer();
            pdfRenderer.Dock = DockStyle.Fill; // Заполняем всю доступную область формы

            // Загружаем PDF-файл
            string pdfPath = "C:\\test\\file.pdf";
            PdfDocument pdfDocument = PdfDocument.Load(pdfPath);
            pdfRenderer.Load(pdfDocument);

            // Добавляем элемент управления на форму
            this.Controls.Add(pdfRenderer);
        }
    }
}