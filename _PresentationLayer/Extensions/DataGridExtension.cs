using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _PresentationLayer.Extensions
{
    public static class DataGridExtension
    {
        public static void HideColumns(this Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid, int hideColumns)
        {
            for (int i = hideColumns; i < dataGrid.ColumnCount; i++)
                dataGrid.Columns[i].Visible = false;
        }
    }
}
