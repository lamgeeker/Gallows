using System.Collections.Generic;

namespace Gallows
{
    internal class WordsList
    {
        private List<string> words = new List<string> { "кiт", "сонце", "квiтка", "молоко", "дiм", "вiтер", "книга", "мак", "снiг", "мiст", "вода", "кава", "море", "кiно", "мед", "день", "нiж", "край", "ранок", "крапля", "мураха", "школа", "бiлка", "пiсок", "дим", "хвiст", "куля", "дверi", "меч", "лiжко", "зiрка", "дерево", "птах", "гора", "сiль", "тiнь", "хлiб", "мiсяць", "смак", "лiто", "яблуко", "метелик", "камiнь", "вогонь", "коса", "бджола", "мудрiсть", "мир", "плiт"};

        public string this[int index]
        {
            
            get => words[index];
        }

    
    }
}
