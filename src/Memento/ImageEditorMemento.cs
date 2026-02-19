namespace DesignPatternChallengeMemento.Memento
{
    public class ImageEditorMemento
    {
        public byte[] _pixels;
        public int _width;
        public int _height;
        public int _brightness;
        public int _contrast;
        public int _saturation;
        public string _filterApplied;
        public double _rotation;

        public ImageEditorMemento(byte[] pixels, int width, int height, int brightness, int contrast, int saturation, string filterApplied, double rotation)
        {
            _pixels = pixels;
            _width = width;
            _height = height;
            _brightness = brightness;
            _contrast = contrast;
            _saturation = saturation;
            _filterApplied = filterApplied;
            _rotation = rotation;
        }
    }
}
