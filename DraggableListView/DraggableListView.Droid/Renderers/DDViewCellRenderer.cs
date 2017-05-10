using Android.Views;
using DraggableListView;
using DraggableListView.Droid.Custom;
using DraggableListView.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(DDViewCell), typeof(DDViewCellRenderer))]
namespace DraggableListView.Droid.Renderers
{
    public class DDViewCellRenderer : ViewCellRenderer
    {
        protected override global::Android.Views.View GetCellCore(Xamarin.Forms.Cell item, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent, global::Android.Content.Context context)
        {
            var cell = base.GetCellCore(item, convertView, parent, context) as ViewGroup;

            cell.SetOnDragListener(new ItemDragListener(cell));
            return cell;
        }
    }
}