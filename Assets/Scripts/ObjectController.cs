using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// For Control base(Number) object.  
/// </summary>
public class ObjectController : MonoBehaviour
{
    /// <summary>
    /// base Object.
    /// </summary>
	public List<GameObject> numberList;

    /// <summary>
    /// background behind base Object.
    /// </summary>
	public List<GameObject> spaceList;

    /// <summary>
    /// Fakelist for random position of base object.
    /// </summary>
    public List<GameObject> fakeList;

    /// <summary>
    /// objlist last position of base object after generate.
    /// </summary>
    public List<GameObject> objList;

	void Start ()
	{
        Reset();
    }

    /// <summary>
    /// Reset object position. random object position.
    /// </summary>
    public void Reset ()
    {
        objList.Clear();

        fakeList.AddRange(numberList);

        while (fakeList.Count > 0)
        {
            int i = Random.Range(0, fakeList.Count);

            objList.Add(fakeList[i]);
            fakeList.RemoveAt(i);

        }

        for (int i = 0; i < objList.Count; i++)
        {
            objList[i].transform.position = spaceList[i].transform.position;
            objList[i].transform.Translate(0, 0, -1);
        }
    }

    /// <summary>
    /// Solve.
    /// </summary>
    public void Solve ()
    {
        for (int i = 0; i < numberList.Count; i++)
        {
            numberList[i].transform.position = spaceList[i].transform.position;
            numberList[i].transform.Translate(0, 0, -1);
        }
    }

}
