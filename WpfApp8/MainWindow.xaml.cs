using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        List<Class1> myclass = new List<Class1>();
        public MainWindow()
        {
            InitializeComponent();
            displayimgage();
           // methodforimageadd();


            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            // Put image location in uri
           // bitmap.UriSource = new Uri(WIN_20230307_22_25_50_Pro);
           // bitmap.EndInit();


        }

        public void displayimgage()
        {
            string myphoto= @"C:\Users\bresh\OneDrive\Pictures\Camera Roll\WIN_20230309_23_24_02_Pro.jpg";
            string myphoto2= @"C:\Users\bresh\OneDrive\Pictures\Camera Roll\WIN_20230309_23_22_18_Pro";
            Uri uri=new Uri(myphoto);
            BitmapImage bitmap = new BitmapImage(uri);
            image22.Source = bitmap;
            //imagedisplay.Source= bitmap; here use bitmapmethoth name
            imagedisplay.Source= BitmapImage22(myphoto);

            Class1 messgephoto = new Class1(myphoto2, "nice ");
            imagedisplay.Source = messgephoto.Image;
            showlink.Content = messgephoto.Content;

        }

        public BitmapImage BitmapImage22(string image22)
        {

           // Uri uri = new Uri(image22);
           // BitmapImage bitmap = new BitmapImage(uri);
          //  return bitmap;
          return new BitmapImage(new Uri(image22));// this for add new image

        }

        /*public void netmethod()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFileName = dlg.FileName;
                FileNameLabel.Content = selectedFileName;

                //    // In order to get a bitmap, "image?", start here
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                // Put image location in uri
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();

                // Probably display our image to our image control
                imgDisplay.Source = bitmap;
            }
        */
    
        

        private void imageshow_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "select photo";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
             "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
             "Portable Network Graphic (*.png)|*.png|" +
             "my own text|*.txt";

            if (op.ShowDialog() == true)
            {
                string imge22 = op.FileName;
               showlink.Content = image22;
                imagedisplay.Source = new BitmapImage(new Uri(imge22));
               image22.Source= BitmapImage22(imge22);


            }

            

            
            }

      /*  public string cleancoding(string image22)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Title = "select photo";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png|" +
              "my own text|*.txt";

            if (op.ShowDialog() == true)
            {
                string imge22 = op.FileName;
               return op.FileName;

            }
            else
            {
                return "";

            }
      */



        }








        //string addp = @"C:\Users\bresh\OneDrive\Pictures\Camera Roll\WIN_20230309_23_24_02_Pro.jpg";

        // Uri uri = new Uri(addp);
        // BitmapImage bitmap=new BitmapImage(uri);
        //
        //imagedisplay.Source= bitmap;
        //imagedisplay.Source = bitmapmethod(addp);
        // string image2 = @"C:\Users\bresh\OneDrive\Pictures\Camera Roll\WIN_20230309_23_22_18_Pro";
        // image22.Source= bitmapmethod(image2);
    }

       /* public BitmapImage bitmapmethod(string addp)
        {

           // Uri uri = new Uri(addp);
           // BitmapImage bitmap=new BitmapImage(uri);

            return new BitmapImage(new Uri(addp));
        }
       */
      
        
    

