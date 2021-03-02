using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Platform
{
	public interface IChartView : IView
	{
		int SeriesCount { get; set; }
	}
}
