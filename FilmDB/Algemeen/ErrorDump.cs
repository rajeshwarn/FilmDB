using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FilmDB.Algemeen
{
    public class ErrorDump
    {
        #region Variables
        /********************************************** Variables ******************************************************************/

        private static string Source;
        private static string Function;
        private static string Message;
        private static string StackTrace;
        private static string ExtraStackTrace;
        private static string ExtraInfo;        
        private static Exception Error;

        private static string ErrorLogPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Sietse\FDB";

        #endregion Variables

        #region Functions
        /********************************************** Functions ******************************************************************/

        public static void AddError(string Src, string Func, Exception e)
        {
            Source = Src;
            Function = Func;
            Message = e.Message;
            StackTrace = e.StackTrace;
            ExtraInfo = null;
            Error = e;

            WriteLogs();
        }

        public static void AddError(string Src, string Func, Exception e, string Extra)
        {
            Source = Src;
            Function = Func;
            Message = e.Message;
            StackTrace = e.StackTrace;
            ExtraInfo = Extra;
            Error = e;

            WriteLogs();
        }

        private static void WriteLogs()
        {
            int volgnr = GetVolgnr();
            DateTime timestamp = DateTime.Now;

            ExtraStackTrace = "";

            try
            {
                ExtraStackTrace = Environment.StackTrace;
            }
            catch { }

            try
            {
                StreamWriter mainLog = File.AppendText(string.Format("{0}\\mainLog.txt", ErrorLogPath));
                mainLog.WriteLine("--------------");
                mainLog.WriteLine(string.Format("{0} - {1} ({2} {3}", timestamp, volgnr, Source, Message));
                mainLog.Close();

                StreamWriter log = File.CreateText(string.Format("{0}\\errorLog{1}.txt", ErrorLogPath, volgnr.ToString()));
                log.WriteLine(String.Format("Date      : {0}", timestamp));
                log.WriteLine(String.Format("Filename  : {0}", Source));
                log.WriteLine(String.Format("Function  : {0}", Function));
                log.WriteLine(String.Format("Message   : {0}", Message));
                if (ExtraInfo != null)
                {
                    log.WriteLine(string.Format("Extra   : {0}", ExtraInfo));
                }
                log.WriteLine(string.Format("Stacktrace: {0}", StackTrace));
                log.WriteLine(string.Format("ExtraStacktrace: {0}", ExtraStackTrace));


                log.Close();
            }
            catch { }

#if DEBUG
            //MessageBox.Show(Error.Message);
#endif
            MessageBox.Show(Error.Message);
        }

        private static int GetVolgnr()
        {
            int i = 1;

            string filename = string.Format("{0}\\errorlog1.txt", ErrorLogPath);

            while (File.Exists(filename))
            {
                i++;
                filename = string.Format("{0}\\errorlog{1}.txt", ErrorLogPath, i);
            }

            return i;
        }

        #endregion Functions

    }
}
