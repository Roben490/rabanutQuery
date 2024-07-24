using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.LinkLabel;

namespace rabanutQuery
{
    public partial class Form1 : Form
    {
        //יצירת משתנה שיהיה מכיל את הקלאס
        XmlDocument XmlDocument;
        //יצירת משתנה שיכיל את הנתיב שבו יושב הקובץ XML
        string patName = Directory.GetCurrentDirectory() + "\\ravQuery.xml";

        public Form1()
        {
            InitializeComponent();
            //יצירה של מופע חדש לקלאס של ה XML בתוך הבנאי 
            XmlDocument = new XmlDocument();
            //בדיקה האם קיים כבר קובץ במערכת
            if (File.Exists(patName))
            {
                try
                {
                    //טעינה של קובץ XML קיים
                    XmlDocument.Load(patName);
                }
                catch (Exception ex)
                {
                    //הודעה באם לא נטען הקובץ
                    MessageBox.Show("Error loading XML file: " + ex.Message);
                }
            }
            //אחרתת במידה ןלא קיים קובץ XML
            else
            {
                //יצירה של תגית חדשה בתוך המסמך העתידי
                XmlNode root = XmlDocument.CreateElement("Querys");
                //תוסיף את התגית לתוך ה(מסמך) המשתנה 
                XmlDocument.AppendChild(root);
                //שמירה של המסמך הזה שהיה באוויר עד עכשיו לתוך הנתיב שלא היה קיים
                XmlDocument.Save(patName);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //יצירת נוד ראשי שנקרא שאילתא
            XmlNode Query = XmlDocument.CreateElement("Query");
            //הכנסת הנתונים בתיבות לתוך המסמך
            Query.AppendChild(XmlDocument.CreateElement("Day")).InnerText = cmbDayOnWeek.Text;
            Query.AppendChild(XmlDocument.CreateElement("DayMounth")).InnerText = cmbDayOfMounth.Text;
            Query.AppendChild(XmlDocument.CreateElement("Mounth")).InnerText = cmbMounth.Text;
            Query.AppendChild(XmlDocument.CreateElement("Year")).InnerText = cmbYear.Text;

            //נזמין פונקציות המרה
            convertDays(cmbDayOnWeek.Text);
            convertDaysOfMount(cmbDayOfMounth.Text);
            convertYear(cmbYear.Text);


            //אמירה ש-שאילתה היא הנוד הראשי 
            XmlDocument.FirstChild.AppendChild(Query);
            //שמירה של המסמך בנתיב המדובר
            XmlDocument.Save(patName);
            //איפוס כל התיבות
        }

        private void convertDays(string day)
        {
            if (string.IsNullOrEmpty(day))
            {
                MessageBox.Show("תיבת היום בשבוע ריקה");
                return;
            }
            switch (day)
            {
                case "ראשון":
                    txtResault.Text += "באחד בשבת ";
                    break;
                case "שני":
                    txtResault.Text += "בשני בשבת ";
                    break;
                case "שלישי":
                    txtResault.Text += "שלישי בשבת ";
                    break;
                case "רביעי":
                    txtResault.Text += " ברביעי בשבת ";
                    break;
                case "חמישי":
                    txtResault.Text += " בחמישי בשבת ";
                    break;
                case "ששי":
                    txtResault.Text += " בששי בשבת ";
                    break;
                default:
                    MessageBox.Show("נא לבחור יום מהרשימה או לכתוב את היום במדוייק");
                    return;
            }
        }

        private void convertDaysOfMount(string DayOfMounth)
        {
            

            switch (DayOfMounth)
            {
                case "1":
                    txtResault.Text += "יום אחד ";
                    break;
                case "2":
                    txtResault.Text += "שני ימים ";
                    break;
                case "3":
                    txtResault.Text += "שלשה ימים  ";
                    break;
                case "4":
                    txtResault.Text += "ארבעה ימים ";
                    break;
                case "5":
                    txtResault.Text += "חמישה ימים ";
                    break;
                case "6":
                    txtResault.Text += "ששה ימים ";
                    break;
                case "7":
                    txtResault.Text += "שבעה ימים ";
                    break;
                case "8":
                    txtResault.Text += "שמונה ימים ";
                    break;
                case "9":
                    txtResault.Text += "תשעה ימים ";
                    break;
                case "10":
                    txtResault.Text += "עשרה ימים ";
                    break;
                case "11":
                    txtResault.Text += "אחד עשר יום ";
                    break;
                case "12":
                    txtResault.Text += "שנים עשר יום ";
                    break;
                case "13":
                    txtResault.Text += "שלשה עשר יום ";
                    break;
                case "14":
                    txtResault.Text += "ארבעה עשר יום ";
                    break;
                case "15":
                    txtResault.Text += "חמישה עשר יום ";
                    break;
                case "16":
                    txtResault.Text += "ששה עשר יום ";
                    break;
                case "17":
                    txtResault.Text += "שבעה עשר יום ";
                    break;
                case "18":
                    txtResault.Text += "שמנה עשר יום ";
                    break;
                case "19":
                    txtResault.Text += "תשעה עשר יום ";
                    break;
                case "20":
                    txtResault.Text += "עשרים יום ";
                    break;
                case "21":
                    txtResault.Text += "עשרים ואחד יום ";
                    break;
                case "22":
                    txtResault.Text += "עשרים ושנים יום ";
                    break;
                case "23":
                    txtResault.Text += "עשרים ושלשה יום ";
                    break;
                case "24":
                    txtResault.Text += "עשרים וארבעה יום ";
                    break;
                case "25":
                    txtResault.Text += "עשרים וחמישה יום ";
                    break;
                case "26":
                    txtResault.Text += "עשרים וששה יום ";
                    break;
                case "27":
                    txtResault.Text += "עשרים ושבעה יום ";
                    break;
                case "28":
                    txtResault.Text += "עשרים ושמנה יום ";
                    break;
                case "29":
                    txtResault.Text += "עשרים ותשעה יום ";
                    break;
                case "30":
                    txtResault.Text += "שלושים יום ";
                    break;
                default:
                    break;
            }
            txtResault.Text += "לירח " + cmbMounth.Text + " " + "שנת" + " " + "חמשת אלפים" + " ";
        }

        private void convertYear(string year)
        {
            string resOf_2NIT = "";
            string resOf_NIT = "";
            if (year.Length == 4)
            {
                switch (year[-1])
                {
                    case 'א':
                        resOf_NIT = "ואחד לבריאת העולם";
                        break;
                    case 'ב':
                        resOf_NIT = "ושנים לבריאת העולם";
                        break;
                    case 'ג':
                        resOf_NIT = "ושלשה לבריאת העולם";
                        break;
                    case 'ד':
                        resOf_NIT = "וארבעה לבריאת העולם";
                        break;
                    case 'ה':
                        resOf_NIT = "וחמישה לבריאת העולם";
                        break;
                    case 'ו':
                        resOf_NIT = "וששה לבריאת העולם";
                        break;
                    case 'ז':
                        resOf_NIT = "ושבעה לבריאת העולם";
                        break;
                    case 'ח':
                        resOf_NIT = "ושמנה לבריאת העולם";
                        break;
                    case 'ט':
                        resOf_NIT = "ותשעה לבריאת העולם";
                        break;
                    default :
                        break;


                }
            }
                

                txtResault.Text += resOf_2NIT + " " + resOf_NIT + " " + "לבריאת העולם";


        }





    }
}

