namespace DesignPatternChallengeMemento
{
    using DesignPatternChallengeMemento.Caretaker;
    using DesignPatternChallengeMemento.Originator;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Editor de Imagens - Problema de Undo ===\n");

            var image = new ImageEditor(1920, 1080);
            var editing = new Editing();

            Console.WriteLine("=== Realizando Edições ===");

            editing.SaveState(image.Save()); // Estado inicial
            image.DisplayInfo();

            image.ApplyBrightness(20);
            editing.SaveState(image.Save());

            image.ApplyFilter("Sepia");
            editing.SaveState(image.Save());

            image.Rotate(90);
            editing.SaveState(image.Save());

            image.Crop(1280, 720);
            editing.SaveState(image.Save());

            image.DisplayInfo();

            Console.WriteLine("=== Desfazendo ===");

            image.Restore(editing.Undo());
            image.DisplayInfo();
        }
    }
}