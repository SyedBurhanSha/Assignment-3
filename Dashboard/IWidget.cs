using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboards
{
    public interface IWidget
    {
        IWidget Clone();
        void Configure(string configuration);
        void Display();
    }

class ChartWidget : IWidget
    {
        private string configuration;

        public IWidget Clone()
        {
            return (IWidget)this.MemberwiseClone();
        }

        public void Configure(string configuration)
        {
            this.configuration = configuration;
        }

        public void Display()
        {
            Console.WriteLine($"Displaying chart widget with configuration: {configuration}");
        }
    }

    // Client class
    class Dashboard
    {
        private Dictionary<string, IWidget> widgets = new Dictionary<string, IWidget>();

        public void AddWidget(string key, IWidget widget)
        {
            widgets.Add(key, widget);
        }

        public IWidget GetWidget(string key)
        {
            return widgets[key].Clone();
        }
    }

}
