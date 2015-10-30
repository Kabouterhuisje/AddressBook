using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> people = new List<Person>();

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\Address Book - Kabouterhuisje"))
            Directory.CreateDirectory(path + "\\Address Book - Kabouterhuisje");
            if (!File.Exists(path + "\\Address Book - Kabouterhuisje\\settings.xml"))
            {
                //File.Create(path + "\\Address Book - Kabouterhuisje\\settings.xml");
                XmlTextWriter xw = new XmlTextWriter(path + "\\Address Book - Kabouterhuisje\\settings.xml", Encoding.UTF8);
                xw.WriteStartElement("people");
                xw.WriteEndElement();
                xw.Close();
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "\\Address Book - Kabouterhuisje\\settings.xml");
            foreach (XmlNode xNode in xDoc.SelectNodes("People/Person"))
            {
                Person p = new Person();
                p.Name = xNode.SelectSingleNode("Name").InnerText;
                p.EmailAddress = xNode.SelectSingleNode("Email").InnerText;
                p.StreetAddress = xNode.SelectSingleNode("Address").InnerText;
                p.ExtraInformation = xNode.SelectSingleNode("Notes").InnerText;
                p.Birthday = DateTime.FromFileTime(Convert.ToInt64(xNode.SelectSingleNode("Birthday").InnerText));
                people.Add(p);
                lvPeople.Items.Add(p.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = txtName.Text;
            p.EmailAddress = txtMail.Text;
            p.StreetAddress = txtStreet.Text;
            p.Birthday = dtpBirthday.Value;
            p.ExtraInformation = txtExtra.Text;
            people.Add(p);
            lvPeople.Items.Add(p.Name);
            txtName.Text = "";
            txtMail.Text = "";
            txtStreet.Text = "";
            txtExtra.Text = "";
            dtpBirthday.Value = DateTime.Now;
        }

        private void lvPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = people[lvPeople.SelectedItems[0].Index].Name;
            txtMail.Text = people[lvPeople.SelectedItems[0].Index].EmailAddress;
            txtStreet.Text = people[lvPeople.SelectedItems[0].Index].StreetAddress;
            txtExtra.Text = people[lvPeople.SelectedItems[0].Index].ExtraInformation;
            dtpBirthday.Value = people[lvPeople.SelectedItems[0].Index].Birthday;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void Remove()
        {
            try
            {
                lvPeople.Items.Remove(lvPeople.SelectedItems[0]);
                people.RemoveAt(lvPeople.SelectedItems[0].Index);
            }
            catch { }
            
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            people[lvPeople.SelectedItems[0].Index].Name = txtName.Text;
            people[lvPeople.SelectedItems[0].Index].EmailAddress = txtMail.Text;
            people[lvPeople.SelectedItems[0].Index].StreetAddress = txtStreet.Text;
            people[lvPeople.SelectedItems[0].Index].ExtraInformation = txtExtra.Text;
            people[lvPeople.SelectedItems[0].Index].Birthday = dtpBirthday.Value;
            lvPeople.SelectedItems[0].Text = txtName.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            xDoc.Load(path + "\\Address Book - Kabouterhuisje\\settings.xml");
            XmlNode xNode = xDoc.SelectSingleNode("People");
            xNode.RemoveAll();

            foreach (Person p in people)
            {
                XmlNode xTop = xDoc.CreateElement("Person");
                XmlNode xName = xDoc.CreateElement("Name");
                XmlNode xEmail = xDoc.CreateElement("Email");
                XmlNode xAdress = xDoc.CreateElement("Address");
                XmlNode xNotes = xDoc.CreateElement("Notes");
                XmlNode xBirthday = xDoc.CreateElement("Birthday");
                xName.InnerText = p.Name;
                xEmail.InnerText = p.EmailAddress;
                xAdress.InnerText = p.StreetAddress;
                xNotes.InnerText = p.ExtraInformation;
                xBirthday.InnerText = p.Birthday.ToFileTime().ToString();
                xTop.AppendChild(xName);
                xTop.AppendChild(xEmail);
                xTop.AppendChild(xAdress);
                xTop.AppendChild(xNotes);
                xTop.AppendChild(xBirthday);
                xDoc.DocumentElement.AppendChild(xTop);
            }
            xDoc.Save(path + "\\Address Book - Kabouterhuisje\\settings.xml");
        }
    }

    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public string EmailAddress
        {
            get;
            set;
        }
        public string StreetAddress
        {
            get;
            set;
        }
        public string ExtraInformation
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
    }
}
