using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardDataSO", menuName = "Scriptable Objects/CardDataSO")]
public class CardDataSO : ScriptableObject
{
	public enum CardType { CREATURE, LAND, SORCERY, INSTANT, ARTIFACT, ARTIFACT_CREATURE, HULK_SMASH }

	public enum Ability { CUTENESS_OVERLOAD, STEEL_OF_THE_MOTHERLAND, REGENERATIVE_FACTOR, BURNING_PLASMA, UPGRADE, RED_FURY, SCARLET_DREAM, INFINITY_SNAP,
		TIME_LORD, REPULSOR_BLAST, MASTER_OF_MAGNETISM, SPIDER_WEB, SIMBIOSIS, DENSITY_SHIFT, ADAMANTIUM_SKELETON }
	public enum CardColor { RED, GREEN, BLACK, WHITE, BLUE, COLOURLESS }

	public CardType type;
	public CardColor color;
	public List<CardColor> protection;
	public string cardName = "";
	public int cost = 0;
	public int overloadCost = 0;
	public bool infiniteCost = false;
	public bool trample = false;
	public bool flying = false;
	public bool vigilance = false;
	public bool deathTouch = false;
	public bool indestructible = false;

	public int strength = -1;
	public int resistence = -1;

	public int addMana = -1;

	public List<AbilitySO> abilities;
}
