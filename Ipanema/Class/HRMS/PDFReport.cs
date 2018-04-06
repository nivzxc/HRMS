using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.Rendering;
using System.Diagnostics;
using MigraDoc.RtfRendering;


namespace HRMS
{
    class PDFReport
    {
     
        Document document;
        Paragraph paragraph;
        Section section;
        TextFrame addressframe;
        Image image;

        public DateTime dtFrom;
        public DateTime dtTo;
        public List<string> empNum;
        public List<string> empName;
        public List<string> totalabs;
        public List<string> totallate_hr;
        public List<string> totallate_min;
        public List<string> totalut_hr;
        public List<string> totalut_min;
        public List<string> rendered_dt;
        
        public Document Late_absence_summary(string _dtFrom, string _dtTo, List<string> num, List<string> name, List<string> abs, List<string> late_hr, List<string> late_min, List<string> ut_hr, List<string> ut_min, List<string> render_dt)
        {
            dtFrom = Convert.ToDateTime(_dtFrom);
            dtTo = Convert.ToDateTime(_dtTo);
            empNum = num;
            empName = name;           
            totalabs = abs;
            totallate_hr = late_hr;
            totallate_min = late_min;
            totalut_hr = ut_hr;
            totalut_min = ut_min;
            rendered_dt = render_dt;

            this.document = new Document();
            document.DefaultPageSetup.TopMargin = 20;
            document.DefaultPageSetup.LeftMargin = 40;
            document.DefaultPageSetup.RightMargin = 20;            
            document.DefaultPageSetup.BottomMargin = 20;
            this.document.Info.Title = "HRMS Report";
            this.document.Info.Subject = "HR reports";
            this.document.Info.Author = "HR";

            DefineStyle(); // style
            PageHeader();
            PageSender();
            tableHeader();
            PageFooter();
            return document ;
        }
        public void DefineStyle()
        {
            Style style = this.document.Styles["Normal"];
            style.Font.Name = "Times New Roman";

            //HEADER
            style = this.document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm",TabAlignment.Right);
            style.ParagraphFormat.SpaceAfter = "3.0 cm";

            //FOOTER
            style = this.document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm",TabAlignment.Right);

            //tables
            style = this.document.Styles.AddStyle("Tables", "Normal");
            style.Font.Name = "Verdana";
            style.Font.Name = "Times New Roman";
            style.Font.Size = 5;

            //reference
            style = this.document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "5mm";
            style.ParagraphFormat.SpaceAfter = "5mm";
            style.ParagraphFormat.TabStops.AddTabStop("16cm", TabAlignment.Right);
        }
        
        void PageHeader()
        {            
            section = this.document.AddSection();
            image = section.AddImage("Support/logo.jpg");
            image.Height = "2.5cm";
            image.LockAspectRatio = true;
            image.RelativeVertical = RelativeVertical.Line;
            image.RelativeHorizontal = RelativeHorizontal.Margin;
            image.Top = ShapePosition.Top;
            image.Left = ShapePosition.Center;
            image.WrapFormat.Style = WrapStyle.Through;          
        }
        void PageSender()
        {
            addressframe = section.AddTextFrame();
            addressframe.Height = "3.0cm";
            addressframe.Width = "7.0cm";
            addressframe.Top = "5.0cm";
            addressframe.Left = ShapePosition.Left;
            addressframe.RelativeHorizontal = RelativeHorizontal.Margin;            
            addressframe.RelativeVertical = RelativeVertical.Page;          

            paragraph = section.AddParagraph();
            paragraph.Format.SpaceBefore = "5.0cm";
            paragraph.Style = "Reference";
            paragraph.AddFormattedText("LATE AND ABSENCES SUMMARY REPORT",TextFormat.Bold);
            paragraph.AddTab();
            paragraph.AddFormattedText("Date Printed: ", TextFormat.Bold);
            paragraph.AddText(DateTime.Now.ToString());
            paragraph = section.AddParagraph();
            paragraph.AddFormattedText("Payroll Period: ", TextFormat.Bold);
            paragraph.AddFormattedText(dtFrom.ToString(" MMM dd yyyy "));
            paragraph.AddFormattedText(" - ", TextFormat.Bold);
            paragraph.AddFormattedText(dtTo.ToString(" MMM dd yyyy"));
            paragraph.Format.SpaceBefore = "-0.3cm";
        }
        void PageFooter()
        {           
            paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddFormattedText("");
            paragraph.Format.Alignment = ParagraphAlignment.Center;
        }

