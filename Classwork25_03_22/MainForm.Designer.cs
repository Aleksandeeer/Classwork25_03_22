
namespace Classwork25_03_22
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.VisitorsTP = new System.Windows.Forms.TabPage();
            this.SimulatorsTP = new System.Windows.Forms.TabPage();
            this.TariffTP = new System.Windows.Forms.TabPage();
            this.VisitorsDGV = new System.Windows.Forms.DataGridView();
            this.NameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TariffColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SimulatorsDGV = new System.Windows.Forms.DataGridView();
            this.NameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodypartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TariffDGV = new System.Windows.Forms.DataGridView();
            this.NameColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.VisitorsTP.SuspendLayout();
            this.SimulatorsTP.SuspendLayout();
            this.TariffTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulatorsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TariffDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.VisitorsTP);
            this.tabControl1.Controls.Add(this.SimulatorsTP);
            this.tabControl1.Controls.Add(this.TariffTP);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // VisitorsTP
            // 
            this.VisitorsTP.Controls.Add(this.VisitorsDGV);
            this.VisitorsTP.Location = new System.Drawing.Point(4, 25);
            this.VisitorsTP.Name = "VisitorsTP";
            this.VisitorsTP.Padding = new System.Windows.Forms.Padding(3);
            this.VisitorsTP.Size = new System.Drawing.Size(792, 421);
            this.VisitorsTP.TabIndex = 0;
            this.VisitorsTP.Text = "Посетители";
            this.VisitorsTP.UseVisualStyleBackColor = true;
            // 
            // SimulatorsTP
            // 
            this.SimulatorsTP.Controls.Add(this.SimulatorsDGV);
            this.SimulatorsTP.Location = new System.Drawing.Point(4, 25);
            this.SimulatorsTP.Name = "SimulatorsTP";
            this.SimulatorsTP.Padding = new System.Windows.Forms.Padding(3);
            this.SimulatorsTP.Size = new System.Drawing.Size(792, 421);
            this.SimulatorsTP.TabIndex = 1;
            this.SimulatorsTP.Text = "Тренажёры";
            this.SimulatorsTP.UseVisualStyleBackColor = true;
            // 
            // TariffTP
            // 
            this.TariffTP.Controls.Add(this.TariffDGV);
            this.TariffTP.Location = new System.Drawing.Point(4, 25);
            this.TariffTP.Name = "TariffTP";
            this.TariffTP.Size = new System.Drawing.Size(792, 421);
            this.TariffTP.TabIndex = 2;
            this.TariffTP.Text = "Тарифы";
            this.TariffTP.UseVisualStyleBackColor = true;
            // 
            // VisitorsDGV
            // 
            this.VisitorsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisitorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn1,
            this.SurnameColumn1,
            this.AgeColumn1,
            this.TariffColumn1});
            this.VisitorsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisitorsDGV.Location = new System.Drawing.Point(3, 3);
            this.VisitorsDGV.Name = "VisitorsDGV";
            this.VisitorsDGV.RowHeadersVisible = false;
            this.VisitorsDGV.RowHeadersWidth = 51;
            this.VisitorsDGV.RowTemplate.Height = 24;
            this.VisitorsDGV.Size = new System.Drawing.Size(786, 415);
            this.VisitorsDGV.TabIndex = 0;
            // 
            // NameColumn1
            // 
            this.NameColumn1.HeaderText = "Имя";
            this.NameColumn1.MinimumWidth = 6;
            this.NameColumn1.Name = "NameColumn1";
            // 
            // SurnameColumn1
            // 
            this.SurnameColumn1.HeaderText = "Фамилия";
            this.SurnameColumn1.MinimumWidth = 6;
            this.SurnameColumn1.Name = "SurnameColumn1";
            // 
            // AgeColumn1
            // 
            this.AgeColumn1.HeaderText = "Возраст";
            this.AgeColumn1.MinimumWidth = 6;
            this.AgeColumn1.Name = "AgeColumn1";
            // 
            // TariffColumn1
            // 
            this.TariffColumn1.HeaderText = "Тариф";
            this.TariffColumn1.MinimumWidth = 6;
            this.TariffColumn1.Name = "TariffColumn1";
            // 
            // SimulatorsDGV
            // 
            this.SimulatorsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SimulatorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulatorsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn2,
            this.PriceColumn2,
            this.BodypartColumn});
            this.SimulatorsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulatorsDGV.Location = new System.Drawing.Point(3, 3);
            this.SimulatorsDGV.Name = "SimulatorsDGV";
            this.SimulatorsDGV.RowHeadersVisible = false;
            this.SimulatorsDGV.RowHeadersWidth = 51;
            this.SimulatorsDGV.RowTemplate.Height = 24;
            this.SimulatorsDGV.Size = new System.Drawing.Size(786, 415);
            this.SimulatorsDGV.TabIndex = 0;
            // 
            // NameColumn2
            // 
            this.NameColumn2.HeaderText = "Название";
            this.NameColumn2.MinimumWidth = 6;
            this.NameColumn2.Name = "NameColumn2";
            // 
            // PriceColumn2
            // 
            this.PriceColumn2.HeaderText = "Стоимость";
            this.PriceColumn2.MinimumWidth = 6;
            this.PriceColumn2.Name = "PriceColumn2";
            // 
            // BodypartColumn
            // 
            this.BodypartColumn.HeaderText = "Активная часть тела";
            this.BodypartColumn.MinimumWidth = 6;
            this.BodypartColumn.Name = "BodypartColumn";
            // 
            // TariffDGV
            // 
            this.TariffDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TariffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TariffDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn3,
            this.PriceColumn3});
            this.TariffDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TariffDGV.Location = new System.Drawing.Point(0, 0);
            this.TariffDGV.Name = "TariffDGV";
            this.TariffDGV.RowHeadersVisible = false;
            this.TariffDGV.RowHeadersWidth = 51;
            this.TariffDGV.RowTemplate.Height = 24;
            this.TariffDGV.Size = new System.Drawing.Size(792, 421);
            this.TariffDGV.TabIndex = 0;
            // 
            // NameColumn3
            // 
            this.NameColumn3.HeaderText = "Название";
            this.NameColumn3.MinimumWidth = 6;
            this.NameColumn3.Name = "NameColumn3";
            // 
            // PriceColumn3
            // 
            this.PriceColumn3.HeaderText = "Цена тарифа";
            this.PriceColumn3.MinimumWidth = 6;
            this.PriceColumn3.Name = "PriceColumn3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.VisitorsTP.ResumeLayout(false);
            this.SimulatorsTP.ResumeLayout(false);
            this.TariffTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulatorsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TariffDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage VisitorsTP;
        private System.Windows.Forms.TabPage SimulatorsTP;
        private System.Windows.Forms.TabPage TariffTP;
        private System.Windows.Forms.DataGridView VisitorsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TariffColumn1;
        private System.Windows.Forms.DataGridView SimulatorsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BodypartColumn;
        private System.Windows.Forms.DataGridView TariffDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn3;
    }
}

