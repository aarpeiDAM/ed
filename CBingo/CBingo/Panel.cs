using System;
using Gtk;
namespace CBingo
{
    public class Panel
    {
        private static uint rows = 9;
        private static uint columns = 10;
        public Panel(VBox vBox)
        {
            Table table = new Table(rows,columns,true);
            int index = 0;
            for (uint row = 0; row < rows; row++)
            {
                for(uint column = 0; column < columns;column++){
                    index++;
                    Button button = new Button();
                    button.Label = index.ToString();
                    table.Attach(button,column,column+1,row,row+1);
                }

            }
            table.ShowAll();
            vBox.Add(table);
        }
        public void Marcar(int numero){

        }
    }
}
