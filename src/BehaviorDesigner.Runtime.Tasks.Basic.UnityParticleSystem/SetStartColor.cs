using System;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityParticleSystem
{
	[TaskCategory("Basic/ParticleSystem"), TaskDescription("Sets the start color of the Particle System.")]
	public class SetStartColor : BehaviorDesigner.Runtime.Tasks.Action
	{
		[BehaviorDesigner.Runtime.Tasks.Tooltip("The GameObject that the task operates on. If null the task GameObject is used.")]
		public SharedGameObject targetGameObject;

		[BehaviorDesigner.Runtime.Tasks.Tooltip("The start color of the ParticleSystem")]
		public SharedColor startColor;

		private ParticleSystem particleSystem;

		private GameObject prevGameObject;

		public override void OnStart()
		{
			GameObject defaultGameObject = base.GetDefaultGameObject(this.targetGameObject.Value);
			if (defaultGameObject != this.prevGameObject)
			{
				this.particleSystem = defaultGameObject.GetComponent<ParticleSystem>();
				this.prevGameObject = defaultGameObject;
			}
		}

		public override TaskStatus OnUpdate()
		{
			if (this.particleSystem == null)
			{
				Debug.LogWarning("ParticleSystem is null");
				return TaskStatus.Failure;
			}
			this.particleSystem.startColor = this.startColor.Value;
			return TaskStatus.Success;
		}

		public override void OnReset()
		{
			this.targetGameObject = null;
			this.startColor = Color.white;
		}
	}
}
