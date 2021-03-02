using System;

namespace Xamarin.Platform.Handlers
{
	public partial class ChartHandler : AbstractViewHandler<IChartView, object>
	{
		protected override object CreateNativeView() => throw new NotImplementedException();

		public static void MapSeriesCount(ChartHandler handler, IChartView chart) { }
	}
}
