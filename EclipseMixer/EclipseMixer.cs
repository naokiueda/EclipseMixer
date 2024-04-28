using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.IO;

namespace EclipseBlender
{
    public partial class EclipseMixer : Form
    {
        public EclipseMixer()
        {
            InitializeComponent();
        }

        private void button_FOD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //[ファイルの種類]に表示される選択肢を指定する
            ofd.Filter = "CSV file(*.csv)|*.csv|All files(*.*)|*.*";
            ofd.Title = "Select CSV";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_instructionFIlePath.Text = ofd.FileName;
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            string instructionFilePath = textBox_instructionFIlePath.Text;
            if (!File.Exists(instructionFilePath))
            {
                MessageBox.Show("Instruction File does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double ratio = 0.85;
            if (!double.TryParse(textBox_ratio.Text, out ratio)){
                MessageBox.Show("Invalid Mix Ratio. Please set between 0 and 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ratio <= 0 || ratio >= 1)
            {
                MessageBox.Show("Invalid Mix Ratio. Please set between 0 and 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            doProcess(instructionFilePath, ratio);

        }

        private void doProcess(string instructionFilePath, double ratio)
        {
            panel_progress.Visible = true;
            List<string> baseFiles = new List<string>();
            List<string> sunFiles = new List<string>();
            List<string> outFiles = new List<string>();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(instructionFilePath,System.Text.Encoding.GetEncoding("shift_jis")))
            {
                //内容を一行ずつ読み込む
                while (sr.Peek() > -1)
                {
                    string[] files = sr.ReadLine().Split(',');
                    if (files.Length == 3)
                    {
                        if(radioButton_overwrite.Checked || !File.Exists(files[2]))
                        {
                            baseFiles.Add(files[0]);
                            sunFiles.Add(files[1]);
                            outFiles.Add(files[2]);
                        }
                    }
                }
            }

            Blender bl = new Blender();
            for(int fidx=0; fidx<baseFiles.Count; fidx++)
            {
                string b = baseFiles[fidx];
                string s = sunFiles[fidx];
                string o = Path.GetDirectoryName(outFiles[fidx])+ "\\" + Path.GetFileName(outFiles[fidx]);

                progressBar1.Value = (int)(100 * (double)(fidx+1) / (double)baseFiles.Count);
                label_progress.Text = (fidx+1).ToString() + "/" + baseFiles.Count.ToString();
                label_BaseFile.Text = Path.GetFileName(b);
                label_SunShape.Text = Path.GetFileName(s);
                label_output.Text = Path.GetFileName(o);
                Application.DoEvents();

                if(File.Exists(o))
                {
                    if (radioButton_overwrite.Checked)
                    {
                        File.Delete(o);
                    }
                    else
                    {
                        //Error
                        continue;
                    }
                }
                bl.mixThem(b,s,o, ratio);
            }
            MessageBox.Show("Process Completed", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panel_progress.Visible = false;
        }
    }
}
