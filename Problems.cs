namespace LeetCodeProblems;

public class Problems
{
    // Problem: 01 - TwoSum
    internal static int[] twoSum(int[] nums, int tagret)
    {
        // Dictionary für Zahlen mit Indizes
        Dictionary<int,int> map = new();

        // for - jedes Element von nums durchlaufen
        for (int i = 0; i < nums.Length; i++)
        {
            // num = Wert von aktuellen nums[i] zum Target
            int num = tagret - nums[i];

            // if - num bereits in Dictionary
            if (map.TryGetValue(num, out int index))
            {
                // Array aus Indizes der Zahlen zurückgeben
                return new int[] {i, index};
            }

            // aktuelle num in das Dictionary hinzufügen
            else 
            {
                map[nums[i]] = i;
            }
        }

        // falls keine Übereinstimmung - leeres Array zurückgeben
        return new int[2];
    }

    
}
