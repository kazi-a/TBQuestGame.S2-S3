using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTBQuestGame.S2.Models;
using System.Collections.ObjectModel;

namespace WpfTBQuestGame.S2.DataLayer
{
    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Herry",
                Age = 42,
                JobTitle = Player.JobTitleName.Astronaut,
                Race = Character.RaceType.Human,
                Health = 100,
                Lives = 3,
                ExpPoint = 0,
                LocationId = 0,
				Visited = 0,
                Inventory = new ObservableCollection<GameItem>
                {
                    GameItemById(1002)
                }
            };
        }

        private static GameItem GameItemById(int id)
        {
            return StandardGameItems().FirstOrDefault(i => i.Id == id);
        }

        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "The Space Mission Corportion is an independent company responsible for the civilian space program," +
                "as well as aeronautics and aerospace research. The Sapce Mission was established in 1958. " +
                "The new agency was to have a distinctly civilian orientation, encouraging peaceful applications in space science." +
                "Since its establishment, most private US space exploration efforts have been led by Space Mission," +
                "including the Apollo Moon landing missions, the Skylab space station, and later the Space Shuttle."
            };
        }

        public static GameMapCoordinates InitialGameMapLocation()
        {
            return new GameMapCoordinates()
            {
                Row = 1,
                Column = 1
            };
        }

        public static Map GameMapData()
        {
            int rows = 3;
            int columns = 4;

            Map gameMap = new Map(rows, columns);

            gameMap.StandardGameItems = StandardGameItems();

            //
            // row 1
            //
            gameMap.MapLocations[0, 0] = new Location()
            {
                Id = 1,
                Name = "Mars",
                Description = "Island Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System after Mercury. " +
                "In English, Mars carries a name of the Roman god of war, and is often referred to as the Red Planet because the reddish iron oxide prevalent on " +
                "its surface gives it a reddish appearance that is distinctive among the astronomical bodies visible to the naked eye." +
                "Mars is a terrestrial planet with a thin atmosphere, " +
                "having surface features reminiscent both of the impact craters of the Moon and the valleys, deserts, and polar ice caps of Earth.",
                Accessible = true,
                ModifyExp = 10,
                ModifyVisited = 2,
                GameItems = new ObservableCollection<GameItem>
                {
                    GameItemById(3002),
                    GameItemById(2003)
                }
            };
            gameMap.MapLocations[0, 1] = new Location()
            {
                Id = 2,
                Name = "Jupiter",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. " +
                "It is a giant planet with a mass one-thousandth that of the Sun, but two-and-a-half times that of all the other planets in the Solar System combined." +
                "Jupiter and Saturn are gas giants; the other two giant planets, Uranus and Neptune, are ice giants. " +
                "Jupiter has been known to astronomers since antiquity. It is named after the Roman god Jupiter. " +
                "When viewed from Earth, Jupiter can reach an apparent magnitude of −2.94, bright enough for its reflected light to cast shadows. " +
                "And making it on average the third-brightest natural object in the night sky after the Moon and Venus.",
                Accessible = true,
                ModifyExp = 10,
                ModifyVisited = 2,
                GameItems = new ObservableCollection<GameItem>
                {
                    GameItemById(1001)
                }
            };

            //
            // row 2
            //
            gameMap.MapLocations[1, 1] = new Location()
            {
                Id = 3,
                Name = "Saturn",
                Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter." +
                "It is a gas giant with an average radius about nine times that of Earth. " +
                "It has only one-eighth the average density of Earth, but with its larger volume Saturn is over 95 times more massive." +
                "Saturn is named after the Roman god of agriculture; its astronomical symbol (♄) represents the god's sickle. " +
                "Saturn's interior is probably composed of a core of iron–nickel and rock (silicon and oxygen compounds).",
                Accessible = true,
                ModifyExp = 10,
                ModifyVisited = 2,
                GameItems = new ObservableCollection<GameItem>
                {
                    GameItemById(3003)
                }
            };
            gameMap.MapLocations[2, 0] = new Location()
            {
                Id = 4,
                Name = "Mercury",
                Description = "Mercury is the smallest and innermost planet in the Solar System. " +
                "Its orbital period around the Sun of 87.97 days is the shortest of all the planets in the Solar System. " +
                "It is named after the Roman deity Mercury, the messenger of the gods. " +
                "Like Venus, Mercury orbits the Sun within Earth's orbit as an inferior planet, and never exceeds 28° away from the Sun when viewed from Earth. " +
                "This proximity to the Sun means the planet can only be seen near the western or eastern horizon during the early evening or early morning. " +
                "At this time it may appear as a bright star-like object, but is often far more difficult to observe than Venus. " +
                "The planet telescopically displays the complete range of phases, similar to Venus and the Moon, as it moves in its inner orbit relative to Earth, " +
                "which reoccurs over the so-called synodic period approximately every 116 days.",
                Accessible = true,
                ModifyExp = 10,
                ModifyVisited = 2,
                GameItems = new ObservableCollection<GameItem>
                {
                    GameItemById(2001)
                }
                                
            };

            //
            // row 3
            //
            gameMap.MapLocations[2, 1] = new Location()
            {
                Id = 5,
                Name = "Neptune",
                Description = "Neptune is the eighth and farthest known planet from the Sun in the Solar System. " +
                "In the Solar System, it is the fourth-largest planet by diameter, the third-most-massive planet, and the densest giant planet. " +
                "Neptune is 17 times the mass of Earth, slightly more massive than its near-twin Uranus. " +
                "Neptune is denser and physically smaller than Uranus because its greater mass causes more gravitational compression of its atmosphere." +
                "Neptune orbits the Sun once every 164.8 years at an average distance of 30.1 AU (4.5 billion km). " +
                "It is named after the Roman god of the sea and has the astronomical symbol ♆, a stylised version of the god Neptune's trident.",
                Accessible = true,
                ModifyExp = 10,
                ModifyVisited = 2,
                GameItems = new ObservableCollection<GameItem>
                {
                    GameItemById(3001),
                    GameItemById(2002)
                }
                   
            };

            gameMap.MapLocations[2, 2] = new Location()
            {
                Id = 6,
                Name = "Venus",
                Description = "Venus is the second planet from the Sun, orbiting it every 224.7 Earth days. " +
                "It has the longest rotation period (243 days) of any planet in the Solar System and rotates " +
                "in the opposite direction to most other planets (meaning the Sun rises in the west and sets " +
                "in the east). It does not have any natural satellites. It is named after the Roman goddess of" +
                "love and beauty. It is the second-brightest natural object in the night sky after the Moon, " +
                "reaching an apparent magnitude of −4.6 – bright enough to cast shadows at night and, rarely, " +
                "visible to the naked eye in broad daylight. Orbiting within Earth's orbit, Venus is an inferior" +
                "planet and never appears to venture far from the Sun; its maximum angular distance from the Sun" +
                "(elongation) is 47.8°.",
                Accessible = true,
                ModifyExp = 10,
                ModifyVisited = 2,
                GameItems = new ObservableCollection<GameItem>
                {
                    GameItemById(3001),
                    GameItemById(3003)
                }
            };

            return gameMap;
        }

		public static List<GameItem> StandardGameItems()
		{
			return new List<GameItem>()
			{
				new Rocket(1001, "Titan", "Titan is the sixth gravitationally rounded moon from Saturn", 30, "You are able to visit other Planet", Rocket.UseActionType.OPENLOCATION, true),
                new Rocket(1002, "Scout", "A distroyed vessel", 0, "", Rocket.UseActionType.OPENLOCATION, false),
				new Potion(2001, "Oxyzen", "Oxygen for future use and backup", 10, "You use oxyzen and gain health", 10),
				new Potion(2002, "Spacesuit", "Spacesuit protects the astronaut from the dangers of being outside in space", 10, "This Will protect you and help to gain Health", 30),
				new Potion(2003, "Frozen Food", "Few frozen foods", 20, "This will help you to survive and increase health", 50),
				new Treasure(3001, "Crystal", "A rear and valuable Crystal", 20, "", Treasure.TreasureType.Crystal),
				new Treasure(3002, "Gold", "Gold from other plannet", 20, "", Treasure.TreasureType.Gold),
				new Treasure(3003, "Rear Rock", "Made of different things. You can pick it up for Scientist for research", 30, "", Treasure.TreasureType.Rock)
			};
		}
	}
}
