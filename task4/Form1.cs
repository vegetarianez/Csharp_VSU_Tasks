using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


public partial class Form1 : Form
{
    private MainViewModel _viewModel = new MainViewModel();

    public Form1()
    {
        InitializeComponent();
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        try
        {
            _viewModel.LoadLibrary(txtPath.Text);
            lstClasses.DataSource = _viewModel.AvailableTypes;
            lstClasses.DisplayMember = "Name";
        }
        catch (Exception ex) { MessageBox.Show("Ошибка: " + ex.Message); }
    }

    private void lstClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstClasses.SelectedItem is Type selectedType)
        {
            GenerateParamInputs(selectedType.GetConstructors()[0]);

            var methods = selectedType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Select(m => m.Name).ToList();
            lstMethods.DataSource = methods;
        }
    }

    private void GenerateParamInputs(MethodBase method)
    {
        pnlParams.Controls.Clear();
        var parameters = method.GetParameters();
        int y = 10;
        foreach (var p in parameters)
        {
            Label lbl = new Label { Text = $"{p.Name} ({p.ParameterType.Name}):", Top = y, Left = 10 };
            TextBox txt = new TextBox { Top = y, Left = 150, Name = "param_" + p.Name, Tag = p.ParameterType };
            pnlParams.Controls.Add(lbl);
            pnlParams.Controls.Add(txt);
            y += 30;
        }
    }

    private void btnExecute_Click(object sender, EventArgs e)
    {
        try
        {
            if (lstClasses.SelectedItem is Type selectedType)
            {
                List<object> ctorArgs = new List<object>();
                foreach (Control ctrl in pnlParams.Controls)
                {
                    if (ctrl is TextBox txt)
                    {
                        Type targetType = (Type)txt.Tag;
                        object value = Convert.ChangeType(txt.Text, targetType);
                        ctorArgs.Add(value);
                    }
                }

                object instance = Activator.CreateInstance(selectedType, ctorArgs.ToArray());


                string methodName = lstMethods.SelectedItem.ToString();
                MethodInfo method = selectedType.GetMethod(methodName);


                object result = method.Invoke(instance, null);


                int currentAltitude = (int)selectedType.GetMethod("GetAltitude").Invoke(instance, null);
                lblResult.Text = $"Результат: {result}. Высота: {currentAltitude}";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка выполнения: " + (ex.InnerException?.Message ?? ex.Message));
        }
    }

    private object[] GetParamsFromUI()
    {
        List<object> args = new List<object>();
        foreach (Control ctrl in pnlParams.Controls)
        {
            if (ctrl is TextBox txt)
            {
                Type targetType = (Type)txt.Tag;
                args.Add(Convert.ChangeType(txt.Text, targetType));
            }
        }
        return args.ToArray();
    }

    private void lstClasses_SelectedIndexChanged_1(object sender, EventArgs e)
    {
        
        if (lstClasses.SelectedItem is Type selectedType)
        {
            var methods = selectedType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            lstMethods.DataSource = methods.Select(m => m.Name).ToList();

            pnlParams.Controls.Clear();
            var ctor = selectedType.GetConstructors()[0];
            var parameters = ctor.GetParameters();

            int y = 10;
            foreach (var p in parameters)
            {
                Label lbl = new Label { Text = $"{p.Name}:", Top = y, Left = 5, Width = 100 };
                TextBox txt = new TextBox { Top = y, Left = 110, Width = 100, Name = "param_" + p.Name };
                txt.Tag = p.ParameterType;

                pnlParams.Controls.Add(lbl);
                pnlParams.Controls.Add(txt);
                y += 30;
            }
        }
        
    }
}
