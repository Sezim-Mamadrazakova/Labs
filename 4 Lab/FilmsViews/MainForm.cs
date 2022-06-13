using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace FilmsViews
{
    public partial class MainForm : Form
    {
        Assembly assembly;
        IEnumerable<Type> types;
        Type currentType;
        object currentObject;
        MethodInfo currentMethod;
        object[] methodParameters;

        public MainForm()
        {
            InitializeComponent();
            comboBoxMethod.Enabled = false;
            buttonExecute.Enabled = false;
            buttonEnter.Enabled = false;
            buttonCreate.Enabled = false;
        }

   
        private void MainForm_Load(object sender, EventArgs e)
        {
            assembly = Assembly.Load("FilmsModels");
            types = assembly.GetTypes().Where(type => !type.IsAbstract && type.GetInterface("IFilm") != null);
            comboBoxClass.Items.AddRange(types.Select(type => type.Name).ToArray());
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonCreate.Enabled = true;
            buttonEnter.Enabled = false;
            buttonExecute.Enabled = false;
            listBoxMethod.Items.Clear();
            listBoxClass.Items.Clear();
            comboBoxMethod.Items.Clear();
            currentType = types.First(type => type.Name == comboBoxClass.SelectedItem.ToString());
            currentObject = null;

            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);
            comboBoxMethod.Items.AddRange(currentType.GetMethods().Where(method => !objectMethods.Contains(method.Name)
                && !method.Name.Contains("get_") && !method.Name.Contains("set_")).Select(method => method.Name).ToArray());

            comboBoxMethod.Enabled = false;
            buttonCreate.Enabled = true;
        }

        private void comboBoxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

            currentMethod = currentType.GetMethods()
                .First(method => method.Name == comboBoxMethod.SelectedItem.ToString());
            methodParameters = null;

            buttonExecute.Enabled = false;

            if (currentMethod.GetParameters().Length == 0)
            {
                buttonEnter.Enabled = false;
                buttonExecute.Enabled = currentObject != null;
            }
            else
            {
                buttonEnter.Enabled = true;
                buttonExecute.Enabled = false;
            }

            listBoxMethod.Items.Clear();
            foreach (ParameterInfo info in currentMethod.GetParameters())
            {
                listBoxMethod.Items.Add(info.Name);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            listBoxClass.Items.Clear();
            comboBoxMethod.Enabled = true;
            buttonExecute.Enabled = false;
            buttonEnter.Enabled = false;

            MessageBox.Show("Введите объект класса " + currentType.Name);
            object newObject = Activator.CreateInstance(currentType);

            Form addForm = new Form();
            addForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            addForm.MaximizeBox = false;
            addForm.MinimizeBox = false;
            addForm.ClientSize = new Size(400, 200);

            int coordinate = 0;
            foreach (PropertyInfo info in newObject.GetType().GetProperties())
            {
                Label label = new Label { Top = coordinate, Left = 0, Width = addForm.ClientSize.Width / 2, Height = 20 };
                label.Text = info.Name;

                TextBox textBox = new TextBox { Top = coordinate, Left = label.Width, Width = label.Width, Height = 20 };
                textBox.Text = "0";

                addForm.Controls.Add(label);
                addForm.Controls.Add(textBox);
                coordinate += label.Height + 5;
            }

            addForm.Controls.Add(new Button() { Top = 150, Left = 130, Width = 100, Height = 50, Text = "Подтвердить" });
            addForm.Controls[addForm.Controls.Count - 1].Click +=
                new EventHandler(
                    (object sender2, EventArgs e2) =>
                    {
                        addForm.DialogResult = DialogResult.OK; addForm.Close();
                    });

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                PropertyInfo[] properties = newObject.GetType().GetProperties();
                for (int i = 1, j = 0; i < addForm.Controls.Count; i += 2, j++)
                {
                    string value = addForm.Controls[i].Text;
                    if (value.Length != 0)
                    {
                        if (properties[j].PropertyType.Name == "Int32")
                        {
                            properties[j].SetValue(newObject, Int32.Parse(value));
                        }
                        else if (properties[j].PropertyType.Name == "Double")
                        {
                            properties[j].SetValue(newObject, double.Parse(value));
                        }
                        else
                        {
                            properties[j].SetValue(newObject, value);
                        }
                    }
                }
            }

            currentObject = newObject;
            foreach (PropertyInfo info in currentType.GetProperties())
            {
                listBoxClass.Items.Add(info.Name + ": " + info.GetValue(currentObject));
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (comboBoxMethod.SelectedIndex != -1)
            {
                listBoxMethod.Items.Clear();
                if (currentMethod.GetParameters().Length != 0)
                {
                    var parametersList = new List<object>();

                    foreach (var it in currentMethod.GetParameters())
                    {
                        if (it.ParameterType.Name == "Int32")
                        {
                            InputString inputForm = new InputString("Введите " + it.Name);
                            inputForm.ShowDialog();
                            int number;
                            while (!int.TryParse(inputForm.Value, out number))
                            {
                                MessageBox.Show("Введите целое число!", "Ошибка ввода", MessageBoxButtons.OK);
                                inputForm.ShowDialog();
                            }

                            parametersList.Add(number);
                            listBoxMethod.Items.Add(it.Name + ": " + number);

                        }
                        else if (it.ParameterType.Name == "Double")
                        {
                            InputString inputForm = new InputString("Введите " + it.Name);
                            inputForm.ShowDialog();
                            double number;
                            while (!double.TryParse(inputForm.Value,out  number))
                            {
                                MessageBox.Show("Введите число!", "Ошибка ввода", MessageBoxButtons.OK);
                                inputForm.ShowDialog();
                            }
                            parametersList.Add(number);
                            listBoxMethod.Items.Add(it.Name + ": " + number);
                        }
                        else
                        {
                            InputString inputForm = new InputString("Введите " + it.Name);
                            inputForm.ShowDialog();
                            string str = inputForm.Value;
                            parametersList.Add(str);
                            listBoxMethod.Items.Add(it.Name + ": " + str);
                        }
                    }
                    methodParameters = parametersList.Select(x => x).ToArray();
                    buttonExecute.Enabled = true;

                }
                else
                {
                    methodParameters = null;
                }
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (listBoxMethod.Text.Length == 0 || listBoxMethod.SelectedIndex != -1)
            {
                if (currentMethod.GetParameters().Length != 0 && methodParameters == null)
                {
                    MessageBox.Show("Сначала введите параметры.");
                }
                else
                {
                    if (currentMethod.ReturnType == typeof(void))
                    {
                        currentMethod.Invoke(currentObject, methodParameters);
                        MessageBox.Show("Метод выполнен.");
                    }
                    else
                    {
                        MessageBox.Show(currentMethod.Invoke(currentObject, methodParameters).ToString());
                    }

                    listBoxClass.Items.Clear();
                    foreach (PropertyInfo info in currentType.GetProperties())
                    {
                        listBoxClass.Items.Add(info.Name + ": " + info.GetValue(currentObject));
                    }
                }
            }
            else
            {
                MessageBox.Show("Создайте объект и выберите метод.");
            }
        }
    }
}
