using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnWard.Game.Casting;

namespace OnWard
{
     public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "RUN OF GLORY";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 1600;
        public static int SCREEN_HEIGHT = 900;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;

        // FIELD
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;

        // SOUND
        public static string COLLIDE_SOUND = "Assets/Sounds/score-interface.wav";
        public static string JUMP_SOUND = "Assets/Sounds/jump.wav";

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);

        // KEYS
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";

        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // LEVELS
        public static string LEVEL_FILE = "Assets/Data/level-{0:000}.txt";
        public static int BASE_LEVELS = 5;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 3;
        public static int MAXIMUM_LIVES = 5;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string LIVES_GROUP = "lives";
        public static string SCORE_GROUP = "score";
        public static string LIVES_FORMAT = "LIVES: {0}";
        public static string SCORE_FORMAT = "SCORE: {0}";

        // BACKGROUND
        public static string BACKGROUND_GROUP = "motion_background";
        public static string BACKGROUND_IMAGE = "Assets/Images/background.png";
        public static float BACKGROUND_IMAGE_SCROLLRATE = 0.5f;
        public static string MIDGROUND_IMAGE = "Assets/Images/midground.png";
        public static float MIDGROUND_IMAGE_SCROLLRATE = 1.0f;
        public static string FOREGROUND_IMAGE = "Assets/Images/foreground.png";
        public static float FOREGROUND_IMAGE_SCROLLRATE = 2.0f;
        public static int BACKGROUND_IMAGE_WIDTH = 800;
        public static int BACKGROUND_IMAGE_HEIGHT = 450;
    }
}