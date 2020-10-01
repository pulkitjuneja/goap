using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Logger : Labourer
{
	/**
	 * Our only goal will ever be to chop trees.
	 * The ChopTreeAction will be able to fulfill this goal.
	 */
	public override Dictionary<string,object> createGoalState () {
		Dictionary<string,object> goal = new Dictionary<string,object> ();
		
		goal.Add("collectLogs", true );
		return goal;
	}

}

