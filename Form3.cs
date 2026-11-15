using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CLAVIOMICA_INVENTORY
{
    public partial class Form3 : Form
    {
        private readonly Color navigationDefaultColor = Color.Transparent;
        private readonly Color navigationHoverColor = Color.FromArgb(52, 110, 160);
        private readonly Color navigationActiveColor = Color.FromArgb(65, 125, 180);
        private readonly Color navigationTextColor = Color.FromArgb(31, 78, 121);
        private readonly List<Control> dashboardControls = new();
        private Button? activeNavigationButton;
        private Product? productView;
        private Panel inventoryChartPanel => panel3;

        public Form3()
        {
            InitializeComponent();

            foreach (Control control in panel.Controls)
            {
                dashboardControls.Add(control);
            }

            ConfigureNavigationButtons();
            LoadDashboardSummary();
        }

        private void ConfigureNavigationButtons()
        {
            Button[] navigationButtons = { btnDashboard, btnProducts, btnReports, btnSettings, btnUsers, button3 };

            foreach (Button navigationButton in navigationButtons)
            {
                navigationButton.BackColor = navigationDefaultColor;
                navigationButton.ForeColor = navigationTextColor;
                navigationButton.FlatAppearance.MouseOverBackColor = navigationHoverColor;
                navigationButton.FlatAppearance.MouseDownBackColor = navigationActiveColor;
                navigationButton.Click += NavigationButton_Click;
                navigationButton.MouseEnter += NavigationButton_MouseEnter;
                navigationButton.MouseLeave += NavigationButton_MouseLeave;
            }

            SetActiveNavigationButton(btnDashboard);
        }

        private void NavigationButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button navigationButton)
            {
                SetActiveNavigationButton(navigationButton);

                if (navigationButton == btnDashboard)
                {
                    ShowDashboardPage();
                }
                else if (navigationButton == btnProducts)
                {
                    ShowProductsPage();
                }
            }
        }

        private void ShowProductsPage()
        {
            foreach (Control control in dashboardControls)
            {
                control.Visible = false;
            }

            if (productView is null)
            {
                productView = new Product
                {
                    Dock = DockStyle.Fill,
                    Margin = Padding.Empty,
                    Name = "productView",
                    BackColor = Color.Lavender
                };

                panel.Controls.Add(productView);
            }

            productView.Visible = true;
            productView.BringToFront();
        }

        private void ShowDashboardPage()
        {
            if (productView is not null)
            {
                panel.Controls.Remove(productView);
                productView.Dispose();
                productView = null;
            }

            foreach (Control control in dashboardControls)
            {
                control.Visible = true;
            }

            LoadDashboardSummary();
        }

        private void LoadDashboardSummary()
        {
            try
            {
                Database.EnsureProductsTable();
                using OleDbConnection connection = Database.GetConnection();
                connection.Open();
                using OleDbCommand command = connection.CreateCommand();
                command.CommandText = "SELECT ProductName, Category, Status FROM Products";

                DataTable products = new();
                using OleDbDataAdapter adapter = new(command);
                adapter.Fill(products);

                int totalProducts = products.Rows.Count;
                int lowStockProducts = products.AsEnumerable().Count(row =>
                    string.Equals(row.Field<string>("Status"), "Low Stock", StringComparison.OrdinalIgnoreCase));
                int totalCategories = products.AsEnumerable()
                    .Select(row => row.Field<string>("Category"))
                    .Where(category => !string.IsNullOrWhiteSpace(category))
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .Count();

                lblPValue.Text = totalProducts.ToString();
                lblLSt.Text = lowStockProducts.ToString();
                lblLowStockValue.Text = totalCategories.ToString();
            }
            catch (OleDbException ex)
            {
                ShowDashboardDatabaseError(ex);
            }
            catch (InvalidOperationException ex)
            {
                ShowDashboardDatabaseError(ex);
            }
        }

        private static void ShowDashboardDatabaseError(Exception ex)
        {
            MessageBox.Show(
                $"Dashboard data could not be loaded: {ex.Message}",
                "Dashboard",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void NavigationButton_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Button navigationButton && navigationButton != activeNavigationButton)
            {
                navigationButton.BackColor = navigationHoverColor;
            }
        }

        private void NavigationButton_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button navigationButton && navigationButton != activeNavigationButton)
            {
                navigationButton.BackColor = navigationDefaultColor;
            }
        }

        private void SetActiveNavigationButton(Button selectedButton)
        {
            Button[] navigationButtons = { btnDashboard, btnProducts, btnReports, btnSettings, btnUsers, button3 };

            foreach (Button navigationButton in navigationButtons)
            {
                bool isSelected = navigationButton == selectedButton;
                navigationButton.BackColor = isSelected ? navigationActiveColor : navigationDefaultColor;
                navigationButton.ForeColor = isSelected ? Color.White : navigationTextColor;
            }

            activeNavigationButton = selectedButton;
        }

        private void inventoryChartPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int left = 38;
            int top = 10;
            int right = inventoryChartPanel.ClientSize.Width - 12;
            int bottom = inventoryChartPanel.ClientSize.Height - 30;
            int chartWidth = right - left;
            int chartHeight = bottom - top;
            string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            int[] values = { 62, 70, 58, 80, 74, 91, 85 };

            using Pen gridPen = new(Color.FromArgb(225, 230, 235));
            using Pen axisPen = new(Color.FromArgb(150, 160, 170), 1.2F);
            using Pen linePen = new(Color.FromArgb(31, 120, 180), 2.5F);
            using Brush pointBrush = new SolidBrush(Color.FromArgb(31, 120, 180));
            using Brush labelBrush = new SolidBrush(Color.FromArgb(90, 100, 110));
            using Font labelFont = new("Segoe UI", 8.5F);

            for (int index = 0; index <= 4; index++)
            {
                float y = top + chartHeight * index / 4F;
                graphics.DrawLine(gridPen, left, y, right, y);
            }

            graphics.DrawLine(axisPen, left, top, left, bottom);
            graphics.DrawLine(axisPen, left, bottom, right, bottom);

            PointF[] points = new PointF[values.Length];
            for (int index = 0; index < values.Length; index++)
            {
                float x = left + chartWidth * index / (values.Length - 1F);
                float y = bottom - chartHeight * values[index] / 100F;
                points[index] = new PointF(x, y);

                SizeF labelSize = graphics.MeasureString(days[index], labelFont);
                graphics.DrawString(days[index], labelFont, labelBrush, x - labelSize.Width / 2F, bottom + 7);
            }

            graphics.DrawLines(linePen, points);
            foreach (PointF point in points)
            {
                graphics.FillEllipse(pointBrush, point.X - 4, point.Y - 4, 8, 8);
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(btnProducts);
            ShowProductsPage();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(btnReports);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(btnSettings);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(btnUsers);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetActiveNavigationButton(button3);
        }

        private void lblProductsValue_Click(object sender, EventArgs e)
        {

        }

        private void activityOne_Click(object sender, EventArgs e)
        {

        }

        private void inventoryOverviewTitle_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
