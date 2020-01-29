using CursoPatrones.Fabrica;
using CursoPatrones.implementacion;
using System;

namespace CursoPatrones
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the HTML.");
            ClientCode(new WebDialog());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the Windows.");
            ClientCode(new windowsDialog());
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void ClientCode(Dialog creator)
        {
            creator.render();
            creator.CreateButton();

            // ...
        }
    }
}