        void tableHeader()
        {
            Table table = section.AddTable();
            table.Style = "Tables";
            table.Borders.Width = "0.25";
            table.Borders.Left.Width = 0.5;
            table.Borders.Right.Width = 0.5;
            table.Rows.LeftIndent = 0;

            Column column = table.AddColumn("5cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = table.AddColumn("3cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = table.AddColumn("3cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = table.AddColumn("5cm");
            column.Format.Alignment = ParagraphAlignment.Center;
                     

            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;

            row.Cells[0].AddParagraph("Employee Details");
            row.Cells[0].Format.Font.Bold = true;
            row.Cells[0].Format.Font.Size = 12;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;

            row.Cells[1].AddParagraph("ABSENT");
            row.Cells[1].Format.Font.Bold = true;
            row.Cells[1].Format.Font.Size = 12;
            row.Cells[1].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;

            row.Cells[2].AddParagraph("TARDY");
            row.Cells[2].Format.Font.Bold = true;
            row.Cells[2].Format.Font.Size = 12;
            row.Cells[2].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[2].VerticalAlignment = VerticalAlignment.Bottom;

            row.Cells[3].AddParagraph("UNDERTIME");
            row.Cells[3].Format.Font.Bold = true;
            row.Cells[3].Format.Font.Size = 12;
            row.Cells[3].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[3].VerticalAlignment = VerticalAlignment.Bottom;

            row.Cells[4].AddParagraph("");
            row.Cells[4].Format.Font.Bold = true;
            row.Cells[4].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[4].VerticalAlignment = VerticalAlignment.Bottom;

            Table table2 = section.AddTable();
            table2.Style = "Tables";
            table2.Borders.Width = "0.25";
            table2.Borders.Left.Width = 0.5;
            table2.Borders.Right.Width = 0.5;
            table2.Rows.LeftIndent = 0;

            Column column1 = table2.AddColumn("2cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            column1 = table2.AddColumn("3cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            column1 = table2.AddColumn("2cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            column1 = table2.AddColumn("1.5cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1.5cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1.5cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1.5cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            column1 = table2.AddColumn("2.5cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("2.5cm");
            column1.Format.Alignment = ParagraphAlignment.Center;


            Row row2 = table2.AddRow();
            row2.Cells[0].AddParagraph("No.");
            row2.Cells[0].Format.Font.Bold = true;
            row2.Cells[0].Format.Font.Size = 7;
            row2.Cells[0].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;

            row2.Cells[1].AddParagraph("Employee Name");
            row2.Cells[1].Format.Font.Bold = true;
            row2.Cells[1].Format.Font.Size = 7;
            row2.Cells[1].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;

            row2.Cells[2].AddParagraph("DAYS");
            row2.Cells[2].Format.Font.Bold = true;
            row2.Cells[2].Format.Font.Size = 7;
            row2.Cells[2].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[2].VerticalAlignment = VerticalAlignment.Bottom;

            row2.Cells[3].AddParagraph("HOURS");
            row2.Cells[3].Format.Font.Bold = true;
            row2.Cells[3].Format.Font.Size = 7;
            row2.Cells[3].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[3].VerticalAlignment = VerticalAlignment.Bottom;

            row2.Cells[4].AddParagraph("MINS");
            row2.Cells[4].Format.Font.Bold = true;
            row2.Cells[4].Format.Font.Size = 7;
            row2.Cells[4].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[4].VerticalAlignment = VerticalAlignment.Bottom;

            row2.Cells[5].AddParagraph("HOURS");
            row2.Cells[5].Format.Font.Bold = true;
            row2.Cells[5].Format.Font.Size = 7;
            row2.Cells[5].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[5].VerticalAlignment = VerticalAlignment.Bottom;

            row2.Cells[6].AddParagraph("MINS");
            row2.Cells[6].Format.Font.Bold = true;
            row2.Cells[6].Format.Font.Size = 7;
            row2.Cells[6].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[6].VerticalAlignment = VerticalAlignment.Bottom;

            row2.Cells[7].AddParagraph("DATE");
            row2.Cells[7].Format.Font.Bold = true;
            row2.Cells[7].Format.Font.Size = 7;
            row2.Cells[7].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[7].VerticalAlignment = VerticalAlignment.Bottom;

            row2.Cells[8].AddParagraph("REMARKS");
            row2.Cells[8].Format.Font.Bold = true;
            row2.Cells[8].Format.Font.Size = 7;
            row2.Cells[8].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[8].VerticalAlignment = VerticalAlignment.Bottom;

            Row contents;

            for (int i=0; i< empNum.Count; i++) {
                contents = table2.AddRow();
                contents.Cells[0].AddParagraph(empNum[i]);
                contents.Cells[0].Format.Font.Bold = false;
                contents.Cells[0].Format.Font.Size = 7;
                contents.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[0].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[1].AddParagraph(empName[i]);
                contents.Cells[1].Format.Font.Bold = false;
                contents.Cells[1].Format.Font.Size = 7;
                contents.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[1].VerticalAlignment = VerticalAlignment.Bottom;

                contents.Cells[2].AddParagraph(totalabs[i]);
                contents.Cells[2].Format.Font.Bold = false;
                contents.Cells[2].Format.Font.Size = 7;
                contents.Cells[2].Format.Alignment = ParagraphAlignment.Center;
                contents.Cells[2].VerticalAlignment = VerticalAlignment.Bottom;

                contents.Cells[3].AddParagraph(totallate_hr[i]);
                contents.Cells[3].Format.Font.Bold = false;
                contents.Cells[3].Format.Font.Size = 7;
                contents.Cells[3].Format.Alignment = ParagraphAlignment.Center;
                contents.Cells[3].VerticalAlignment = VerticalAlignment.Bottom;

                contents.Cells[4].AddParagraph(totallate_min[i]);
                contents.Cells[4].Format.Font.Bold = false;
                contents.Cells[4].Format.Font.Size = 7;
                contents.Cells[4].Format.Alignment = ParagraphAlignment.Center;
                contents.Cells[4].VerticalAlignment = VerticalAlignment.Bottom;

                contents.Cells[5].AddParagraph(totalut_hr[i]);
                contents.Cells[5].Format.Font.Bold = false;
                contents.Cells[5].Format.Font.Size = 7;
                contents.Cells[5].Format.Alignment = ParagraphAlignment.Center;
                contents.Cells[5].VerticalAlignment = VerticalAlignment.Bottom;

                contents.Cells[6].AddParagraph(totalut_min[i]);
                contents.Cells[6].Format.Font.Bold = false;
                contents.Cells[6].Format.Font.Size = 7;
                contents.Cells[6].Format.Alignment = ParagraphAlignment.Center;
                contents.Cells[6].VerticalAlignment = VerticalAlignment.Bottom;

                contents.Cells[7].AddParagraph(rendered_dt[i]);
                contents.Cells[7].Format.Font.Bold = false;
                contents.Cells[7].Format.Font.Size = 7;
                contents.Cells[7].Format.Alignment = ParagraphAlignment.Right;
                contents.Cells[7].VerticalAlignment = VerticalAlignment.Bottom;

                contents.Cells[8].AddParagraph("");
                contents.Cells[8].Format.Font.Bold = false;
                contents.Cells[8].Format.Font.Size = 7;
                contents.Cells[8].Format.Alignment = ParagraphAlignment.Right;
                contents.Cells[8].VerticalAlignment = VerticalAlignment.Bottom;
            }

        }



    }
}
