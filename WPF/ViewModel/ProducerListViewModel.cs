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
    public class ProducerListViewModel : ViewModelBase
    {
        BLC.DataProvider dataProvider;
        public ObservableCollection<ProducerViewModel> Producers { get; set; } = new ObservableCollection<ProducerViewModel>();
        private ListCollectionView _view;

        private RelayCommand _filterDataCommand;
        public RelayCommand FilterDataCommand { get => _filterDataCommand; }

        public string FilterValue { get; set; }

        public ProducerListViewModel()
        {
            dataProvider = new BLC.DataProvider(Properties.Settings.Default.baza);
            OnPropertyChanged("Producers");
            GetAllProducers();
            _view = (ListCollectionView)CollectionViewSource.GetDefaultView(Producers);
            _filterDataCommand = new RelayCommand(param => this.FilterData());
            _addNewProducerCommand = new RelayCommand(param => this.AddNewProducer(), param => this.CanAddNewProducer());
            _saveProducerCommand = new RelayCommand(param => this.SaveProducer(), param => this.CanSaveProducer());

            EditedProducer = Producers[0];
            SelectedProducer = EditedProducer;
        }

        private void GetAllProducers()
        {
            foreach (var producer in dataProvider.Producers)
            {
                Producers.Add(new ProducerViewModel(producer));
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
                _view.Filter = (p) => ((ProducerViewModel)p).Name.Contains(FilterValue);
            }
        }

        private ProducerViewModel _selectedProducer;
        public ProducerViewModel SelectedProducer
        {
            get => _selectedProducer;
            set
            {
                _selectedProducer = value;
                EditedProducer = value;
                OnPropertyChanged(nameof(SelectedProducer));
            }
        }

        private ProducerViewModel _editedProducer;
        public ProducerViewModel EditedProducer
        {
            get => _editedProducer;
            set
            {
                _editedProducer = value;
                OnPropertyChanged(nameof(EditedProducer));
            }
        }

        private void SaveProducer()
        {
            if (!Producers.Contains(EditedProducer))
            {
                Producers.Add(EditedProducer);
                EditedProducer = null;
            }

            EditedProducer = null;
        }

        private bool CanSaveProducer()
        {
            if (EditedProducer != null && !EditedProducer.HasErrors)
            {
                return true;
            }
            return false;
        }

        private RelayCommand _saveProducerCommand;
        public RelayCommand SaveProducerCommand
        {
            get => _saveProducerCommand;
        }

        private void AddNewProducer()
        {
            EditedProducer = new ProducerViewModel(dataProvider.AddProducer());
            EditedProducer.Validate();
        }

        private RelayCommand _addNewProducerCommand;
        public RelayCommand AddNewProducerCommand
        {
            get => _addNewProducerCommand;
        }

        private bool CanAddNewProducer()
        {
            if (EditedProducer != null)
                return false;
            return true;
        }

    }
}
