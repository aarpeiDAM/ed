using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    int player = 1;
    int turn = 0;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        if (turn < 9)
        {
            if (player == 1)
            {
                ((Button)sender).Label = "x";
                player = 2;
                turn++;
            }
            else
            {
                ((Button)sender).Label = "o";
                player = 1;
                turn++;
            }
        }
    }

    protected void Reset(object sender, EventArgs e)
    {
        Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        foreach(Button button in buttons){
            button.Label = "";
        }
        turn = 0;
        player = 1;
    }
}
