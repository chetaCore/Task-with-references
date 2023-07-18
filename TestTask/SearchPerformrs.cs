namespace TestTask
{
    public static class SearchPerformrs
    {
        public static (Dictionary<string, int>, Dictionary<string, int>, Dictionary<string, int>) GetPerforms(string rkkPath, string obrPath)
        {
            Dictionary<string, int> rkkManagersPerformersDict = GetManagersPerformersDict(rkkPath);
            Dictionary<string, int> obrManagersPerformersDict = GetManagersPerformersDict(obrPath);

            rkkManagersPerformersDict = MergeLibraries(rkkManagersPerformersDict, obrManagersPerformersDict);
            obrManagersPerformersDict = MergeLibraries(obrManagersPerformersDict, rkkManagersPerformersDict);

            Dictionary<string, int> totalDict = SumDictionaries(rkkManagersPerformersDict, obrManagersPerformersDict);

            return (rkkManagersPerformersDict, obrManagersPerformersDict, totalDict);
        }

        public static Dictionary<string, int> GetManagersPerformersDict(string filePath)
        {
            string[] rKKArr = File.ReadAllLines(filePath);
            Dictionary<string, int> managersPerformersDict = new Dictionary<string, int>();

            foreach (string rKK in rKKArr)
            {
                string currentPerformer = GetCurrentPerformer(rKK);
                if (!string.IsNullOrEmpty(currentPerformer))
                {
                    if (managersPerformersDict.ContainsKey(currentPerformer))
                    {
                        managersPerformersDict[currentPerformer]++;
                    }
                    else
                    {
                        managersPerformersDict.Add(currentPerformer, 1);
                    }
                }
            }

            return managersPerformersDict;
        }

        public static string GetCurrentPerformer(string rKK)
        {
            string[] activeStrArr = rKK.Split("\t");
            string currentPerformer = string.Empty;

            if (activeStrArr[0] != "Климов Сергей Александрович")
            {
                string[] nameParts = activeStrArr[0].Split(' ');
                currentPerformer = $"{nameParts[0]} {nameParts[1][0]}.{nameParts[2][0]}.";
            }
            else
            {
                currentPerformer = activeStrArr[1].Split("; ")[0];
                if (currentPerformer.Split(' ').Length == 3)
                {
                    currentPerformer = currentPerformer.Split(' ')[0] + " " + currentPerformer.Split(' ')[1];
                }
            }

            return currentPerformer;
        }

        private static Dictionary<string, int> MergeLibraries(Dictionary<string, int> firstLibrary, Dictionary<string, int> secondLibrary)
        {
            foreach (var libraryKey in secondLibrary.Keys)
            {
                if (!firstLibrary.ContainsKey(libraryKey))
                {
                    firstLibrary.Add(libraryKey, 0);
                }
            }

            return firstLibrary;
        }

        private static Dictionary<string, int> SumDictionaries(Dictionary<string, int> dictionary1, Dictionary<string, int> dictionary2)
        {
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();

            foreach (var kvp in dictionary1)
            {
                string key = kvp.Key;
                int value = kvp.Value;

                resultDictionary[key] = value;
            }

            foreach (var kvp in dictionary2)
            {
                string key = kvp.Key;
                int value = kvp.Value;

                if (resultDictionary.ContainsKey(key))
                {
                    resultDictionary[key] += value;
                }
                else
                {
                    resultDictionary[key] = value;
                }
            }

            return resultDictionary;
        }

        public static (Dictionary<string, int>, Dictionary<string, int>, Dictionary<string, int>) SortingByName(Dictionary<string, int> dictionary1, Dictionary<string, int> dictionary2, Dictionary<string, int> dictionary3)
        {
            List<string> sortedKeys = dictionary1.Keys.OrderBy(key => key).ToList();

            Dictionary<string, int> sortedDictionary1 = sortedKeys.ToDictionary(key => key, key => dictionary1[key]);
            Dictionary<string, int> sortedDictionary2 = sortedKeys.ToDictionary(key => key, key => dictionary2[key]);
            Dictionary<string, int> sortedDictionary3 = sortedKeys.ToDictionary(key => key, key => dictionary3[key]);

            return (sortedDictionary1, sortedDictionary2, sortedDictionary3);
        }

        public static (Dictionary<string, int>, Dictionary<string, int>, Dictionary<string, int>) SortingByRkk(Dictionary<string, int> dictionary1, Dictionary<string, int> dictionary2, Dictionary<string, int> dictionary3)
        {
            List<KeyValuePair<string, int>> sortedItems = dictionary1.OrderByDescending(x => x.Value)
                .ThenByDescending(x => dictionary2.ContainsKey(x.Key) ? dictionary2[x.Key] : 0)
                .ThenByDescending(x => dictionary3.ContainsKey(x.Key) ? dictionary3[x.Key] : 0)
                .ToList();

            Dictionary<string, int> sortedDictionary1 = sortedItems.ToDictionary(x => x.Key, x => x.Value);
            Dictionary<string, int> sortedDictionary2 = sortedItems.ToDictionary(x => x.Key, x => dictionary2[x.Key]);
            Dictionary<string, int> sortedDictionary3 = sortedItems.ToDictionary(x => x.Key, x => dictionary3[x.Key]);

            return (sortedDictionary1, sortedDictionary2, sortedDictionary3);
        }

        public static (Dictionary<string, int>, Dictionary<string, int>, Dictionary<string, int>) SortingByObr(Dictionary<string, int> dictionary1, Dictionary<string, int> dictionary2, Dictionary<string, int> dictionary3)
        {
            List<KeyValuePair<string, int>> sortedItems = dictionary1.OrderByDescending(x => dictionary2.ContainsKey(x.Key) ? dictionary2[x.Key] : 0)
                .ThenByDescending(x => x.Value)
                .ThenByDescending(x => dictionary3.ContainsKey(x.Key) ? dictionary3[x.Key] : 0)
                .ToList();

            Dictionary<string, int> sortedDictionary1 = sortedItems.ToDictionary(x => x.Key, x => x.Value);
            Dictionary<string, int> sortedDictionary2 = sortedItems.ToDictionary(x => x.Key, x => dictionary2[x.Key]);
            Dictionary<string, int> sortedDictionary3 = sortedItems.ToDictionary(x => x.Key, x => dictionary3[x.Key]);

            return (sortedDictionary1, sortedDictionary2, sortedDictionary3);
        }


        public static (Dictionary<string, int>, Dictionary<string, int>, Dictionary<string, int>) SortingByTotal(Dictionary<string, int> dictionary1, Dictionary<string, int> dictionary2, Dictionary<string, int> dictionary3)
        {
            List<KeyValuePair<string, int>> sortedItems = dictionary1.OrderByDescending(x => x.Value)
                .ThenByDescending(x => dictionary2.ContainsKey(x.Key) ? dictionary2[x.Key] : 0)
                .ThenByDescending(x => dictionary3.ContainsKey(x.Key) ? dictionary3[x.Key] : 0)
                .ThenByDescending(x => x.Value)
                .ToList();

            Dictionary<string, int> sortedDictionary1 = sortedItems.ToDictionary(x => x.Key, x => x.Value);
            Dictionary<string, int> sortedDictionary2 = sortedItems.ToDictionary(x => x.Key, x => dictionary2[x.Key]);
            Dictionary<string, int> sortedDictionary3 = sortedItems.ToDictionary(x => x.Key, x => dictionary3[x.Key]);

            return (sortedDictionary1, sortedDictionary2, sortedDictionary3);
        }

        public static int CalculateTotalSum(Dictionary<string, int> dictionary)
        {
            int sum = 0;

            foreach (int value in dictionary.Values)
            {
                sum += value;
            }

            return sum;
        }
    }
}