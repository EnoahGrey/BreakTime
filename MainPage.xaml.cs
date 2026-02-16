using BreakTime.Custom;

namespace BreakTime;

public partial class MainPage : ContentPage
{
    TimerLogic oTimer = new TimerLogic();
    private bool isRunning = false;
    private bool isWhite = true;
    
    public MainPage()
    {
        InitializeComponent();
        Title = "Break Time";
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        btnTake5.IsEnabled = true;
        btnTake10.IsEnabled = true;
        btnTake15.IsEnabled = true;
        btnStop.IsEnabled = false;
    }

    private void BtnTake5_OnClicked(object sender, EventArgs e)
    {
        btnTake5.IsEnabled = false;
        btnTake10.IsEnabled = false;
        btnTake15.IsEnabled = false;
        btnStop.IsEnabled = true;
        
        oTimer.SetBreakTime(5);
        isRunning = true;

            Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (isRunning)
                {
                    if (oTimer._intMin > 0)
                    {
                        oTimer.SetTickCount(); 
                        lblDisplay.Text = oTimer.MinLeftMessage();
                    }
                    else
                    {
                        lblDisplay.Text = "Time is Up!";
                        if (isWhite)
                        {
                            ftmMain.Background = Colors.Red;
                            isWhite = false;
                        }
                        else
                        {
                            ftmMain.Background = Colors.White;
                            isWhite = true;
                        }
                    }
                }
                return isRunning;
            });
    }

    private void BtnTake10_OnClicked(object sender, EventArgs e)
    {
        btnTake5.IsEnabled = false;
        btnTake10.IsEnabled = false;
        btnTake15.IsEnabled = false;
        btnStop.IsEnabled = true;
        
        oTimer.SetBreakTime(10);
        isRunning = true;

        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            if (isRunning)
            {
                if (oTimer._intMin > 0)
                {
                    oTimer.SetTickCount(); 
                    lblDisplay.Text = oTimer.MinLeftMessage();
                }
                else
                {
                    lblDisplay.Text = "Time is Up!";
                    if (isWhite)
                    {
                        ftmMain.Background = Colors.Red;
                        isWhite = false;
                    }
                    else
                    {
                        ftmMain.Background = Colors.White;
                        isWhite = true;
                    }
                }
            }
            return isRunning;
        });
    }

    private void BtnTake15_OnClicked(object sender, EventArgs e)
    {
        btnTake5.IsEnabled = false;
        btnTake10.IsEnabled = false;
        btnTake15.IsEnabled = false;
        btnStop.IsEnabled = true;
        
        oTimer.SetBreakTime(15);
        isRunning = true;

        Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            if (isRunning)
            {
                if (oTimer._intMin > 0)
                {
                    oTimer.SetTickCount(); 
                    lblDisplay.Text = oTimer.MinLeftMessage();
                }
                else
                {
                    lblDisplay.Text = "Time is Up!";
                    if (isWhite)
                    {
                        ftmMain.Background = Colors.Red;
                        isWhite = false;
                    }
                    else
                    {
                        ftmMain.Background = Colors.White;
                        isWhite = true;
                    }
                }
            }
            return isRunning;
        });
    }

    private void BtnStop_OnClicked(object sender, EventArgs e)
    {
        btnTake5.IsEnabled = true;
        btnTake10.IsEnabled = true;
        btnTake15.IsEnabled = true;
        btnStop.IsEnabled = false;
        isRunning = false;
        isWhite = true;
    }
}