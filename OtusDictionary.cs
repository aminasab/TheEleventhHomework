namespace TheEleventhHomework
{
    internal class OtusDictionary
    {
        public int Key { get; set; }
        public string? Value { get; set; }
        int _counter = 0;
        static int _sizeOfArray = 32;
        OtusDictionary[] arrayOfStrings = new OtusDictionary[_sizeOfArray];

        /// <summary>
        /// Добавление ключа и элемента.
        /// </summary>
        public void Add(int key, string value)
        {
            for (int i = 0; i < _counter; i++)
            {
                if (arrayOfStrings[i].Key == key)
                {
                    throw new KeyDuplicationException("Дублирование ключа. Попробуйте использовать другой ключ.");
                }
            }
            if (String.IsNullOrEmpty(value))
            {
                Console.WriteLine("Строка является пустой, либо ее значение = null");
            }
            else
            {
                var newOtusDictionary = new OtusDictionary();
                if (_counter == _sizeOfArray)
                {
                    //throw new OverflowException("Место занято!");
                    _sizeOfArray *= 2;
                    Array.Resize(ref arrayOfStrings, _sizeOfArray);
                }
                newOtusDictionary.Key = key;
                newOtusDictionary.Value = value;
                arrayOfStrings[_counter] = newOtusDictionary;
                _counter++;
            }
        }

        /// <summary>
        /// Получение элемента по ключу.
        /// </summary>
        public string Get(int key)
        {
            if (key < _sizeOfArray)
            {
                for (int i = 0; i < _sizeOfArray; i++)
                {
                    if (arrayOfStrings[i].Key == key)
                        return arrayOfStrings[i].Value;
                }
            }
            return "Ключ не найден!";
        }
    }
}
