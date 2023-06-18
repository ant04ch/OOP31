namespace OOP31
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.оновитиПроцесиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зупинитиПроцесToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяПроПроцесToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, -1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(805, 417);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // оновитиПроцесиToolStripMenuItem
            // 
            this.оновитиПроцесиToolStripMenuItem.Name = "оновитиПроцесиToolStripMenuItem";
            this.оновитиПроцесиToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.оновитиПроцесиToolStripMenuItem.Text = "Оновити процеси";
            // 
            // зупинитиПроцесToolStripMenuItem
            // 
            this.зупинитиПроцесToolStripMenuItem.Name = "зупинитиПроцесToolStripMenuItem";
            this.зупинитиПроцесToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.зупинитиПроцесToolStripMenuItem.Text = "Зупинити процес";
            // 
            // інформаціяПроПроцесToolStripMenuItem
            // 
            this.інформаціяПроПроцесToolStripMenuItem.Name = "інформаціяПроПроцесToolStripMenuItem";
            this.інформаціяПроПроцесToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.інформаціяПроПроцесToolStripMenuItem.Text = "Інформація про процес";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт списку";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Задачи";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem оновитиПроцесиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зупинитиПроцесToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяПроПроцесToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

