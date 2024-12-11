using System.Collections.ObjectModel;

using Mvvm.Models;
using Mvvm.ViewModels;
using Microsoft.EntityFrameworkCore;
using Mvvm.Models.Entities;

public class UserViewModel : NotifyProperty
{
    private readonly MvvmContext db = new MvvmContext();
    public ObservableCollection<CarEntity> CarEntities { get => db.CarEntities.Local.ToObservableCollection(); }

    public UserViewModel()
    {
        db.CarEntities.Load();
    }
} 