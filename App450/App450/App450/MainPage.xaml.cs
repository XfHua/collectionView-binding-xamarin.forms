using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App450
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<myModel> models = new ObservableCollection<myModel>();

        public MainPage()
        {
            InitializeComponent();

            myModel model1 = new myModel() { FirstFrameBackColor = Color.White, SecondFrameBackColor = Color.Purple };
            myModel model2 = new myModel() { FirstFrameBackColor = Color.White, SecondFrameBackColor = Color.Purple };
            myModel model3 = new myModel() { FirstFrameBackColor = Color.White, SecondFrameBackColor = Color.Purple };
            myModel model4 = new myModel() { FirstFrameBackColor = Color.White, SecondFrameBackColor = Color.Purple };
            myModel model5 = new myModel() { FirstFrameBackColor = Color.White, SecondFrameBackColor = Color.Purple };
            myModel model6 = new myModel() { FirstFrameBackColor = Color.White, SecondFrameBackColor = Color.Purple };
            myModel model7 = new myModel() { FirstFrameBackColor = Color.White, SecondFrameBackColor = Color.Purple };

            models.Add(model1);
            models.Add(model2);
            models.Add(model3);
            models.Add(model4);
            models.Add(model5);
            models.Add(model6);
            models.Add(model7);

            CNlist.ItemsSource = models;
        }

        private void CNlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            myModel previous = (e.PreviousSelection.FirstOrDefault() as myModel) ;
            myModel current = (e.CurrentSelection.FirstOrDefault() as myModel);

            //Set the current to the color you want
            current.FirstFrameBackColor = Color.Pink;
            current.SecondFrameBackColor = Color.Green;

            if (previous != null)
            {
                //Reset the previous to defaulr color
                previous.FirstFrameBackColor = Color.White;
                previous.SecondFrameBackColor = Color.Purple;
            }

        }
    }

    class myModel : INotifyPropertyChanged
    {

        Color firstFrameBackColor;

        Color secondFrameBackColor;

        public event PropertyChangedEventHandler PropertyChanged;

        public myModel()
        {
       
        }

        public Color FirstFrameBackColor
        {
            set
            {
                if (firstFrameBackColor != value)
                {
                    firstFrameBackColor = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("FirstFrameBackColor"));
                    }
                }
            }
            get
            {
                return firstFrameBackColor;
            }
        }

        public Color SecondFrameBackColor
        {
            set
            {
                if (secondFrameBackColor != value)
                {
                    secondFrameBackColor = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("SecondFrameBackColor"));
                    }
                }
            }
            get
            {
                return secondFrameBackColor;
            }
        }
    }

}
