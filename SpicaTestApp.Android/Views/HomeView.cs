using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace SpicaTestApp.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "View for HomeViewModel", Theme = "@style/MainTheme")]
    public class HomeView : MvxAppCompatActivity
    {
        private MvxRecyclerView todoListRecyclerView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HomeView);

            todoListRecyclerView = FindViewById<MvxRecyclerView>(Resource.Id.todo_recycler);

            if (todoListRecyclerView != null)
            {
                todoListRecyclerView.HasFixedSize = true;
                var layoutManager = new LinearLayoutManager(this);
                
                todoListRecyclerView.SetLayoutManager(layoutManager);
                var dividerItemDecoration = new DividerItemDecoration(todoListRecyclerView.Context,
                                                                                        layoutManager.Orientation);
                todoListRecyclerView.AddItemDecoration(dividerItemDecoration);
            }

        }
    }
}
