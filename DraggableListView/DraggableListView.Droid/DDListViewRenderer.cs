using Android.App;
using DraggableListView;
using DraggableListView.Droid;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(DDListView), typeof(DDListViewRenderer))]
namespace DraggableListView.Droid
{
    public class DDListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var list = new DraggableListView(base.Context);

                var items = new List<string> {
                    "Vegetables",
                    "Fruits",
                    "Flower Buds",
                    "Legumes",
                    "Vegetables",
                    "Fruits",
                    "Flower Buds",
                    "Legumes",
                };
                var activity = Context as Activity;
                list.Adapter = new DraggableListAdapter(activity, items);
                base.SetNativeControl(list);
            }
            
        }
    }
}