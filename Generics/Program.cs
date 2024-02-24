
namespace Generics;

class Program
{
    static void Main(String[] args)
    {
        List<string> sehirler = new List<string>();
        sehirler.Add("Ankara");
        Console.WriteLine(sehirler.Count); //count is property
        MyList<string> sehirler2 = new MyList<string>();
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        Console.WriteLine(sehirler2.Count);
    }

    class MyList<T> //generic class
    {
        T[] _array;
        T[] _tempArray; //önceki değerleri tutmak için //temporary veritabanlarında çok kullanılır geçici anlamında
        public MyList()
        {
            _array = new T[0]; //0 elemanlı bir array
        }
        public void Add(T item)
        {
            _tempArray = _array; // tempArray array in referansını tutmak için  //önceki değerleri tutar 
            _array = new T[_array.Length + 1]; //eleman sayısı 1 arttırır
            for (int i = 0; i < _tempArray.Length; i++) //önceki değerlerin heap te yeni adrese kaydetmek için
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;   //array in eleman sayısı item e eşitlendi
        }

        public int Count
        {
            get { return _array.Length; } //array in uzunluğunu döner

        }

    }
}
