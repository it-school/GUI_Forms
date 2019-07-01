using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Forms
{
    public partial class MainForm : Form
    {
        Lesson8_Classwork.Book book;
        public MainForm()
        {
            InitializeComponent();
        }


        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            if (title.Equals(""))
            {
                MessageBox.Show("Не задано название книги!");
                txtTitle.Focus();
                return;
            }

            string authors = txtAuthors.Text;
            if (authors.Equals(""))
            {
                MessageBox.Show("Не заданы авторы книги!");
                txtAuthors.Focus();
                return;
            }

            Lesson8_Classwork.Publisher publisher = new Lesson8_Classwork.Publisher(txtPublisher.Text, "");
            ushort pages = 0;
            ushort year = 0;
            try
            {
                pages = (ushort)Convert.ToInt16(txtPages.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Для кол-ва страниц: " + exc.Message);
                txtPages.Focus();
            }

            try
            {
                year = (ushort)Convert.ToInt32(txtYear.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Для года издания: " + exc.Message);
            }

            book = new Lesson8_Classwork.Book(title, authors, publisher, pages, year);
            MessageBox.Show(book.ToString());
        }

    }
}
