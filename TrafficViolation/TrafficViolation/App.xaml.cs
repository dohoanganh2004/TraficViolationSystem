using System.Configuration;
using System.Data;
using System.Windows;
using TrafficViolation.DAL.Models;

namespace TrafficViolation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static User? LoggedInUser { get; set; }
    }

}
