using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Controls;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Dialogs;
using Stimulsoft.Report.Components;

namespace Reports
{
    
    public class TempProject : Stimulsoft.Report.StiReport
    {
        
        public TempProject()
        {
            this.InitializeComponent();
        }
        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Components.StiPage Страница1;
        public Stimulsoft.Report.Components.StiDataBand DataMain;
        public Stimulsoft.Report.Components.StiImage Картинка1;
        public Stimulsoft.Report.Components.StiText Текст2;
        public Stimulsoft.Report.Components.StiText Текст14;
        public Stimulsoft.Report.Components.StiText Текст17;
        public Stimulsoft.Report.Components.StiText Текст21;
        public Stimulsoft.Report.Components.StiText Текст22;
        public Stimulsoft.Report.Components.StiText Текст23;
        public Stimulsoft.Report.Components.StiText Текст24;
        public Stimulsoft.Report.Components.StiText Текст25;
        public Stimulsoft.Report.Components.StiWatermark Страница1_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings TempProject_PrinterSettings;
        public UserProjectDataSource UserProject;
        
        public void Текст2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Time, true);
        }
        
        public void Текст14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "time print project";
        }
        
        public void Текст17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "actor age";
        }
        
        public void Текст21__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Текст21.TextFormat.Format(CheckExcelValue(sender, UserProject.Age));
        }
        
        public void Текст22__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "actor height";
        }
        
        public void Текст23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Текст23.TextFormat.Format(CheckExcelValue(sender, UserProject.ActorHeght));
        }
        
        public void Текст24__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "actor number";
        }
        
        public void Текст25__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = this.Текст25.TextFormat.Format(CheckExcelValue(sender, UserProject.ActorId));
        }
        
        private void InitializeComponent()
        {
            this.UserProject = new UserProjectDataSource();
            this.NeedsCompiling = false;
            this.ReferencedAssemblies = new System.String[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "TempProject";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2015, 10, 20, 6, 54, 6, 692);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2008, 7, 4, 17, 26, 36, 0);
            this.ReportGuid = "fe8c4ebfd7a24d8ea0cb272bd7caf9b7";
            this.ReportName = "TempProject";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Страница1
            // 
            this.Страница1 = new Stimulsoft.Report.Components.StiPage();
            this.Страница1.Guid = "9ee3270176e643df89dca8cf1dcce9dc";
            this.Страница1.Name = "Страница1";
            this.Страница1.PageHeight = 29.7;
            this.Страница1.PageWidth = 21;
            this.Страница1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Страница1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // DataMain
            // 
            this.DataMain = new Stimulsoft.Report.Components.StiDataBand();
            this.DataMain.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 20, 12.6);
            this.DataMain.DataRelationName = "";
            this.DataMain.DataSourceName = "UserProject";
            this.DataMain.MaxHeight = 0;
            this.DataMain.MinHeight = 0;
            this.DataMain.Name = "DataMain";
            this.DataMain.Sort = new System.String[0];
            this.DataMain.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataMain.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Картинка1
            // 
            this.Картинка1 = new Stimulsoft.Report.Components.StiImage();
            this.Картинка1.CanGrow = true;
            this.Картинка1.CanShrink = true;
            this.Картинка1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.6, 2.45, 11, 10);
            this.Картинка1.DataColumn = "UserProject.PhotoLarge";
            this.Картинка1.MaxSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Картинка1.MinSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Картинка1.Name = "Картинка1";
            this.Картинка1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Картинка1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Картинка1.Guid = null;
            this.Картинка1.Image = null;
            // 
            // Текст2
            // 
            this.Текст2 = new Stimulsoft.Report.Components.StiText();
            this.Текст2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(15.4, 0.05, 4.4, 0.45);
            this.Текст2.Guid = "204a4ee8b422467b8c59690b7f3ce015";
            this.Текст2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Текст2.LinesOfUnderline = Stimulsoft.Base.Drawing.StiPenStyle.None;
            this.Текст2.MaxSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст2.MinSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст2.Name = "Текст2";
            this.Текст2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Текст2__GetValue);
            this.Текст2.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Текст2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Текст2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Текст2.Font = new System.Drawing.Font("Arial", 9F);
            this.Текст2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Текст2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Текст2.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Текст2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Текст14
            // 
            this.Текст14 = new Stimulsoft.Report.Components.StiText();
            this.Текст14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(11.8, 0, 3.4, 0.45);
            this.Текст14.Guid = "732a9f6b3bb641f28944e49d25331394";
            this.Текст14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Текст14.LinesOfUnderline = Stimulsoft.Base.Drawing.StiPenStyle.None;
            this.Текст14.MaxSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст14.MinSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст14.Name = "Текст14";
            this.Текст14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Текст14__GetValue);
            this.Текст14.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Текст14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Текст14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Текст14.Font = new System.Drawing.Font("Arial", 9F);
            this.Текст14.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Текст14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Текст14.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Текст14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Текст17
            // 
            this.Текст17 = new Stimulsoft.Report.Components.StiText();
            this.Текст17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.8, 1.2, 5.2, 0.6);
            this.Текст17.Guid = "025e781c992a43ad8dd641bc405f8e97";
            this.Текст17.LinesOfUnderline = Stimulsoft.Base.Drawing.StiPenStyle.None;
            this.Текст17.MaxSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст17.MinSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст17.Name = "Текст17";
            this.Текст17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Текст17__GetValue);
            this.Текст17.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Текст17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Текст17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Текст17.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.Текст17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Текст17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Gray);
            this.Текст17.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Текст17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Текст21
            // 
            this.Текст21 = new Stimulsoft.Report.Components.StiText();
            this.Текст21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(8.6, 1.2, 7.6, 0.6);
            this.Текст21.Guid = "ff864191247b4915bf54b982b059de4f";
            this.Текст21.LinesOfUnderline = Stimulsoft.Base.Drawing.StiPenStyle.None;
            this.Текст21.MaxSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст21.MinSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст21.Name = "Текст21";
            this.Текст21.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Текст21__GetValue);
            this.Текст21.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Текст21.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Текст21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Текст21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.Текст21.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Текст21.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Gray);
            this.Текст21.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("d", " ");
            this.Текст21.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Текст22
            // 
            this.Текст22 = new Stimulsoft.Report.Components.StiText();
            this.Текст22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.8, 1.8, 5.2, 0.6);
            this.Текст22.Guid = "c5070d95579b4f9c880989ec4554bf90";
            this.Текст22.LinesOfUnderline = Stimulsoft.Base.Drawing.StiPenStyle.None;
            this.Текст22.MaxSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст22.MinSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст22.Name = "Текст22";
            this.Текст22.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Текст22__GetValue);
            this.Текст22.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Текст22.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Текст22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Текст22.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.Текст22.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Текст22.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Gray);
            this.Текст22.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Текст22.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Текст23
            // 
            this.Текст23 = new Stimulsoft.Report.Components.StiText();
            this.Текст23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(8.6, 1.8, 7.6, 0.6);
            this.Текст23.Guid = "c7c9d672a91c4b0885d54a7156af0750";
            this.Текст23.LinesOfUnderline = Stimulsoft.Base.Drawing.StiPenStyle.None;
            this.Текст23.MaxSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст23.MinSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст23.Name = "Текст23";
            this.Текст23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Текст23__GetValue);
            this.Текст23.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Текст23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Текст23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Текст23.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.Текст23.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Текст23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Gray);
            this.Текст23.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("d", " ");
            this.Текст23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Текст24
            // 
            this.Текст24 = new Stimulsoft.Report.Components.StiText();
            this.Текст24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.8, 0.6, 5.2, 0.6);
            this.Текст24.Guid = "f8c86075f5964d0192495c1d653b357f";
            this.Текст24.LinesOfUnderline = Stimulsoft.Base.Drawing.StiPenStyle.None;
            this.Текст24.MaxSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст24.MinSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст24.Name = "Текст24";
            this.Текст24.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Текст24__GetValue);
            this.Текст24.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Текст24.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Текст24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Текст24.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.Текст24.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Текст24.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Gray);
            this.Текст24.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiGeneralFormatService();
            this.Текст24.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Текст25
            // 
            this.Текст25 = new Stimulsoft.Report.Components.StiText();
            this.Текст25.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(8.6, 0.6, 7.6, 0.6);
            this.Текст25.Guid = "4b3f2ac4fd564b429c1e4e18d179bc19";
            this.Текст25.LinesOfUnderline = Stimulsoft.Base.Drawing.StiPenStyle.None;
            this.Текст25.MaxSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст25.MinSize = new Stimulsoft.Base.Drawing.SizeD(0, 0);
            this.Текст25.Name = "Текст25";
            this.Текст25.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Текст25__GetValue);
            this.Текст25.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Текст25.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Текст25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Текст25.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.Текст25.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Текст25.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Gray);
            this.Текст25.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("d", " ");
            this.Текст25.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataMain.Guid = null;
            this.DataMain.MasterComponent = null;
            this.Страница1.ExcelSheetValue = null;
            this.Страница1.Margins = new Stimulsoft.Report.Components.StiMargins(0.5, 0.5, 1, 1);
            this.Страница1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Страница1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Страница1_Watermark.Image = null;
            this.Страница1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.TempProject_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.PrinterSettings = this.TempProject_PrinterSettings;
            this.Страница1.Page = this.Страница1;
            this.Страница1.Report = this;
            this.Страница1.Watermark = this.Страница1_Watermark;
            this.DataMain.Page = this.Страница1;
            this.DataMain.Parent = this.Страница1;
            this.Картинка1.Page = this.Страница1;
            this.Картинка1.Parent = this.DataMain;
            this.Текст2.Page = this.Страница1;
            this.Текст2.Parent = this.DataMain;
            this.Текст14.Page = this.Страница1;
            this.Текст14.Parent = this.DataMain;
            this.Текст17.Page = this.Страница1;
            this.Текст17.Parent = this.DataMain;
            this.Текст21.Page = this.Страница1;
            this.Текст21.Parent = this.DataMain;
            this.Текст22.Page = this.Страница1;
            this.Текст22.Parent = this.DataMain;
            this.Текст23.Page = this.Страница1;
            this.Текст23.Parent = this.DataMain;
            this.Текст24.Page = this.Страница1;
            this.Текст24.Parent = this.DataMain;
            this.Текст25.Page = this.Страница1;
            this.Текст25.Parent = this.DataMain;
            // 
            // Add to DataMain.Components
            // 
            this.DataMain.Components.Clear();
            this.DataMain.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Картинка1,
                        this.Текст2,
                        this.Текст14,
                        this.Текст17,
                        this.Текст21,
                        this.Текст22,
                        this.Текст23,
                        this.Текст24,
                        this.Текст25});
            // 
            // Add to Страница1.Components
            // 
            this.Страница1.Components.Clear();
            this.Страница1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.DataMain});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Страница1});
            this.UserProject.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PhotoId", "PhotoId", "PhotoId", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PhotoLarge", "PhotoLarge", "PhotoLarge", typeof(byte[])),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ActorId", "ActorId", "ActorId", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Age", "Age", "Age", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ActorHeght", "ActorHeght", "ActorHeght", typeof(int))});
            this.DataSources.Add(this.UserProject);
        }
        
        #region DataSource UserProject
        public class UserProjectDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public UserProjectDataSource() : 
                    base("UserProject", "UserProject")
            {
            }
            
            public virtual int PhotoId
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["PhotoId"], typeof(int), true)));
                }
            }
            
            public virtual byte[] PhotoLarge
            {
                get
                {
                    return ((byte[])(StiReport.ChangeType(this["PhotoLarge"], typeof(byte[]), true)));
                }
            }
            
            public virtual int ActorId
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ActorId"], typeof(int), true)));
                }
            }
            
            public virtual int Age
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["Age"], typeof(int), true)));
                }
            }
            
            public virtual int ActorHeght
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["ActorHeght"], typeof(int), true)));
                }
            }
        }
        #endregion DataSource UserProject
        #endregion StiReport Designer generated code - do not modify
    }
}