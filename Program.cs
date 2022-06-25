
Dictionary<int, int> descedants = new Dictionary<int, int>();

descedants.Add(1, 0);
descedants.Add(2, 0);
descedants.Add(3, 2);
descedants.Add(4, 2);
descedants.Add(5, 1);
descedants.Add(6, 4);
descedants.Add(7, 0);
descedants.Add(8, 4);
descedants.Add(9, 3);
descedants.Add(10, 3);
descedants.Add(11, 11);


bool result = isChildOf(11, 11);

Console.WriteLine(result);


/// <summary>
/// Is nodes are descedants
/// </summary>
bool isChildOf(int node1, int node2)
{
    foreach (KeyValuePair<int, int> descedant in descedants)
    {
        if (descedant.Key == node1 && descedant.Value == node2)
        {
            return true;
        }
    }

    int key = descedants[node1];

    if (key == 0)
    {
        return false;
    }

    return isChildOf(key, node2); ;
}