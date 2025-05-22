using System;
using System.IO;
using System.Windows.Forms;

namespace CSharpWinFormsPOS
{
    public partial class MainForm : Form
    {
        private readonly string logFilePath = @"C:\POSAppLogs\pos_log.txt";
        private readonly string configFilePath = @"C:\POSAppLogs\config.txt";

        public MainForm()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));
            Logger.LogFilePath = logFilePath;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.LogEnvironmentInfo();

            try
            {
                Logger.Log("Application started.", "INFO");

                if (!File.Exists(configFilePath))
                {
                    Logger.Log("Configuration file not found.", "WARN");
                    MessageBox.Show("Configuration file missing.");
                }
                else
                {
                    var config = File.ReadAllText(configFilePath);
                    Logger.Log("Configuration file loaded.", "INFO");

                    if (!config.Contains("StoreID"))
                    {
                        Logger.Log("Invalid configuration: StoreID is missing.", "WARN");
                        MessageBox.Show("Invalid config: StoreID missing.");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(ex, "Error in MainForm_Load");
                MessageBox.Show("Error loading application.");
            }
        }

        private void btnProcessSale_Click(object sender, EventArgs e)
        {
            Logger.Log("User clicked 'Process Sale'.", "INFO");

            try
            {
                int total = 100;
                int discount;

                if (!int.TryParse(txtDiscount.Text, out discount))
                {
                    Logger.Log("Invalid discount input: Not a number", "WARN");
                    MessageBox.Show("Please enter a valid discount.");
                    return;
                }

                Logger.Log($"Input discount: {discount}", "INFO");

                int final = total / discount;
                Logger.Log($"Sale processed successfully. Total: {total}, Discount: {discount}, Final: {final}", "INFO");
                MessageBox.Show($"Sale completed. Final: {final}");
            }
            catch (DivideByZeroException ex)
            {
                Logger.LogException(ex, "Attempted division by zero during sale.");
                MessageBox.Show("Discount cannot be zero.");
            }
            catch (Exception ex)
            {
                Logger.LogException(ex, "Unexpected error during sale.");
                MessageBox.Show("Unexpected error occurred.");
            }
        }
    }
}
