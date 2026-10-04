namespace Dudelschach
{
    public partial class MainPage : ContentPage
    {
        string mall = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (mall == "X")
            {
                button.IsEnabled = false;
                button.Text = "X";
                mall = "O";
            } else
            {
                button.Text = "O";
                mall = "X";
            }

            /*Verifizierung, ob X in erste Linie gewinnen hat */

            if (button10.Text == "X" && button11.Text == "X" && button12.Text == "X")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "X hat gewinnt", "Ok");
                Wiederholen();
            }

            /*Verifizierung, ob X in erste Linie gewinnen hat */

            if (button10.Text == "X" && button20.Text == "X" && button30.Text == "X")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "X hat gewinnt", "Ok");
                Wiederholen();
            }

            if (button12.Text == "X" && button22.Text == "X" && button32.Text == "X")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "X hat gewinnt", "Ok");
                Wiederholen();
            }

            if (button11.Text == "X" && button21.Text == "X" && button31.Text == "X")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "O hat gewinnt", "Ok");
                Wiederholen();
            }

            /*Verifizierung, ob X in die Diagonal gewinnen hat */

            if (button10.Text == "X" && button21.Text == "X" && button32.Text == "X")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "X hat gewinnt", "Ok");
                Wiederholen();
            }

            /*Verifizierung, ob X in die Diagonal gewinnen hat */

            if (button12.Text == "X" && button21.Text == "X" && button30.Text == "X")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "X hat gewinnt", "Ok");
                Wiederholen();
            }

            /*Verifizierung, ob X in die zweite Linie gewinnen hat */

            if (button20.Text == "X" && button21.Text == "X" && button22.Text == "X")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "X hat gewinnt", "Ok");
                Wiederholen();
            }

            /*Verifizierung, ob X in die dritte Linie gewinnen hatv */

            if (button30.Text == "X" && button31.Text == "X" && button32.Text == "X")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "X hat gewinnt", "Ok");
                Wiederholen();
            }




            /*Verifizierung, ob O in erste Linie gewinnen hat */

            if (button10.Text == "O" && button11.Text == "O" && button12.Text == "O")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "O hat gewinnt", "Ok");
                Wiederholen();
            }

            /*Verifizierung, ob O in zweite Linie gewinnen hat */

            if (button20.Text == "O" && button21.Text == "O" && button22.Text == "O")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "O hat gewinnt", "Ok");
                Wiederholen();
            }

            /*Verifizierung, ob O in dritte Linie gewinnen hat */

            if (button30.Text == "O" && button31.Text == "O" && button32.Text == "O")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "O hat gewinnt", "Ok");
                Wiederholen();
            }

            /*Verifizierung, ob O in die Diagonal gewinnen hat */

            if (button12.Text == "O" && button21.Text == "O" && button30.Text == "O")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "O hat gewinnt", "Ok");
                Wiederholen();
            }

            /*Verifizierung, ob O in die Diagonal gewinnen hat */

            if (button12.Text == "O" && button21.Text == "O" && button32.Text == "O")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "O hat gewinnt", "Ok");
                Wiederholen();
            }

            /*Verifizierung, ob O in erste Linie gewinnen hat */

            if (button10.Text == "O" && button20.Text == "O" && button30.Text == "O")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "O hat gewinnt", "Ok");
                Wiederholen();
            }

            if (button11.Text == "O" && button21.Text == "O" && button31.Text == "O")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "O hat gewinnt", "Ok");
                Wiederholen();
            }

            if (button12.Text == "O" && button22.Text == "O" && button32.Text == "O")
            {
                DisplayAlert("Herzlich Glueckwunsch!", "O hat gewinnt", "Ok");
                Wiederholen();
            }
        }

        void Wiederholen()
        {
            /* Erste Linie */
            button10.Text = "";
            button10.IsEnabled = true;
            button11.Text = "";
            button11.IsEnabled = true;
            button12.Text = "";
            button12.IsEnabled = true;

            /*Zweite Linie */
            button20.Text = "";
            button20.IsEnabled = true;
            button21.Text = "";
            button21.IsEnabled = true;
            button22.Text = "";
            button22.IsEnabled = true;

            /*Dritte Linie*/
            button30.Text = "";
            button30.IsEnabled = true;
            button31.Text = "";
            button31.IsEnabled = true;
            button32.Text = "";
            button32.IsEnabled = true;
        }
    }
}
