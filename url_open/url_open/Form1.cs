using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace url_open
{
    public partial class Form1 : Form
    {
        String url;

        public Form1()
        {
            InitializeComponent();
            bt_delete.Enabled = false;
        }

        private void Bt_insert_Click(object sender, EventArgs e)
        {
            if (tb_url.Text == "")
            {
                MessageBox.Show("URLを入力してください");
            }
            else
            {
                lb_url.Items.Add(tb_url.Text);
            }
        }

        private void Bt_delete_Click(object sender, EventArgs e)
        {
            int sel = lb_url.SelectedIndex;
            if (sel == -1) { }
            else
            {
                lb_url.Items.RemoveAt(sel);
            }
        }

        private void Lb_url_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_url.SelectedItems.Count > 0)
            {
                bt_delete.Enabled = true;
            }
            else
            {
                bt_delete.Enabled = false;
            }
        }

        private void Bt_open_Click(object sender, EventArgs e)
        {
            if (lb_url.SelectedItems.Count > 0)
            {
                url = lb_url.SelectedItem.ToString();
            }
            //to Do
            //urlが有効かどうかチェックする
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception) {
                MessageBox.Show("正しいURLを選択してください");
            }
        }

        private void Bt_allopen_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lb_url.Items.Count; i++)
            {
                url = lb_url.Items[i].ToString();
                try
                {
                    System.Diagnostics.Process.Start(url);
                }
                catch (Exception) { }
            }
        }
    }
}
