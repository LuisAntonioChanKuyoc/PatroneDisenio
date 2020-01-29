using CursoPatrones.Botones;

namespace CursoPatrones.Interfaces
{
    public interface IDialog
    {
        void render();
        IButton createButton(int iTipo); 
    }
}
