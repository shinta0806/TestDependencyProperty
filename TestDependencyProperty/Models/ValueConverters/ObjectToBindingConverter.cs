using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;

namespace TestDependencyProperty.Models.ValueConverters;

internal class ObjectToBindingConverter : IValueConverter
{
	public Object Convert(Object value, Type targetType, Object parameter, String language)
	{
		// parameter でバインドパスを受け取る前提
		Binding binding = new();
		binding.Mode = BindingMode.TwoWay;
		binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
		binding.Path = new PropertyPath(parameter.ToString());
		return binding;
	}

	public Object ConvertBack(Object value, Type targetType, Object parameter, String language) => throw new NotImplementedException();
}
