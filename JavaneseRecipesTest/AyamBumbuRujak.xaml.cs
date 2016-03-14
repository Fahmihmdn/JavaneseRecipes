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
    public partial class AyamBumbuRujak : PhoneApplicationPage
    {
        public ObservableCollection<Recipe> MyFood = new ObservableCollection<Recipe>();
        public ObservableCollection<Method> MyMethod = new ObservableCollection<Method>();
        public AyamBumbuRujak()
        {
            InitializeComponent();
            //Add items to collection.
            MyFood.Add(new Recipe("@  1 Ekor ayam kampung (pilih yang agak kecil)"));
            MyFood.Add(new Recipe("@  1 Butir jeruk nipis, ambil airnya"));
            MyFood.Add(new Recipe("@  3 sdm minyak untuk menumis"));
            MyFood.Add(new Recipe("@  3 lembar daun jeruk"));
            MyFood.Add(new Recipe("@  1 batang serai, memarkan"));
            MyFood.Add(new Recipe("@  2 sdm air asam jawa"));
            MyFood.Add(new Recipe("@  400 ml santan cair"));
            MyFood.Add(new Recipe("@  600 ml santan kental"));
            MyFood.Add(new Recipe("                       "));
            MyFood.Add(new Recipe("Haluskan: "));
            MyFood.Add(new Recipe("@  8 butir bwang merah"));
            MyFood.Add(new Recipe("@  4 siung bawang putih"));
            MyFood.Add(new Recipe("@  10 buah cabai merah keriting"));
            MyFood.Add(new Recipe("@  1/2 sdt terasi matang"));
            MyFood.Add(new Recipe("@  2 sdm gula merah, iris"));
            MyFood.Add(new Recipe("@  3 butir kemiri"));
            MyFood.Add(new Recipe("@  2 sdt garam"));
            //set data context to ListBox; bahan1
            bahan1.DataContext = MyFood;

            MyMethod.Add(new Method("@  Potong ayam menjadi empat bagian. \n \t  Lumuri dengan air jeruk nipis, \n \t  lalu diamkan selama 15 menit. \n \t  Bilas dan sisihkan"));
            MyMethod.Add(new Method("@  Panaskan Minyak, tumis bumbu yang \n \t  dihaluskan bersama daun jeruk \n \t  dan serai sampai harum dan matang. \n \t  Masukkan ayam, aduk dan beri santan cair \n \t  Masak sampai ayam setengah matang. "));
            MyMethod.Add(new Method("@  Beri Santan kental, lalu teruskan \n \t  memasak sampai ayam empuk dan santan \n \t  menyusut. Angkat. Bakar ayam diatas bara,  \n \t  sambil sesekali diolesi bumbu santan."));
            //set data context to ListBox; cara1 
            cara1.DataContext = MyMethod;


            List<ImageData> datasource = new List<ImageData>()
            {
                new ImageData(){ImagePath="/Assets/Images/AyamRujak3.jpg"}
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