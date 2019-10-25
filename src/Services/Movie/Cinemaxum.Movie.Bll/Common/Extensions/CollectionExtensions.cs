using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinemaxum.Movie.Bll.Common.Extensions
{
    public static class CollectionExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }
    }
}
