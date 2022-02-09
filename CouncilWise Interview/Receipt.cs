using System.Collections.Generic;
using System.Text;

namespace CouncilWise
{
    internal class Receipt
    {
        public ICollection<ReceiptItem> Items { get; set; }
        public decimal Total { get; set; }
        public decimal TaxTotal { get; set; }

        public override string ToString()
        {
            string outputReceipt = "\nReceipt: \n   Items: \n";
            foreach (ReceiptItem item in this.Items)
            {

                string itemInfo = $"     {item.Name} \n     {item.Quantity}    {item.UnitPrice}    {item.TotalAmount} \n";

                outputReceipt += itemInfo;
            }

            string totalItemsResult = $"\n   Total: {this.Total} \n   GST:    {this.TaxTotal}";

            outputReceipt += totalItemsResult;

            return outputReceipt;

        }

    }

}

