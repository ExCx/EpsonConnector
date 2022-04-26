using CsvHelper;
using CsvHelper.Configuration;
using EpsonConnector.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpsonConnector
{
    public class PrinterManager
    {
        public IProgress<string> reporter;
        public bool IsConnected { get; set; } = false;

        public PrinterManager(IProgress<string> reporter)
        {
            this.reporter = reporter;
        }

        public List<string> GetPrinters()
        {
            return new List<string> { "LW-Z900" };
        }

        /*public void Connect()
        {
            printer.USBPortID = Settings.Default.YaziciPortu;
            try
            {
                printer.Connect();
                reporter.Report("Bağlantı Durumu|Yazıcı bağlantısı kuruldu");
                IsConnected = true;
            }
            catch (Exception ex)
            {
                reporter.Report("Yazıcı Hatası|" + ex.Message);
                IsConnected = false;
            }
        }*/

        internal void Print(ServerManager.AssetPrintDto asset)
        {
            /*try
            {
                printer.Send(Utils.StringToByteArray(prn));
            }
            catch (Exception ex)
            {
                reporter.Report("Yazıcı Hatası|" + ex.Message);
            }*/
        }

        internal void PrintAll(List<ServerManager.AssetPrintDto> assetsToPrint)
        {
            using (var writer = new StreamWriter("data.csv", false, Encoding.UTF8))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<AssetMap>();
                foreach (var record in assetsToPrint)
                {
                    csv.WriteRecord(record);
                    csv.NextRecord();
                }
            }

            ExecuteCommand($"\"{Settings.Default.EditorLocation}\"/pt \"{Settings.Default.SablonPath},{AppContext.BaseDirectory}\\data.csv,1\" \"EPSON {Settings.Default.PrinterName}\"");
        }

        public sealed class AssetMap : ClassMap<ServerManager.AssetPrintDto>
        {
            public AssetMap()
            {
                Map(m => m.AssetTypeDefinition).Index(0);
                Map(m => m.RemoteId).Index(1);
            }
        }

        static void ExecuteCommand(string command)
        {
            using (var writer = new StreamWriter("print.bat"))
                writer.Write(command);

            var processInfo = new ProcessStartInfo("print.bat");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("output>>" + e.Data);
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                Console.WriteLine("error>>" + e.Data);
            process.BeginErrorReadLine();

            process.WaitForExit();

            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
        }
    }
}