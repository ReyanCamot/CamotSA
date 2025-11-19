using CamotWPF.Commands;
using CamotWPF.Stores;
using Domain.Commands;
using Domain.Models;
using Domain.Queries;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CamotWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ItemStore _itemStore;
    }
}