using System.Diagnostics;

namespace POC_image_table
{
    class Program
    {
        static void Main(string[] args)
        {

            var Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderHtmlAsPdf("<html><head><style>td{border: 1px solid;}</style> </head><body><table style='width: 100%;'> <tr> <td>adasdasd</td> <td>asdsad</td> <td>asdasdasd</td> <td> <img src=\"http://imgur.com/SZ8Cm.jpg\"/> </td> <td>asdasdsdsad</td> </tr> <tr> <td>adasdasd</td> <td>asdsad</td> <td>asdasdasd</td> <td><img src=\"http://imgur.com/SZ8Cm.jpg\"/></td> <td>asdasdsdsad</td> </tr> <tr> <td>adasdasd</td> <td>asdsad</td> <td>asdasdasd</td> <td><img src=\"http://imgur.com/SZ8Cm.jpg\"/></td> <td>asdasdsdsad</td> </tr> <tr> <td>adasdasd</td> <td>asdsad</td> <td>asdasdasd</td> <td><img src=\"http://imgur.com/SZ8Cm.jpg\"/></td> <td>asdasdsdsad</td> </tr> <tr> <td>adasdasd</td> <td>asdsad</td> <td>asdasdasd</td> <td><img src=\"http://imgur.com/SZ8Cm.jpg\"/></td> <td>asdasdsdsad</td> </tr> </table></body></table>");
            var OutputPath = "HtmlToPDF.pdf";
            PDF.SaveAs(OutputPath);


            // This neat trick opens our PDF file so we can see the result in our default PDF viewer
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = OutputPath //put the correct path here
            };
            p.Start();

        }
    }
}
