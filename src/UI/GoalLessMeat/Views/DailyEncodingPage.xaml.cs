using GoalLessMeat.Domain.Enums;
using GoalLessMeat.ViewModels;

namespace GoalLessMeat.Views;

public partial class DailyEncodingPage : ContentPage
{
    public DailyEncodingViewModel DailyEncodingViewModel => BindingContext as DailyEncodingViewModel;

    public DailyEncodingPage(DailyEncodingViewModel dailyEncodingViewModel)
    {
        BindingContext = dailyEncodingViewModel;
        InitializeComponent();
    }
}