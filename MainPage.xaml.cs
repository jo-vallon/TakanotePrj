namespace Takanote;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		SetUpMainPage();
    }

	private void SetUpMainPage()
	{
		try
		{
			txt_current_time.Text = DateTime.Now.ToString("dddd, dd MMMM, yyyy");
			txt_time_message.Text = GetCurrentTimeMessage();
			lst_tasks.ItemsSource = new List<string>() { "test", "test", "test", "test", "test", "test", "test", "test", "test"};
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private string GetCurrentTimeMessage()
	{
		try
		{
			var hour = DateTime.Now.Hour;
			if (hour >= 4 && hour < 12)
			{
				return "Good morning!";
			}
            else if (hour >= 12 && hour < 17)
            {
                return "Good afternoon!";
            }
            else
            {
                return "Good evening!";
            }
        }
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
			return "Hello!";
		}
	}
}

