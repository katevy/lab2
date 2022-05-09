
namespace Laba2._0
{
    partial class PersonEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnnameLabel;
            System.Windows.Forms.Label birthdateLabel;
            this.notebookDataSet = new Laba2._0.NotebookDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new Laba2._0.NotebookDataSetTableAdapters.PersonsTableAdapter();
            this.tableAdapterManager = new Laba2._0.NotebookDataSetTableAdapters.TableAdapterManager();
            this.contactsTableAdapter = new Laba2._0.NotebookDataSetTableAdapters.ContactsTableAdapter();
            this.contactTypeTableAdapter = new Laba2._0.NotebookDataSetTableAdapters.ContactTypeTableAdapter();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnnameTextBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contctTypeldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contactTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKContactsPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKContactsPersonsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            surnnameLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKContactsPersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKContactsPersonsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(300, 73);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // surnnameLabel
            // 
            surnnameLabel.AutoSize = true;
            surnnameLabel.Location = new System.Drawing.Point(300, 101);
            surnnameLabel.Name = "surnnameLabel";
            surnnameLabel.Size = new System.Drawing.Size(77, 17);
            surnnameLabel.TabIndex = 3;
            surnnameLabel.Text = "Surnname:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(300, 130);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(69, 17);
            birthdateLabel.TabIndex = 5;
            birthdateLabel.Text = "Birthdate:";
            // 
            // notebookDataSet
            // 
            this.notebookDataSet.DataSetName = "NotebookDataSet";
            this.notebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.notebookDataSet;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactsTableAdapter = this.contactsTableAdapter;
            this.tableAdapterManager.ContactTypeTableAdapter = this.contactTypeTableAdapter;
            this.tableAdapterManager.PersonsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Laba2._0.NotebookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // contactTypeTableAdapter
            // 
            this.contactTypeTableAdapter.ClearBeforeFill = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(383, 70);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // surnnameTextBox
            // 
            this.surnnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Surnname", true));
            this.surnnameTextBox.Location = new System.Drawing.Point(383, 98);
            this.surnnameTextBox.Name = "surnnameTextBox";
            this.surnnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.surnnameTextBox.TabIndex = 4;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personsBindingSource, "Birthdate", true));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(383, 126);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.birthdateDateTimePicker.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Yellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.personldDataGridViewTextBoxColumn,
            this.contctTypeldDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKContactsPersonsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(258, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(450, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // personldDataGridViewTextBoxColumn
            // 
            this.personldDataGridViewTextBoxColumn.DataPropertyName = "Personld";
            this.personldDataGridViewTextBoxColumn.HeaderText = "Personld";
            this.personldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personldDataGridViewTextBoxColumn.Name = "personldDataGridViewTextBoxColumn";
            this.personldDataGridViewTextBoxColumn.Visible = false;
            this.personldDataGridViewTextBoxColumn.Width = 125;
            // 
            // contctTypeldDataGridViewTextBoxColumn
            // 
            this.contctTypeldDataGridViewTextBoxColumn.DataPropertyName = "ContctTypeld";
            this.contctTypeldDataGridViewTextBoxColumn.DataSource = this.contactTypeBindingSource;
            this.contctTypeldDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.contctTypeldDataGridViewTextBoxColumn.HeaderText = "ContctTypeld";
            this.contctTypeldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contctTypeldDataGridViewTextBoxColumn.Name = "contctTypeldDataGridViewTextBoxColumn";
            this.contctTypeldDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.contctTypeldDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.contctTypeldDataGridViewTextBoxColumn.ValueMember = "id";
            this.contctTypeldDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactTypeBindingSource
            // 
            this.contactTypeBindingSource.DataMember = "ContactType";
            this.contactTypeBindingSource.DataSource = this.notebookDataSet;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKContactsPersonsBindingSource
            // 
            this.fKContactsPersonsBindingSource.DataMember = "FK_Contacts_Persons";
            this.fKContactsPersonsBindingSource.DataSource = this.personsBindingSource;
            // 
            // fKContactsPersonsBindingSource1
            // 
            this.fKContactsPersonsBindingSource1.DataMember = "FK_Contacts_Persons";
            this.fKContactsPersonsBindingSource1.DataSource = this.personsBindingSource;
            // 
            // personsBindingSource1
            // 
            this.personsBindingSource1.DataMember = "Persons";
            this.personsBindingSource1.DataSource = this.notebookDataSet;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Yellow;
            this.btnSave.Location = new System.Drawing.Point(346, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Yellow;
            this.btnCancel.Location = new System.Drawing.Point(477, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PersonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnnameLabel);
            this.Controls.Add(this.surnnameTextBox);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Name = "PersonEditForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.PersonEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKContactsPersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKContactsPersonsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotebookDataSet notebookDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private NotebookDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private NotebookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private NotebookDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnnameTextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKContactsPersonsBindingSource;
        private NotebookDataSetTableAdapters.ContactTypeTableAdapter contactTypeTableAdapter;
        private System.Windows.Forms.BindingSource fKContactsPersonsBindingSource1;
        private System.Windows.Forms.BindingSource personsBindingSource1;
        private System.Windows.Forms.BindingSource contactTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn contctTypeldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}