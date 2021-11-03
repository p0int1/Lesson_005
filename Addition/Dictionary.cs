namespace Addition
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] en_words = new string[5];
        private string[] ua_words = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; en_words[0] = "book"; ua_words[0] = "книга";
            key[1] = "ручка"; en_words[1] = "pen"; ua_words[1] = "ручка";
            key[2] = "солнце"; en_words[2] = "sun"; ua_words[2] = "сонце";
            key[3] = "яблоко"; en_words[3] = "apple"; ua_words[3] = "яблуко";
            key[4] = "стол"; en_words[4] = "table"; ua_words[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + "(ru): " + en_words[i] + "(en), " + ua_words[i] + "(ua)";
                    if (en_words[i] == index)
                        return ua_words[i] + "(en): " + key[i] + "(ru), " + ua_words[i] + "(ua)";
                    if (ua_words[i] == index)
                        return ua_words[i] + "(ua): " + en_words[i] + "(en), " + key[i] + "(ru)";
                }

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + ": " + en_words[index] + ", " + ua_words[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

    }
}