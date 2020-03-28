using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace YOLO_TO_AUTOML
{
    public partial class Form1 : Form
    {
        String[] labelMaps;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] yoloTxts = Directory.GetFiles(localPath.Text, "*.txt");
            String outputLines = "";
            labelMaps = labelMap.Text.Replace("\r","").Split('\n');
            foreach (String yoloTxt in yoloTxts)
            {
                FileInfo yoloTxtFile = new FileInfo(yoloTxt);
                String[] yoloAnno = File.ReadAllLines(yoloTxt);
                outputLines += "TRAIN," +gsPath.Text + "/" + yoloTxtFile.Name.Replace(".txt","") + gsPathAppend.Text + ".jpg," + ((yoloAnno.Length>0)?Convert(yoloAnno[0]):"") + "\n";
            }
            WriteCsv(outputLines);
        }

        private String Convert(String line)
        {
            String className;
            Double x, y, w, h;
            String[] yoloFormattedBox = line.Split(' ');
            className = yoloFormattedBox[0];
            x = Double.Parse(yoloFormattedBox[1]);
            y = Double.Parse(yoloFormattedBox[2]);
            w = Double.Parse(yoloFormattedBox[3]);
            h = Double.Parse(yoloFormattedBox[4]);
            return labelMaps[int.Parse(className)] + "," +
                Math.Round( (x - w/2) , 2) + "," + Math.Round( (y - h/2) , 2) + "," + Math.Round( (x + w/2) , 2) + "," +
                Math.Round( (y - h / 2) , 2) + "," + Math.Round((x + w / 2), 2) + "," + Math.Round((y + h / 2), 2) + "," +
                Math.Round((x - w / 2), 2) + "," + Math.Round((y + h / 2), 2);
        }

        private void WriteCsv(String outputLines)
        {
            File.WriteAllText(csvPath.Text, outputLines);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/goraegori/yolo-to-automl/README.md");
        }

        private void label2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.EnsurePathExists = true;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                localPath.Text = dialog.FileName;
            }
        }

        private void label3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV|*.csv";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                csvPath.Text = dialog.FileName;
            }
        }

        private void label5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Labelmap txt file|*.txt";
            dialog.CheckFileExists = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                labelMap.Text = File.ReadAllText(dialog.FileName);
            }
        }
    }
}
