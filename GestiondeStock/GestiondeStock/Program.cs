using System;
using System.Windows.Forms;

namespace GestiondeStock
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lancer d'abord la fenêtre de connexion
           Application.Run(new Connexion());
        }
    }
}
