using Xunit;

namespace StringManipulations.Test
{
    public class AnagramsTest
    {
        [Fact]
        public void GroupAnagrams_Null_ReturnEmpty()
        {
            Assert.Empty(Anagrams.GroupAnagrams(null));
        }

        [Fact]
        public void GroupAnagrams_EmptyArray_ReturnEmpty()
        {
            Assert.Empty(Anagrams.GroupAnagrams(new string[0]));
        }

        [Fact]
        public void GroupAnagrams_AllDifferentStrings_ReturnWithoutGrouping()
        {
            var input = new[] {"a", "b", "c", "d", "f"};
            var expected = new[]
            {
                new[] {"a"},
                new[] {"b"},
                new[] {"c"},
                new[] {"d"},
                new[] {"f"}
            };
            Assert.Equal(expected, Anagrams.GroupAnagrams(input));
        }

        [Fact]
        public void GroupAnagrams_AllAnagramsOfOneWord_ReturnAllGrouped()
        {
            var input = new[] {"abcdf", "bacdf", "cdfab", "dfabc", "fabcd"};
            var expected = new[]
            {
                new[] {"abcdf", "bacdf", "cdfab", "dfabc", "fabcd"}
            };
            Assert.Equal(expected, Anagrams.GroupAnagrams(input));
        }

        [Fact]
        public void GroupAnagrams_HalfAnagrams_ReturnPartlyGrouped()
        {
            var input = new[] {"ab", "ba", "cd", "dc", "f", "fabcde"};
            var expected = new[]
            {
                new[] {"ab", "ba"},
                new[] {"cd", "dc"},
                new[] {"f"},
                new[] {"fabcde"}
            };
            Assert.Equal(expected, Anagrams.GroupAnagrams(input));
        }

        [Fact]
        public void GroupAnagrams_HalfAnagramsWithCapitalLetters_ReturnPartlyGroupedIgnoringCapitalLetters()
        {
            var input = new[] {"aB", "ba", "cD", "dc", "f", "faBCde"};
            var expected = new[]
            {
                new[] {"aB", "ba"},
                new[] {"cD", "dc"},
                new[] {"f"},
                new[] {"faBCde"}
            };
            Assert.Equal(expected, Anagrams.GroupAnagrams(input));
        }

        [Fact]
        public void GroupAnagrams_LongAnagrams_ReturnPartlyGrouped()
        {
            var input = new[] {"МОРИСТА", "ОСраМИТ", "РАстИМО", "РАСТИМ", "РАСТОПИ", "СТОПИРА", "ЖеняКотович"};
            var expected = new[]
            {
                new[] {"МОРИСТА", "ОСраМИТ", "РАстИМО"},
                new[] {"РАСТИМ"},
                new[] {"РАСТОПИ", "СТОПИРА"},
                new[] {"ЖеняКотович"}
            };
            Assert.Equal(expected, Anagrams.GroupAnagrams(input));
        }
    }
}