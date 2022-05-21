using FABControl_XamarinForms.AnimationFactory;
using FABControl_XamarinForms.Interface;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FABControl_XamarinForms.Controls
{
        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class FABControl : ContentView
        {
                static IAnimation ani;
                public FABControl()
                {
                        InitializeComponent();
                        ani = new Scale(FABSub1, FABSub2, FABSub3);
                }

                private void FABMain_Clicked(object sender, EventArgs e)
                {
                        var Clearani = ani.Clear();
                        if (Clearani != null)
                        {
                                Clearani.Commit(this, "FabMainAnimation");
                        }
                        ani.GetAnimation().Commit(this, "FabMainAnimation");
                }
                public delegate void ClickedHandler(object sender, EventArgs e);
                public event ClickedHandler SubButton1Clicked;
                public event ClickedHandler SubButton2Clicked;
                public event ClickedHandler SubButton3Clicked;

                private void FabSub1_Clicked(object sender, EventArgs e)
                {
                        this.SubButton1Clicked?.Invoke(sender, e);
                }

                private void FabSub2_Clicked(object sender, EventArgs e)
                {
                        this.SubButton2Clicked?.Invoke(sender, e);
                }

                private void FabSub3_Clicked(object sender, EventArgs e)
                {
                        this.SubButton3Clicked?.Invoke(sender, e);
                }
        }
}