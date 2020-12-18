namespace Практическая_работа__2
{
    partial class Praktikum2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Praktikum2));
            this.TableMas = new System.Windows.Forms.DataGridView();
            this.btnFillTable = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnSaveTable = new System.Windows.Forms.Button();
            this.btnOpenTable = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.массивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TableFunc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableMas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMas
            // 
            this.TableMas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMas.Location = new System.Drawing.Point(36, 88);
            this.TableMas.Name = "TableMas";
            this.TableMas.Size = new System.Drawing.Size(334, 68);
            this.TableMas.TabIndex = 0;
            // 
            // btnFillTable
            // 
            this.btnFillTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFillTable.Location = new System.Drawing.Point(73, 232);
            this.btnFillTable.Name = "btnFillTable";
            this.btnFillTable.Size = new System.Drawing.Size(122, 34);
            this.btnFillTable.TabIndex = 1;
            this.btnFillTable.Text = "Заполнить";
            this.btnFillTable.UseVisualStyleBackColor = true;
            this.btnFillTable.Click += new System.EventHandler(this.btnFillTable_Click);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearTable.Location = new System.Drawing.Point(201, 232);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(122, 34);
            this.btnClearTable.TabIndex = 2;
            this.btnClearTable.Text = "Очистить";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveTable.Location = new System.Drawing.Point(73, 272);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(122, 33);
            this.btnSaveTable.TabIndex = 3;
            this.btnSaveTable.Text = "Сохранить";
            this.btnSaveTable.UseVisualStyleBackColor = true;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // btnOpenTable
            // 
            this.btnOpenTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenTable.Location = new System.Drawing.Point(201, 272);
            this.btnOpenTable.Name = "btnOpenTable";
            this.btnOpenTable.Size = new System.Drawing.Size(122, 33);
            this.btnOpenTable.TabIndex = 4;
            this.btnOpenTable.Text = "Открыть";
            this.btnOpenTable.UseVisualStyleBackColor = true;
            this.btnOpenTable.Click += new System.EventHandler(this.btnOpenTable_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFunc.Location = new System.Drawing.Point(132, 311);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(122, 33);
            this.btnFunc.TabIndex = 5;
            this.btnFunc.Text = "Вычислить";
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.массивToolStripMenuItem,
            this.функцияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 29);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // массивToolStripMenuItem
            // 
            this.массивToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заполнитьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.массивToolStripMenuItem.Name = "массивToolStripMenuItem";
            this.массивToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.массивToolStripMenuItem.Text = "Массив";
            // 
            // заполнитьToolStripMenuItem
            // 
            this.заполнитьToolStripMenuItem.Name = "заполнитьToolStripMenuItem";
            this.заполнитьToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.заполнитьToolStripMenuItem.Text = "Заполнить";
            this.заполнитьToolStripMenuItem.Click += new System.EventHandler(this.btnFillTable_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.btnOpenTable_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // функцияToolStripMenuItem
            // 
            this.функцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вычислитьToolStripMenuItem});
            this.функцияToolStripMenuItem.Name = "функцияToolStripMenuItem";
            this.функцияToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.функцияToolStripMenuItem.Text = "Функция";
            // 
            // вычислитьToolStripMenuItem
            // 
            this.вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            this.вычислитьToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.вычислитьToolStripMenuItem.Text = "Вычислить";
            this.вычислитьToolStripMenuItem.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TableFunc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.btnFunc);
            this.groupBox1.Controls.Add(this.TableMas);
            this.groupBox1.Controls.Add(this.btnFillTable);
            this.groupBox1.Controls.Add(this.btnSaveTable);
            this.groupBox1.Controls.Add(this.btnOpenTable);
            this.groupBox1.Controls.Add(this.btnClearTable);
            this.groupBox1.Location = new System.Drawing.Point(21, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 363);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // TableFunc
            // 
            this.TableFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableFunc.Location = new System.Drawing.Point(36, 162);
            this.TableFunc.Name = "TableFunc";
            this.TableFunc.Size = new System.Drawing.Size(334, 64);
            this.TableFunc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите число n";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(123, 49);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(144, 33);
            this.txtNumber.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(305, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfo.Location = new System.Drawing.Point(177, 413);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(122, 32);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.Text = "О программе";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Praktikum2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 472);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Praktikum2";
            this.Text = "Практическая работа №2";
            ((System.ComponentModel.ISupportInitialize)(this.TableMas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableMas;
        private System.Windows.Forms.Button btnFillTable;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.Button btnOpenTable;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ToolStripMenuItem массивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заполнитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TableFunc;
    }
}

