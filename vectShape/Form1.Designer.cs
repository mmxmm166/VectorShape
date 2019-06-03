namespace VectShape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblArea = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewdoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShape1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShape2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShapeDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(44, 246);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewdoc,
            this.toolStripButtonShape1,
            this.toolStripButtonShape2,
            this.toolStripButtonShapeDel,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNewdoc
            // 
            this.toolStripButtonNewdoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNewdoc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewdoc.Image")));
            this.toolStripButtonNewdoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewdoc.Name = "toolStripButtonNewdoc";
            this.toolStripButtonNewdoc.Size = new System.Drawing.Size(104, 22);
            this.toolStripButtonNewdoc.Text = "Новый документ";
            this.toolStripButtonNewdoc.Click += new System.EventHandler(this.toolStripButtonNewdoc_Click);
            // 
            // toolStripButtonShape1
            // 
            this.toolStripButtonShape1.CheckOnClick = true;
            this.toolStripButtonShape1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonShape1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShape1.Image")));
            this.toolStripButtonShape1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShape1.Name = "toolStripButtonShape1";
            this.toolStripButtonShape1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripButtonShape1.Size = new System.Drawing.Size(113, 22);
            this.toolStripButtonShape1.Text = "добавить фигуру 1";
            this.toolStripButtonShape1.Click += new System.EventHandler(this.toolStripButtonShape1_Click);
            // 
            // toolStripButtonShape2
            // 
            this.toolStripButtonShape2.CheckOnClick = true;
            this.toolStripButtonShape2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonShape2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShape2.Image")));
            this.toolStripButtonShape2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShape2.Name = "toolStripButtonShape2";
            this.toolStripButtonShape2.Size = new System.Drawing.Size(113, 22);
            this.toolStripButtonShape2.Text = "добавить фигуру 2";
            this.toolStripButtonShape2.Click += new System.EventHandler(this.toolStripButtonShape2_Click);
            // 
            // toolStripButtonShapeDel
            // 
            this.toolStripButtonShapeDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonShapeDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShapeDel.Image")));
            this.toolStripButtonShapeDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShapeDel.Name = "toolStripButtonShapeDel";
            this.toolStripButtonShapeDel.Size = new System.Drawing.Size(171, 22);
            this.toolStripButtonShapeDel.Text = "удалить выбранный элемент";
            this.toolStripButtonShapeDel.Click += new System.EventHandler(this.toolStripButtonShapeDel_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(176, 22);
            this.toolStripButtonUndo.Text = "отменить последнее действие";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(120, 22);
            this.toolStripButtonRedo.Text = "повторить действие";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 425);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewdoc;
        private System.Windows.Forms.ToolStripButton toolStripButtonShape1;
        private System.Windows.Forms.ToolStripButton toolStripButtonShape2;
        private System.Windows.Forms.ToolStripButton toolStripButtonShapeDel;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.Panel panel2;
    }
}

