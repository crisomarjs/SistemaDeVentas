

namespace SVPresentation.Utilidades
{
    public class CustomToolStripRender : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                // Cambiar el color de fondo al pasar el cursor
                Color hoverColor = Color.FromArgb(70, 65, 75);
                e.Graphics.FillRectangle(new SolidBrush(hoverColor), e.Item.ContentRectangle);
                e.Item.ForeColor = Color.White; // Cambiar el color del texto
            }
            else
            {
                // Color de fondo normal
                Color hoverColor = Color.FromArgb(58, 49, 69);
                e.Graphics.FillRectangle(new SolidBrush(hoverColor), e.Item.ContentRectangle);
                e.Item.ForeColor = Color.White; // Color de texto normal
            }
        }

    }
}
