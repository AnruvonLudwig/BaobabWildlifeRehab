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
            panel1 = new Panel();
            lblHeading2 = new Label();
            lblCriticalCountSummary = new Label();
            lblSeriousCountSummary = new Label();
            lblRecoveryCountSummary = new Label();
            lblStableCountSummary = new Label();
            lblAverageScoreSummary = new Label();
            lblAverageAgeSummary = new Label();
            lblReleaseReadyCountSummary = new Label();
            lblTotalAnimalsSummary = new Label();
            lblRecoveryScore = new Label();
            lblAge = new Label();
            lblSpecies = new Label();
            lblAnimalID = new Label();
            lblName = new Label();
            panel2 = new Panel();
            lblHeading1 = new Label();
            pictureBox1 = new PictureBox();
            lblSearchByID = new Label();
            dgvAnimals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.BackgroundColor = Color.DarkCyan;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Columns.AddRange(new DataGridViewColumn[] { Id, colName, Species, Age, RecoveryScore, Status, HousingUnit });
            dgvAnimals.GridColor = Color.DarkGray;
            dgvAnimals.Location = new Point(314, 0);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(743, 411);
            dgvAnimals.TabIndex = 12;
            dgvAnimals.CellClick += dgvAnimals_CellClick;
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
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
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
            txtAnimaliD.Location = new Point(236, 115);
            txtAnimaliD.Name = "txtAnimaliD";
            txtAnimaliD.Size = new Size(107, 23);
            txtAnimaliD.TabIndex = 0;
            txtAnimaliD.TextChanged += txtAnimaliD_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(236, 144);
            txtName.Name = "txtName";
            txtName.Size = new Size(107, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(236, 173);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(107, 23);
            txtSpecies.TabIndex = 2;
            txtSpecies.TextChanged += txtSpecies_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(236, 202);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(107, 23);
            txtAge.TabIndex = 3;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(236, 231);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(107, 23);
            txtRecoveryScore.TabIndex = 4;
            txtRecoveryScore.TextChanged += txtRecoveryScore_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Location = new Point(34, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(379, 316);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(75, 23);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(268, 316);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(148, 315);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(233, 355);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Location = new Point(68, 198);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(118, 23);
            btnGenerateSummary.TabIndex = 10;
            btnGenerateSummary.Text = "Generate Summary";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(117, 355);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(107, 23);
            txtSearchID.TabIndex = 11;
            txtSearchID.TextChanged += txtSearchID_TextChanged;
            // 
            // lblTotalAnimals
            // 
            lblTotalAnimals.AutoSize = true;
            lblTotalAnimals.Location = new Point(254, 47);
            lblTotalAnimals.Name = "lblTotalAnimals";
            lblTotalAnimals.Size = new Size(79, 15);
            lblTotalAnimals.TabIndex = 13;
            lblTotalAnimals.Text = "Total Animals";
            lblTotalAnimals.Click += lblTotalAnimals_Click;
            // 
            // lblReleaseReadyCount
            // 
            lblReleaseReadyCount.AutoSize = true;
            lblReleaseReadyCount.Location = new Point(254, 178);
            lblReleaseReadyCount.Name = "lblReleaseReadyCount";
            lblReleaseReadyCount.Size = new Size(111, 15);
            lblReleaseReadyCount.TabIndex = 14;
            lblReleaseReadyCount.Text = "Release Redy Count";
            lblReleaseReadyCount.Click += lblReleaseReadyCount_Click;
            // 
            // lblRecoveringCount
            // 
            lblRecoveringCount.AutoSize = true;
            lblRecoveringCount.Location = new Point(254, 236);
            lblRecoveringCount.Name = "lblRecoveringCount";
            lblRecoveringCount.Size = new Size(102, 15);
            lblRecoveringCount.TabIndex = 15;
            lblRecoveringCount.Text = "Recovering Count";
            lblRecoveringCount.Click += lblRecoveringCount_Click;
            // 
            // lblStableCount
            // 
            lblStableCount.AutoSize = true;
            lblStableCount.Location = new Point(254, 207);
            lblStableCount.Name = "lblStableCount";
            lblStableCount.Size = new Size(75, 15);
            lblStableCount.TabIndex = 16;
            lblStableCount.Text = "Stable Count";
            lblStableCount.Click += lblStableCount_Click;
            // 
            // lblSeriousCount
            // 
            lblSeriousCount.AutoSize = true;
            lblSeriousCount.Location = new Point(254, 262);
            lblSeriousCount.Name = "lblSeriousCount";
            lblSeriousCount.Size = new Size(81, 15);
            lblSeriousCount.TabIndex = 17;
            lblSeriousCount.Text = "Serious Count";
            lblSeriousCount.Click += lblSeriousCount_Click;
            // 
            // lblCriticalCount
            // 
            lblCriticalCount.AutoSize = true;
            lblCriticalCount.Location = new Point(254, 290);
            lblCriticalCount.Name = "lblCriticalCount";
            lblCriticalCount.Size = new Size(80, 15);
            lblCriticalCount.TabIndex = 18;
            lblCriticalCount.Text = "Critical Count";
            lblCriticalCount.Click += lblCriticalCount_Click;
            // 
            // lblAverageScore
            // 
            lblAverageScore.AutoSize = true;
            lblAverageScore.Location = new Point(254, 77);
            lblAverageScore.Name = "lblAverageScore";
            lblAverageScore.Size = new Size(82, 15);
            lblAverageScore.TabIndex = 19;
            lblAverageScore.Text = "Average Score";
            lblAverageScore.Click += lblAverageScore_Click;
            // 
            // lblAverageAge
            // 
            lblAverageAge.AutoSize = true;
            lblAverageAge.Location = new Point(254, 107);
            lblAverageAge.Name = "lblAverageAge";
            lblAverageAge.Size = new Size(74, 15);
            lblAverageAge.TabIndex = 20;
            lblAverageAge.Text = "Average Age";
            lblAverageAge.Click += lblAverageAge_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHeading2);
            panel1.Controls.Add(lblCriticalCountSummary);
            panel1.Controls.Add(lblSeriousCountSummary);
            panel1.Controls.Add(lblRecoveryCountSummary);
            panel1.Controls.Add(lblStableCountSummary);
            panel1.Controls.Add(lblAverageScoreSummary);
            panel1.Controls.Add(lblAverageAgeSummary);
            panel1.Controls.Add(lblReleaseReadyCountSummary);
            panel1.Controls.Add(lblTotalAnimalsSummary);
            panel1.Controls.Add(lblTotalAnimals);
            panel1.Controls.Add(lblAverageScore);
            panel1.Controls.Add(lblAverageAge);
            panel1.Controls.Add(lblRecoveringCount);
            panel1.Controls.Add(lblCriticalCount);
            panel1.Controls.Add(lblReleaseReadyCount);
            panel1.Controls.Add(lblSeriousCount);
            panel1.Controls.Add(lblStableCount);
            panel1.Controls.Add(btnGenerateSummary);
            panel1.Location = new Point(514, 417);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 352);
            panel1.TabIndex = 21;
            // 
            // lblHeading2
            // 
            lblHeading2.AutoSize = true;
            lblHeading2.Location = new Point(22, 15);
            lblHeading2.Name = "lblHeading2";
            lblHeading2.Size = new Size(96, 15);
            lblHeading2.TabIndex = 29;
            lblHeading2.Text = "Summary Report";
            // 
            // lblCriticalCountSummary
            // 
            lblCriticalCountSummary.AutoSize = true;
            lblCriticalCountSummary.Location = new Point(458, 290);
            lblCriticalCountSummary.Name = "lblCriticalCountSummary";
            lblCriticalCountSummary.Size = new Size(29, 15);
            lblCriticalCountSummary.TabIndex = 28;
            lblCriticalCountSummary.Text = "N/A";
            // 
            // lblSeriousCountSummary
            // 
            lblSeriousCountSummary.AutoSize = true;
            lblSeriousCountSummary.Location = new Point(458, 262);
            lblSeriousCountSummary.Name = "lblSeriousCountSummary";
            lblSeriousCountSummary.Size = new Size(29, 15);
            lblSeriousCountSummary.TabIndex = 27;
            lblSeriousCountSummary.Text = "N/A";
            // 
            // lblRecoveryCountSummary
            // 
            lblRecoveryCountSummary.AutoSize = true;
            lblRecoveryCountSummary.Location = new Point(458, 236);
            lblRecoveryCountSummary.Name = "lblRecoveryCountSummary";
            lblRecoveryCountSummary.Size = new Size(29, 15);
            lblRecoveryCountSummary.TabIndex = 26;
            lblRecoveryCountSummary.Text = "N/A";
            // 
            // lblStableCountSummary
            // 
            lblStableCountSummary.AutoSize = true;
            lblStableCountSummary.Location = new Point(458, 207);
            lblStableCountSummary.Name = "lblStableCountSummary";
            lblStableCountSummary.Size = new Size(29, 15);
            lblStableCountSummary.TabIndex = 25;
            lblStableCountSummary.Text = "N/A";
            // 
            // lblAverageScoreSummary
            // 
            lblAverageScoreSummary.AutoSize = true;
            lblAverageScoreSummary.Location = new Point(458, 77);
            lblAverageScoreSummary.Name = "lblAverageScoreSummary";
            lblAverageScoreSummary.Size = new Size(29, 15);
            lblAverageScoreSummary.TabIndex = 24;
            lblAverageScoreSummary.Text = "N/A";
            // 
            // lblAverageAgeSummary
            // 
            lblAverageAgeSummary.AutoSize = true;
            lblAverageAgeSummary.Location = new Point(458, 107);
            lblAverageAgeSummary.Name = "lblAverageAgeSummary";
            lblAverageAgeSummary.Size = new Size(29, 15);
            lblAverageAgeSummary.TabIndex = 23;
            lblAverageAgeSummary.Text = "N/A";
            // 
            // lblReleaseReadyCountSummary
            // 
            lblReleaseReadyCountSummary.AutoSize = true;
            lblReleaseReadyCountSummary.Location = new Point(458, 181);
            lblReleaseReadyCountSummary.Name = "lblReleaseReadyCountSummary";
            lblReleaseReadyCountSummary.Size = new Size(29, 15);
            lblReleaseReadyCountSummary.TabIndex = 22;
            lblReleaseReadyCountSummary.Text = "N/A";
            // 
            // lblTotalAnimalsSummary
            // 
            lblTotalAnimalsSummary.AutoSize = true;
            lblTotalAnimalsSummary.Location = new Point(458, 47);
            lblTotalAnimalsSummary.Name = "lblTotalAnimalsSummary";
            lblTotalAnimalsSummary.Size = new Size(29, 15);
            lblTotalAnimalsSummary.TabIndex = 21;
            lblTotalAnimalsSummary.Text = "N/A";
            lblTotalAnimalsSummary.Click += lblTotalAnimalsSummary_Click;
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(122, 231);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(90, 15);
            lblRecoveryScore.TabIndex = 23;
            lblRecoveryScore.Text = "Recovery Score:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(122, 202);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 24;
            lblAge.Text = "Age:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(122, 173);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(49, 15);
            lblSpecies.TabIndex = 25;
            lblSpecies.Text = "Species:";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(122, 115);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(62, 15);
            lblAnimalID.TabIndex = 27;
            lblAnimalID.Text = "Animal ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(122, 144);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 28;
            lblName.Text = "Name:";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblHeading1);
            panel2.Controls.Add(btnSaveChanges);
            panel2.Controls.Add(txtAnimaliD);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(lblName);
            panel2.Controls.Add(txtSpecies);
            panel2.Controls.Add(lblAnimalID);
            panel2.Controls.Add(txtAge);
            panel2.Controls.Add(lblSpecies);
            panel2.Controls.Add(txtRecoveryScore);
            panel2.Controls.Add(lblAge);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(lblRecoveryScore);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Location = new Point(0, 417);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 352);
            panel2.TabIndex = 29;
            // 
            // lblHeading1
            // 
            lblHeading1.AutoSize = true;
            lblHeading1.Location = new Point(11, 15);
            lblHeading1.Name = "lblHeading1";
            lblHeading1.Size = new Size(98, 15);
            lblHeading1.TabIndex = 29;
            lblHeading1.Text = "Add/Delete Rows";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(75, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 110);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // lblSearchByID
            // 
            lblSearchByID.AutoSize = true;
            lblSearchByID.Location = new Point(12, 359);
            lblSearchByID.Name = "lblSearchByID";
            lblSearchByID.Size = new Size(75, 15);
            lblSearchByID.TabIndex = 31;
            lblSearchByID.Text = "Search By ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1057, 768);
            Controls.Add(lblSearchByID);
            Controls.Add(pictureBox1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvAnimals);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private Label lblRecoveryScore;
        private Label lblAge;
        private Label lblSpecies;
        private Label lblAnimalID;
        private Label lblName;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblSearchByID;
        private Label lblCriticalCountSummary;
        private Label lblSeriousCountSummary;
        private Label lblRecoveryCountSummary;
        private Label lblStableCountSummary;
        private Label lblAverageScoreSummary;
        private Label lblAverageAgeSummary;
        private Label lblReleaseReadyCountSummary;
        private Label lblTotalAnimalsSummary;
        private Label lblHeading1;
        private Label lblHeading2;
    }
}
