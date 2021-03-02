using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xamarin.Android.Charts;
using Java.Interop;
using UIKit;
using Native = DevExpress.Xamarin.Android.Charts;

namespace Xamarin.Platform.Handlers
{
    public partial class ChartHandler : AbstractViewHandler<IChartView, UIView>
    {

        protected override UIView CreateNativeView()
		{
			return new UIView();
		}

		protected override void ConnectHandler(UIView nativeView)
		{
			

			base.ConnectHandler(nativeView);
		}

		protected override void DisconnectHandler(UIView nativeView)
		{
			

			base.DisconnectHandler(nativeView);
		}

		public static void MapSeriesCount(ChartHandler handler, IChartView chart)
		{
			ViewHandler.CheckParameters(handler, chart);

			// TODO RR
		}
    }

 //   class DataObject
	//{
 //       public double Argument { get; }
 //       public double Value { get; }

 //       public DataObject(double argument, double value)
	//	{
 //           this.Argument = argument;
 //           this.Value = value;
	//	}
	//}

	//class DataAdapter : Java.Lang.Object, INumericSeriesData
	//{
 //       readonly List<DataObject> data;

 //       public DataAdapter(List<DataObject> data)
	//	{
 //           this.data = data;
	//	}

 //       int INumericSeriesData.DataCount => data.Count;

	//	double INumericSeriesData.GetArgument(int index)
	//	{
 //           return data[index].Argument;
	//	}

	//	double INumericSeriesData.GetValue(int index)
	//	{
 //           return data[index].Value;
 //       }
	//}
}
