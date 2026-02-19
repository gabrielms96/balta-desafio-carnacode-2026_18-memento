using DesignPatternChallengeMemento.Memento;

namespace DesignPatternChallengeMemento.Originator
{
    public class ImageEditor
    {
        // Estado interno complexo
        private byte[] _pixels;
        private int _width;
        private int _height;
        private int _brightness;
        private int _contrast;
        private int _saturation;
        private string _filterApplied;
        private double _rotation;

        public ImageEditor(int width, int height)
        {
            _width = width;
            _height = height;
            _pixels = new byte[width * height * 3]; // RGB
            _brightness = 0;
            _contrast = 0;
            _saturation = 0;
            _filterApplied = "None";
            _rotation = 0;

            Console.WriteLine($"[Editor] Imagem criada: {width}x{height}");
        }

        public void ApplyBrightness(int value)
        {
            _brightness += value;
            Console.WriteLine($"[Editor] Brilho ajustado para {_brightness}");
        }

        public void ApplyFilter(string filter)
        {
            _filterApplied = filter;
            Console.WriteLine($"[Editor] Filtro aplicado: {filter}");
        }

        public void Rotate(double degrees)
        {
            _rotation += degrees;
            Console.WriteLine($"[Editor] Rotação: {_rotation}°");
        }

        public void Crop(int newWidth, int newHeight)
        {
            _width = newWidth;
            _height = newHeight;
            Array.Resize(ref _pixels, newWidth * newHeight * 3);
            Console.WriteLine($"[Editor] Imagem cortada para {newWidth}x{newHeight}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n=== Estado Atual ===");
            Console.WriteLine($"Dimensões: {_width}x{_height}");
            Console.WriteLine($"Brilho: {_brightness}");
            Console.WriteLine($"Filtro: {_filterApplied}");
            Console.WriteLine($"Rotação: {_rotation}°\n");
        }

        public ImageEditorMemento Save() => new ImageEditorMemento(_pixels, _width, _height, _brightness, _contrast, _saturation, _filterApplied, _rotation);

        public void Restore(ImageEditorMemento memento)
        {
            _pixels = memento._pixels;
            _width = memento._width;
            _height = memento._height;
            _brightness = memento._brightness;
            _contrast = memento._contrast;
            _saturation = memento._saturation;
            _filterApplied = memento._filterApplied;
            _rotation = memento._rotation;
            Console.WriteLine($"[Editor] Estado restaurado do memento.");
        }
    }
}
