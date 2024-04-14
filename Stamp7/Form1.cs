using PdfiumViewer;

namespace Stamp7
{
    public partial class Stamp7_Main_Form : Form
    {
        public Stamp7_Main_Form()
        {
            InitializeComponent();
            InitializeComponent();
            // ������� ������� ���������� PdfRenderer
            var pdfRenderer = new PdfRenderer();
            pdfRenderer.Dock = DockStyle.Fill; // ��������� ��� ��������� ������� �����

            // ��������� PDF-����
            string pdfPath = "C:\\test\\file.pdf";
            PdfDocument pdfDocument = PdfDocument.Load(pdfPath);
            pdfRenderer.Load(pdfDocument);

            // ��������� ������� ���������� �� �����
            this.Controls.Add(pdfRenderer);
        }
    }
}