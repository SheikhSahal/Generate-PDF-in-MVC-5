using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using Syncfusion.Pdf.Grid;
using System.Data;
using Syncfusion.Pdf.Tables;
using System.Diagnostics;

namespace Create_PDF_in_MVC.Controllers
{
    public class Bulk_PDFController : Controller
    {
        // GET: Bulk_PDF
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateDocument()
        {
            using (PdfDocument document = new PdfDocument())
            {
                //Add a page to the document
                PdfPage page = document.Pages.Add();

                //Create PDF graphics for the page
                PdfGraphics graphics = page.Graphics;

                //Set the standard font
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

                //Draw the text
                PdfFont font01 = new PdfStandardFont(PdfFontFamily.Helvetica, 20,PdfFontStyle.Underline);
                graphics.DrawString("PAYSLIP FOR THE MONTH OF MARCH 2021", font01, PdfBrushes.Black, new PointF(50, 10));

                PdfFont employeedatafont = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
                graphics.DrawString("EMPLOYEE # :", employeedatafont, PdfBrushes.Black, new PointF(20, 60));
                graphics.DrawString("1024:", employeedatafont, PdfBrushes.Black, new PointF(100, 60));


                graphics.DrawString("EMPLOYEE NAME :", employeedatafont, PdfBrushes.Black, new PointF(20, 80));
                graphics.DrawString("SAHAL", employeedatafont, PdfBrushes.Black, new PointF(120, 80));

                graphics.DrawString("DESGINATION :", employeedatafont, PdfBrushes.Black, new PointF(20, 100));
                graphics.DrawString("DEVELOPER", employeedatafont, PdfBrushes.Black, new PointF(120, 100));

                PdfFont footerfont = new PdfStandardFont(PdfFontFamily.Helvetica, 20, PdfFontStyle.Bold);
                graphics.DrawString("Earnings:", footerfont, PdfBrushes.Black, new PointF(20, 150));

                graphics.DrawString("Working Days:", employeedatafont, PdfBrushes.Black, new PointF(20, 180));
                graphics.DrawString("Working Hours:", employeedatafont, PdfBrushes.Black, new PointF(20, 200));
                graphics.DrawString("Over-time:", employeedatafont, PdfBrushes.Black, new PointF(20, 220));

                graphics.DrawString("5", employeedatafont, PdfBrushes.Black, new PointF(100, 180));
                graphics.DrawString("39", employeedatafont, PdfBrushes.Black, new PointF(100, 200));
                graphics.DrawString("600", employeedatafont, PdfBrushes.Black, new PointF(100, 220));

                graphics.DrawString("Deductions:", footerfont, PdfBrushes.Black, new PointF(350, 150));

                graphics.DrawString("Abcent Days:", employeedatafont, PdfBrushes.Black, new PointF(350, 180));
                graphics.DrawString("26", employeedatafont, PdfBrushes.Black, new PointF(450, 180));

                PdfFont NetFont = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Bold);
                graphics.DrawString("Net Salary:", NetFont, PdfBrushes.Black, new PointF(20, 270));
                graphics.DrawString("26", NetFont, PdfBrushes.Black, new PointF(100, 270));

                // Open the document in browser after saving it
                document.Save("Output.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
            }

            return View();
        }

    }
}