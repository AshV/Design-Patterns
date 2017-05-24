using System;
using System.Drawing;

namespace R_Solution_2
{
    public class MyImage : IProxy
    {
        private string path;
        private string name;

        public MyImage(string path, string name)
        {
            this.path = path;
            this.name = name;
        }

        public string getAlter()
        {
            return name;
        }

        public Image getImage()
        {
            Image image = Image.FromFile(path);
            return image;
        }
    }
}