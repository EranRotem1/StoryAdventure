using System.Reflection.Metadata;

namespace StoryProject
{
    public class Story
    {
        public int health = 60;
        public int Health
        { get { return health; } set { health = value; } }


        public static int UserInput3(double txtKey)
        {
            Console.WriteLine(txt[txtKey]);
            var i = Console.ReadLine();
            string[] options = { "1", "2", "3", "health" };
            //if (i.ToLower() == "health")
            //{
            //    Console.WriteLine(Health: {health});
            //}
            while (!options.Contains(i))
            {
                Console.WriteLine("Sorry, option unavailable.");
                i = Console.ReadLine();
            }
            return int.Parse(i);
        }

        public static int UserInput2(double txtKey)
        {
            Console.WriteLine(txt[txtKey]);
            var i = Console.ReadLine();
            string[] options = { "1", "2" };
            while (!options.Contains(i))
            {
                Console.WriteLine("Sorry, option unavailable.");
                i = Console.ReadLine();
            }
            return int.Parse(i);
        }

        public static void OpenDoorSeq()
        {
            var door_open = UserInput2(1.1211);
            switch (door_open)
            {
                case 1:
                    //cuffs off walk out 
                    Console.WriteLine(txt[1.12111]);
                    Console.WriteLine(txt[1.12112102]);
                    break;
                case 2:
                    var distract = UserInput3(1.12112);
                    switch (distract)
                    {
                        case 1:
                            var scream = UserInput2(1.121121);
                            switch (scream)
                            {
                                case 1:
                                    //gaurd outfit
                                    Console.WriteLine(txt[1.12112101]);
                                    Console.WriteLine(txt[1.12112102]);
                                    //items.Append("gaurd uniform")
                                    break;
                                case 2:
                                    //none
                                    Console.WriteLine(txt[1.12112102]);
                                    break;
                            }
                            break;
                        case 2:
                            var help = UserInput2(1.121122);
                            switch (help)
                            {
                                case 1:
                                    //gaurd outfit
                                    Console.WriteLine(txt[1.12112101]);
                                    Console.WriteLine(txt[1.12112102]);
                                    break;
                                case 2:
                                    Console.WriteLine(txt[1.12112102]);
                                    break;
                            }
                            break;
                        case 3:
                            //sorry johnny
                            Console.WriteLine(txt[1.121123]);
                            Console.WriteLine(txt[1.12112102]);
                            break;
                    }
                    break;
            }
        }


