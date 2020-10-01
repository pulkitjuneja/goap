using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Blacksmith : Labourer
{
	/**
	 * Our only goal will ever be to make tools.
	 * The ForgeTooldAction will be able to fulfill this goal.
	 */
	public override Dictionary<string,object> createGoalState () {
		Dictionary<string,object> goal = new Dictionary<string,object> ();
		
		goal.Add("collectTools", true );
		return goal;
	}
}

