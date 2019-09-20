using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelegramSender;

namespace SoftwareTas
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new FormSendMessage());
           // Application.Run(new FormSelectMessage());
         //   Application.Run(new FormEtudiant());
            Application.Run(new FormRevision1());
        }
    }
}
