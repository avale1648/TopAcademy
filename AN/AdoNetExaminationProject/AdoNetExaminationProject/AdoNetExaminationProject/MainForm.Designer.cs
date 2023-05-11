namespace AdoNetExaminationProject
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.storedProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хранимыеПроцедурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедура10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.представление1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самыйАктивныйКлиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuyTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storedProceduresToolStripMenuItem,
            this.addToToolStripMenuItem,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.BuyTicketToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // storedProceduresToolStripMenuItem
            // 
            this.storedProceduresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хранимыеПроцедурыToolStripMenuItem,
            this.представление1ToolStripMenuItem});
            this.storedProceduresToolStripMenuItem.Name = "storedProceduresToolStripMenuItem";
            this.storedProceduresToolStripMenuItem.Size = new System.Drawing.Size(183, 20);
            this.storedProceduresToolStripMenuItem.Text = "Хранимые процедуры и виды";
            // 
            // хранимыеПроцедурыToolStripMenuItem
            // 
            this.хранимыеПроцедурыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.процедура1ToolStripMenuItem,
            this.процедура2ToolStripMenuItem,
            this.процедура3ToolStripMenuItem,
            this.процедура4ToolStripMenuItem,
            this.процедура5ToolStripMenuItem,
            this.процедура6ToolStripMenuItem,
            this.процедура8ToolStripMenuItem,
            this.процедура9ToolStripMenuItem,
            this.процедура10ToolStripMenuItem});
            this.хранимыеПроцедурыToolStripMenuItem.Name = "хранимыеПроцедурыToolStripMenuItem";
            this.хранимыеПроцедурыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.хранимыеПроцедурыToolStripMenuItem.Text = "Хранимые процедуры...";
            // 
            // процедура1ToolStripMenuItem
            // 
            this.процедура1ToolStripMenuItem.Name = "процедура1ToolStripMenuItem";
            this.процедура1ToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.процедура1ToolStripMenuItem.Text = "События по дате";
            this.процедура1ToolStripMenuItem.Click += new System.EventHandler(this.процедура1ToolStripMenuItem_Click);
            // 
            // процедура2ToolStripMenuItem
            // 
            this.процедура2ToolStripMenuItem.Name = "процедура2ToolStripMenuItem";
            this.процедура2ToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.процедура2ToolStripMenuItem.Text = "События по категории";
            this.процедура2ToolStripMenuItem.Click += new System.EventHandler(this.процедура2ToolStripMenuItem_Click);
            // 
            // процедура3ToolStripMenuItem
            // 
            this.процедура3ToolStripMenuItem.Name = "процедура3ToolStripMenuItem";
            this.процедура3ToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.процедура3ToolStripMenuItem.Text = "События со 100% продаж";
            this.процедура3ToolStripMenuItem.Click += new System.EventHandler(this.процедура3ToolStripMenuItem_Click);
            // 
            // процедура4ToolStripMenuItem
            // 
            this.процедура4ToolStripMenuItem.Name = "процедура4ToolStripMenuItem";
            this.процедура4ToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.процедура4ToolStripMenuItem.Text = "3 наиболее популярные события";
            this.процедура4ToolStripMenuItem.Click += new System.EventHandler(this.процедура4ToolStripMenuItem_Click);
            // 
            // процедура5ToolStripMenuItem
            // 
            this.процедура5ToolStripMenuItem.Name = "процедура5ToolStripMenuItem";
            this.процедура5ToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.процедура5ToolStripMenuItem.Text = "Наиболее популярное событие в городе";
            this.процедура5ToolStripMenuItem.Click += new System.EventHandler(this.процедура5ToolStripMenuItem_Click);
            // 
            // процедура6ToolStripMenuItem
            // 
            this.процедура6ToolStripMenuItem.Name = "процедура6ToolStripMenuItem";
            this.процедура6ToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.процедура6ToolStripMenuItem.Text = "Самая непопулярная категория событий";
            this.процедура6ToolStripMenuItem.Click += new System.EventHandler(this.процедура6ToolStripMenuItem_Click);
            // 
            // процедура8ToolStripMenuItem
            // 
            this.процедура8ToolStripMenuItem.Name = "процедура8ToolStripMenuItem";
            this.процедура8ToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.процедура8ToolStripMenuItem.Text = "3 набирающих популярность события";
            this.процедура8ToolStripMenuItem.Click += new System.EventHandler(this.процедура8ToolStripMenuItem_Click);
            // 
            // процедура9ToolStripMenuItem
            // 
            this.процедура9ToolStripMenuItem.Name = "процедура9ToolStripMenuItem";
            this.процедура9ToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.процедура9ToolStripMenuItem.Text = "События сегодня";
            this.процедура9ToolStripMenuItem.Click += new System.EventHandler(this.процедура9ToolStripMenuItem_Click);
            // 
            // процедура10ToolStripMenuItem
            // 
            this.процедура10ToolStripMenuItem.Name = "процедура10ToolStripMenuItem";
            this.процедура10ToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.процедура10ToolStripMenuItem.Text = "Города в которых сегодня события";
            this.процедура10ToolStripMenuItem.Click += new System.EventHandler(this.процедура10ToolStripMenuItem_Click);
            // 
            // представление1ToolStripMenuItem
            // 
            this.представление1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.самыйАктивныйКлиентToolStripMenuItem});
            this.представление1ToolStripMenuItem.Name = "представление1ToolStripMenuItem";
            this.представление1ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.представление1ToolStripMenuItem.Text = "Представления";
            // 
            // самыйАктивныйКлиентToolStripMenuItem
            // 
            this.самыйАктивныйКлиентToolStripMenuItem.Name = "самыйАктивныйКлиентToolStripMenuItem";
            this.самыйАктивныйКлиентToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.самыйАктивныйКлиентToolStripMenuItem.Text = "Самый активный клиент";
            this.самыйАктивныйКлиентToolStripMenuItem.Click += new System.EventHandler(this.самыйАктивныйКлиентToolStripMenuItem_Click);
            // 
            // addToToolStripMenuItem
            // 
            this.addToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.archiveToolStripMenuItem});
            this.addToToolStripMenuItem.Name = "addToToolStripMenuItem";
            this.addToToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.addToToolStripMenuItem.Text = "Таблицы";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.customersToolStripMenuItem.Text = "Клиенты";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.eventsToolStripMenuItem.Text = "События";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ticketsToolStripMenuItem.Text = "Билеты";
            this.ticketsToolStripMenuItem.Click += new System.EventHandler(this.ticketsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.archiveToolStripMenuItem.Text = "Архив";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.updateToolStripMenuItem.Text = "Изменить";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // BuyTicketToolStripMenuItem
            // 
            this.BuyTicketToolStripMenuItem.Name = "BuyTicketToolStripMenuItem";
            this.BuyTicketToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.BuyTicketToolStripMenuItem.Text = "Купить билет";
            this.BuyTicketToolStripMenuItem.Click += new System.EventHandler(this.BuyTicketToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 411);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem storedProceduresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хранимыеПроцедурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедура10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem представление1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самыйАктивныйКлиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem BuyTicketToolStripMenuItem;
    }
}

