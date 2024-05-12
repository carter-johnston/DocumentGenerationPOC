using DocumentGenerationPOC.Invoice;
using QuestPDF;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System.Diagnostics;

Settings.License = LicenseType.Community;

var filePath = "invoice.pdf";
var model = InvoiceDataSource.GetInvoiceDetails();
var document = new InvoiceDocument(model);

document.GeneratePdf(filePath);

Process.Start("explorer.exe", filePath);