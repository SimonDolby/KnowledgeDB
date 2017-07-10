using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Novacode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;


namespace Unit__Tests_of_KnowledgeDB
{
   

    [TestClass]
    public class WritingToDocumentsTest
    {



        [TestMethod]
        public void CreateDocxTest()
        {
            String filepath;
            filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "test.docx");
            string headlineText = "Lorem Ipsum";
            string paraOne = ""
                + "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce bibendum dictum sapien at sagittis."
                + "Donec dapibus vel mauris mattis fringilla. "
                + "Donec ornare, augue ac rutrum vulputate, dolor est venenatis felis, eget facilisis dolor eros non mauris. ";
       

            // A formatting object for our headline:
            var headLineFormat = new Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily("Arial Black");
            headLineFormat.Size = 18D;
            headLineFormat.Position = 12;

            // A formatting object for our normal paragraph text:
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 10D;

            // Create the document in memory:
            var doc = DocX.Create(filepath);

            // Insert the now text obejcts;
            // Insert the Headline and do some formatting:
            Paragraph headline = doc.InsertParagraph(headlineText);
            headline.Color(System.Drawing.Color.Teal);
            headline.Font(new System.Drawing.FontFamily("Calibri light"));
            headline.Bold();
            headline.Position(12D);
            headline.FontSize(18D);

            
            doc.InsertParagraph(paraOne, false, paraFormat);

            // Save to the output directory:
            doc.Save();

            
        }
    }
}
