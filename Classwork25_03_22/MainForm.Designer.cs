
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
            this.XMLTabControl = new System.Windows.Forms.TabControl();
            this.VisitorsTP = new System.Windows.Forms.TabPage();
            this.VisitorsDGV = new System.Windows.Forms.DataGridView();
            this.NameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TariffColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SimulatorsTP = new System.Windows.Forms.TabPage();
            this.SimulatorsDGV = new System.Windows.Forms.DataGridView();
            this.NameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodypartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TariffTP = new System.Windows.Forms.TabPage();
            this.TariffDGV = new System.Windows.Forms.DataGridView();
            this.NameColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.XMLTP = new System.Windows.Forms.TabPage();
            this.JSONTP = new System.Windows.Forms.TabPage();
            this.JSONTabControl = new System.Windows.Forms.TabControl();
            this.VisitorsTP2 = new System.Windows.Forms.TabPage();
            this.SimulatorsTP2 = new System.Windows.Forms.TabPage();
            this.TariffTP2 = new System.Windows.Forms.TabPage();
            this.VisitorsDGV2 = new System.Windows.Forms.DataGridView();
            this.NameColumn2_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn2_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn2_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TariffColumn2_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SimulatorsDGV2 = new System.Windows.Forms.DataGridView();
            this.NameColumn2_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn2_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodypartColumn2_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TariffDGV2 = new System.Windows.Forms.DataGridView();
            this.NameColumn2_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn2_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMLTabControl.SuspendLayout();
            this.VisitorsTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsDGV)).BeginInit();
            this.SimulatorsTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimulatorsDGV)).BeginInit();
            this.TariffTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TariffDGV)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.XMLTP.SuspendLayout();
            this.JSONTP.SuspendLayout();
            this.JSONTabControl.SuspendLayout();
            this.VisitorsTP2.SuspendLayout();
            this.SimulatorsTP2.SuspendLayout();
            this.TariffTP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsDGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulatorsDGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TariffDGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // XMLTabControl
            // 
            this.XMLTabControl.Controls.Add(this.VisitorsTP);
            this.XMLTabControl.Controls.Add(this.SimulatorsTP);
            this.XMLTabControl.Controls.Add(this.TariffTP);
            this.XMLTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XMLTabControl.Location = new System.Drawing.Point(3, 3);
            this.XMLTabControl.Name = "XMLTabControl";
            this.XMLTabControl.SelectedIndex = 0;
            this.XMLTabControl.Size = new System.Drawing.Size(786, 415);
            this.XMLTabControl.TabIndex = 0;
            // 
            // VisitorsTP
            // 
            this.VisitorsTP.Controls.Add(this.VisitorsDGV);
            this.VisitorsTP.Location = new System.Drawing.Point(4, 25);
            this.VisitorsTP.Name = "VisitorsTP";
            this.VisitorsTP.Padding = new System.Windows.Forms.Padding(3);
            this.VisitorsTP.Size = new System.Drawing.Size(778, 386);
            this.VisitorsTP.TabIndex = 0;
            this.VisitorsTP.Text = "Посетители";
            this.VisitorsTP.UseVisualStyleBackColor = true;
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
            this.VisitorsDGV.Size = new System.Drawing.Size(772, 380);
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
            // SimulatorsTP
            // 
            this.SimulatorsTP.Controls.Add(this.SimulatorsDGV);
            this.SimulatorsTP.Location = new System.Drawing.Point(4, 25);
            this.SimulatorsTP.Name = "SimulatorsTP";
            this.SimulatorsTP.Padding = new System.Windows.Forms.Padding(3);
            this.SimulatorsTP.Size = new System.Drawing.Size(778, 386);
            this.SimulatorsTP.TabIndex = 1;
            this.SimulatorsTP.Text = "Тренажёры";
            this.SimulatorsTP.UseVisualStyleBackColor = true;
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
            this.SimulatorsDGV.Size = new System.Drawing.Size(772, 380);
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
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.XMLTP);
            this.MainTabControl.Controls.Add(this.JSONTP);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(800, 450);
            this.MainTabControl.TabIndex = 1;
            // 
            // XMLTP
            // 
            this.XMLTP.Controls.Add(this.XMLTabControl);
            this.XMLTP.Location = new System.Drawing.Point(4, 25);
            this.XMLTP.Name = "XMLTP";
            this.XMLTP.Padding = new System.Windows.Forms.Padding(3);
            this.XMLTP.Size = new System.Drawing.Size(792, 421);
            this.XMLTP.TabIndex = 0;
            this.XMLTP.Text = "XML";
            this.XMLTP.UseVisualStyleBackColor = true;
            // 
            // JSONTP
            // 
            this.JSONTP.Controls.Add(this.JSONTabControl);
            this.JSONTP.Location = new System.Drawing.Point(4, 25);
            this.JSONTP.Name = "JSONTP";
            this.JSONTP.Padding = new System.Windows.Forms.Padding(3);
            this.JSONTP.Size = new System.Drawing.Size(792, 421);
            this.JSONTP.TabIndex = 1;
            this.JSONTP.Text = "JSON";
            this.JSONTP.UseVisualStyleBackColor = true;
            // 
            // JSONTabControl
            // 
            this.JSONTabControl.Controls.Add(this.VisitorsTP2);
            this.JSONTabControl.Controls.Add(this.SimulatorsTP2);
            this.JSONTabControl.Controls.Add(this.TariffTP2);
            this.JSONTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JSONTabControl.Location = new System.Drawing.Point(3, 3);
            this.JSONTabControl.Name = "JSONTabControl";
            this.JSONTabControl.SelectedIndex = 0;
            this.JSONTabControl.Size = new System.Drawing.Size(786, 415);
            this.JSONTabControl.TabIndex = 0;
            // 
            // VisitorsTP2
            // 
            this.VisitorsTP2.Controls.Add(this.VisitorsDGV2);
            this.VisitorsTP2.Location = new System.Drawing.Point(4, 25);
            this.VisitorsTP2.Name = "VisitorsTP2";
            this.VisitorsTP2.Padding = new System.Windows.Forms.Padding(3);
            this.VisitorsTP2.Size = new System.Drawing.Size(778, 386);
            this.VisitorsTP2.TabIndex = 0;
            this.VisitorsTP2.Text = "Посетители";
            this.VisitorsTP2.UseVisualStyleBackColor = true;
            // 
            // SimulatorsTP2
            // 
            this.SimulatorsTP2.Controls.Add(this.SimulatorsDGV2);
            this.SimulatorsTP2.Location = new System.Drawing.Point(4, 25);
            this.SimulatorsTP2.Name = "SimulatorsTP2";
            this.SimulatorsTP2.Padding = new System.Windows.Forms.Padding(3);
            this.SimulatorsTP2.Size = new System.Drawing.Size(778, 386);
            this.SimulatorsTP2.TabIndex = 1;
            this.SimulatorsTP2.Text = "Тренажёры";
            this.SimulatorsTP2.UseVisualStyleBackColor = true;
            // 
            // TariffTP2
            // 
            this.TariffTP2.Controls.Add(this.TariffDGV2);
            this.TariffTP2.Location = new System.Drawing.Point(4, 25);
            this.TariffTP2.Name = "TariffTP2";
            this.TariffTP2.Size = new System.Drawing.Size(778, 386);
            this.TariffTP2.TabIndex = 2;
            this.TariffTP2.Text = "Тарифы";
            this.TariffTP2.UseVisualStyleBackColor = true;
            // 
            // VisitorsDGV2
            // 
            this.VisitorsDGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisitorsDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorsDGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn2_1,
            this.SurnameColumn2_1,
            this.AgeColumn2_1,
            this.TariffColumn2_1});
            this.VisitorsDGV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisitorsDGV2.Location = new System.Drawing.Point(3, 3);
            this.VisitorsDGV2.Name = "VisitorsDGV2";
            this.VisitorsDGV2.RowHeadersVisible = false;
            this.VisitorsDGV2.RowHeadersWidth = 51;
            this.VisitorsDGV2.RowTemplate.Height = 24;
            this.VisitorsDGV2.Size = new System.Drawing.Size(772, 380);
            this.VisitorsDGV2.TabIndex = 0;
            // 
            // NameColumn2_1
            // 
            this.NameColumn2_1.HeaderText = "Имя";
            this.NameColumn2_1.MinimumWidth = 6;
            this.NameColumn2_1.Name = "NameColumn2_1";
            // 
            // SurnameColumn2_1
            // 
            this.SurnameColumn2_1.HeaderText = "Фамилия";
            this.SurnameColumn2_1.MinimumWidth = 6;
            this.SurnameColumn2_1.Name = "SurnameColumn2_1";
            // 
            // AgeColumn2_1
            // 
            this.AgeColumn2_1.HeaderText = "Возраст";
            this.AgeColumn2_1.MinimumWidth = 6;
            this.AgeColumn2_1.Name = "AgeColumn2_1";
            // 
            // TariffColumn2_1
            // 
            this.TariffColumn2_1.HeaderText = "Тариф";
            this.TariffColumn2_1.MinimumWidth = 6;
            this.TariffColumn2_1.Name = "TariffColumn2_1";
            // 
            // SimulatorsDGV2
            // 
            this.SimulatorsDGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SimulatorsDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulatorsDGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn2_2,
            this.PriceColumn2_2,
            this.BodypartColumn2_2});
            this.SimulatorsDGV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulatorsDGV2.Location = new System.Drawing.Point(3, 3);
            this.SimulatorsDGV2.Name = "SimulatorsDGV2";
            this.SimulatorsDGV2.RowHeadersVisible = false;
            this.SimulatorsDGV2.RowHeadersWidth = 51;
            this.SimulatorsDGV2.RowTemplate.Height = 24;
            this.SimulatorsDGV2.Size = new System.Drawing.Size(772, 380);
            this.SimulatorsDGV2.TabIndex = 0;
            // 
            // NameColumn2_2
            // 
            this.NameColumn2_2.HeaderText = "Название";
            this.NameColumn2_2.MinimumWidth = 6;
            this.NameColumn2_2.Name = "NameColumn2_2";
            // 
            // PriceColumn2_2
            // 
            this.PriceColumn2_2.HeaderText = "Цена";
            this.PriceColumn2_2.MinimumWidth = 6;
            this.PriceColumn2_2.Name = "PriceColumn2_2";
            // 
            // BodypartColumn2_2
            // 
            this.BodypartColumn2_2.HeaderText = "Активная часть тела";
            this.BodypartColumn2_2.MinimumWidth = 6;
            this.BodypartColumn2_2.Name = "BodypartColumn2_2";
            // 
            // TariffDGV2
            // 
            this.TariffDGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TariffDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TariffDGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn2_3,
            this.PriceColumn2_3});
            this.TariffDGV2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TariffDGV2.Location = new System.Drawing.Point(0, 0);
            this.TariffDGV2.Name = "TariffDGV2";
            this.TariffDGV2.RowHeadersVisible = false;
            this.TariffDGV2.RowHeadersWidth = 51;
            this.TariffDGV2.RowTemplate.Height = 24;
            this.TariffDGV2.Size = new System.Drawing.Size(778, 386);
            this.TariffDGV2.TabIndex = 0;
            // 
            // NameColumn2_3
            // 
            this.NameColumn2_3.HeaderText = "Название тарифа";
            this.NameColumn2_3.MinimumWidth = 6;
            this.NameColumn2_3.Name = "NameColumn2_3";
            // 
            // PriceColumn2_3
            // 
            this.PriceColumn2_3.HeaderText = "Цена";
            this.PriceColumn2_3.MinimumWidth = 6;
            this.PriceColumn2_3.Name = "PriceColumn2_3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.XMLTabControl.ResumeLayout(false);
            this.VisitorsTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsDGV)).EndInit();
            this.SimulatorsTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimulatorsDGV)).EndInit();
            this.TariffTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TariffDGV)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.XMLTP.ResumeLayout(false);
            this.JSONTP.ResumeLayout(false);
            this.JSONTabControl.ResumeLayout(false);
            this.VisitorsTP2.ResumeLayout(false);
            this.SimulatorsTP2.ResumeLayout(false);
            this.TariffTP2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsDGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulatorsDGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TariffDGV2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl XMLTabControl;
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
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage XMLTP;
        private System.Windows.Forms.TabPage JSONTP;
        private System.Windows.Forms.TabControl JSONTabControl;
        private System.Windows.Forms.TabPage VisitorsTP2;
        private System.Windows.Forms.TabPage SimulatorsTP2;
        private System.Windows.Forms.DataGridView VisitorsDGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn2_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn2_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn2_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TariffColumn2_1;
        private System.Windows.Forms.DataGridView SimulatorsDGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn2_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn2_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BodypartColumn2_2;
        private System.Windows.Forms.TabPage TariffTP2;
        private System.Windows.Forms.DataGridView TariffDGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn2_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn2_3;
    }
}

