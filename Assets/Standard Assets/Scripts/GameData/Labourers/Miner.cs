using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Miner : Labourer
{
	/**
	 * Our only goal will ever be to mine ore.
	 * The MineOreAction will be able to fulfill this goal.
	 */
	public override Dictionary<string,object> createGoalState () {
		Dictionary<string,object> goal = new Dictionary<string,object> ();
		
		goal.Add("collectOre", true );
		return goal;
	}

}

