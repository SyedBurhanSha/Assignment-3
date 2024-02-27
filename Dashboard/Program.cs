using Dashboards;

class Program
{
    static void Main(string[] args)
    {
        Dashboard dashboard = new Dashboard();

        // Create and configure a chart widget
        ChartWidget chartWidget = new ChartWidget();
        chartWidget.Configure("Type: Bar, Data: Sales");
        dashboard.AddWidget("Chart1", chartWidget);

        // Clone the chart widget and add it to the dashboard with different configuration
        IWidget clonedWidget = dashboard.GetWidget("Chart1");
        ((ChartWidget)clonedWidget).Configure("Type: Line, Data: Revenue");
        dashboard.AddWidget("Chart2", clonedWidget);

        // Display widgets
        dashboard.GetWidget("Chart1").Display();
        dashboard.GetWidget("Chart2").Display();
    }
}
