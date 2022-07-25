using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void readjsonbtn_Click(object sender, EventArgs e)
        {
            var Json_Path = @"C:\Users\DELL LATITUDE\Desktop\PDF Generator\Agarin-Resume.json";
            string JsonFIle = File.ReadAllText(Json_Path);
            Json_Content j = JsonConvert.DeserializeObject<Json_Content>(JsonFIle);

            textBoxName.Text = j.Name;
            textBoxAdd.Text = j.Address;
            textBoxEadd.Text = j.EmailAddress;
            textBoxConNo.Text = j.ContactNo;
            textBoxTerEd.Text = j.TertiaryEducation + "\r\n" + j.SchoolAddress + "\r\n" + j.YearGraduated + "\r\n" + j.SecondaryEducation + "\r\n" + j.SchoolAddress1 + "\r\n" + j.YearGraduated1
            + "\r\n" + j.PrimaryEducation + "\r\n" + j.SchoolAddress3 + "\r\n" + j.YearGraduated3;
            textBoxach1.Text = j.Achievements + "\r\n" + j.Achievements1 + "\r\n" + j.Achievements2 + "\r\n" + j.Achievements4;
            textBoxsem1.Text = j.Seminars + "\r\n" + j.Seminars1;
            textBoxCRName.Text = j.CRName + "\r\n" + j.CRPosition + "\r\n" + j.CRSchool;
            textBoxCRName1.Text = j.CRName1 + "\r\n" + j.CRPosition1 + "\r\n" + j.CRSchool1;
            textBoxskill1.Text = j.Skill1 + "\r\n" + j.Skill2 + "\r\n" + j.Skill3;
            textBoxObj.Text = j.Objective;
        }

        private void textBoxObj_TextChanged(object sender, EventArgs e)
        {

        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            Document document = new Document(iTextSharp.text.PageSize.LEGAL, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"C:\Users\DELL LATITUDE\Desktop\PDF Generator\Agarin.pdf", FileMode.Create));
            document.Open();

        }
    }
}
