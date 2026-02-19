using DesignPatternChallengeMemento.Memento;

namespace DesignPatternChallengeMemento.Caretaker
{
    public class Editing
    {
        private readonly Stack<ImageEditorMemento> _editing = new();

        public void SaveState(ImageEditorMemento memento)
        {
            _editing.Push(memento);
            Console.WriteLine($"[Caretaker] Estado salvo. Total estados: {_editing.Count}");
        }

        public ImageEditorMemento? Undo()
        {
            if (_editing.Count == 0)
            {
                Console.WriteLine("[Caretaker] Nenhum estado para desfazer.");
                return null;
            }

            Console.WriteLine($"[Caretaker] Estado restaurado. Estados restantes: {_editing.Count}");
            return _editing.Pop();
        }
    }
}
