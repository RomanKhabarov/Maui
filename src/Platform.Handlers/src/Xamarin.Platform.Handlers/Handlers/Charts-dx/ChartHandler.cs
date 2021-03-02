using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Platform.Handlers
{
	public partial class ChartHandler
	{
		public static PropertyMapper<IChartView, ChartHandler> ChartMapper = new PropertyMapper<IChartView, ChartHandler>(ViewHandler.ViewMapper)
		{
			[nameof(IChartView.SeriesCount)] = MapSeriesCount
		};

		public ChartHandler() : base(ChartMapper)
		{

		}

		public ChartHandler(PropertyMapper mapper) : base(mapper ?? ChartMapper)
		{

		}
	}
}

