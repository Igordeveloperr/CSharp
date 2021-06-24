using System;
using System.Collections.Generic;
using System.Text;

namespace _19_DataBaseLibrery.requestBuilder.builderParametr
{
    public class SelectParametr : Parametr
    {
        public string SorCategory { get; }
        public string SortValue { get; }
        public string SorCategorySecond { get; }
        public string SortValueSecond { get; }
        public SelectParametr(string table) : base(table)
        {
            if (string.IsNullOrWhiteSpace(table))
                throw new ArgumentException("не указана таблица!");
        }
        public SelectParametr(string table, string sortCategory, string sortValue) : base(table)
        {
            if (string.IsNullOrWhiteSpace(sortCategory) || string.IsNullOrWhiteSpace(sortValue))
                throw new ArgumentException("один из параметров пуст!");
            SorCategory = sortCategory;
            SortValue = sortValue;
        }
        public SelectParametr(string table, string sortCategory, string sortValue, string sorCategorySecond, string sortValueSecond) : base(table)
        {
            if (string.IsNullOrWhiteSpace(sortCategory) || string.IsNullOrWhiteSpace(sortValue))
                throw new ArgumentException("один из параметров пуст!");
            if (string.IsNullOrWhiteSpace(sorCategorySecond) || string.IsNullOrWhiteSpace(sortValueSecond))
                throw new ArgumentException("один из параметров пуст!");
            SorCategory = sortCategory;
            SortValue = sortValue;
            SorCategorySecond = sorCategorySecond;
            SortValueSecond = sortValueSecond;
        }
    }
}
