using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        private List<InvItem>? invItems = null;

        public frmInvMaint()
        {
            InitializeComponent();
        }

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems = InvItemDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();

            if (invItems != null)
            {
                foreach (InvItem item in invItems)
                {
                    lstItems.Items.Add(item.GetDisplayText());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem? item = newItemForm.GetNewItem();

            if (item != null && invItems != null)
            {
                invItems.Add(item);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1 && invItems != null)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete " + invItems[i].Description + "?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    invItems.RemoveAt(i);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
