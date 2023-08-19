namespace StructuralPatterns.Bridge
{
    internal class LaptopProduct
    {
        public int GetLaptopCost()
        {
            return 3500;
        }

        public string GetLaptopName()
        {
            return "HP Laptop";
        }

        public string GetLaptopConfiguration()
        {
            return "Processor: Intel Core i5, Cores: 4, RAM: 8 GB, Storage: 512GB, Display: 14.0, Software: Windows 11 Home";
        }

        public string GetLaptopAccessories()
        {
            return "Camera - Lenovo 300 FHD Webcam, Mouse - Sculpt Ergonomic, Keyboar - QWERTY Virtual Keyboard";
        }
    }
}
