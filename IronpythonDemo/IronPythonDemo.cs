using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Scripting.Hosting;

namespace IronpythonDemo
{
    public partial class IronPythonDemo : Form
    {
        public IronPythonDemo()
        {
            InitializeComponent();
        }

        private string _scriptDir = "script\\";
        private void RefreshScriptName()
        {
            comboBoxScript.Items.Clear();
            string[] files = Directory.GetFiles(_scriptDir, "*.py");
            foreach (string file in files)
            {
                string fileName = file.Substring(_scriptDir.Length);

                comboBoxScript.Items.Add(fileName.Remove(fileName.Length - 3, 3));
            }
            comboBoxScript.SelectedIndex = 0;
        }

        private bool ScriptRun(string fileName)
        {
            bool success = false;
            var engine = IronPython.Hosting.Python.CreateEngine();
            try
            {
                var source = engine.CreateScriptSourceFromFile(fileName);


                dynamic result = source.Execute();
                success = true;
            }
            catch (System.Exception ex)
            {
                var eo = engine.GetService<ExceptionOperations>();
                var eoString = eo.FormatException(ex);
                Console.WriteLine(eoString);
                if (ex.Message != "SystemExit")
                {
                    MessageBox.Show(eoString, ex.Message, // ex.GetType().ToString(),
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                success = false;
            }
            return success;
        }
        private void IronPythonDemo_Load(object sender, EventArgs e)
        {
            RefreshScriptName();
            DataManage.ShowData = "";
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshScriptName();
        }
        private void buttonScriptRun_Click(object sender, EventArgs e)
        {
            ScriptRun(_scriptDir + comboBoxScript.Text + ".py");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (richTextBoxShow.Text != DataManage.ShowData)
            {
                richTextBoxShow.Text = DataManage.ShowData;
            }
        }
    }
}
