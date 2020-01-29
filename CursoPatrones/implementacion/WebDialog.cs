using CursoPatrones.Botones;
using CursoPatrones.Fabrica;

namespace CursoPatrones.implementacion
{
    public class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HTML();

        }
    }
}
