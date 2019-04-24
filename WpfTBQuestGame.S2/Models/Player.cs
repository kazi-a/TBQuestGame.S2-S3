using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTBQuestGame.S2.Models
{
    public class Player : Character
    {
        #region ENUM

        public enum JobTitleName
        {
            Astronaut,
            Protector,
            Visitor
        }

        #endregion

        #region FIELDS

        protected int _lives;
        protected int _health;
        private int _expPoints;
        private JobTitleName _jobTitle;
		private List<Location> _locationsVisited;
		private int _Visited;




		#endregion

		#region PROPERTIES

		public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int ExpPoint
        {
            get { return _expPoints; }
            set
			{
				_expPoints = value;
				OnPropertyChanged(nameof(ExpPoint));
			}
        }

        public JobTitleName JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

		public List<Location> LocationsVisited
		{
			get { return _locationsVisited; }
			set { _locationsVisited = value; }
		}

		public int Visited
		{
			get { return _Visited; }
			set
			{
				_Visited = value;
				OnPropertyChanged(nameof(Visited));
			}
		}

		#endregion

		#region METHODS

		public Player()
		{
			_locationsVisited = new List<Location>();
		}

		public bool HasVisited(Location location)
		{
			return _locationsVisited.Contains(location);
		}

		#endregion

		#region CONSTRUCTORS

		#endregion
	}
}
