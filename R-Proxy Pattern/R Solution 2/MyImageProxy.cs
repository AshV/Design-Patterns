using System.Drawing;

namespace R_Solution_2
{
    public class MyImageProxy : IProxy
    {
        public MyImage image_;

        public MyImageProxy(string path, string name)
        {
            image_ = new MyImage(path, name);
        }

        public string getAlter()
        {
            return image_.getAlter();
        }

        public Image getImage()
        {
            return image_.getImage();
        }
    }
}