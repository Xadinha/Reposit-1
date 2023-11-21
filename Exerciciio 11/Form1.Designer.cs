namespace Exerciciio_11
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
            toolStrip1 = new ToolStrip();
            menuStrip1 = new MenuStrip();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            corDaLetraToolStripMenuItem = new ToolStripMenuItem();
            tipoDeLetraToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { formatarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { corDaLetraToolStripMenuItem, tipoDeLetraToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(67, 20);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // corDaLetraToolStripMenuItem
            // 
            corDaLetraToolStripMenuItem.Name = "corDaLetraToolStripMenuItem";
            corDaLetraToolStripMenuItem.Size = new Size(142, 22);
            corDaLetraToolStripMenuItem.Text = "Cor da Letra";
            corDaLetraToolStripMenuItem.Click += corDaLetraToolStripMenuItem_Click;
            // 
            // tipoDeLetraToolStripMenuItem
            // 
            tipoDeLetraToolStripMenuItem.Name = "tipoDeLetraToolStripMenuItem";
            tipoDeLetraToolStripMenuItem.Size = new Size(142, 22);
            tipoDeLetraToolStripMenuItem.Text = "Tipo de Letra";
            tipoDeLetraToolStripMenuItem.Click += tipoDeLetraToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 103);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "POO em C#";
            // 
            // button1
            // 
            button1.Location = new Point(662, 297);
            button1.Name = "button1";
            button1.Size = new Size(108, 47);
            button1.TabIndex = 5;
            button1.Text = "Próxima Página";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem corDaLetraToolStripMenuItem;
        private ToolStripMenuItem tipoDeLetraToolStripMenuItem;
        private Label label1;
        private Button button1;
    }
}