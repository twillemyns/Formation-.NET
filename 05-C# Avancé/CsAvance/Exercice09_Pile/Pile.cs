namespace Exercice09_Pile;

public class Pile<T> : IPile
{
    private T[] _elements = [];

    public void Empiler(T nouveau)
    {
        var remplacant = new T[_elements.Length + 1];
        Array.Copy(_elements, remplacant, _elements.Length);
        remplacant[_elements.Length] = nouveau;
        _elements = remplacant;
    }

    public void Depiler()
    {
        var remplacant = new T[_elements.Length - 1];
        Array.Copy(_elements, remplacant, _elements.Length - 1);
        _elements = remplacant;
    }

    public T ExtraireElement(int index)
    {
        var element = _elements[index];

        var remplacant = new T[_elements.Length - 1];

        Array.Copy(_elements, 0, remplacant, 0, index);
        
        Array.Copy(_elements, index + 1, remplacant, index, remplacant.Length - index); 

        _elements = remplacant;
        
        return element;
    }
}