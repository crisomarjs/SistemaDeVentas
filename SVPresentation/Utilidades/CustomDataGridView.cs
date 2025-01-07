

namespace SVPresentation.Utilidades
{
    public static class CustomDataGridView
    {
        public static void ImplementarConfiguracion(this DataGridView data, string txtButton ="")
        {
            data.AllowUserToAddRows = false;
            data.AllowUserToDeleteRows = false;
            data.AllowUserToResizeColumns = true;
            data.AllowUserToResizeRows = false;
            data.AllowUserToOrderColumns = false;
            data.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data.MultiSelect = false;
            data.RowHeadersVisible = false;
            data.ReadOnly = true;
            data.BackgroundColor = Color.White;
            data.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(58, 49, 69),
                SelectionBackColor = Color.FromArgb(58, 49, 69),
                ForeColor = Color.FromArgb(255, 255, 255)
            };
            data.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(191, 176, 209),
                SelectionForeColor = Color.FromArgb(0, 0, 0),
            };
            data.ColumnHeadersHeight = 30;
            data.EnableHeadersVisualStyles = false;
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            if (txtButton != "")
            {
                var btnEditarColumn = new DataGridViewButtonColumn();
                btnEditarColumn.Text = txtButton;
                btnEditarColumn.Name = "ColumnaAccion";
                btnEditarColumn.HeaderText = "";
                btnEditarColumn.UseColumnTextForButtonValue = true;
                btnEditarColumn.Width = 50;
                btnEditarColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                data.Columns.Add(btnEditarColumn);
            } 
        }
    }
}
