using Raylib_cs;

namespace platformer
{
	public enum State
	{
		Quit,
		Playing,
		Lost,
		Won
	}

	public abstract class SceneNode : Node
	{
		
		public State State { get; set; }

		private string scenetitle;
		public string SceneTitle {
			get { return scenetitle; }
			set { scenetitle = value; }
		}

		protected SceneNode(string title) : base()
		{
			SceneTitle = title;
			State = State.Playing;
		}

		public override void Update(float deltaTime)
		{
			
			ShowTitle();
	
		}


		

		private void ShowTitle()
		{
			Raylib.DrawText(SceneTitle, 10, 10, 20, Color.WHITE);
		}
	}
}
