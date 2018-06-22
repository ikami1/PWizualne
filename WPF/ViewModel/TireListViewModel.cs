using Galazkiewicz.ProjectTireCatalog.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Galazkiewicz.ProjectTireCatalog.WPF.ViewModel
{
    public class TireListViewModel: ViewModelBase
    {
        BLC.DataProvider dataProvider;
        public ObservableCollection<TireViewModel> Tires { get; set; } = new ObservableCollection<TireViewModel>();

        private ListCollectionView _view;

        private RelayCommand _filterDataCommand;
        public RelayCommand FilterDataCommand { get => _filterDataCommand; }

        public string FilterValue { get; set; }

        public TireListViewModel()
        {
            dataProvider = new BLC.DataProvider(Properties.Settings.Default.baza);
            OnPropertyChanged("Tires");
            GetAllTires();
            _view = (ListCollectionView)CollectionViewSource.GetDefaultView(Tires);
            _filterDataCommand = new RelayCommand(param => this.FilterData());
            _addNewTireCommand = new RelayCommand(param => this.AddNewTire(), param => this.CanAddNewTire());
            _saveTireCommand = new RelayCommand(param => this.SaveTire(), param => this.CanSaveTire());

            EditedTire = Tires[0];
            SelectedTire = EditedTire;
        }

        private void GetAllTires()
        {
            List<IProducer> producers = (List<IProducer>)dataProvider.Producers;
            foreach (var tire in dataProvider.Tires)
            {
                Tires.Add(new TireViewModel(tire, producers));
            }
        }

        private void FilterData()
        {
            if (string.IsNullOrEmpty(FilterValue))
            {
                _view.Filter = null;
            }
            else
            {
                _view.Filter = (c) => ((TireViewModel)c).Model.Contains(FilterValue);
            }
        }

        private TireViewModel _selectedTire;
        public TireViewModel SelectedTire
        {
            get => _selectedTire;
            set
            {
                _selectedTire = value;
                EditedTire = value;
                OnPropertyChanged(nameof(EditedTire));
            }
        }

        private TireViewModel _editedTire;
        public TireViewModel EditedTire
        {
            get => _editedTire;
            set
            {
                _editedTire = value;
                OnPropertyChanged(nameof(EditedTire));
            }
        }

        private void AddNewTire()
        {
            EditedTire = new TireViewModel(dataProvider.AddNewTire(), (List<IProducer>)dataProvider.Producers);
            EditedTire.Validate();
        }

        private RelayCommand _addNewTireCommand;
        public RelayCommand AddNewTireCommand
        {
            get => _addNewTireCommand;
        }

        private void SaveTire()
        {
            if (!Tires.Contains(EditedTire))
            {
                Tires.Add(EditedTire);
                EditedTire = null;
            }
            EditedTire = null;
        }

        private RelayCommand _saveTireCommand;
        public RelayCommand SaveTireCommand
        {
            get => _saveTireCommand;
        }

        private bool CanSaveTire()
        {

            if (EditedTire != null && !EditedTire.HasErrors)
            {
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }

        private bool CanAddNewTire()
        {
            Console.WriteLine("Jestem2");

            if (EditedTire != null)
                return false;
            return true;
        }
    }
}
