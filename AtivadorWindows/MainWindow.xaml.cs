using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace AtivadorWindows
{
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AtivarWindows(object sender, RoutedEventArgs e)
        {
            string pastaAtivadorWindows = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoDoAtivador = Path.Combine(pastaAtivadorWindows, "AtivadoresWindowsOffice", "HWID_Activation.cmd");

            if (File.Exists(caminhoDoAtivador))
            {
                Process.Start(caminhoDoAtivador);
                WindowState = WindowState.Minimized;
            }
            else
            {
                MessageBox.Show("O arquivo não existe.");
            }
        }

        private void AtivarOffice(object sender, RoutedEventArgs e)
        {
            string pastaAtivadorWindows = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoDoAtivador = Path.Combine(pastaAtivadorWindows, "AtivadoresWindowsOffice", "Ohook_Activation_AIO.cmd");

            if (File.Exists(caminhoDoAtivador))
            {
                Process.Start(caminhoDoAtivador);
                WindowState = WindowState.Minimized;
            }
            else
            {
                MessageBox.Show("O arquivo não existe.");
            }
        }

        private void MudarEdicao(object sender, RoutedEventArgs e)
        {
            string pastaAtivadorWindows = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoDoAtivador = Path.Combine(pastaAtivadorWindows, "AtivadoresWindowsOffice", "Change_Edition.cmd");

            if (File.Exists(caminhoDoAtivador))
            {
                Process.Start(caminhoDoAtivador);
                WindowState = WindowState.Minimized;
            }
            else
            {
                MessageBox.Show("O arquivo não existe.");
            }
        }
    }
}
