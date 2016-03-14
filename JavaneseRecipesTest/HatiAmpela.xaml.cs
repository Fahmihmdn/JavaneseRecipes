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
    public partial class HatiAmpela : PhoneApplicationPage
    {
        public ObservableCollection<Recipe> MyFood = new ObservableCollection<Recipe>();
        public ObservableCollection<Method> MyMethod = new ObservableCollection<Method>();
        public HatiAmpela()
        {
            InitializeComponent();
            //Add items to collection.
            MyFood.Add(new Recipe("@  400 gram kentang, potong dadu"));
            MyFood.Add(new Recipe("@  3 pasang hati dan ampela ayam"));
            MyFood.Add(new Recipe("@  1 papan petai, iris-iris"));
            MyFood.Add(new Recipe("@  Minyak untuk menggoreng"));
            MyFood.Add(new Recipe("@  1 lembar daun salam"));
            MyFood.Add(new Recipe("@  2 cm lengkuas, memarkan"));
            MyFood.Add(new Recipe("@  1 tangkai serai, memarkan"));
            MyFood.Add(new Recipe("@  2 lembar daun jeruk purut"));
            MyFood.Add(new Recipe("@  3 buah cabai merah besar, \n \t  buang biji, iris halus"));
            MyFood.Add(new Recipe("@  1 sdm kecap manis"));
            MyFood.Add(new Recipe("                       "));
            MyFood.Add(new Recipe("Haluskan: "));
            MyFood.Add(new Recipe("@  6 butir bawang merah"));
            MyFood.Add(new Recipe("@  3 siung bawang putih"));
            MyFood.Add(new Recipe("@  6 buah cabai merah keriting"));
            MyFood.Add(new Recipe("@  1/2 butir tomat"));
            MyFood.Add(new Recipe("@  1/2 sdt terasi matang"));
            MyFood.Add(new Recipe("@  1 1/2 sdt garam"));
            MyFood.Add(new Recipe("@  1/2 kaldu ayam bubuk"));
            //set data context to ListBox; bahan1
            bahan1.DataContext = MyFood;

            MyMethod.Add(new Method("@  Goreng kentang sampai matang \n \t  dan kecoklatan. \n \t  Angkat dan sisihkan. \n \t  Potong-potong hati dan ampela ayam. \n \t  Goreng sampai matang. sisihkan."));
            MyMethod.Add(new Method("@  Panaskan minyak, tumis bumbu yang \n \t  dihaluskan bersama daun salam, \n \t  lengkuas, daun jeruk, dan irisan cabai merah \n \t  sampai harum dan layu. \n \t  Masukkan irisan petai dan hati ampela ayam. \n \t  Aduk-aduk dan masak sebentar"));
            MyMethod.Add(new Method("@  Masukkan kentang goreng. \n \t  Aduk sampai rata, dan masak \n \t  sebentar sampai bumbu meresap. \n \t  Angkat. "));
            //set data context to ListBox; cara1 
            cara1.DataContext = MyMethod;


            List<ImageData> datasource = new List<ImageData>()
            {
                new ImageData(){ImagePath="/Assets/Images/HatiAmpela2.png"}
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