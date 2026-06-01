using System.Drawing;
using System.Windows.Forms;

namespace StoreInventoryPos
{
    internal static class AppTheme
    {
        private static readonly HashSet<Form> ThemedForms = new();
        private static readonly Color Background = Color.FromArgb(245, 247, 251);
        private static readonly Color Panel = Color.White;
        private static readonly Color Primary = Color.FromArgb(35, 99, 235);
        private static readonly Color Danger = Color.FromArgb(220, 38, 38);
        private static readonly Color Text = Color.FromArgb(17, 24, 39);
        private static readonly Color Border = Color.FromArgb(209, 213, 219);

        public static void Apply(Form form)
        {
            if (!ThemedForms.Add(form))
            {
                return;
            }

            form.BackColor = Background;
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            foreach (Control control in form.Controls)
            {
                ApplyControl(control);
            }
        }

        private static void ApplyControl(Control control)
        {
            switch (control)
            {
                case Button button:
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.BackColor = IsDanger(button) ? Danger : Primary;
                    button.ForeColor = Color.White;
                    button.Font = new Font("Segoe UI Semibold", Math.Max(10F, button.Font.Size - 4F), FontStyle.Bold);
                    button.Cursor = Cursors.Hand;
                    break;
                case TextBox textBox:
                    textBox.BackColor = Panel;
                    textBox.ForeColor = Text;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = new Font("Segoe UI", 11F);
                    break;
                case ComboBox comboBox:
                    comboBox.BackColor = Panel;
                    comboBox.ForeColor = Text;
                    comboBox.FlatStyle = FlatStyle.Flat;
                    comboBox.Font = new Font("Segoe UI", 11F);
                    break;
                case DataGridView grid:
                    StyleGrid(grid);
                    break;
                case Label label:
                    label.ForeColor = Text;
                    label.BackColor = Color.Transparent;
                    if (label.Font.Size > 18F)
                    {
                        label.Font = new Font("Segoe UI Semibold", Math.Min(label.Font.Size, 24F), FontStyle.Bold);
                    }
                    break;
            }

            foreach (Control child in control.Controls)
            {
                ApplyControl(child);
            }
        }

        private static bool IsDanger(Button button)
        {
            string name = button.Name.ToLowerInvariant();
            string text = button.Text.ToLowerInvariant();
            return name.Contains("delete") || name.Contains("logout") || text.Contains("delete") || text.Contains("logout");
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Panel;
            grid.BorderStyle = BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Primary;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grid.DefaultCellStyle.BackColor = Panel;
            grid.DefaultCellStyle.ForeColor = Text;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor = Text;
            grid.GridColor = Border;
            grid.RowHeadersVisible = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