        public static void StoryAdventure()
        {
            var intro = UserInput3(0);
            switch (intro)
            {
                case 1:
                    Console.WriteLine(txt[0.1]);
                    break;
                case 2:
                    Console.WriteLine(txt[0.2]);
                    break;
                case 3:
                    Console.WriteLine(txt[0.3]);
                    break;
            }

            var opening = UserInput3(1.0);
            switch (opening)
            {
                case 1:
                    var myst = UserInput2(1.1);
                    switch (myst)
                    {
                        case 1:
                            var yay = UserInput3(1.11);
                            switch (yay)
                            {
                                case 1:
                                    var benefit = UserInput2(1.111);
                                    switch (benefit)
                                    {
                                        case 1:
                                            //your loss/death
                                            Console.WriteLine(txt[1.1212]);
                                            Console.WriteLine(txt[1.122]);
                                            break;
                                        case 2:
                                            Console.WriteLine(txt[1.1112]);
                                            OpenDoorSeq();
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine(txt[1.112]);
                                    OpenDoorSeq();
                                    break;
                                case 3:
                                    //im sure, your loss, death
                                    Console.WriteLine(txt[1.113]);
                                    Console.WriteLine(txt[1.1212]);
                                    Console.WriteLine(txt[1.122]);
                                    break;
                            }
                            break;
                        case 2:
                            var nay = UserInput2(1.12);
                            switch (nay)
                            {
                                case 1:
                                    var sassy2 = UserInput2(1.121);
                                    switch (sassy2)
                                    {
                                        case 1:
                                            OpenDoorSeq();
                                            break; 
                                        case 2:
                                            //death
                                            Console.WriteLine(txt[1.1212]);
                                            Console.WriteLine(txt[1.122]);
                                            break;  
                                    }
                                    break;
                                case 2:
                                    //death
                                    Console.WriteLine(txt[1.122]);
                                    break;
                            }
                            break;
                    }
                    break;
                case 2:
                    var sassy = UserInput3(1.2);
                    break;

                case 3:
                    var cool = UserInput3(1.3);
                    break;
            }

        }

        static void Main(string[] args)
        {
            //OpenDoorSeq();
            StoryAdventure();
        }

        public static Dictionary<double, string> txt = new Dictionary<double, string>(){
            {0.0, "Let's write a little story! \n-Type the number that correlates to your choice \n-You can type in Health to any prompt to display your remaining health points," +
                " afterwards you will still input your choice \n-Your choices and health do matter, your selections determine the length and content of your story and ultimately" +
                " change the outcome, if you get to 0 health you will die and the story will end. \n-You are encouraged to play multiple times, there are many options, some " +
                "resulting in a very long or very short story, both can be fun!\nWhere would you like to start? : \n1. Dungeon \n2. Castle \n3. Village \n" },
            {0.1, "Well that's fortunate, because that's where you're going.\n" },
            {0.2, "Wouldn't we all? well I guess technically this is part of a castle.\n" },
            {0.3, "Humble, I'm afraid it's much worse than that.\n" },
            {1.0, "(Health: 60) \nYour eyes slowly open, woken up by the sound of dripping on cold stone. Your wrists, bruised and shackled, sink to the floor like stones. As you " +
                "sit there, back against the rough rocky cell wall, clinging to restless consciousness, you notice that the constant moaning of pain that fills the dungeon halls " +
                "has quieted. \n You hear a faint whisper \"Hey…\" \n \"Yea you, hey\" \nWhat do you say? \n1. \"What? Who’s there?\" \n2. \"I know you’re not really " +
                "here!\" \n3. \"Alright, well I have no plans today, what’s up?\"\n" },
            {1.1, "\"Would you like to leave this place?\" \n1. \"Yes\" \n2. \"I don’t trust you\"\n" },
            {1.2, "\"Oh I’m no figment of your imagination my friend\" \n" },
            {1.3, "\"You seem cool so I’m gonna be straight with you, I’m also trapped in this prison, but together we can escape, scratch my back I scratch yours type of deal.\"\n" },
            {1.11, "\"Well today’s your lucky day… I can get you out of here but you have to listen to everything I say, ok?\" \n1. What’s in it for you? \n2. I can do that. \n3. Sounds" +
                " like a trap, I’m sure one of these other sad souls will happily die for your amusement.\n" },
            {1.12, "\"Fine then, I’m perfectly content letting you rot here.\" \n1. \"Woah, woah, wait! What do I need to do?\" \n2. Lower your head and tune back into the familiar screaming of your cellmates \n" },
            {1.121, "\"That’s kinda what I thought, listen there’s not time to explain, there’s only a small interval of time to make this work, are you in?\" \n1. \"Yes!\" \n2. " +
                "\"Nah, you know what? I’m not getting killed over this.\"\n" },
            {1.122, "You settle back into your cold, damp, and hostile life. You rot away in the dungeon, the few weeks you have left are spent thinking about that mysterious voice that once offered you help." },
            {1.1211, "Your cell door clicks and starts to slowly open, you stand up in excitement but the heft and short chain of your irons pull you back (-5 Health). \n1. \"Hey! " +
                "What about my shackles?\" \n2. Alright, I can figure this out… lure a guard. \n" },
            {1.1212, "\"Your lossss……\" The voice echoes and fades.\n " },
            {1.12111, "\"Oh yea, right.\" \nThe rod that kept your cuffs linked turns to dust, separating your hands with a jolt, the heavy restraints finally fall off of your wrists\n" },
            {1.12112, "1. Start screaming in terror \n2. \"Help! Guard! Please help!\" \n3. \"Hey, my cell just opened, I did not do this, I am still restrained. Just wanna make sure I’m gonna get in trouble for this.\" \n" },
            {1.121121, "You shout your head off until a guard rushes over to find your cell open, you still shackled, standing facing the wall and screaming in horror as if you were face " +
                "to face with a demon. \n\"What’s wrong with you!?\" He walks in front of you in an attempt to snap you out of it. As he places both hands aggressively on your shoulders " +
                "you rear back and head slam him square on the nose. (-5 Health) \nThe guard is rendered unconscious allowing you to release him of his keys and unlock your cuffs. \nTake his " +
                "uniform? \n1. Yes, of course \n2. No, that’s gonna backfire\n" },
            {1.121122, "The rushing footsteps of a guard rapidly approach your cell, \"Help!\" you shout again, \"I don’t know how, but that thing opened the cell and blended into the wall! " +
                "I think it wants to eat me in my sleep!\" the guard sprints into the cell, glancing at your irons and turning to look at the wall in reference. As he does you kick the back of " +
                "his knee, dropping him to the ground and in a single motion you wrap the short but thick metal chain around his neck and pull it tightly to your stomach. Rendering the guard " +
                "unconscious, allowing you to lift his keys and remove your cuffs. \nTake his uniform? \n1. Yes, of course \n2. No, that’s gonna backfire\n" },
            {1.121123, "You hear the lazy steps of Johnathan the guard, he’s your favorite, but today Johnny’s gotta go. As his footsteps approach the front of your cell you shout out \"Hey, " +
                "my door just kinda swung open, it was not my doing, I’m not trying to lose dinner privileges, in the spirit of honesty, my cuffs are a little loose too.\" Johnny sighs and lets " +
                "out a grunt \"yea you’re ok, lemme just tighten those for you, i’ll put a request in for the door, i’ll just stick a rock in front of it for now.\" John pulls the keys from his " +
                "back pocket and bends over your irons in an attempt to tighten your restraints, as he does you swing your bound wrists up, meeting his chin halfway with your cold iron shackles; " +
                "knocking him out allowing you to swipe his keys and unlock your cuffs. \"Sorry Johnny Boy\"\n" },
            {1.12112101, "You are now wearing a guards uniform\n" },
            {1.12112102, "You step out of the cell.\n" },
            {1.111, "Aaahh clever, well if you must know this isn’t completely out of the kindness of my heart, I can help you escape, and in exchange you will help me retrieve something in the dungeon " +
                "on your way out. \n1. I see, you need some foolhardy worthless soul to risk his life so you can steal something, thank you, I'll wait for my next exciting opportunity. \n2. Sounds like a fair exchange." },
            {1.112, "There’s a smart cookie, trust me this’ll be worth your time." },
            {1.113, "Fine I’m sure so too" },
            {1.1112, "There’s a smart lad." }
        };
       

        

    }
}