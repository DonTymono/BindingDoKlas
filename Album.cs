using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace bindingDoKlas
{
    public class Album : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private static Dictionary<string, ICollection<string>> powiązaneWłaściwości
            = new()
            {
                ["Tytuł"] = new string[] { "FormatTytułAutor" },
                ["Autor"] = new string[] { "FormatTytułAutor" },
                ["Nośnik"] = new string[] { "SkrótSzczegółów" },
                ["Długość"] = new string[] { "SkrótSzczegółów" },
                ["DataWydania"] = new string[] { "SkrótSzczegółów" }
            };
        private void NotyfikujZmianę(
            [CallerMemberName] string? nazwaWłaściwości = null,
            HashSet<string> jużZałatwione = null
            )
        {
            if (jużZałatwione == null)
                jużZałatwione = new();
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(nazwaWłaściwości)
                );
            jużZałatwione.Add(nazwaWłaściwości);
            if (powiązaneWłaściwości.ContainsKey(nazwaWłaściwości))
                foreach (string powiązanaWłaściwość in powiązaneWłaściwości[nazwaWłaściwości])
                    if (jużZałatwione.Contains(powiązanaWłaściwość) == false)
                        NotyfikujZmianę(powiązanaWłaściwość, jużZałatwione);
        }

        private string tytuł;
        private string autor;
        private string nośnik;
        private TimeSpan długość;
        private DateTime dataWydania;

        public string Tytuł
        {
            get => tytuł;
            set
            {
                tytuł = value;
                NotyfikujZmianę();
            }
        }
        public string Autor
        {
            get => autor;
            set
            {
                autor = value;
                NotyfikujZmianę();
            }
        }
        public string Nośnik
        {
            get => nośnik;
            set
            {
                nośnik = value;
                NotyfikujZmianę();
            }
        }
        public TimeSpan Długość
        {
            get => długość;
            set
            {
                długość = value;
                NotyfikujZmianę();
            }
        }
        public DateTime DataWydania
        {
            get => dataWydania;
            set
            {
                dataWydania = value;
                NotyfikujZmianę();
            }
        }

        public string FormatTytułAutor => $"{Tytuł} - {Autor}";
        public string SkrótSzczegółów => $"{Nośnik}, Długość: {Długość}, Data wydania: {DataWydania}";

        public event PropertyChangedEventHandler PropertyChanged2;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged2?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
