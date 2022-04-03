using System;
using System.Collections.Generic;

// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/default-values-table
// Таблица значений по умолчанию (справочник по C#)
namespace Ex313
{
    class MyDictionary<TKey, TValue>
        where TKey : class
        where TValue : TKey
    {
        public MyDictionary()
        {
            // MyDictionary<D, B> d = new MyDictionary<D, B>();
        }
    }

    class D { }
    class B : D { }
    class C : B { }

    struct S { public int MyProperty { get; set; } }  // для where T : unmanaged 
    struct F { public string MyProperty { get; set; } }  // для where T : unmanaged не подойдет

    class MyList<T>
    #region  
    // where T : D
    // where T : IDisposable, ICloneable
    // where T : class
    // where T : struct
    // where T : new()
    // where T : class, new()
    // where T : class, IDisposable, new()
    // where T : unmanaged // Аргумент типа не может быть ссылочным типом и содержать члены ссылочного типа на любом уровне вложения.
    // where T : notnull 
    //// Предложение where может включать ограничение notnull.
    //// Ограничение notnull ограничивает параметр типа типами, допускающими значение NULL.
    //// Этот тип может быть типом значения или ссылочным типом, не допускающим значение NULL. 
    //// Ограничение notnull доступно начиная с C# 8.0 для кода, 
    //// скомпилированного в nullable enable контексте. В отличие от других ограничений, 
    //// если аргумент типа нарушает ограничение notnull, компилятор генерирует предупреждение вместо ошибки. 
    //// Предупреждения генерируются только в контексте nullable enable.
    ///
    #endregion
    {
        private int size;

        private T[] list;

        public MyList()
        {
            list = new T[4];
            T t = default;
            size = 0;
            //Console.WriteLine(t.GetType());
        }

        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public Dictionary<T, int> DoIt()
        {
            Dictionary<T, int> res = new Dictionary<T, int>();

            for (int i = 0; i < size; i++)
            {
                if (res.ContainsKey(list[i]))
                    res[list[i]]++;
                else res.Add(list[i], 1);
            }
            return res;
        }

        public int MyCount { get => size; }

        public void Add(T Item)
        {

            if (size >= list.Length)
            {
                Array.Resize(ref list, list.Length * 2);
            }
            list[size++] = Item;
        }

        public void Add(params T[] Items)
        {
            if (size >= list.Length)
            {
                Array.Resize(ref list, list.Length * 2 < Items.Length ? list.Length * 2 : Items.Length * 2);
            }
            for (int i = 0; i < Items.Length; i++)
            {
                this.list[size++] = Items[i];
            }
        }

        public void RemoveAt(int Index)
        {
            for (int i = Index; i < size; i++)
            {
                list[i] = list[i + 1];
            }
            size--;
        }

    }
}