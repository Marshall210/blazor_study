using System.Collections.Generic;

namespace Blazor1.Models
{

        
    public class AppStyle
    {
        public string Color { get; set; } = "blue";
        public string Size { get; set; } = "65px";

        public List<string> WitcherWords { get; set; } = new List<string>()
        {
            new string("Интерфейс отвечает на вопрос что делать (не как ), что принимает что возвращет только МЕТОДЫ List<Page> GetAllPages()"),
            new string("Класс реализации интерфейса отвечает на вопрос как будет выполняться действие GetAllPages"),
            new string("Если нужно вывести на экран весь коунтер можно просто вставить Blazor1.Pages.Counter")
        };

        public List<TableListModel> TableStyle { get; set; } = new List<TableListModel>()
        {
            new TableListModel() {Text = "Table Dark", Value = "table-dark"},
            new TableListModel() {Text = "Table Striped", Value = "table-striped"},
            new TableListModel() {Text = "Table Bordered", Value = "table-bordered"},
        };
    }
}

