using System;
using System.Collections.Generic;
using System.Text;
using Android.Runtime;
using DevExpress.Xamarin.Android.Charts;
using Java.Interop;
using Native = DevExpress.Xamarin.Android.Charts;

namespace Xamarin.Platform.Handlers
{
    public partial class ChartHandler : AbstractViewHandler<IChartView, Native.Chart>
    {

        protected override Native.Chart CreateNativeView()
		{
            Native.Chart nativeView = new Native.Chart(Context, null, 0, RenderMode.Surface);

            Native.NumericAxisX axisX = new Native.NumericAxisX();
            Native.NumericAxisY axisY = new Native.NumericAxisY();

			nativeView.AxisX = axisX;
            nativeView.AxisY = axisY;
            nativeView.AxisXNavigationMode = AxisNavigationMode.ScrollingAndZooming;

			return nativeView;
		}

		protected override void ConnectHandler(Native.Chart nativeView)
		{
			

			base.ConnectHandler(nativeView);
		}

		protected override void DisconnectHandler(Native.Chart nativeView)
		{
			

			base.DisconnectHandler(nativeView);
		}

		public static void MapSeriesCount(ChartHandler handler, IChartView chart)
		{
			ViewHandler.CheckParameters(handler, chart);

			for (int i = 0; i < chart.SeriesCount; i++)
			{
				Random rnd = new Random(i);
				Native.LineSeries series = new Native.LineSeries();
				series.Data = new DataAdapter(new List<DataObject>()
				{
					new DataObject(1, rnd.NextDouble()),
					new DataObject(2, rnd.NextDouble()),
					new DataObject(3, rnd.NextDouble()),
					new DataObject(4, rnd.NextDouble()),
					new DataObject(5, rnd.NextDouble()),
				});
				handler?.TypedNativeView?.AddSeries(series);
			}
		}
    }

	class DataObject
	{
		public double Argument { get; }
		public double Value { get; }

		public DataObject(double argument, double value)
		{
			this.Argument = argument;
			this.Value = value;
		}
	}

	class DataAdapter : Java.Lang.Object, INumericSeriesData
	{
		readonly List<DataObject> data;

		public DataAdapter(List<DataObject> data)
		{
			this.data = data;
		}

		int INumericSeriesData.DataCount => data.Count;

		double INumericSeriesData.GetArgument(int index)
		{
			return data[index].Argument;
		}

		double INumericSeriesData.GetValue(int index)
		{
			return data[index].Value;
		}
	}
}
