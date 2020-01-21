namespace WinFormApp
{
    partial class WinFormsDB
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonCategs = new System.Windows.Forms.Button();
            this.buttonComps = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 46);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(776, 403);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(12, 12);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(144, 23);
            this.buttonUsers.TabIndex = 1;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonCategs
            // 
            this.buttonCategs.Location = new System.Drawing.Point(170, 12);
            this.buttonCategs.Name = "buttonCategs";
            this.buttonCategs.Size = new System.Drawing.Size(144, 23);
            this.buttonCategs.TabIndex = 2;
            this.buttonCategs.Text = "Категории";
            this.buttonCategs.UseVisualStyleBackColor = true;
            // 
            // buttonComps
            // 
            this.buttonComps.Location = new System.Drawing.Point(328, 12);
            this.buttonComps.Name = "buttonComps";
            this.buttonComps.Size = new System.Drawing.Size(144, 23);
            this.buttonComps.TabIndex = 3;
            this.buttonComps.Text = "Компании";
            this.buttonComps.UseVisualStyleBackColor = true;
            // 
            // buttonItems
            // 
            this.buttonItems.Location = new System.Drawing.Point(486, 12);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(144, 23);
            this.buttonItems.TabIndex = 4;
            this.buttonItems.Text = "Товары";
            this.buttonItems.UseVisualStyleBackColor = true;
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(644, 12);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(144, 23);
            this.buttonOrders.TabIndex = 5;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            // 
            // WinFormsDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.buttonComps);
            this.Controls.Add(this.buttonCategs);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.dataGridView);
            this.MinimumSize = new System.Drawing.Size(816, 500);
            this.Name = "WinFormsDB";
            this.Text = "Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonCategs;
        private System.Windows.Forms.Button buttonComps;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button buttonOrders;
    }
}

