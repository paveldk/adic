using UnityEngine;
using System.Collections;
using Adic;

namespace Adic.Examples.Commander.Commands {
	/// <summary>
	/// Game object rotator.
	/// 
	/// Receives the Transform component of the game object to be rotated as
	/// a parameter during execution.
	/// </summary>
	public class RotateGameObjectCommand : Command, IUpdatable {
		/// <summary>The object to be rotated.</summary>
		protected Transform objectToRotate;
		
		public override void Execute(params object[] parameters) {
			this.objectToRotate = (Transform)parameters[0];

			this.Retain();
		}

		public void Update () {
			this.objectToRotate.Rotate(1.0f, 1.0f, 1.0f);
		}
	}
}