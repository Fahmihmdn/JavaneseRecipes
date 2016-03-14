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
    public partial class MasakNus : PhoneApplicationPage
    {
        public ObservableCollection<Recipe> MyFood = new ObservableCollection<Recipe>();
        public ObservableCollection<Method> MyMethod = new ObservableCollection<Method>();
        public MasakNus()
        {
            InitializeComponent();
            MyFood.Add(new Recipe("@  500 gram cumi basah (pilih yang kecil-kecil)"));
            MyFood.Add(new Recipe("@  2 sdm minyak untuk menumis"));
            MyFood.Add(new Recipe("@  4 siung bawang putih, tumbuk kasar"));
            MyFood.Add(new Recipe("@  2 lembar daun salam"));
            MyFood.Add(new Recipe("@  3 cm lengkuas, memarkan"));
            MyFood.Add(new Recipe("@  1 sdm gula pasir"));
            MyFood.Add(new Recipe("@  1 sdt garam"));
            MyFood.Add(new Recipe("@  1 sdm kecap manis"));
            MyFood.Add(new Recipe("                       "));
        
            //set data context to ListBox; bahan1
            bahan1.DataContext = MyFood;

            MyMethod.Add(new Method("@  Pisahkan badan dan kepala cumi, \n \t  buang kulit arinya (jangan buang tintanya). \n \t  Sisihkan."));
            MyMethod.Add(new Method("@  Panaskan minyak, tumis bawang putih, \n \t  daun salam dan lengkuas sampai harum. \n \t  Masukkan cumi beserta kepala dan tintanya. \n \t  Aduk-aduk sampai cumi berair. Kecilkan apinya"));
            MyMethod.Add(new Method("@  Beri kecap manis, aduk lalu \n \t  masak sampai kuahnya kental \n \t  dan hitam. Angkat. "));
            //set data context to ListBox; cara1 
            cara1.DataContext = MyMethod;

            List<ImageData> datasource = new List<ImageData>()
            {
                new ImageData(){ImagePath="/Assets/Images/MasakNus3.jpg"}
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