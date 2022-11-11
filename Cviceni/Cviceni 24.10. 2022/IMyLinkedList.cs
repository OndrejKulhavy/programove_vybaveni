using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Rozhrani definuje operace, ktere musi splnit kazda implementace spojoveho seznamu
    /// </summary>
    /// <typeparam name="T">Genericky datovy typ prvku, ktere budou ulozeny ve spojovem seznamu</typeparam>
    public interface IMyLinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Vlozi na zacatek seznamu prvek
        /// </summary>
        /// <param name="element">prvek k vlozeni</param>
        public void AddToFront(T element);
        /// <summary>
        /// Vlozi na konec seznamu prvek
        /// </summary>
        /// <param name="element">prvek k vlozeni</param>
        public void AddToEnd(T element);
        /// <summary>
        /// Vrati prvek na zadanem indexu
        /// </summary>
        /// <param name="index">index prvku</param>
        /// <returns>vrati prvek na zadanem indexu</returns>
        /// <exception cref="System.IndexOutOfRangeException">
        /// K vyjimce dojde v pripade, ze index je mimo rozsah seznamu
        /// </exception>
        public T Get(int index);
        /// <summary>
        /// Vlozi prvek pred prvek spojoveho seznamu se zadanym indexem
        /// </summary>
        /// <param name="element">vkladany prvek</param>
        /// <param name="index">index prvku, pred ktery ma byt vkladany prvek vlozen</param>
        /// <exception cref="System.IndexOutOfRangeException">
        /// K vyjimce dojde v pripade, ze index je mimo rozsah seznamu
        /// </exception>
        public void InsertBefor(T element, int index);
        /// <summary>
        /// Vlozi prvek za prvek spojoveho seznamu se zadanym indexem
        /// </summary>
        /// <param name="element">vkladany prvek</param>
        /// <param name="index">index prvku, za ktery ma byt vkladany prvek vlozen</param>
        /// <exception cref="System.IndexOutOfRangeException">
        /// K vyjimce dojde v pripade, ze index je mimo rozsah seznamu
        /// </exception>
        public void InsertAfter(T element, int index);
        /// <summary>
        /// Smaze prvek na zadanem indexu ze spojoveho seznamu
        /// </summary>
        /// <param name="index">index mazaneho prvku</param>
        /// /// <exception cref="System.IndexOutOfRangeException">
        /// K vyjimce dojde v pripade, ze index je mimo rozsah seznamu
        /// </exception>
        public void Remove(int index);
        /// <summary>
        /// Pocet prvku ve spojovem seznamu
        /// </summary>
        public int Count { get; }

    }
