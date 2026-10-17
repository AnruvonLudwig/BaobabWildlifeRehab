namespace BaobabWildlifeRehab
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
            DataGridView dgvAnimals;
            Id = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            Species = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            RecoveryScore = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            HousingUnit = new DataGridViewTextBoxColumn();
            txtAnimaliD = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtRecoveryScore = new TextBox();
            btnAdd = new Button();
            btnSaveChanges = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnGenerateSummary = new Button();
            txtSearchID = new TextBox();
            lblTotalAnimals = new Label();
            lblReleaseReadyCount = new Label();
            lblRecoveringCount = new Label();
            lblStableCount = new Label();
            lblSeriousCount = new Label();
            lblCriticalCount = new Label();
            lblAverageScore = new Label();
            lblAverageAge = new Label();
            dgvAnimals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Columns.AddRange(new DataGridViewColumn[] { Id, colName, Species, Age, RecoveryScore, Status, HousingUnit });
            dgvAnimals.GridColor = Color.Cyan;
            dgvAnimals.Location = new Point(206, 12);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(744, 168);
            dgvAnimals.TabIndex = 12;
            dgvAnimals.CellContentClick += dgvAnimals_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "colName";
            colName.HeaderText = "colName";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // Species
            // 
            Species.DataPropertyName = "Species";
            Species.HeaderText = "Species";
            Species.Name = "Species";
            Species.ReadOnly = true;
            // 
            // Age
            // 
            Age.DataPropertyName = "Age";
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // RecoveryScore
            // 
            RecoveryScore.DataPropertyName = "RecoveryScore";
            RecoveryScore.HeaderText = "Recovery Score";
            RecoveryScore.Name = "RecoveryScore";
            RecoveryScore.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // HousingUnit
            // 
            HousingUnit.DataPropertyName = "HousingUnit";
            HousingUnit.HeaderText = "Housing Unit";
            HousingUnit.Name = "HousingUnit";
            HousingUnit.ReadOnly = true;
            // 
            // txtAnimaliD
            // 
            txtAnimaliD.Location = new Point(12, 12);
            txtAnimaliD.Name = "txtAnimaliD";
            txtAnimaliD.Size = new Size(107, 23);
            txtAnimaliD.TabIndex = 0;
            txtAnimaliD.TextChanged += txtAnimaliD_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(107, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(12, 70);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(107, 23);
            txtSpecies.TabIndex = 2;
            txtSpecies.TextChanged += txtSpecies_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(12, 99);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(107, 23);
            txtAge.TabIndex = 3;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(12, 128);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(107, 23);
            txtRecoveryScore.TabIndex = 4;
            txtRecoveryScore.TextChanged += txtRecoveryScore_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(125, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(125, 41);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(75, 23);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "button2";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(125, 70);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "button3";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(125, 99);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "button4";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(125, 128);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "button5";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Location = new Point(125, 157);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(75, 23);
            btnGenerateSummary.TabIndex = 10;
            btnGenerateSummary.Text = "button6";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(12, 157);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(107, 23);
            txtSearchID.TabIndex = 11;
            txtSearchID.TextChanged += txtSearchID_TextChanged;
            // 
            // lblTotalAnimals
            // 
            lblTotalAnimals.AutoSize = true;
            lblTotalAnimals.Location = new Point(12, 196);
            lblTotalAnimals.Name = "lblTotalAnimals";
            lblTotalAnimals.Size = new Size(38, 15);
            lblTotalAnimals.TabIndex = 13;
            lblTotalAnimals.Text = "label1";
            lblTotalAnimals.Click += lblTotalAnimals_Click;
            // 
            // lblReleaseReadyCount
            // 
            lblReleaseReadyCount.AutoSize = true;
            lblReleaseReadyCount.Location = new Point(56, 273);
            lblReleaseReadyCount.Name = "lblReleaseReadyCount";
            lblReleaseReadyCount.Size = new Size(38, 15);
            lblReleaseReadyCount.TabIndex = 14;
            lblReleaseReadyCount.Text = "label2";
            lblReleaseReadyCount.Click += lblReleaseReadyCount_Click;
            // 
            // lblRecoveringCount
            // 
            lblRecoveringCount.AutoSize = true;
            lblRecoveringCount.Location = new Point(56, 246);
            lblRecoveringCount.Name = "lblRecoveringCount";
            lblRecoveringCount.Size = new Size(38, 15);
            lblRecoveringCount.TabIndex = 15;
            lblRecoveringCount.Text = "label3";
            lblRecoveringCount.Click += lblRecoveringCount_Click;
            // 
            // lblStableCount
            // 
            lblStableCount.AutoSize = true;
            lblStableCount.Location = new Point(56, 221);
            lblStableCount.Name = "lblStableCount";
            lblStableCount.Size = new Size(38, 15);
            lblStableCount.TabIndex = 16;
            lblStableCount.Text = "label4";
            lblStableCount.Click += lblStableCount_Click;
            // 
            // lblSeriousCount
            // 
            lblSeriousCount.AutoSize = true;
            lblSeriousCount.Location = new Point(56, 196);
            lblSeriousCount.Name = "lblSeriousCount";
            lblSeriousCount.Size = new Size(38, 15);
            lblSeriousCount.TabIndex = 17;
            lblSeriousCount.Text = "label5";
            lblSeriousCount.Click += lblSeriousCount_Click;
            // 
            // lblCriticalCount
            // 
            lblCriticalCount.AutoSize = true;
            lblCriticalCount.Location = new Point(12, 273);
            lblCriticalCount.Name = "lblCriticalCount";
            lblCriticalCount.Size = new Size(38, 15);
            lblCriticalCount.TabIndex = 18;
            lblCriticalCount.Text = "label6";
            lblCriticalCount.Click += lblCriticalCount_Click;
            // 
            // lblAverageScore
            // 
            lblAverageScore.AutoSize = true;
            lblAverageScore.Location = new Point(12, 246);
            lblAverageScore.Name = "lblAverageScore";
            lblAverageScore.Size = new Size(38, 15);
            lblAverageScore.TabIndex = 19;
            lblAverageScore.Text = "label7";
            lblAverageScore.Click += lblAverageScore_Click;
            // 
            // lblAverageAge
            // 
            lblAverageAge.AutoSize = true;
            lblAverageAge.Location = new Point(12, 221);
            lblAverageAge.Name = "lblAverageAge";
            lblAverageAge.Size = new Size(38, 15);
            lblAverageAge.TabIndex = 20;
            lblAverageAge.Text = "label8";
            lblAverageAge.Click += lblAverageAge_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(lblAverageAge);
            Controls.Add(lblAverageScore);
            Controls.Add(lblCriticalCount);
            Controls.Add(lblSeriousCount);
            Controls.Add(lblStableCount);
            Controls.Add(lblRecoveringCount);
            Controls.Add(lblReleaseReadyCount);
            Controls.Add(lblTotalAnimals);
            Controls.Add(dgvAnimals);
            Controls.Add(txtSearchID);
            Controls.Add(btnGenerateSummary);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnAdd);
            Controls.Add(txtRecoveryScore);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(txtAnimaliD);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnimaliD;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private TextBox txtRecoveryScore;
        private Button btnAdd;
        private Button btnSaveChanges;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnGenerateSummary;
        private TextBox txtSearchID;
        private DataGridView dgvAnimals;
        private Label lblTotalAnimals;
        private Label lblReleaseReadyCount;
        private Label lblRecoveringCount;
        private Label lblStableCount;
        private Label lblSeriousCount;
        private Label lblCriticalCount;
        private Label lblAverageScore;
        private Label lblAverageAge;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn Species;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn RecoveryScore;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn HousingUnit;
    }
}
