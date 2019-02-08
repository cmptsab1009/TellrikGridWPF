using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Filtering.Editors;
using Telerik.Windows.Data;

namespace TelerikWpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ObservableCollection<Player> players = new ObservableCollection<Player>();
        public Window1()
        {
            InitializeComponent();


            players = new ObservableCollection<Player>();
            players.Add(new Player() { Name = "Jamie Carragher", Number = "23", Num1 = 3, Num2 = 1, });
            players.Add(new Player() { Name = "Pepe Reina", Number = "25", Num1 = 1, Num2 = 1, });
            players.Add(new Player() { Name = "Pepe Reina", Number = "25", Num1 = 5, Num2 = 1, });
            players.Add(new Player() { Name = "Jamie Carragher", Number = "23", Num1 = 3, Num2 = 1, });
            players.Add(new Player() { Name = "Steven Gerrard", Number = "8", Num1 = 4, Num2 = 1, });
            players.Add(new Player() { Name = "Fernando Torres", Number = "9", Num1 = 5, Num2 = 1, });
                        
            foreach (PropertyInfo prop in typeof(Player).GetProperties())
            {
                GridViewDataColumn column = new GridViewDataColumn();
                column.DataMemberBinding = new Binding(prop.Name);
                column.Header = prop.Name;
                column.UniqueName = prop.Name;
                this.playersGrid.Columns.Add(column);
            }

            this.playersGrid.ItemsSource = players;






            //GridViewDataColumn column = new GridViewDataColumn();
            //column.DataMemberBinding = new Binding("Id");
            //column.DataMemberBinding
            //this.playersGrid.Columns.Add(column);
            //this.playersGrid.
            //this.playersGrid.EnableCustomFiltering = true;
            //this.playersGrid.CustomFiltering += new GridViewCustomFilteringEventHandler(playersGrid_CustomFiltering);
            //FilterDescriptor descriptor = new FilterDescriptor("UnitsInStock", FilterOperator.IsGreaterThan, 0);
            //descriptor.IsFilterEditor = true;
            //this.playersGrid.FilterDescriptors.Add(descriptor);



        }

        private void playersGrid_FieldFilterEditorCreated(object sender, Telerik.Windows.Controls.GridView.EditorCreatedEventArgs e)
        {
            //get the StringFilterEditor in your RadGridView 
            var stringFilterEditor = e.Editor as StringFilterEditor;
            //var stringFilterEditor = e.Editor as StringFilterEditor;

            //var colTType = e.Column.sea

            if (stringFilterEditor != null)
            {
                //stringFilterEditor.
                stringFilterEditor.MatchCaseVisibility = Visibility.Hidden;
            }
        }
        public IEnumerable<object> GetColumn(ObservableCollection<Player> items, string columnName)
        {
            var values = items.Select(x => x.GetType().GetProperty(columnName).GetValue(x));
            return values;
        }

        //hide filters
        private void playersGrid_FilterOperatorsLoading(object sender, Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs e)
        {

            var temp = ((Telerik.Windows.Controls.GridViewBoundColumnBase)e.Column).DataType;
            if (temp.Name.Equals("String"))
            {
                e.Column.ShowDistinctFilters = false;
            }
            else
            {
                // needs to show filters
                //1. Filnd the column header Name
                //2. Get disctinct value form the collection for the column identified
                //3. Pass/load the distinct values into the ShowDistinctFilters

                var header = e.Column.Header;
                var result = GetColumn(players, header.ToString());
                var d = result.Distinct().ToList();

                Telerik.Windows.Controls.GridViewColumn countryColumn = this.playersGrid.Columns[header.ToString()];
                Telerik.Windows.Controls.GridView.IColumnFilterDescriptor countryFilter = countryColumn.ColumnFilterDescriptor;

                // Suspend the notifications to avoid multiple data engine updates 
                countryFilter.SuspendNotifications();

                // This is the same as the end user selecting a distinct value through the UI. 
                countryFilter.DistinctFilter.RemoveDistinctValue("1");
                countryFilter.DistinctFilter.RemoveDistinctValue("3");
                //countryFilter.DistinctFilter.AddDistinctValue("Uzbekistan");
                //countryFilter.DistinctFilter.AddDistinctValue("Netherlands");
                //countryFilter.DistinctFilter.AddDistinctValue("Austria");
                //countryFilter.DistinctFilter.AddDistinctValue("Finland");
                //countryFilter.DistinctFilter.AddDistinctValue("Pakistan");

                //playersGrid_DistinctValuesLoading.FindResource
                //e.Column.FilteringControlStyle.DistinctValuesLoading
                //

            }
            //if (e.Column.UniqueName == "Num1")
            //{
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.Contains);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.DoesNotContain);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.EndsWith);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsContainedIn);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsEmpty);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsEqualTo);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsGreaterThan);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsLessThan);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsLessThanOrEqualTo);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotContainedIn);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotEmpty);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotEqualTo);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotNull);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNull);
            //    e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.StartsWith);

            //    //var d = e.DefaultOperator1.Value;

            //    //e.AvailableOperators.Remove(Telerik.Windows.Data.filterop)



            //}
            //var s = e.Column.FilteringControl;
            //var s1 = e.Column.GetType();
            //var s2 = e.Column.ItemType;
            //            if ()
        }

        public void CreateColumn()
        {

        }

        private void playersGrid_DistinctValuesLoading(object sender, Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs e)
        {
            //var client = ((MyDataContext)DataContext).Client;
            //var collection = new RadObservableCollection<object>();

            //e.ItemsSource = collection;

            //client.GetDistinctValuesCompleted += (s, args) =>
            //{
            //    collection.Clear();
            //    collection.AddRange(args.Result);
            //};

            //client.GetDistinctValuesAsync(e.Column.UniqueName);
        }


    }

    public class Player
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
    }
}
