using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager.Services
{
    public class LanguageService : ILanguageService

    {

        LanguageService(string targetLanguage)

        {
            //Thread.CurrentThread.CurrentCulture = New ("DE")
            if (targetLanguage == "DE")
            {
                //// Create a ResXResourceReader for the file items.resx.
                //LanguageService rsxr = new LanguageService("items.resx");

                //// Iterate through the resources and display the contents to the console.
                //foreach (DictionaryEntry d in rsxr)
                //{
                //    Console.WriteLine(d.Key.ToString() + ":\t" + d.Value.ToString());
                //}

                ////Close the reader.
                //rsxr.Close();
            }
            else if (targetLanguage == "EN")
            {
            
            }



        }
    }
}
