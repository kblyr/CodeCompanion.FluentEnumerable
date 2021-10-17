namespace CodeCompanion.FluentEnumerable
{
    public static class IDictionaryExtensions
    {
        public static IDictionary<TKey, TValue> FluentAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            dictionary.Add(key, value);
            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentAddIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value, bool condition)
        {
            if (condition)
                dictionary.Add(key, value);

            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentAddIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value, Func<bool> evaluate)
        {
            if (evaluate())
                dictionary.Add(key, value);

            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            dictionary[key] = value;
            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentUpdateIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value, bool condition)
        {
            if (condition)
                dictionary[key] = value;

            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentUpdateIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value, Func<bool> evaluate)
        {
            if (evaluate())
                dictionary[key] = value;

            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentAddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
                dictionary.FluentUpdate(key, value);
            else
                dictionary.FluentAdd(key, value);

            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentAddOrUpdateIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value, bool condition)
        {
            if (condition)
            {
                if (dictionary.ContainsKey(key))
                    dictionary.FluentUpdate(key, value);
                else
                    dictionary.FluentAdd(key, value);
            }

            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentAddOrUpdateIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value, Func<bool> evaluate)
        {
            if(evaluate())
            {
                if (dictionary.ContainsKey(key))
                    dictionary.FluentUpdate(key, value);
                else
                    dictionary.FluentAdd(key, value);
            }

            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentRemove<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            dictionary.Remove(key);
            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentRemoveIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, bool condition)
        {
            if (condition)
                dictionary.Remove(key);

            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentRemoveIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<bool> evaluate)
        {
            if (evaluate())
                dictionary.Remove(key);

            return dictionary;
        }

        public static IDictionary<TKey, TValue> FluentAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> item) => dictionary.FluentAdd(item.Key, item.Value);

        public static IDictionary<TKey, TValue> FluentAddIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> item, bool condition) => dictionary.FluentAddIf(item.Key, item.Value, condition);

        public static IDictionary<TKey, TValue> FluentAddIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> item, Func<bool> evaluate) => dictionary.FluentAddIf(item.Key, item.Value, evaluate);

        public static IDictionary<TKey, TValue> FluentUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> item) => dictionary.FluentUpdate(item.Key, item.Value);

        public static IDictionary<TKey, TValue> FluentUpdateIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> item, bool condition) => dictionary.FluentUpdateIf(item.Key, item.Value, condition);

        public static IDictionary<TKey, TValue> FluentUpdateIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> item, Func<bool> evaluate) => dictionary.FluentUpdateIf(item.Key, item.Value, evaluate);

        public static IDictionary<TKey, TValue> FluentAddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> item) => dictionary.FluentAddOrUpdate(item.Key, item.Value);

        public static IDictionary<TKey, TValue> FluentAddOrUpdateIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> item, bool condition) => dictionary.FluentAddOrUpdateIf(item.Key, item.Value, condition);
        
        public static IDictionary<TKey, TValue> FluentAddOrUpdateIf<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> item, Func<bool> evaluate) => dictionary.FluentAddOrUpdateIf(item.Key, item.Value, evaluate);
    }
}