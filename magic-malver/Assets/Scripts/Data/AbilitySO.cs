using UnityEngine;

[CreateAssetMenu(fileName = "AbilitySO", menuName = "Scriptable Objects/AbilitySO")]
public class AbilitySO : ScriptableObject
{
	public string abilityName = "";
	public int cost = 0;
	public bool indefiniteCost = false;
	public bool mustTap = false;
	public bool unblockable = false;
	public int addStrength = -1;
	public int addResistence = -1;
}
