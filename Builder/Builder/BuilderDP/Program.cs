// See https://aka.ms/new-console-template for more information

using BuilderDP;
// Client Code


Report report;
ReportDirector reportDirector = new ReportDirector();
// Construct and display Reports
PDFReport pdfReport = new PDFReport();
report = reportDirector.MakeReport(pdfReport);
report.DisplayReport();
Console.WriteLine("-------------------");
ExcelReport excelReport = new ExcelReport();
report = reportDirector.MakeReport(excelReport);
report.DisplayReport();

Console.ReadKey();

