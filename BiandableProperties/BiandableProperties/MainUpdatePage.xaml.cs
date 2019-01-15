using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace BiandableProperties
{
    public partial class MainUpdatePage : StackLayout
    {


        public MainUpdatePage()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty OnSelectFBLoginCommandProperty =
            BindableProperty.Create<mainUpdatePage_Clicked, ICommand>(p => p.OnSelectFBLoginCommand, null);


        public ICommand FBLoginCommand
        {
            get { return (ICommand)GetValue(OnSelectFBLoginCommandProperty);}
            set { SetValue(OnSelectFBLoginCommandProperty, value);}
        }


        public EventHandler onUpdateClickHandler;
         void mainUpdatePage_Clicked(object sender, System.EventArgs e)
        {
            var item = sender as Button;
            if (item != null)
                FBLoginCommand.Execute(item.StyleId);

        }


    }

}
