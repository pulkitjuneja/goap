using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WoodCutter : Labourer
{
	/**
	 * Our only goal will ever be to chop logs.
	 * The ChopFirewoodAction will be able to fulfill this goal.
	 */
	public override Dictionary<string,object> createGoalState () {
		Dictionary<string,object> goal = new Dictionary<string,object> ();
		
		goal.Add("collectFirewood", true );
		return goal;
	}
}

