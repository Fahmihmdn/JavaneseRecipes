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
    public partial class DendengRagi : PhoneApplicationPage
    {

        public ObservableCollection<Recipe> MyFood = new ObservableCollection<Recipe>();
        public ObservableCollection<Method> MyMethod = new ObservableCollection<Method>();
        public DendengRagi()
        {
            InitializeComponent();
            //Add items to collection.
            MyFood.Add(new Recipe("@  500 gram daging sapi tanpa lemak"));
            MyFood.Add(new Recipe("@  1/2 butir kelapa agak muda"));
            MyFood.Add(new Recipe("@  2 lembar daun salam"));
            MyFood.Add(new Recipe("@  1 ibu jari lengkuas, memarkan"));
            MyFood.Add(new Recipe("@  1 tangkai serai, memarkan"));
            MyFood.Add(new Recipe("@  500 ml air"));
            MyFood.Add(new Recipe("@  50 ml minyak goreng"));
            MyFood.Add(new Recipe("Haluskan: "));
            MyFood.Add(new Recipe("@  7 butir bwang merah"));
            MyFood.Add(new Recipe("@  4 siung bawang putih"));
            MyFood.Add(new Recipe("@  2 butir kemiri"));  
            MyFood.Add(new Recipe("@  1 sdm ketumbar sangrai"));
            MyFood.Add(new Recipe("@  3 sdm gula merah, iris"));
            MyFood.Add(new Recipe("@  1/2 sdt asam jawa"));
            MyFood.Add(new Recipe("@  2 sdt garam"));
            //set data context to ListBox; bahan1
            bahan1.DataContext = MyFood;

            MyMethod.Add(new Method("@  Potong-potong daging melintang serat, \n \t  setebal 1 cm. Sisihkan. \n \t  Kupas kulit ari kelapa, \n \t  kemudian parut memanjang. Sisihkan."));
            MyMethod.Add(new Method("@  Campur irisan daging, kelapa parut, \n \t  daun salam, lengkuas, serai, \n \t  dan bumbu yang dihaluskan. \n \t  Aduk rata. Tambahkan air, kemudian masak \n \t  dengan api sedang sambil sesekali diaduk \n \t  sampai air mengering dan daging matang. "));
            MyMethod.Add(new Method("@  Beri minyak goreng masak kembali \n \t  sambil diaduk sampai bumbu kering \n \t  dan melekat pada daging. "));
            //set data context to ListBox; cara1 
            cara1.DataContext = MyMethod;

            List<ImageData> datasource = new List<ImageData>()
            {
                new ImageData(){ImagePath="/Assets/Images/DendengRagi3.jpg"}
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