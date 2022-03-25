using System.Collections.Generic;
using System.Windows;
using System;

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Window
    {
        public ExpenseItHome()
        {
            InitializeComponent();

            this.DataContext = this;

            LastChecked = DateTime.Now;

            ExpenseDataSource = new List<Person>()
            {
                new Person()
                {
                    Name ="Mike",
                    Department ="Legal",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Lunch", ExpenseAmount =50 },
                        new Expense() { ExpenseType="Transportation", ExpenseAmount=50 }
                    }
                },
                new Person()
                {
                    Name ="Lisa",
                    Department ="Marketing",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Document printing", ExpenseAmount=50 },
                        new Expense() { ExpenseType="Gift", ExpenseAmount=125 }
                    }
                },
                new Person()
                {
                    Name ="John",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Magazine subscription", ExpenseAmount=50 },
                        new Expense() { ExpenseType="New machine", ExpenseAmount=600 },
                        new Expense() { ExpenseType="Software", ExpenseAmount=500 }
                    }
                },
                new Person()
                {
                    Name ="Mary",
                    Department ="Finance",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                    }
                },
                new Person()
                {
                    Name ="Theo",
                    Department ="Marketing",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                    }
                },
                new Person()
                {
                    Name ="James",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Dinner", ExpenseAmount=600 },
                        new Expense() { ExpenseType="Magazine subscription", ExpenseAmount=50 }
                    }
                },
                new Person()
                {
                    Name ="David",
                    Department ="Finance",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                    }
                }
            };
        }

        public DateTime LastChecked { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport expenseReportWindow = new ExpenseReport(peopleListBox.SelectedItem)
            {
                Height = this.Height,
                Width = this.Width
            };
            expenseReportWindow.ShowDialog();
        }

        public List<Person> ExpenseDataSource { get; set; }
    }
}
