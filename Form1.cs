using BaobabWildlifeRehab.BusinessLogic;
using BaobabWildlifeRehab.Data;
using BaobabWildlifeRehab.Models;
using System.Drawing;
using System.Windows.Forms;

namespace BaobabWildlifeRehab
{
    public partial class Form1 : Form
    {
        private readonly DataHandler handler = new DataHandler();

        private readonly TextBox txtId = new();
        private readonly TextBox txtName = new();
        private readonly TextBox txtSpecies = new();
        private readonly TextBox txtAge = new();
        private readonly TextBox txtScore = new();
        private readonly TextBox txtStatus = new();
        private readonly TextBox txtHousingUnit = new();
        private readonly TextBox txtSearch = new();
        private readonly Button btnSearch = new();
        private readonly Button btnAdd = new();
        private readonly Button btnSaveChanges = new();
        private readonly Button btnClear = new();
        private readonly DataGridView gridAnimals = new();
        private readonly Label lblMessage = new();

        private string? editingId;
        private bool isEditMode;

        public Form1()
        {
            InitializeComponent();
            Text = "Baobab Wildlife Rehabilitation - Animal Records";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1220, 760);
            MinimumSize = new Size(1000, 650);

            BuildInterface();
            WireEvents();
            gridAnimals.DataSource = handler.DataSource;
            SetEditMode(false);
            LoadAnimals();
        }

