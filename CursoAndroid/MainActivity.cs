using System;
using Android.App;
using Android.Widget;
using Android.OS;
using ClassLibraryCurso;

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
        CourseManager courseManager;

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
            courseManager = new CourseManager();
            courseManager.moveFirst();
            updateUI();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            courseManager.movePrev();
            updateUI();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            courseManager.moveNext();
            updateUI();

        }

        private void updateUI()
        {
            textTitle.Text = courseManager.Current.Title;
            textDescription.Text = courseManager.Current.Description;
            imageCourse.SetImageResource(ResourceHelper.TranslateDrawableWithReflection(courseManager.Current.Image));

            //imageCourse.SetImageResource(ResourceHelper.TranslateDrawable(courseManager.Current.Image));

            buttonNext.Enabled = courseManager.canMoveNext;
            buttonPrev.Enabled = courseManager.canMovePrev;
        }
    }
}

