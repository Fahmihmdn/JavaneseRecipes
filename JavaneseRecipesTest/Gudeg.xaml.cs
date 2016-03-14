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
    public partial class Gudeg : PhoneApplicationPage
    {
        public ObservableCollection<Recipe> MyFood = new ObservableCollection<Recipe>();
        public ObservableCollection<Method> MyMethod = new ObservableCollection<Method>();
        public Gudeg()
        {
            InitializeComponent();
            //Add items to collection.
            MyFood.Add(new Recipe("@  600 gram nangka muda"));
            MyFood.Add(new Recipe("@  1 liter santan kental"));
            MyFood.Add(new Recipe("@  2 lembar daun jati"));
            MyFood.Add(new Recipe("@  4 lembar daun jambu kelutuk"));
            MyFood.Add(new Recipe("@ 1/4 potong ayam kampung"));
            MyFood.Add(new Recipe("@  2 lembar daun salam"));
            MyFood.Add(new Recipe("@  1 ibu jari lengkuas, memarkan"));
            MyFood.Add(new Recipe("                       "));
            MyFood.Add(new Recipe("Haluskan: "));
            MyFood.Add(new Recipe("@  7 butir bwang merah"));
            MyFood.Add(new Recipe("@  4 siung bawang putih"));
            MyFood.Add(new Recipe("@  2 sdm ketumbar sangrai"));
            MyFood.Add(new Recipe("@  1 1/2 sdm gula merah"));
            MyFood.Add(new Recipe("@  2 sdm tempe semangit"));
            MyFood.Add(new Recipe("@  2 sdt garam"));
            //set data context to ListBox; bahan1
            bahan1.DataContext = MyFood;

            MyMethod.Add(new Method("@  Cacah nangka muda, kemudian campur \n \t  dengan santan, bumbu yang di haluskan, \n \t  daun salam, lengkuas, dan ayam kampung. \n \t  Sementara itu alasi dasar panci \n \t  perebus dengan daun jati dan daun jambu. \n \t  Masukkan nangka ke dalamnya, \n \t  lalu masak sampai mendidih."));
            MyMethod.Add(new Method("@  Tambahkan gula merah. Aduk dan masak \n \t  kembali dengan panci tertutup sampai \n \t  santan mendidih sekali lagi. \n \t  Kecilkan api lalu teruskan memasak sambil \n \t  sesekali diaduk sampai santan terserap \n \t  habis dan ayam matang. Angkat. \n \t  Sajikan bersama areh."));
            MyMethod.Add(new Method("@  AREH:  masak 1 liter santan bersama bumbu \n \t  yang sama dengan bumbu gudeg \n \t  sambil diaduk sampai kecokelatan  \n \t  dan kental. Angkat."));
            //set data context to ListBox; cara1 
            cara1.DataContext = MyMethod;


            List<ImageData> datasource = new List<ImageData>()
            {
                new ImageData(){ImagePath="/Assets/Images/Gdg3.jpg"}
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