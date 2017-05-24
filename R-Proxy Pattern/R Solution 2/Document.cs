using System.Collections.Generic;
using System.Windows.Forms;
using static System.Console;

namespace R_Solution_2
{
    public class Document
    {
        private string text_;
        private List<IProxy> images_;

        public Document()
        {
            images_ = new List<IProxy>();
        }

        public void addText(string text)
        {
            text_ += text;
        }

        public void addImage(string path, string name)
        {
            images_.Add(new MyImageProxy(path, name));
        }

        public void open()
        {
            System.Console.WriteLine(text_);
            images_.ForEach(image =>
            {
                WriteLine(image.getAlter());
            });
        }

        public void clickImage()
        {
            Form form = new Form();
            Label label = new Label();
            form.BackgroundImage = images_[0].getImage();
            form.Show();
        }
    }
}