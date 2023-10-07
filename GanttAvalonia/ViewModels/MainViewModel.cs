using GanttAvalonia.Models;
using System;
using System.Collections.ObjectModel;

namespace GanttAvalonia.ViewModels;

public class MainViewModel : ViewModelBase
{
    public ObservableCollection<GanttTask> Tasks { get; } = new()
    {
        new("Take a shower", "Don't waste too much shampoo", new DateTime(2023, 7, 12, 15, 0, 0), new DateTime(2023, 7, 12, 23, 0, 0))
    };
}
