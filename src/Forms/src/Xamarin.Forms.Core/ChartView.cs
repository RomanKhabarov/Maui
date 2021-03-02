using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms
{
	public partial class ChartView : View, IElementConfiguration<ChartView>
	{
		public static readonly BindableProperty SeriesCountProperty = BindableProperty.Create(nameof(SeriesCount), typeof(int), typeof(ChartView), 3, propertyChanged: (bindable, oldValue, newValue) => { }, defaultBindingMode: BindingMode.TwoWay);

		public int SeriesCount
		{
			get { return (int)GetValue(SeriesCountProperty); }
			set { SetValue(SeriesCountProperty, value); }
		}

		readonly Lazy<PlatformConfigurationRegistry<ChartView>> _platformConfigurationRegistry;

		public ChartView()
		{
			_platformConfigurationRegistry = new Lazy<PlatformConfigurationRegistry<ChartView>>(() => new PlatformConfigurationRegistry<ChartView>(this));
		}

		public IPlatformElementConfiguration<T, ChartView> On<T>() where T : IConfigPlatform
		{
			return _platformConfigurationRegistry.Value.On<T>();
		}
	}
}