        private void BuildInterface()
        {
            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(12),
                ColumnCount = 1,
                RowCount = 4
            };
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 46));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 54));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 28));

            var heading = new Label
            {
                Text = "Baobab Wildlife Rehabilitation | Animal Records",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 17, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };
            root.Controls.Add(heading, 0, 0);

            var searchPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(0, 8, 0, 4),
                AutoScroll = true
            };
            searchPanel.Controls.Add(new Label
            {
                Text = "Search by Animal ID:",
                AutoSize = false,
                Width = 145,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0, 0, 8, 0)
            });
            txtSearch.Width = 260;
            txtSearch.Height = 30;
            txtSearch.Margin = new Padding(0, 0, 8, 0);
            searchPanel.Controls.Add(txtSearch);
            btnSearch.Text = "Search";
            btnSearch.Width = 94;
            btnSearch.Height = 30;
            btnSearch.Margin = new Padding(0, 0, 8, 0);
            searchPanel.Controls.Add(btnSearch);
            root.Controls.Add(searchPanel, 0, 1);

            var split = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Size = new Size(1150, 620),
                Orientation = Orientation.Vertical,
                Panel1MinSize = 340,
                Panel2MinSize = 600,
                SplitterDistance = 365,
                FixedPanel = FixedPanel.Panel1
            };
            root.Controls.Add(split, 0, 2);

            var editor = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(8),
                ColumnCount = 2,
                RowCount = 9
            };
            editor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37));
            editor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63));
            editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            for (int row = 1; row <= 7; row++)
                editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 43));
            editor.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var editorHeading = new Label
            {
                Text = "Animal Details",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };
            editor.Controls.Add(editorHeading, 0, 0);
            editor.SetColumnSpan(editorHeading, 2);

            AddEditorRow(editor, 1, "Animal ID:", txtId);
            AddEditorRow(editor, 2, "Name:", txtName);
            AddEditorRow(editor, 3, "Species:", txtSpecies);
            AddEditorRow(editor, 4, "Age:", txtAge);
            AddEditorRow(editor, 5, "Recovery Score:", txtScore);
            AddEditorRow(editor, 6, "Status:", txtStatus);
            AddEditorRow(editor, 7, "Housing Unit:", txtHousingUnit);

            ConfigureTextBox(txtId);
            ConfigureTextBox(txtName);
            ConfigureTextBox(txtSpecies);
            ConfigureTextBox(txtAge);
            ConfigureTextBox(txtScore);
            ConfigureTextBox(txtStatus);
            ConfigureTextBox(txtHousingUnit);
            txtStatus.ReadOnly = true;
            txtHousingUnit.ReadOnly = true;
            txtStatus.BackColor = SystemColors.Control;
            txtHousingUnit.BackColor = SystemColors.Control;

            var actionPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(0, 10, 0, 0),
                Margin = new Padding(0)
            };
            btnAdd.Text = "Add";
            btnAdd.Width = 72;
            btnAdd.Height = 34;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.Width = 112;
            btnSaveChanges.Height = 34;
            btnClear.Text = "Clear";
            btnClear.Width = 72;
            btnClear.Height = 34;
            actionPanel.Controls.Add(btnAdd);
            actionPanel.Controls.Add(btnSaveChanges);
            actionPanel.Controls.Add(btnClear);
            editor.Controls.Add(actionPanel, 0, 8);
            editor.SetColumnSpan(actionPanel, 2);
            split.Panel1.Controls.Add(editor);

            var records = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(8),
                ColumnCount = 1,
                RowCount = 2
            };
            records.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            records.RowStyles.Add(new RowStyle(SizeType.Absolute, 38));
            records.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            records.Controls.Add(new Label
            {
                Text = "Registered Animals (select a row to edit)",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            }, 0, 0);

            gridAnimals.Dock = DockStyle.Fill;
            gridAnimals.ReadOnly = true;
            gridAnimals.AllowUserToAddRows = false;
            gridAnimals.AllowUserToDeleteRows = false;
            gridAnimals.AllowUserToOrderColumns = true;
            gridAnimals.AutoGenerateColumns = true;
            gridAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridAnimals.MultiSelect = false;
            gridAnimals.RowHeadersVisible = false;
            gridAnimals.BackgroundColor = SystemColors.Window;
            records.Controls.Add(gridAnimals, 0, 1);
            split.Panel2.Controls.Add(records);

            lblMessage.Dock = DockStyle.Fill;
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            lblMessage.AutoEllipsis = true;
            lblMessage.ForeColor = SystemColors.ControlText;
            root.Controls.Add(lblMessage, 0, 3);
            Controls.Add(root);
        }

        private static void ConfigureTextBox(TextBox textBox)
        {
            textBox.Dock = DockStyle.Fill;
            textBox.Margin = new Padding(3, 7, 3, 7);
        }

        private static void AddEditorRow(TableLayoutPanel layout, int row, string labelText, Control control)
        {
            layout.Controls.Add(new Label
            {
                Text = labelText,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            }, 0, row);
            layout.Controls.Add(control, 1, row);
        }

        private void WireEvents()
        {
            btnSearch.Click += (_, _) => SearchAnimal();
            txtSearch.KeyDown += (_, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SearchAnimal();
                }
            };
            btnAdd.Click += (_, _) => AddAnimal();
            btnSaveChanges.Click += (_, _) => SaveChanges();
            btnClear.Click += (_, _) => ClearForm();
            gridAnimals.CellClick += GridAnimals_CellClick;
            txtScore.TextChanged += (_, _) => UpdateCalculatedPreview();
        }

        private void LoadAnimals()
        {
            try
            {
                int skipped = handler.Load();
                lblMessage.Text = skipped == 0
                    ? "Records loaded. Select a grid row or search by ID to edit an animal."
                    : $"Records loaded. {skipped} malformed line(s) in animals.txt were skipped.";
            }
            catch (DataAccessException ex)
            {
                ShowDataError(ex);
            }
        }

        private void SearchAnimal()
        {
            string id = txtSearch.Text.Trim();
            if (id.Length == 0)
            {
                lblMessage.Text = "Enter an Animal ID to search.";
                txtSearch.Focus();
                return;
            }

            try
            {
                Animal? animal = handler.FindById(id);
                if (animal is null)
                {
                    lblMessage.Text = $"No animal with ID '{id}' was found.";
                    gridAnimals.ClearSelection();
                    return;
                }

                LoadAnimalForEditing(animal);
                SelectGridRowById(animal.Id);
                lblMessage.Text = $"Animal '{animal.Id}' loaded. Edit the details and select Save Changes.";
            }
            catch (DataAccessException ex)
            {
                ShowDataError(ex);
            }
        }

        private void GridAnimals_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= gridAnimals.Rows.Count)
                return;

            if (gridAnimals.Rows[e.RowIndex].DataBoundItem is Animal animal)
            {
                LoadAnimalForEditing(animal);
                lblMessage.Text = $"Editing animal '{animal.Id}'. The ID cannot be changed.";
            }
        }

        private void LoadAnimalForEditing(Animal animal)
        {
            editingId = animal.Id;
            txtId.Text = animal.Id;
            txtName.Text = animal.Name;
            txtSpecies.Text = animal.Species;
            txtAge.Text = animal.Age.ToString();
            txtScore.Text = animal.RecoveryScore.ToString();
            txtStatus.Text = animal.Status;
            txtHousingUnit.Text = animal.HousingUnit;
            SetEditMode(true);
        }

        private void AddAnimal()
        {
            if (isEditMode)
                return;

            try
            {
                Animal added = handler.Add(txtId.Text, txtName.Text, txtSpecies.Text, txtAge.Text, txtScore.Text);
                handler.Load();
                ClearForm();
                lblMessage.Text = $"Animal '{added.Id}' was added successfully.";
            }
            catch (ValidationException ex)
            {
                ShowValidationError(ex);
            }
            catch (DataAccessException ex)
            {
                ShowDataError(ex);
            }
        }

        private void SaveChanges()
        {
            if (!isEditMode || string.IsNullOrWhiteSpace(editingId))
            {
                lblMessage.Text = "Select an existing animal before saving changes.";
                return;
            }

            try
            {
                // Use the selected animal's original ID; the ID field is not editable.
                Animal updated = handler.Update(editingId, txtName.Text, txtSpecies.Text, txtAge.Text, txtScore.Text);
                LoadAnimalForEditing(updated);
                SelectGridRowById(updated.Id);
                lblMessage.Text = $"Changes to animal '{updated.Id}' were saved.";
            }
            catch (ValidationException ex)
            {
                ShowValidationError(ex);
            }
            catch (DataAccessException ex)
            {
                ShowDataError(ex);
            }
        }

        private void ClearForm()
        {
            editingId = null;
            txtId.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtScore.Clear();
            txtStatus.Clear();
            txtHousingUnit.Clear();
            txtSearch.Clear();
            gridAnimals.ClearSelection();
            SetEditMode(false);
            lblMessage.Text = "Ready to add a new animal.";
            txtId.Focus();
        }

        private void SetEditMode(bool enabled)
        {
            isEditMode = enabled;
            txtId.ReadOnly = enabled;
            txtId.BackColor = enabled ? SystemColors.Control : SystemColors.Window;
            btnAdd.Enabled = !enabled;
            btnSaveChanges.Enabled = enabled;
            if (!enabled)
                editingId = null;
            UpdateCalculatedPreview();
        }

        private void UpdateCalculatedPreview()
        {
            if (int.TryParse(txtScore.Text.Trim(), out int score) && score >= 0 && score <= 100)
            {
                (string status, string housingUnit) = DataHandler.Classify(score);
                txtStatus.Text = status;
                txtHousingUnit.Text = housingUnit;
            }
            else if (!isEditMode || txtScore.Focused)
            {
                txtStatus.Clear();
                txtHousingUnit.Clear();
            }
        }

        private void SelectGridRowById(string id)
        {
            foreach (DataGridViewRow row in gridAnimals.Rows)
            {
                if (row.DataBoundItem is Animal animal &&
                    string.Equals(animal.Id, id, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    if (row.Cells.Count > 0)
                        gridAnimals.CurrentCell = row.Cells[0];
                    return;
                }
            }
        }

        private void ShowValidationError(ValidationException ex)
        {
            lblMessage.Text = ex.Message;
            MessageBox.Show(this, ex.Message, "Check the animal details", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Control? target = ex.FieldName.ToLowerInvariant() switch
            {
                "id" => txtId,
                "name" => txtName,
                "species" => txtSpecies,
                "age" => txtAge,
                "score" => txtScore,
                _ => null
            };
            target?.Focus();
            if (target is TextBox textBox)
                textBox.SelectAll();
        }

        private void ShowDataError(DataAccessException ex)
        {
            lblMessage.Text = ex.Message;
            MessageBox.Show(this, ex.Message, "Animal data could not be accessed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
