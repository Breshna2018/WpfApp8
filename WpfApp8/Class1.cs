using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApp8
{
    class Class1
    {
        BitmapImage _image;
        string _Content;

        public Class1(BitmapImage image, string content)
        {
            Image = image;
            Content = content;
        }
        public Class1(string Image22,string content)
        {
            _image=new BitmapImage(new Uri(im));
            _Content = content;
        }

        public BitmapImage Image { get => _image; set => _image = value; }
        public string Content { get => _Content; set => _Content = value; }
    }
}
