namespace TheGameOfLifeApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plansza10x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plansza10x15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plansza15x15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextEraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.otwórzToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 76);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem1,
            this.nowaGraToolStripMenuItem,
            this.nextEraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem1
            // 
            this.plikToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem1,
            this.otwórzToolStripMenuItem1});
            this.plikToolStripMenuItem1.Name = "plikToolStripMenuItem1";
            this.plikToolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem1.Text = "Plik";
            // 
            // zapiszToolStripMenuItem1
            // 
            this.zapiszToolStripMenuItem1.Name = "zapiszToolStripMenuItem1";
            this.zapiszToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.zapiszToolStripMenuItem1.Text = "Zapisz";
            this.zapiszToolStripMenuItem1.Click += new System.EventHandler(this.onClickZapisz);
            // 
            // otwórzToolStripMenuItem1
            // 
            this.otwórzToolStripMenuItem1.Name = "otwórzToolStripMenuItem1";
            this.otwórzToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.otwórzToolStripMenuItem1.Text = "Otwórz";
            this.otwórzToolStripMenuItem1.Click += new System.EventHandler(this.onClickWczytaj);
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plansza10x10ToolStripMenuItem,
            this.plansza10x15ToolStripMenuItem,
            this.plansza15x15ToolStripMenuItem});
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.nowaGraToolStripMenuItem.Text = "Nowa gra";
            // 
            // plansza10x10ToolStripMenuItem
            // 
            this.plansza10x10ToolStripMenuItem.Name = "plansza10x10ToolStripMenuItem";
            this.plansza10x10ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.plansza10x10ToolStripMenuItem.Text = "Plansza 10x10";
            this.plansza10x10ToolStripMenuItem.Click += new System.EventHandler(this.plansza10x10ToolStripMenuItem_Click);
            // 
            // plansza10x15ToolStripMenuItem
            // 
            this.plansza10x15ToolStripMenuItem.Name = "plansza10x15ToolStripMenuItem";
            this.plansza10x15ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.plansza10x15ToolStripMenuItem.Text = "Plansza 10x15";
            this.plansza10x15ToolStripMenuItem.Click += new System.EventHandler(this.plansza10x15ToolStripMenuItem_Click);
            // 
            // plansza15x15ToolStripMenuItem
            // 
            this.plansza15x15ToolStripMenuItem.Name = "plansza15x15ToolStripMenuItem";
            this.plansza15x15ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.plansza15x15ToolStripMenuItem.Text = "Plansza 15x15";
            this.plansza15x15ToolStripMenuItem.Click += new System.EventHandler(this.plansza15x15ToolStripMenuItem_Click);
            // 
            // nextEraToolStripMenuItem
            // 
          
           
           
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 422);
            this.mainPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plansza10x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plansza10x15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plansza15x15ToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel
            ;
        private System.Windows.Forms.ToolStripMenuItem nextEraToolStripMenuItem;
    }
}


