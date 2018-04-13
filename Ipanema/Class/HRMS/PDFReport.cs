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

        ///////////////////////////
        //LATE & ABSENCES REPORT///
        ///////////////////////////
        public List<string> empNum;
        public List<string> empName;
        public List<string> totalabs;
        public List<string> totallate_hr;
        public List<string> totallate_min;
        public List<string> totalut_hr;
        public List<string> totalut_min;
        public List<string> rendered_dt;

        ////////////////////////
        //OVERTIME PAY REPORT///
        ////////////////////////
        List<string> num;
        List<string> empLname;
        List<string> empFname;

        //REGULAR OVERTIME VARIABLES
        List<string> reg_ot_1st_8hrs;
        List<string> reg_ot_aft_8hrs;
        List<string> reg_ot_other_ot;
        List<string> reg_ot_ND;

        // REGULAR REST DAY VARIABLES
        List<string> reg_rest_1st_8hrs;
        List<string> reg_rest_aft_8hrs;
        List<string> reg_rest_1st_8hrs_ND;
        List<string> reg_rest_aft_8hrs_2;
        List<string> reg_rest_aft_8hrs_ND;

        // SPECIAL NON-WORKING HOLIDAY
        List<string> spech_1st_8hrs;
        List<string> spech_aft_8hrs;
        List<string> spech_aft_8hrs_ND;

        // REGULAR HOLIDAY
        List<string> regh_1st_8hrs;
        List<string> regh_aft_8hrs;
        List<string> regh_aft_8hrs_ND;

        public Document Overtime_summary(DateTime  _dtFrm, DateTime _dtTo, List<string> emp_num, List<string> fname, List<string> lname, List<string> regOT_1st_8hrs, List<string> regOT_aft_8hrs, List<string> regOT_other, List<string> regOT_ND, List<string> regRD_1st_8hrs, List<string> regRD_aft_8hrs, List<string> regRD_1st_8hrsND, List<string> regRD_aft_8hrs_2, List<string> regRD_aft_8hrsND, List<string>specH_1st_8hrs, List<string>specH_aft_8hrs, List<string>specH_aft_8hrsND, List<string>regH_1st_8hrs, List<string>regH_aft_8hrs, List<string>regH_aft_8hrsND)
        {
            dtFrom = _dtFrm;
            dtTo = _dtTo;
            num = emp_num;
            empLname = lname;
            empFname = fname;

            //REGULAR OVERTIME VARIABLES
            reg_ot_1st_8hrs = regOT_1st_8hrs;
            reg_ot_aft_8hrs = regOT_aft_8hrs;
            reg_ot_other_ot = regOT_other;
            reg_ot_ND = regOT_ND;

            // REGULAR REST DAY VARIABLES
            reg_rest_1st_8hrs = regRD_1st_8hrs;
            reg_rest_aft_8hrs = regRD_aft_8hrs;
            reg_rest_1st_8hrs_ND = regRD_1st_8hrsND;
            reg_rest_aft_8hrs_2 = regRD_aft_8hrs_2;
            reg_rest_aft_8hrs_ND = regRD_aft_8hrsND;

            // SPECIAL NON-WORKING HOLIDAY
            spech_1st_8hrs = specH_1st_8hrs;
            spech_aft_8hrs = specH_aft_8hrs;
            spech_aft_8hrs_ND = specH_aft_8hrsND;

            // REGULAR HOLIDAY
            regh_1st_8hrs = regH_1st_8hrs;
            regh_aft_8hrs = regH_aft_8hrs;
            regh_aft_8hrs_ND = regH_aft_8hrsND;


            this.document = new Document();
            document.DefaultPageSetup.Orientation = Orientation.Landscape;
            document.DefaultPageSetup.PageFormat = PageFormat.A4;
            document.DefaultPageSetup.TopMargin = 20;
            document.DefaultPageSetup.LeftMargin = 25;
            document.DefaultPageSetup.RightMargin = 30;
            document.DefaultPageSetup.BottomMargin = 20;
            this.document.Info.Title = "HRMS Report";
            this.document.Info.Subject = "HR reports";
            this.document.Info.Author = "HR";
            DefineStyle();
            PageHeader();
            PageSender();
            overtime_pays();
            return document;
        }


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
            document.DefaultPageSetup.Orientation = Orientation.Portrait;
            document.DefaultPageSetup.TopMargin = 20;
            document.DefaultPageSetup.LeftMargin = 40;
            document.DefaultPageSetup.RightMargin = 40;            
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
            paragraph.Format.SpaceBefore = "3.0cm";
            paragraph.Style = "Reference";
            paragraph.AddFormattedText("Date:", TextFormat.Bold);
            paragraph.AddText(DateTime.Now.ToString(" MMM dd, yyyy"));
            paragraph.Format.Alignment = ParagraphAlignment.Right;

            paragraph = section.AddParagraph();
            paragraph.AddFormattedText("Prepared by:",TextFormat.Bold);
            paragraph.Format.SpaceAfter = "0.2cm";
            paragraph = section.AddParagraph();
            paragraph.AddFormattedText(clsUsers.getLoginDetails(HRMSCore.Username));
            paragraph = section.AddParagraph();
            paragraph.AddFormattedText("Philippines First Insurance Co., Inc.", TextFormat.Bold);
            paragraph = section.AddParagraph();
            paragraph.AddFormattedText("7F STI Holdings Center");
            paragraph = section.AddParagraph();
            paragraph.AddFormattedText("6764 Ayala Avenue, 1226 Makati City, Philippines");
            paragraph = section.AddParagraph();
            paragraph.AddFormattedText("HR OFFICE", TextFormat.Bold);
            paragraph.Format.SpaceAfter = "0.5cm";

        }
        void PageFooter()
        {           
            paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddFormattedText("");
            paragraph.Format.Alignment = ParagraphAlignment.Center;
        }

        void tableHeader()
        {
            paragraph = section.AddParagraph();                  
            paragraph.AddFormattedText("LATE AND ABSENCES SUMMARY REPORT", TextFormat.Bold);
            paragraph = section.AddParagraph();
            paragraph.Format.SpaceAfter = "0cm";
            paragraph.AddFormattedText("Payroll Period: ", TextFormat.Bold);
            paragraph.AddFormattedText(dtFrom.ToString(" MMM dd yyyy "));
            paragraph.AddFormattedText(" - ", TextFormat.Bold);
            paragraph.AddFormattedText(dtTo.ToString(" MMM dd yyyy"));
            
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
            row2.Cells[0].AddParagraph("");
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
                if (empName[i] == clsCluster.getClusterName(empName[i]))
                {
                    contents.Cells[0].AddParagraph(empNum[i]);
                    contents.Cells[0].Format.Font.Bold = true;
                    contents.Cells[0].Format.Font.Size = 7;
                    contents.Cells[0].Format.Font.Color = Colors.White;
                    contents.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    contents.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                    contents.Cells[0].Shading.Color = Colors.DarkBlue;
                }
                else {
                    contents.Cells[0].AddParagraph(empNum[i]);
                    contents.Cells[0].Format.Font.Bold = false;
                    contents.Cells[0].Format.Font.Size = 7;
                    contents.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    contents.Cells[0].VerticalAlignment = VerticalAlignment.Center;

                }

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
                contents.Cells[7].Format.Alignment = ParagraphAlignment.Center;
                contents.Cells[7].VerticalAlignment = VerticalAlignment.Bottom;

                contents.Cells[8].AddParagraph("");
                contents.Cells[8].Format.Font.Bold = false;
                contents.Cells[8].Format.Font.Size = 7;
                contents.Cells[8].Format.Alignment = ParagraphAlignment.Center;
                contents.Cells[8].VerticalAlignment = VerticalAlignment.Bottom;
            }

        }

        public void overtime_pays()
        {          
            paragraph = section.AddParagraph();
            paragraph.AddFormattedText("OVERTIME PAYS", TextFormat.Bold);
            paragraph = section.AddParagraph();
            paragraph.Format.SpaceAfter = "0cm";
            paragraph.AddFormattedText("Payroll Period: ", TextFormat.Bold);
            paragraph.AddFormattedText(dtFrom.ToString(" MMM dd yyyy "));
            paragraph.AddFormattedText(" - ", TextFormat.Bold);
            paragraph.AddFormattedText(dtTo.ToString(" MMM dd yyyy"));
            paragraph.Format.SpaceAfter = "0.2cm";

            Table table = section.AddTable();
            table.Style = "Tables";
            table.Borders.Width = "0.25";
            table.Borders.Left.Width = 0.5;
            table.Borders.Right.Width = 0.5;
            table.Rows.LeftIndent = 0;

            // EMPLOYEE NO.
            Column column = table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Center;
            column.Shading.Color = Colors.DarkBlue;
            column.Format.Font.Color = Colors.White;

            // EMPLOYEE NAME
            column = table.AddColumn("8cm");
            column.Format.Alignment = ParagraphAlignment.Center;
            column.Shading.Color = Colors.DarkBlue;
            column.Format.Font.Color = Colors.White;

            // REGULAR OVERTIME
            column = table.AddColumn("4cm");
            column.Format.Alignment = ParagraphAlignment.Center;
            column.Shading.Color = Colors.DarkBlue;
            column.Format.Font.Color = Colors.White;

            //REGULAR REST DAY
            column = table.AddColumn("5cm");
            column.Format.Alignment = ParagraphAlignment.Center;
            column.Shading.Color = Colors.DarkBlue;
            column.Format.Font.Color = Colors.White;

            //SPECIAL NON-WORKING HOLIDAY
            column = table.AddColumn("3cm");
            column.Format.Alignment = ParagraphAlignment.Center;
            column.Shading.Color = Colors.DarkBlue;
            column.Format.Font.Color = Colors.White;

            //REGULAR HOLIDAY
            column = table.AddColumn("3cm");
            column.Format.Alignment = ParagraphAlignment.Center;
            column.Shading.Color = Colors.DarkBlue;
            column.Format.Font.Color = Colors.White;

            //REMARKS
            column = table.AddColumn("2.5cm");
            column.Format.Alignment = ParagraphAlignment.Center;
            column.Shading.Color = Colors.DarkBlue;
            column.Format.Font.Color = Colors.White;

            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;

            row.Cells[0].AddParagraph("");
            row.Cells[0].Format.Font.Bold = true;
            row.Cells[0].Format.Font.Size = 8;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;

            row.Cells[1].AddParagraph("Employee Name");
            row.Cells[1].Format.Font.Bold = true;
            row.Cells[1].Format.Font.Size = 8;
            row.Cells[1].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[1].VerticalAlignment = VerticalAlignment.Center;

            row.Cells[2].AddParagraph("Regular Overtime");
            row.Cells[2].Format.Font.Bold = true;
            row.Cells[2].Format.Font.Size = 8;
            row.Cells[2].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[2].VerticalAlignment = VerticalAlignment.Center;

            row.Cells[3].AddParagraph("Regular Rest Day");
            row.Cells[3].Format.Font.Bold = true;
            row.Cells[3].Format.Font.Size = 8;
            row.Cells[3].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[3].VerticalAlignment = VerticalAlignment.Center;

            row.Cells[4].AddParagraph("SPECIAL NON-WORKING HOLIDAY");
            row.Cells[4].Format.Font.Bold = true;
            row.Cells[4].Format.Font.Size = 8;
            row.Cells[4].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[4].VerticalAlignment = VerticalAlignment.Center;

            row.Cells[5].AddParagraph("REGULAR HOLIDAY");
            row.Cells[5].Format.Font.Bold = true;
            row.Cells[5].Format.Font.Size = 8;
            row.Cells[5].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[5].VerticalAlignment = VerticalAlignment.Center;

            row.Cells[6].AddParagraph("REMARKS");
            row.Cells[6].Format.Font.Bold = true;
            row.Cells[6].Format.Font.Size = 8;
            row.Cells[6].Format.Alignment = ParagraphAlignment.Center;
            row.Cells[6].VerticalAlignment = VerticalAlignment.Center;

            Table table2 = section.AddTable();
            table2.Style = "Tables";
            table2.Borders.Width = "0.25";
            table2.Borders.Left.Width = 0.5;
            table2.Borders.Right.Width = 0.5;
            table2.Rows.LeftIndent = 0;

            //EMPLOYEE NO COLUMN
            Column column1 = table2.AddColumn("2cm");
            column1.Shading.Color = Colors.LightSteelBlue;
            column1.Format.Alignment = ParagraphAlignment.Center;

            //LAST NAME COLUMN
            column1 = table2.AddColumn("4cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            //FIRST NAME COLUMN
            column1 = table2.AddColumn("4cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            //REGULAR OVERTIME COLUMNS
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            //REGULAR REST DAY COLUMNS
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            //SPECIAL NON-WORKING HOLIDAY COLUMNS
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            //REGULAR HOLIDAY COLUMNS
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;
            column1 = table2.AddColumn("1cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            //REMARKS COLUMN
            column1 = table2.AddColumn("2.5cm");
            column1.Format.Alignment = ParagraphAlignment.Center;

            Row row2 = table2.AddRow();
            //EMPLOYEE NO COLUMN NAME
            row2.Cells[0].AddParagraph("");
            row2.Cells[0].Format.Font.Bold = true;
            row2.Cells[0].Format.Font.Size = 7;
            row2.Cells[0].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[0].VerticalAlignment = VerticalAlignment.Center;

            //EMPLOYEE LAST NAME COLUMN NAME
            row2.Cells[1].AddParagraph("Last Name");
            row2.Cells[1].Format.Font.Bold = true;
            row2.Cells[1].Format.Font.Size = 7;
            row2.Cells[1].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[1].VerticalAlignment = VerticalAlignment.Center;
            //EMPLOYEE FIRST NAME COLUMN NAME
            row2.Cells[2].AddParagraph("First Name");
            row2.Cells[2].Format.Font.Bold = true;
            row2.Cells[2].Format.Font.Size = 7;
            row2.Cells[2].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[2].VerticalAlignment = VerticalAlignment.Center;
            
            /////////////REGULAR OVERTIME COLUMNS/////////
            //1st 8 hrs
            row2.Cells[3].AddParagraph("1st 8 hrs");
            row2.Cells[3].Format.Font.Bold = true;
            row2.Cells[3].Format.Font.Size = 7;
            row2.Cells[3].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[3].VerticalAlignment = VerticalAlignment.Center;
            //after 8 hrs
            row2.Cells[4].AddParagraph("after 8 hrs");
            row2.Cells[4].Format.Font.Bold = true;
            row2.Cells[4].Format.Font.Size = 7;
            row2.Cells[4].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[4].VerticalAlignment = VerticalAlignment.Center;
            //OTHER OT
            row2.Cells[5].AddParagraph("OTHER OT");
            row2.Cells[5].Format.Font.Bold = true;
            row2.Cells[5].Format.Font.Size = 7;
            row2.Cells[5].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[5].VerticalAlignment = VerticalAlignment.Center;
            // W/ NIGHT DIFF.
            row2.Cells[6].AddParagraph("w/ Night Diff.");
            row2.Cells[6].Format.Font.Bold = true;
            row2.Cells[6].Format.Font.Size = 7;
            row2.Cells[6].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[6].VerticalAlignment = VerticalAlignment.Center;

            /////////REGULAR REST DAY COLUMNS////////
            //1st 8 hrs
            row2.Cells[7].AddParagraph("1st 8 hrs");
            row2.Cells[7].Format.Font.Bold = true;
            row2.Cells[7].Format.Font.Size = 7;
            row2.Cells[7].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[7].VerticalAlignment = VerticalAlignment.Center;
            //after 8 hrs
            row2.Cells[8].AddParagraph("after 8 hrs");
            row2.Cells[8].Format.Font.Bold = true;
            row2.Cells[8].Format.Font.Size = 7;
            row2.Cells[8].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[8].VerticalAlignment = VerticalAlignment.Center;
            //1st 8 hrs w/ ND
            row2.Cells[9].AddParagraph("1st 8 hrs w/ ND");
            row2.Cells[9].Format.Font.Bold = true;
            row2.Cells[9].Format.Font.Size = 7;
            row2.Cells[9].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[9].VerticalAlignment = VerticalAlignment.Center;
            //after 8 hrs
            row2.Cells[10].AddParagraph("after 8 hrs");
            row2.Cells[10].Format.Font.Bold = true;
            row2.Cells[10].Format.Font.Size = 7;
            row2.Cells[10].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[10].VerticalAlignment = VerticalAlignment.Center;
            //after 8 hrs w/ ND
            row2.Cells[11].AddParagraph("after 8 hrs w/ ND");
            row2.Cells[11].Format.Font.Bold = true;
            row2.Cells[11].Format.Font.Size = 7;
            row2.Cells[11].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[11].VerticalAlignment = VerticalAlignment.Center;

            /////////SPECIAL NON-WORKING HOLIDAY////////
            //1st 8 hrs
            row2.Cells[12].AddParagraph("1st 8 hrs");
            row2.Cells[12].Format.Font.Bold = true;
            row2.Cells[12].Format.Font.Size = 7;
            row2.Cells[12].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[12].VerticalAlignment = VerticalAlignment.Center;
            // after 8 hrs
            row2.Cells[13].AddParagraph("after 8 hrs");
            row2.Cells[13].Format.Font.Bold = true;
            row2.Cells[13].Format.Font.Size = 7;
            row2.Cells[13].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[13].VerticalAlignment = VerticalAlignment.Center;
            //after 8 hrs w/ ND
            row2.Cells[14].AddParagraph("after 8 hrs w/ ND");
            row2.Cells[14].Format.Font.Bold = true;
            row2.Cells[14].Format.Font.Size = 7;
            row2.Cells[14].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[14].VerticalAlignment = VerticalAlignment.Center;

            /////////REGULAR HOLIDAY////////
            //1st 8 hrs
            row2.Cells[15].AddParagraph("1st 8 hrs");
            row2.Cells[15].Format.Font.Bold = true;
            row2.Cells[15].Format.Font.Size = 7;
            row2.Cells[15].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[15].VerticalAlignment = VerticalAlignment.Center;
            // after 8 hrs
            row2.Cells[16].AddParagraph("after 8 hrs");
            row2.Cells[16].Format.Font.Bold = true;
            row2.Cells[16].Format.Font.Size = 7;
            row2.Cells[16].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[16].VerticalAlignment = VerticalAlignment.Center;
            //after 8 hrs w/ ND
            row2.Cells[17].AddParagraph("after 8 hrs w/ ND");
            row2.Cells[17].Format.Font.Bold = true;
            row2.Cells[17].Format.Font.Size = 7;
            row2.Cells[17].Format.Alignment = ParagraphAlignment.Center;
            row2.Cells[17].VerticalAlignment = VerticalAlignment.Center;

            Row contents;
            for (int x = 0; x<num.Count(); x++)
            {
                contents = table2.AddRow();
                if (num[x] == clsCluster.getClusterName(num[x]))
                {
                    contents.Cells[0].AddParagraph(num[x]);
                    contents.Cells[0].Format.Font.Bold = true;
                    contents.Cells[0].Format.Font.Size = 7;
                    contents.Cells[0].Format.Font.Color = Colors.Black;
                    contents.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    contents.Cells[0].VerticalAlignment = VerticalAlignment.Center;
                    contents.Cells[0].Shading.Color = Colors.Aqua;
                }
                else
                {
                    contents.Cells[0].AddParagraph(num[x]);
                    contents.Cells[0].Format.Font.Bold = false;
                    contents.Cells[0].Format.Font.Size = 7;
                    contents.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                    contents.Cells[0].VerticalAlignment = VerticalAlignment.Center;

                }
                contents.Cells[1].AddParagraph(empLname[x]);
                contents.Cells[1].Format.Font.Bold = false;
                contents.Cells[1].Format.Font.Size = 7;
                contents.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[1].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[2].AddParagraph(empFname[x]);
                contents.Cells[2].Format.Font.Bold = false;
                contents.Cells[2].Format.Font.Size = 7;
                contents.Cells[2].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[2].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[3].AddParagraph(reg_ot_1st_8hrs[x]);
                contents.Cells[3].Format.Font.Bold = false;
                contents.Cells[3].Format.Font.Size = 7;
                contents.Cells[3].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[3].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[4].AddParagraph(reg_ot_aft_8hrs[x]);
                contents.Cells[4].Format.Font.Bold = false;
                contents.Cells[4].Format.Font.Size = 7;
                contents.Cells[4].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[4].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[5].AddParagraph(reg_ot_other_ot[x]);
                contents.Cells[5].Format.Font.Bold = false;
                contents.Cells[5].Format.Font.Size = 7;
                contents.Cells[5].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[5].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[6].AddParagraph(reg_ot_ND[x]);
                contents.Cells[6].Format.Font.Bold = false;
                contents.Cells[6].Format.Font.Size = 7;
                contents.Cells[6].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[6].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[7].AddParagraph(reg_rest_1st_8hrs[x]);
                contents.Cells[7].Format.Font.Bold = false;
                contents.Cells[7].Format.Font.Size = 7;
                contents.Cells[7].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[7].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[8].AddParagraph(reg_rest_aft_8hrs[x]);
                contents.Cells[8].Format.Font.Bold = false;
                contents.Cells[8].Format.Font.Size = 7;
                contents.Cells[8].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[8].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[9].AddParagraph(reg_rest_1st_8hrs_ND[x]);
                contents.Cells[9].Format.Font.Bold = false;
                contents.Cells[9].Format.Font.Size = 7;
                contents.Cells[9].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[9].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[10].AddParagraph(reg_rest_aft_8hrs_2[x]);
                contents.Cells[10].Format.Font.Bold = false;
                contents.Cells[10].Format.Font.Size = 7;
                contents.Cells[10].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[10].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[11].AddParagraph(reg_rest_aft_8hrs_ND[x]);
                contents.Cells[11].Format.Font.Bold = false;
                contents.Cells[11].Format.Font.Size = 7;
                contents.Cells[11].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[11].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[12].AddParagraph(spech_1st_8hrs[x]);
                contents.Cells[12].Format.Font.Bold = false;
                contents.Cells[12].Format.Font.Size = 7;
                contents.Cells[12].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[12].VerticalAlignment = VerticalAlignment.Center;


                contents.Cells[13].AddParagraph(spech_aft_8hrs[x]);
                contents.Cells[13].Format.Font.Bold = false;
                contents.Cells[13].Format.Font.Size = 7;
                contents.Cells[13].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[13].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[14].AddParagraph(spech_aft_8hrs_ND[x]);
                contents.Cells[14].Format.Font.Bold = false;
                contents.Cells[14].Format.Font.Size = 7;
                contents.Cells[14].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[14].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[15].AddParagraph(regh_1st_8hrs[x]);
                contents.Cells[15].Format.Font.Bold = false;
                contents.Cells[15].Format.Font.Size = 7;
                contents.Cells[15].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[15].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[16].AddParagraph(regh_aft_8hrs[x]);
                contents.Cells[16].Format.Font.Bold = false;
                contents.Cells[16].Format.Font.Size = 7;
                contents.Cells[16].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[16].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[17].AddParagraph(regh_aft_8hrs_ND[x]);
                contents.Cells[17].Format.Font.Bold = false;
                contents.Cells[17].Format.Font.Size = 7;
                contents.Cells[17].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[17].VerticalAlignment = VerticalAlignment.Center;

                contents.Cells[18].AddParagraph("");
                contents.Cells[18].Format.Font.Bold = false;
                contents.Cells[18].Format.Font.Size = 7;
                contents.Cells[18].Format.Alignment = ParagraphAlignment.Left;
                contents.Cells[18].VerticalAlignment = VerticalAlignment.Center;
            }
        }


    }
}
