using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galazkiewicz.ProjectTireCatalog.Interfaces;
using Galazkiewicz.ProjectTireCatalog.Core;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace Galazkiewicz.ProjectTireCatalog.WPF.ViewModel
{
    public class TireViewModel : ViewModelBase
    {
        private ITire _tire;
        public ITire Tire
        {
            get => _tire;
        }

        private ObservableCollection<IProducer> _producers;
        public ObservableCollection<IProducer> Producers
        {
            get => _producers;
        }

        public TireViewModel(ITire tire, List<IProducer> producers)
        {
            _tire = tire;
            _producers = new ObservableCollection<IProducer>(producers);
        }

        [Required(ErrorMessage = "Producer is required")]
        public IProducer Producer
        {
            get => _tire.Producer;
            set
            {
                _tire.Producer = value;
                Validate();
                OnPropertyChanged("Producer");
            }
        }

        [Required(ErrorMessage = "Name is required!")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "Name length have to be in range <1,40>")]
        public string Model
        {
            get => _tire.Model;
            set
            {
                _tire.Model = value;
                Validate();
                OnPropertyChanged("Model");
            }
        }

        [Required(ErrorMessage = "Weight is required!")]
        [Range(0, double.MaxValue, ErrorMessage = "Weight cannot be less than 0!")]
        public double Waga
        {
            get => _tire.Waga;
            set
            {
                _tire.Waga = value;
                Validate();
                OnPropertyChanged("Waga");
            }
        }

        public Purpose PurposeType
        {
            get => _tire.PurposeType;
            set
            {
                _tire.PurposeType = value;
                Validate();
                OnPropertyChanged("PurposeType");
            }
        }

        public void Validate()
        {
            var validationContext = new ValidationContext(this, null, null);
            var validationResults = new List<ValidationResult>();

            Validator.TryValidateObject(this, validationContext, validationResults, true);

            foreach (var kv in _errors.ToList())
            {
                if (validationResults.All(r => r.MemberNames.All(m => m != kv.Key)))
                {
                    _errors.Remove(kv.Key);
                    RaiseErrorChanged(kv.Key);
                }
            }

            var q = from r in validationResults
                    from m in r.MemberNames
                    group r by m into g
                    select g;

            foreach (var prop in q)
            {
                var messages = prop.Select(r => r.ErrorMessage).ToList();

                if (_errors.ContainsKey(prop.Key))
                {
                    _errors.Remove(prop.Key);
                }
                _errors.Add(prop.Key, messages);

                RaiseErrorChanged(prop.Key);
            }
        }

        /*public void Validate()
        {
            RemoveErrors(nameof(PurposeType));
            RemoveErrors(nameof(Waga));
            RemoveErrors(nameof(Model));
            RemoveErrors(nameof(ProducerName));

            if (PurposeType != Purpose.XC && PurposeType != Purpose.MTB)
            {
                AddError(nameof(PurposeType), "Purpose type can be only XC or MTB");
            }
            if (Waga <= 0)
            {
                AddError(nameof(Waga), "Incorrect weight");
            }

            if (Model.Length == 0)
            {
                AddError(nameof(Model), "Model have to be specified");
            }

            if (ProducerName.Length == 0)
            {
                AddError(nameof(ProducerName), "Producer name have to be specified");
            }
        }*/

    }
}
