using CursoPatrones.Botones;
using CursoPatrones.Fabrica;

namespace CursoPatrones.implementacion
{
    public class windowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new Windows();

        }
    }
}
