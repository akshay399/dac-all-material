using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DemoEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Hindi, 2: English");
            int choice = Convert.ToInt32(Console.ReadLine());

            SpellCheckFactory spellCheckFactory = new SpellCheckFactory();


            ISpellChecker checker =
                    spellCheckFactory.GetSpellChecker(choice);

            Editor editor = new Editor(checker);
            editor.DoSpellCheck("xyz");
        }
    }

    public class Editor
    {
        ISpellChecker checker;
        public Editor(ISpellChecker checker)
        {
            this.checker = checker;
        }
        public void Cut() { }
        public void Copy() { }
        public void Paste() { }

        public void DoSpellCheck(string word)
        {
            
            checker.Check(word);
        }

    }
    public interface ISpellChecker
    {
       void Check(string word);
    }
    public class SpellCheckFactory
    {
        public ISpellChecker GetSpellChecker(int choice)
        {
            ISpellChecker checker = null;

            switch (choice)
            {
                case 1:
                    checker = new HindiSpellChecker();
                    break;
                case 2:
                    checker = new EnglishSpellChecker();
                    break;
                default:
                    checker = new EnglishSpellChecker();
                    break;
            }
            return checker;
        }
    }
    public class EnglishSpellChecker: ISpellChecker
    {
        public void Check(string word)
        {
            Console.WriteLine("Done with spellcheck in English");
        }

        //Many other supporting functions for doing a spellcheck
    }
    public class HindiSpellChecker: ISpellChecker
    {
        public void Check(string word)
        {
            Console.WriteLine("Done with spellcheck in Hindi");
        }

        //Many other supporting functions for doing a spellcheck
    }
}
