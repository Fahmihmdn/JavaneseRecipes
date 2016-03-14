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
    public partial class Krengsengan : PhoneApplicationPage
    {
        public ObservableCollection<Recipe> MyFood = new ObservableCollection<Recipe>();
        public ObservableCollection<Method> MyMethod = new ObservableCollection<Method>();
        public Krengsengan()
        {
            InitializeComponent();
            //Add items to collection.
            MyFood.Add(new Recipe("@  500 gram daging sandung lamur"));
            MyFood.Add(new Recipe("@  2 sdm minyak untuk menumis"));
            MyFood.Add(new Recipe("@  2 sdm petis"));
            MyFood.Add(new Recipe("@  2 sdm kecap manis"));
            MyFood.Add(new Recipe("@  850 ml air"));
            MyFood.Add(new Recipe("@  2 buah cabai merah besar, buang biji, "));
            MyFood.Add(new Recipe("   iris bulat"));
            MyFood.Add(new Recipe("@  Bawang goreng untuk taburan"));
            MyFood.Add(new Recipe("                       "));
            MyFood.Add(new Recipe("Haluskan: "));
            MyFood.Add(new Recipe("@  7 butir bwang merah"));
            MyFood.Add(new Recipe("@  3 siung bawang putih"));
            MyFood.Add(new Recipe("@  3 buah cabai merah keriting"));
            MyFood.Add(new Recipe("@  1/2 sdt merica bulat"));
            MyFood.Add(new Recipe("@  1 butir tomat"));
            MyFood.Add(new Recipe("@  2 sdt garam"));
            //set data context to ListBox; bahan1
            bahan1.DataContext = MyFood;

            MyMethod.Add(new Method("@  Potong-potong daging, lalu sisihkan \n \t  Panaskan minyak, tumis bumbu yang \n \t  dihaluskan sampai harum. \n \t  Masukkan potongan daging. \n \t  Aduk-aduk dan masak sampai berair"));
            MyMethod.Add(new Method("@  Tambahkan petis, kecap manis, dan air. \n \t  Aduk rata, lalu masak daging sampai \n \t  matang dan empuk. Tambahkan irisan \n \t  cabai merah. Aduk-aduk sebentar, \n \t  lalu angkat. Taburi dengan bawang goreng. "));
            //set data context to ListBox; cara1 
            cara1.DataContext = MyMethod;


            List<ImageData> datasource = new List<ImageData>()
            {
                new ImageData(){ImagePath="/Assets/Images/Krengsengan6.png"}
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