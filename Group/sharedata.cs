using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group
{
    internal class sharedata
    {
        private DataGridView _dataGridView;

        public sharedata(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }

        public void AddOrUpdateItem(string description, int price)
        {
            bool itemFound = false;

            foreach (DataGridViewRow row in _dataGridView.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Description"].Value.ToString() == description)
                {
                    int currentQty = Convert.ToInt32(row.Cells["Qty"].Value);
                    row.Cells["Qty"].Value = currentQty + 1;
                    row.Cells["Price"].Value = (currentQty + 1) * price;
                    itemFound = true;
                    break;
                }
            }

            if (!itemFound)
            {
                _dataGridView.Rows.Add(description, 1, price);
            }
        }

        public decimal CalculateTotal(bool excludeRemoved)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in _dataGridView.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    try
                    {
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        if (!excludeRemoved || row.DefaultCellStyle.BackColor != Color.Red)
                        {
                            total += price;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid value detected in the Price column.");
                    }
                }
            }

            return total;
        }

        public void TransferData(DataGridView targetGrid)
        {
            targetGrid.Rows.Clear(); // Clear existing data

            foreach (DataGridViewRow row in _dataGridView.Rows)
            {
                if (row.Cells["Description"].Value != null &&
                    row.Cells["Qty"].Value != null &&
                    row.Cells["Price"].Value != null)
                {
                    targetGrid.Rows.Add(row.Cells["Description"].Value.ToString(),
                                        row.Cells["Qty"].Value,
                                        row.Cells["Price"].Value);
                }
            }
        }
    }
}

