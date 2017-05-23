using System.Drawing;

namespace R_Solution_1
{
    public class MyImage
    {
        private string path;
        private string name;

        public MyImage(string path, string name)
        {
            this.path = path;
            this.name = name;
        }

        public Image getImage()
        {
            Image image = Image.FromFile(path);
            return image;
        }
    }
}