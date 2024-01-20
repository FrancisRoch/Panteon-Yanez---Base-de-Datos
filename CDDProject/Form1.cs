using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace CDDProject
{
    public class MyCsvClassMap : ClassMap<MyDataModel>
    {
        public MyCsvClassMap()
        {
            Map(m => m.Nombre).Name("Nombre del difunto");
            Map(m => m.Fecha).Name("Fecha").TypeConverterOption.Format("dd-MM-yyyy");
            Map(m => m.Bloque).Name("Bloque");
            Map(m => m.Manzana).Name("Manzana");
            Map(m => m.Lote).Name("Lote");
        }
    }

    public class MyDataModel
    {
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Bloque { get; set; }
        public int Manzana { get; set; }
        public string Lote { get; set; }
    }

    public partial class mainprog : Form
    {
        string[] files;
        public mainprog()
        {
            InitializeComponent();
        }

        static void ConvertToExcel(string inputFile, string outputFolder)
        {
            
            List<MyDataModel> records = new List<MyDataModel>();

            using (StreamReader reader = new StreamReader(inputFile))
            using (CsvReader csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false }))
            {
                records = csv.GetRecords<MyDataModel>().ToList();
            }

            string filename = Path.GetFileNameWithoutExtension(inputFile);
            string outputFilePath = Path.Combine(outputFolder, $"{filename}.xlsx");

            using (var writer = new StreamWriter(outputFilePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Context.RegisterClassMap<MyCsvClassMap>();
                csv.WriteRecords(records);
            }
        }

        private void excelEvent(object sender, EventArgs e)
        { 
            FolderBrowserDialog folderSaveDialog = new FolderBrowserDialog();
            folderSaveDialog.Description = "Selecciona dónde deseas guardar los archivos.";

            if (folderSaveDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in files)
                {
                    ConvertToExcel(file, folderSaveDialog.SelectedPath);
                }
                System.Windows.Forms.MessageBox.Show("¡Se han creado exitosamente los archivos!");
            }

        }

        private void fileEvent(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selecciona la carpeta que deseas convertir.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string dirPath = folderBrowserDialog.SelectedPath;
                if (Directory.GetFiles(dirPath, "*.txt").Length == 0) {
                    System.Windows.Forms.MessageBox.Show("No se encontraron archivos de texto dentro de la carpeta.");
                } else
                {
                    files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.txt", SearchOption.AllDirectories);
                    fileTxtb.Text = dirPath;
                    excelBtn.Enabled = true;
                }
            }
        }

    }
}
