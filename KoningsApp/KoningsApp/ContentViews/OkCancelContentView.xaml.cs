using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KoningsApp.ContentViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OkCancelContentView : ContentView
    {
        public event EventHandler ClickedOK;
        public event EventHandler ClickedCancel;
        public OkCancelContentView()
        {
            InitializeComponent();
        }

        

        private void Button_OnClickedCancel(object sender, EventArgs e)
        {
            ClickedCancel.Invoke(sender,e);
        }

        private void Button_OnClickedOk(object sender, EventArgs e)
        {
            ClickedOK.Invoke(sender, e);
        }
    }
}