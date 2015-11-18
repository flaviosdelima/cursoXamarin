using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CursoAndroid
{
    [Activity(Label = "Curso", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;
        ImageView imageCourse;
        TextView textDescription;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            textTitle = FindViewById<TextView>(Resource.Id.textTitle);
            imageCourse = FindViewById<ImageView>(Resource.Id.imageCourse);
            textDescription = FindViewById<TextView>(Resource.Id.textDescription);

            buttonPrev.Click += ButtonPrev_Click;
            buttonNext.Click += ButtonNext_Click;
            
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            textTitle.Text = "Clicou no anterior";
            textDescription.Text = "Clicou no anterior isto é uma descrição";
            imageCourse.SetImageResource(Resource.Drawable.ps_top_card_01);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            textTitle.Text = "Clicou no proximo";
            textDescription.Text = "Clicou no proximo isto é uma descrição";
            imageCourse.SetImageResource(Resource.Drawable.ps_top_card_02);
        }
    }
}

