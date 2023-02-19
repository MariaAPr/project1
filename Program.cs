string[] firstMassive = new string[4] {"dog", "cat", "bird", "mouse"};

int CountElementsOfFinalMassive(string[] firstMassive)
    {
        int counter = 0;
        for (int index = 0; index < firstMassive.Length; index++)
        {
            if (firstMassive[index].Length <= 3) {
            counter++;
            }
        }
        
        return counter;
    }

int a = CountElementsOfFinalMassive(firstMassive);

string[] finalMassive = new string[a];

for (int index = 0; index < firstMassive.Length; index++)
    {
        if (firstMassive[index].Length <= 3) {
        finalMassive[index] = firstMassive[index];
        }
    }

Console.WriteLine(String.Join(",", finalMassive));