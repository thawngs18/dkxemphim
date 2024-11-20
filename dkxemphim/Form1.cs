using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dkxemphim
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnDk_Click(object sender, EventArgs e)
		{
			bool check = true;
			errorProvider1.Clear();
			if (txtPhone.Text == "")
			{
				errorProvider1.SetError(txtPhone, "ban chua nhap so phone");
				check = false;
			}

			int tuoi;
			if (int.TryParse(txtTuoi.Text, out tuoi) == false)
			{
				errorProvider1.SetError(txtTuoi, "sai dinh dang");
				check = false;
			}
			else
			{
				if (tuoi < 17)
				{
					errorProvider1.SetError(txtTuoi, "khong du tuoi de dang ky,17+");
					check = false;
				}

			}

			if (dtpDk.Value.DayOfWeek == DayOfWeek.Monday)
			{
				errorProvider1.SetError(dtpDk, "thu hai ko chieu phim!!!!!!!");
			}

			if (check)
			{
				DialogResult result = MessageBox.Show("ban da dang ky thanh cong", "thong bao", MessageBoxButtons.OK);
				if (result == DialogResult.OK)
				{
					Close();
				}
			}
		}
	}
}
