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

            textBoxName.Text =  Resume.Name;
            textBoxAdd.Text =  Resume.Address;
            textBoxEadd.Text =  Resume.EmailAddress;
            textBoxConNo.Text =  Resume.ContactNo;
            textBoxObj.Text =  Resume.Objective;
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
            

        }
    }
}
