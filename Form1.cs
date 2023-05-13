using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classwork_13._05_localization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enBtn_Click(object sender, EventArgs e)
        {
            ChangeLang("en");
        }

        private void ChangeLang(string lang)
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            CultureInfo culture = new CultureInfo(lang);
            foreach (Control item in this.Controls)
            {
                manager.ApplyResources(item, item.Name, culture);
            }
        }

        private void gerBtn_Click(object sender, EventArgs e)
        {
            ChangeLang("de");
        }

        private void ruBtn_Click(object sender, EventArgs e)
        {
            ChangeLang("ru");
        }

        private void ukrBtn_Click(object sender, EventArgs e)
        {
            ChangeLang("uk_UA");
        }
    }
}
