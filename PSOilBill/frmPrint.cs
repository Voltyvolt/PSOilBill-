using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSOilBill
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void frmPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnPrint.PerformClick();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string lvPrinterSelect = "";
                bool lvChkPrinterStatus = false;

                string lvPrinter = "";
                lvPrinter = "LQ-310";

                //เช็ค Printer
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    if (printer.IndexOf(lvPrinter) != -1)
                    {
                        lvChkPrinterStatus = FncCheckPrinterStatus(printer);
                        if (lvChkPrinterStatus)
                        {
                            lvPrinterSelect = printer;
                            break;
                        }
                    }
                }

                rptBill Report = new rptBill();
                Report.PrinterName = lvPrinterSelect;
                Report.PrintingSystem.ShowMarginsWarning = false;
                Report.ExportOptions.Pdf.ShowPrintDialogOnOpen = true;
                Report.CreateDocument();

                using (ReportPrintTool printTool = new ReportPrintTool(Report))
                {
                    printTool.PrinterSettings.PrinterName = lvPrinterSelect;
                    printTool.Print();

                    printTool.Dispose();
                }

                Report.Dispose();
            }
            catch (Exception ex)
            {

            }
        }

        private bool FncCheckPrinterStatus(string lvPrinter)
        {
            bool lvReturn = false;

            // Set management scope
            ManagementScope scope = new ManagementScope(@"\root\cimv2");
            scope.Connect();

            // Select Printers from WMI Object Collections
            ManagementObjectSearcher searcher = new
             ManagementObjectSearcher("SELECT * FROM Win32_Printer");

            string printerName = "";
            foreach (ManagementObject printer in searcher.Get())
            {
                printerName = printer["Name"].ToString().ToLower();
                if (printerName.Equals(lvPrinter.ToLower()))
                {
                    //Console.WriteLine("Printer = " + printer["Name"]);
                    if (printer["WorkOffline"].ToString().ToLower().Equals("true"))
                    {
                        // printer is offline by user
                        lvReturn = false;
                        break;
                        //Console.WriteLine("Your Plug-N-Play printer is not connected.");
                    }
                    else
                    {
                        // printer is not offline
                        lvReturn = true;
                        break;
                        //Console.WriteLine("Your Plug-N-Play printer is connected.");
                    }
                }
            }


            return lvReturn;
        }
    }
}
