using System.Collections.Generic;
using System.Windows.Forms;

namespace R_Solution_1
{
    public class Document
    {
        private string text_;
        private List<MyImage> images_;

        public Document()
        {
            images_ = new List<MyImage>();
        }

        public void addText(string text)
        {
            text_ += text;
        }

        public void addImage(string path, string name)
        {
            images_.Add(new MyImage(path, name));
        }

        public void open()
        {
            System.Console.WriteLine(text_);
            images_.ForEach(img =>
            {
                Form form = new Form();
                Label label = new Label();
                form.BackgroundImage = img.getImage();
                form.Show();
            });
        }
    }
}