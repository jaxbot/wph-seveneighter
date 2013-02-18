using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace SevenEighter
{
    public partial class languagelist : Form
    {
        class langtitle
        {
            public int id;
            public string name;

            public langtitle(string name, int id)
            {

            }
            public override string ToString()
            {
                return this.name;
            }
        }

        public languagelist()
        {
            InitializeComponent();
        }

        private void languagelist_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < availablePackages.languages.Length; i++)
            {
                checkedListBox1.Items.Add(new System.Globalization.CultureInfo(availablePackages.languages[i]).DisplayName + " (" + availablePackages.languages[i] + ")");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
