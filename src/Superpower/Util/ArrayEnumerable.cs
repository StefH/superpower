﻿// Copyright 2016 Datalust, Superpower Contributors, Sprache Contributors
//  
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at  
//
//     http://www.apache.org/licenses/LICENSE-2.0  
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Runtime.CompilerServices;

namespace Superpower.Util
{
    static class ArrayEnumerable
    {
#if !(NET35 || NET40)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static T[] Cons<T>(T first, T[] rest)
        {
            var all = new T[rest.Length + 1];
            all[0] = first;
            for (var i = 0; i < rest.Length; ++i)
                all[i + 1] = rest[i];
            return all;
        }

#if !(NET35 || NET40)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static T[] Concat<T>(T[] first, T[] rest)
        {
            var all = new T[first.Length + rest.Length];
            var i = 0;
            for (; i < first.Length; ++i)
                all[i] = first[i];
            for (var j = 0; j < rest.Length; ++i, ++j)
                all[i] = rest[j];
            return all;
        }

#if !(NET35 || NET40)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static T[] Append<T>(T[] first, T last)
        {
            var all = new T[first.Length + 1];
            for (var i = 0; i < first.Length; ++i)
                all[i] = first[i];
            all[first.Length] = last;
            return all;
        }
    }
}
