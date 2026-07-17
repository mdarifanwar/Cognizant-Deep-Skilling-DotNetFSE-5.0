using FactoryMethodPatternExample.Documents;
using FactoryMethodPatternExample.Factories;

namespace FactoryMethodPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Factory Method Pattern Example ===\n");

            DocumentFactory wordFactory = new WordDocumentFactory();
            IDocument word = wordFactory.CreateDocument();
            word.Open();

            DocumentFactory pdfFactory = new PdfDocumentFactory();
            IDocument pdf = pdfFactory.CreateDocument();
            pdf.Open();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            IDocument excel = excelFactory.CreateDocument();
            excel.Open();

            Console.WriteLine("\nAll documents created successfully using Factory Method Pattern.");
        }
    }
}