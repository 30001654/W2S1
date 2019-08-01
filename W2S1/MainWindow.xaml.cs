using System;
using System.Collections;
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

namespace W2S1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageDictionary.createDictionary();
            AddListItems.AddItemsToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(AddListItems.a());
        }
    }

    public class ImageDictionary
    {
        public static Dictionary<string, string> imgDictionary = new Dictionary<string, string>();
        public static void createDictionary()
        {
            imgDictionary.Add("1", "Cars");
            imgDictionary.Add("2", "Cars");
            imgDictionary.Add("3", "Lizards");
            imgDictionary.Add("4", "Lizards");
            imgDictionary.Add("5", "GCards");
            imgDictionary.Add("6", "GCards");
        }
    }

    public class AddListItems
    {
        public static ArrayList dictionaryList = new ArrayList(ImageDictionary.imgDictionary.Values);
        public static ArrayList categoryList = new ArrayList();

        public static void AddItemsToList()
        {
            categoryList.Add(dictionaryList[0]);
            for (int i = 0; i < dictionaryList.Count; i++)
            {
                if (!categoryList.Contains(dictionaryList[i]))
                {
                    categoryList.Add(dictionaryList[i]);
                }
            }
        }

        public static string a()
        {
            string x = "";
            for (int i = 0; i < categoryList.Count; i++)
            {
                x += categoryList[i];
            }
            return x;
        }
    }
}
