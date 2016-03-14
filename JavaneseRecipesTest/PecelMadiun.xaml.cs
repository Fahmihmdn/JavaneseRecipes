using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;

namespace JavaneseRecipesTest
{
    public partial class PecelMadiun : PhoneApplicationPage
    {
        public ObservableCollection<Recipe> MyFood = new ObservableCollection<Recipe>();
        public ObservableCollection<Method> MyMethod = new ObservableCollection<Method>();
        public PecelMadiun()
        {
            InitializeComponent();
            //Add items to collection.
            MyFood.Add(new Recipe("@  200 gram daun bayam, rebus"));
            MyFood.Add(new Recipe("@  200 gram kacang panjang, \n \t  potong 2 cm, rebus"));
            MyFood.Add(new Recipe("@  3 lembar daun pepaya muda, rebus"));
            MyFood.Add(new Recipe("@  150 gram bunga turi, rebus"));
            MyFood.Add(new Recipe("@  200 gram taoge, rebus"));
            MyFood.Add(new Recipe("@  1 buah mentimun, iris tipis"));
            MyFood.Add(new Recipe("@  100 gram petai cina"));
            MyFood.Add(new Recipe("@  1 ikat daun kemangi, petik daunnya"));
            MyFood.Add(new Recipe("                       "));
            MyFood.Add(new Recipe("Haluskan: "));
            MyFood.Add(new Recipe("@  300 gram kacang tanah \n \t   (pilih yang kecil-kecil)"));
            MyFood.Add(new Recipe("@  3 siung bawang putih, goreng"));
            MyFood.Add(new Recipe("@  7 buah cabai merah keriting"));
            MyFood.Add(new Recipe("@  3 buah cabai rawit"));
            MyFood.Add(new Recipe("@  4 sdm gula merah"));
            MyFood.Add(new Recipe("@  3 cm kencur"));
            MyFood.Add(new Recipe("@  1 sdt asam jawa"));
            MyFood.Add(new Recipe("@  1 1/2 sdt garam"));
            MyFood.Add(new Recipe("@  2 butir jeruk limo, ambil airnya"));
            //set data context to ListBox; bahan1
            bahan1.DataContext = MyFood;

            MyMethod.Add(new Method("@  Sangrai kacang tanah dengan api sedang \n \t  sampai harum dan matangnya rata \n \t  (jangan sampai kehitaman). \n \t  Kupas kulit arinya, lalu haluskan kacang \n \t  bersama bawang putih goreng, cabai merah, \n \t  cabai rawit, gula merah, kencur, asam jawa, \n \t  dan garam. Tambahkan air jeruk \n \t  limo. Aduk rata. Sisihkan."));
            MyMethod.Add(new Method("@  Campur semua sayuran rebus bersama \n \t  irisan mentimun, petai cina, dan  \n \t  daun kemangi. \n \t  Ambil beberapa sendok bumbu,  \n \t  cairkan dengan air hangat.* \n \t  Siramkan ke atas pecel. \n \t  sSajikan bersama pelengkapnya "));
            MyMethod.Add(new Method("@  *tingkat kekentalan bumbu kacang  \n \t  disesuaikan dengan selera. \n \t  Bumbu didiamkan/ disimpan \n \t  dalam keadaan padat.  "));
            //set data context to ListBox; cara1 
            cara1.DataContext = MyMethod;


            List<ImageData> datasource = new List<ImageData>()
            {
                new ImageData(){ImagePath="/Assets/Images/PecelMadiun3.jpg"}
            };
            this.view1.ItemsSource = datasource;
        }

        public class ImageData
        {
            public String ImagePath
            {
                get;
                set;
            }
        }

        public class Recipe
        {
            public Recipe() { }
            public Recipe(string namaBahan)
            {
                Bahan = namaBahan;
            }
            public String Bahan { get; set; }
        }

        public class Method
        {
            public Method() { }
            public Method(string langkahCara)
            {
                Cara = langkahCara;
            }
            public String Cara { get; set; }
        }
    }
}