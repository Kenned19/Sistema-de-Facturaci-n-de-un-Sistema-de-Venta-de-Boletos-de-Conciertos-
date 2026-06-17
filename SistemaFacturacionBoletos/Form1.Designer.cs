namespace SistemaFacturacionBoletos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menustrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            mnMenu = new ToolStripMenuItem();
            mnCliente = new ToolStripMenuItem();
            mnProducto = new ToolStripMenuItem();
            mnFactura = new ToolStripMenuItem();
            menustrip.SuspendLayout();
            SuspendLayout();
            // 
            // menustrip
            // 
            menustrip.Items.AddRange(new ToolStripItem[] { mnMenu, mnCliente, mnProducto, mnFactura });
            menustrip.Name = "menustrip";
            menustrip.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            menustrip.RenderStyle.BorderColor = Color.Gainsboro;
            menustrip.RenderStyle.ColorTable = null;
            menustrip.RenderStyle.RoundedEdges = true;
            menustrip.RenderStyle.SelectionArrowColor = Color.White;
            menustrip.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            menustrip.RenderStyle.SelectionForeColor = Color.White;
            menustrip.RenderStyle.SeparatorColor = Color.Gainsboro;
            menustrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            menustrip.Size = new Size(181, 114);
            // 
            // mnMenu
            // 
            mnMenu.Name = "mnMenu";
            mnMenu.Size = new Size(180, 22);
            mnMenu.Text = "Menu";
            // 
            // mnCliente
            // 
            mnCliente.Name = "mnCliente";
            mnCliente.Size = new Size(180, 22);
            mnCliente.Text = "Cliente";
            // 
            // mnProducto
            // 
            mnProducto.Name = "mnProducto";
            mnProducto.Size = new Size(180, 22);
            mnProducto.Text = "Producto";
            // 
            // mnFactura
            // 
            mnFactura.Name = "mnFactura";
            mnFactura.Size = new Size(180, 22);
            mnFactura.Text = "Factura";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            menustrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContextMenuStrip menustrip;
        private ToolStripMenuItem mnMenu;
        private ToolStripMenuItem mnCliente;
        private ToolStripMenuItem mnProducto;
        private ToolStripMenuItem mnFactura;
    }
}
