using CursoPatrones.Botones;

namespace CursoPatrones.Fabrica
{
    public abstract class Dialog
    {
        public abstract IButton CreateButton();
        public void render()
        {
            var product = CreateButton();
            product.Onclick();

        }
    }
}
