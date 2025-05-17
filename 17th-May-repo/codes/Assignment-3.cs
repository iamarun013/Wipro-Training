using System;
abstract class Document
{
    public abstract void PrinContent();
    public void ShowDocumentType(string type)
    {
        Console.WriteLine($"Document type:{type}");
    }
}

class WordDocument:Document
{
    public override void PrinContent()
    {
    Console.WriteLine("Printing Word Document");
    }
}

class PDFDocument:Document
{
    public override void PrinContent()
    {
Console.WriteLine("Printing PDF document");
    }
}

class Program
{
    public static void Main(){
        Document doc;
        doc = new WordDocument();
        doc.PrinContent();
        doc.ShowDocumentType("Word Format type");

        doc = new PDFDocument();
        doc.PrinContent();
        doc.ShowDocumentType("PDF Format type");
    }
}