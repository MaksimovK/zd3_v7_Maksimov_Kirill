using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace zd3_v7
{
    public partial class Form1 : Form
    {
        private List<Cable> cables = new List<Cable>();
        private Dictionary<string, EnhancedCable> enhancedCables = new Dictionary<string, EnhancedCable>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            cablesDataGridView.Columns.Add("Тип", "Тип");
            cablesDataGridView.Columns.Add("Кол-во жил", "Кол-во жил");
            cablesDataGridView.Columns.Add("Диаметр", "Диаметр");
            cablesDataGridView.Columns.Add("Длина", "Длина");
            cablesDataGridView.Columns.Add("Мощность тока", "Мощность тока");
            cablesDataGridView.Columns.Add("Наличие оплётки", "Наличие оплётки");
            cablesDataGridView.Columns.Add("Цвет оптёлки", "Цвет оплётки");
            cablesDataGridView.Columns.Add("Качество", "Качество");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }


        private void ClearInputFieldsCabel()
        {
            typeTextBox.Clear();
            numberOfWiresTextBox.Clear();
            diameterTextBox.Clear();
            pCheckBox.Checked = false;
            colorTextBox.Clear();
            lengthTextBox.Clear();
            currentStrengthTextBox.Clear();
        }

        private void addCable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeTextBox.Text) ||
                string.IsNullOrWhiteSpace(numberOfWiresTextBox.Text) ||
                string.IsNullOrWhiteSpace(diameterTextBox.Text) ||
                string.IsNullOrWhiteSpace(colorTextBox.Text) ||
                string.IsNullOrWhiteSpace(lengthTextBox.Text) ||
                string.IsNullOrWhiteSpace(currentStrengthTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (!int.TryParse(numberOfWiresTextBox.Text, out int numberOfWires) ||
                !double.TryParse(diameterTextBox.Text, out double diameter) ||
                !double.TryParse(lengthTextBox.Text, out double length) ||
                !double.TryParse(currentStrengthTextBox.Text, out double currentStrength))
            {
                MessageBox.Show("Неверный формат данных!");
                return;
            }

            bool checkType = typeTextBox.Text.All(Char.IsLetter);
            if (!checkType)
            {
                MessageBox.Show("Тип должен содержать только буквы!");
                return;
            }

            bool checkColor = typeTextBox.Text.All(Char.IsLetter);
            if (!checkColor)
            {
                MessageBox.Show("Цвет должен содержать только буквы!");
                return;
            }

            bool p = pCheckBox.Checked;
            string type = typeTextBox.Text;
            string color = colorTextBox.Text;

            if (cables.Any(c => c.Type == type))
            {
                MessageBox.Show($"Кабель с типом {type} уже есть! Введите другой тип");
                return;
            }

            EnhancedCable enhancedCable =
                new EnhancedCable(type, numberOfWires, diameter, length, currentStrength, p, color);
            Cable.AddCable(cables, enhancedCable);
            EnhancedCable.AddCable(enhancedCables, enhancedCable);

            cablesDataGridView.Rows.Add(enhancedCable.Type, enhancedCable.NumberOfWires, enhancedCable.Diameter,
                enhancedCable.Lenght, enhancedCable.CurrentStrength,
                enhancedCable.P, enhancedCable.Color, enhancedCable.GetQuality());
            ClearInputFieldsCabel();
        }

        private void removeCableButton_Click(object sender, EventArgs e)
        {
            if (cablesDataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = cablesDataGridView.SelectedRows[0].Index;
                Cable selectedCable = cables.ElementAt(selectedIndex);
                cables.Remove(selectedCable);

                EnhancedCable selectedEnhancedCable = enhancedCables.ElementAt(selectedIndex).Value;
                string key =
                    $"{selectedEnhancedCable.Type}-{selectedEnhancedCable.NumberOfWires}-{selectedEnhancedCable.Diameter}";
                enhancedCables.Remove(key);

                cablesDataGridView.Rows.RemoveAt(selectedIndex);
                cablesDataGridView.Refresh();
            }
            else if (cablesDataGridView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Строчек нет, нечего удалять!");
            }
            else
            {
                MessageBox.Show("Выберите строчку!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}