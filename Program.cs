using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*******
 * Read input from Console
 * Use: Console.WriteLine to output your result to STDOUT.
 * Use: Console.Error.WriteLine to output debugging information to STDERR;
 *       
 * ***/
namespace CSharpContestProject
{
    /// <summary>
    /// Implémenté la solution dans cette classe
    /// </summary>
    public class Solution : SolutionAbstract
    {
        override public void Main()
        {
            string line;
            while ((line = ReadLine()) != null)
            {

            }

            WriteLine("4");
            WriteLine("6");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var s = new Solution())
            {
                s.Main();
#if DEBUG
                Console.ReadLine();
#endif
            }
        }
    }

   

   public abstract class SolutionAbstract  : IDisposable
    {
        const int nbTest = 1;

        System.IO.StreamReader fileInput;
        System.IO.StreamReader fileOutput;

        public SolutionAbstract()
        {
#if DEBUG
            fileInput = new System.IO.StreamReader($"{Environment.CurrentDirectory}\\test\\input{nbTest}.txt");
            fileOutput = new System.IO.StreamReader($"{Environment.CurrentDirectory}\\test\\output{nbTest}.txt");
#endif
        }
        public string ReadLine()
        {
#if DEBUG
            return fileInput.ReadLine();
#else
            return Console.ReadLine();
#endif
        }

        public void WriteDebug(String debug)
        {
#if DEBUG
            Console.ForegroundColor = ConsoleColor.DarkYellow;
#endif
            Console.Error.WriteLine("debug");
        }

        public void WriteLine(String msg)
        {
#if DEBUG
            string result = fileOutput.ReadLine();
            if (msg == result)
            {

                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Attendu ({result})\t ");
                
            }
#endif
            Console.WriteLine(msg);
        }

        // Ce code est ajouté pour implémenter correctement le modèle supprimable.
        void IDisposable.Dispose()
        {
#if DEBUG
            fileInput.Close();
            fileOutput.Close();
#endif

        }
        abstract public void Main();

    }

}
