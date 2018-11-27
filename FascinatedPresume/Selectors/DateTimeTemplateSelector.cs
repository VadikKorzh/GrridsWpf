using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FascinatedPresume.Selectors
{
    class DateTimeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate HighLightTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

        public override DataTemplate SelectTemplate(Object item, DependencyObject container)
        {
            DateTime dateTime = (DateTime)item;

            if (dateTime.Month > 6)
            {
                return HighLightTemplate;
            }
            else
            {
                return DefaultTemplate;
            }
        }
    }
}
