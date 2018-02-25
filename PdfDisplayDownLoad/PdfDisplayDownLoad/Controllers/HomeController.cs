using PdfDisplayDownLoad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PdfDisplayDownLoad.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public FileResult PDFDisplay()
        {
            string filepath = Server.MapPath("/Document/ReadMe.pdf");
            byte[] pdfByte = Helper.GetBytesFromFile(filepath);
            return File(pdfByte, "application/pdf");
        }
        public FileResult PDFDownload()
        { 
            string filepath = Server.MapPath("/Document/ReadMe.pdf");
            byte[] pdfByte = Helper.GetBytesFromFile(filepath);
            return File(pdfByte, "application/pdf", "ReadMe.pdf");
        }
    }
}