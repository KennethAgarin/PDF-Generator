using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.Json;
using System.IO;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Media;

namespace PDF_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Json_Content
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string EmailAddress { get; set; }
            public string ContactNo { get; set; }
            public string TertiaryEducation { get; set; }
            public string SchoolAddress { get; set; }
            public string YearGraduated { get; set; }
            public string SecondaryEducation { get; set; }
            public string SchoolAddress1 { get; set; }
            public string YearGraduated1 { get; set; }
            public string PrimaryEducation { get; set; }
            public string SchoolAddress3 { get; set; }
            public string YearGraduated3 { get; set; }
            public string Achievements { get; set; }
            public string Achievements1 { get; set; }
            public string Achievements2 { get; set; }
            public string Achievements4 { get; set; }
            public string Seminars { get; set; }
            public string Seminars1 { get; set; }
            public string CRName { get; set; }
            public string CRPosition { get; set; }
            public string CRSchool { get; set; }
            public string CRName1 { get; set; }
            public string CRPosition1 { get; set; }
            public string CRSchool1 { get; set; }
            public string Skill1 { get; set; }
            public string Skill2 { get; set; }
            public string Skill3 { get; set; }
            public string Objective { get; set; }
            public string Objective1 { get; set; }
            public string Objective2 { get; set; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void readjsonbtn_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\DELL LATITUDE\Desktop\PDF Generator\Agarin-Resume.json";
            string jsonInfo = File.ReadAllText(filename);
            Json_Content Resume = JsonSerializer.Deserialize<Json_Content>(jsonInfo);

            string Name = Resume.Name;
            string Address = Resume.Address;
            string EmailAdress = Resume.EmailAddress;
            string ContactNo = Resume.ContactNo;
            string TertiaryEducation = Resume.TertiaryEducation;
            string SchoolAdress = Resume.SchoolAddress;
            string YearGraduated = Resume.YearGraduated;
            string SecondaryEducation = Resume.SecondaryEducation;
            string SchoolAddress1 = Resume.SchoolAddress1;
            string YearGraduated1 = Resume.YearGraduated1;
            string PrimaryEducation = Resume.PrimaryEducation;
            string SchoolAddress3 = Resume.SchoolAddress3;
            string YearGraduated3 = Resume.YearGraduated3;
            string Achievements = Resume.Achievements;
            string Achievements1 = Resume.Achievements1;
            string Achievements2 = Resume.Achievements2;
            string Achievements4 = Resume.Achievements4;
            string Seminars = Resume.Seminars;
            string Seminars1 = Resume.Seminars1;
            string CRName = Resume.CRName;
            string CRPosition = Resume.CRPosition;
            string CRSchool = Resume.CRSchool;
            string CRName1 = Resume.CRName1;
            string CRPosition1 = Resume.CRPosition1;
            string CRSchool1 = Resume.CRSchool1;
            string Skills = Resume.Skill1;
            string Skills1 = Resume.Skill2;
            string Skills2 = Resume.Skill3;
            string Objectives = Resume.Objective;
            string Objectives1 = Resume.Objective1;
            string Objectives2 = Resume.Objective2;


            textBoxName.Text =  Resume.Name;
            textBoxAdd.Text =  Resume.Address;
            textBoxEadd.Text =  Resume.EmailAddress;
            textBoxConNo.Text =  Resume.ContactNo;
            textBoxObj.Text =  Resume.Objective + " " + Resume.Objective1 + " " + Resume.Objective2;
            textBoxTerEd.Text =  Resume.TertiaryEducation + "  " + Resume.SchoolAddress + "                                       " + Resume.YearGraduated;
            textBoxseced.Text =  Resume.SecondaryEducation + "  " + Resume.SchoolAddress1 + "       " + Resume.YearGraduated1;
            textBoxprimed.Text =  Resume.PrimaryEducation + "  " + Resume.SchoolAddress3 + "                            " + Resume.YearGraduated3;
            textBoxach1.Text =  Resume.Achievements + "  " + Resume.Achievements1 + "  " + Resume.Achievements2 + "                   " + Resume.Achievements4;
            textBoxsem1.Text =  Resume.Seminars + "                         " + Resume.Seminars1;
            textBoxskill1.Text =  Resume.Skill1 + "               " + Resume.Skill2 + "     " + Resume.Skill3;
            textBoxCRName.Text =  Resume.CRName + "                                                   " + Resume.CRPosition + "                        " + Resume.CRSchool;
            textBoxCRName1.Text = Resume.CRName1 + "                                                   " + Resume.CRPosition1 + "  " + Resume.CRSchool1;





        }

        private void textBoxObj_TextChanged(object sender, EventArgs e)
        {

        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\DELL LATITUDE\Desktop\PDF Generator\Agarin-Resume.json";
            string jsonInfo = File.ReadAllText(filename);
            Json_Content Resume = JsonSerializer.Deserialize<Json_Content>(jsonInfo);

            string Name = Resume.Name;
            string Address = Resume.Address;
            string EmailAdress = Resume.EmailAddress;
            string ContactNo = Resume.ContactNo;
            string TertiaryEducation = Resume.TertiaryEducation;
            string SchoolAdress = Resume.SchoolAddress;
            string YearGraduated = Resume.YearGraduated;
            string SecondaryEducation = Resume.SecondaryEducation;
            string SchoolAddress1 = Resume.SchoolAddress1;
            string YearGraduated1 = Resume.YearGraduated1;
            string PrimaryEducation = Resume.PrimaryEducation;
            string SchoolAddress3 = Resume.SchoolAddress3;
            string YearGraduated3 = Resume.YearGraduated3;
            string Achievements = Resume.Achievements;
            string Achievements1 = Resume.Achievements1;
            string Achievements2 = Resume.Achievements2;
            string Achievements4 = Resume.Achievements4;
            string Seminars = Resume.Seminars;
            string Seminars1 = Resume.Seminars1;
            string CRName = Resume.CRName;
            string CRPosition = Resume.CRPosition;
            string CRSchool = Resume.CRSchool;
            string CRName1 = Resume.CRName1;
            string CRPosition1 = Resume.CRPosition1;
            string CRSchool1 = Resume.CRSchool1;
            string Skills = Resume.Skill1;
            string Skills1 = Resume.Skill2;
            string Skills2 = Resume.Skill3;
            string Objectives = Resume.Objective;
            string Objectives1 = Resume.Objective1;
            string Objectives2 = Resume.Objective2; 

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.InitialDirectory = @"C:\Users\DELL LATITUDE\Desktop\PDF Generator";
                dlg.FileName = Name + ".pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    PdfPage page = pdf.AddPage();

                    XGraphics graph = XGraphics.FromPdfPage(page);

                    XFont bigfont = new XFont("Times New Roman", 18, XFontStyle.Regular);
                    XFont smallfont = new XFont("Times New Romant", 12, XFontStyle.Regular);
                    XFont titlefont = new XFont("Times New Roman", 45, XFontStyle.Bold);

                    XPen Line = new XPen(XColors.Black, 2);
                    XPen NewLine = new XPen(XColors.Black, 3);

                    XPen pen = new XPen(XColors.White, 20);

                    graph.DrawRoundedRectangle(XBrushes.White, 0, 0, page.Width.Point, page.Height.Point, 0, 0);

                    graph.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);

                    int marginleft = 25;
                    int initialleft = 200;
                    int marginright = 430;
                    int initialmiddle = 200;

                    string png = @"C:\Users\DELL LATITUDE\Desktop\PDF Generator\1658768368476.jpg";
                    XImage image = XImage.FromFile(png);
                    graph.DrawImage(image, marginright +16, 45, 100, 100);

                    graph.DrawString(Name, bigfont, XBrushes.Black, new XRect(marginleft + 20, initialleft - 130, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Address, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft - 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(EmailAdress, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft - 95, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(ContactNo, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft - 80, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawRectangle(NewLine, marginleft + 20, initialleft - 45, 500, .5);

                    initialmiddle = initialmiddle + 200;
                    graph.DrawString("OBJECTIVE:", bigfont, XBrushes.Black, new XRect(marginleft + 20, initialleft - 40, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Objectives, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft - 20, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Objectives1, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft - 10, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Objectives2, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft - 0, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawRectangle(NewLine, marginleft + 20, initialleft + 20, 500, .5);

                    initialmiddle = initialmiddle + 140;
                    graph.DrawString("EDUCATIONAL BACKGROUND", bigfont, XBrushes.Black, new XRect(marginleft + 20, initialleft +30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawRectangle(NewLine, marginleft + 20, initialleft +190, 500, .5);
                    graph.DrawString("Tertiary Education:", smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 55, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(TertiaryEducation, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 70, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SchoolAdress, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 80, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(YearGraduated, smallfont, XBrushes.Black, new XRect(marginright + 20, initialleft + 70, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("Secondary Education:", smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SecondaryEducation, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 115, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SchoolAddress1, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 125, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(YearGraduated1, smallfont, XBrushes.Black, new XRect(marginright + 20, initialleft + 115, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("Primary Education:", smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 145, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(PrimaryEducation, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 160, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SchoolAddress3, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 170, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(YearGraduated3, smallfont, XBrushes.Black, new XRect(marginright + 20, initialleft + 160, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("SELECTED ACHIEVEMENTS:", bigfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 195, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Achievements, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 215, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Achievements1, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 230, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Achievements2, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 245, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Achievements4, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 260, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("SEMINARS AND TRAINING ATTENDED:", bigfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 285, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Seminars, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 310, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Seminars1, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 320, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawRectangle(NewLine, marginleft + 20, initialleft + 275, 500, .5);

                    
                    graph.DrawString("SKILLS:", bigfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 350, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Skills, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 365, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Skills1, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 375, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Skills2, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 385, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawRectangle(NewLine, marginleft + 20, initialleft + 340, 500, .5);
                    graph.DrawRectangle(NewLine, marginleft + 20, initialleft + 400, 500, .5);

                    graph.DrawRectangle(NewLine, marginleft + 20, initialleft + 565, 500, .5);
                    graph.DrawString("CHARACTER PREFERENCE:", bigfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 410, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("High School:", smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 430, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CRName, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 450, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CRPosition, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 460, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CRSchool, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 470, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("College:", smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 500, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CRName1, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 515, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CRPosition1, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 525, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CRSchool1, smallfont, XBrushes.Black, new XRect(marginleft + 20, initialleft + 535, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);





                    pdf.Save(dlg.FileName);
                    MessageBox.Show("You can know see your Generated Resume!");
                    Application.Exit();


                }
            }
        }
    }
}
