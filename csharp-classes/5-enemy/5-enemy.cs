namespace Enemies
{
	/// <summary>Represents a zombie</summary>
	public class Zombie
	{
		/// <summary>
		/// Represents the health of the zombie
		/// </summary>
		private int health;

		/// <summary>
		/// Represents the name of the zombie
		/// </summary>
		private string name = "(No name)";

		/// <summary>
		/// Public property that gets or sets name
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Zombie"/> class
		/// </summary>
		public Zombie()
		{
			health = 0;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Zombie"/> class and sets its health value
		/// </summary>
		public Zombie(int value)
		{
			if (value < 0)
				throw new System.ArgumentException("Health must be greater than or equal to 0");
			health = value;
		}

		/// <summary>
		/// Gets the health of the zombie
		/// </summary>
		public int GetHealth()
		{
			return health;
		}

		/// <summary>
		/// Returns a string representation of the Zombie instance
		/// </summary>
		public override string toString()
		{
			return "Zombie name: " + name + " / Total Health: " + health;
		}
	}
}
