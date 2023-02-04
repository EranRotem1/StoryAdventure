namespace StoryProject
{
    internal class Program
    {
        public static string Story()
        {
            int Health = 60;
            Console.WriteLine("Let's write a little story! \n-Type the number that correlates to your choice " +
                "\n-You can type in Health to any prompt to display your remaining health points, afterwards you " +
                "will still input your choice \n-Your choices and health do matter, your selections determine the " +
                "length and content of your story and ultimately change the outcome, if you get to 0 health you will" +
                " die and the story will end. \n-You are encouraged to play multiple times, there are many options, " +
                "some resulting in a very long or very short story, both can be fun! \n\nLet's try this, where would you like to start?\n1. Dungeon\n2. Castle\n3. Village");
            int uTest = int.Parse(Console.ReadLine());
            switch (uTest)
            {
                case 1:
                    Console.WriteLine("Well that's fortunate, because that's where you're going.");
                    break;
                case 2:
                    Console.WriteLine("Wouldn't we all? But unfortunately no...");
                    break;
                case 3:
                    Console.WriteLine("Humble of you, it's actually much worse than that.");
                    break;
                default:
                    Console.WriteLine("Ok, well that wasn't even an option so you're definitely going to the dungeon.");
                    break;
            }
            Console.WriteLine($"Starting Health: {Health}\n\nYour eyes slowly open, woken up by the sound of dripping on cold stone. " +
                $"Your wrists, bruised and shackled, sink to the floor like stones. As you sit there, back against the rough rocky cell" +
                $" wall, clinging to restless consciousness, you notice that the constant moaning of pain that fills the dungeon halls " +
                $"has quieted. \n You hear a faint whisper \"Hey…\" \n \"Yea you, hey\" \nWhat do you say? \n1. \"What? Who’s there?\" \n2." +
                $" \"I know you’re not really here!\" \n3. \"Alright, well I have no plans today, what’s up?\"");
            int u1 = int.Parse(Console.ReadLine());
            switch (u1)
            {
                case 1:
                    Console.WriteLine("\"Would you like to leave this place?\" \n1. \"Yes\" \n2. \"I don’t trust you\"");
                    int u2 = int.Parse(Console.ReadLine());
                    switch (u2)
                    {
                        case 1:
                            Console.WriteLine("\"Well today’s your lucky day… I can get you out of here but you have to listen to everything I say, ok?\"");
                            break;
                        case 2:
                            Console.WriteLine("\"Fine then, I’m perfectly content letting you rot here.\" \n1. \"Woah, woah, wait! What do I need to do?\" \n2." +
                                " Lower your head and tune back into the familiar screaming of your cellmates");
                            int u3 = int.Parse(Console.ReadLine());
                            switch (u3)
                            {
                                case 1:
                                    Console.WriteLine("\"That’s kinda what I thought, listen there’s not time to explain, there’s only a small interval of time to " +
                                        "make this work, are you in?\" \n1. \"Yes!\" \n2. \"Nah, you know what? I’m not getting killed over this.\"");
                                    int u4 = int.Parse(Console.ReadLine());
                                    switch (u4)
                                    {
                                        case 1:
                                            Health -= 5;
                                            Console.WriteLine($"Your cell door clicks and starts to slowly open, you stand up in excitement but the heft and short chain " +
                                                $"of your irons pull you back (-5 Health, Current Health: {Health}). \n1. \"Hey! What about my shackles?\" \n2. Alright, I can figure this out… lure a guard.");
                                            int u5 = int.Parse(Console.ReadLine());
                                            switch (u5)
                                            {
                                                case 1:
                                                    Console.WriteLine("\"Oh yea, right.\" \nThe rod that kept your cuffs linked turns to dust, separating your hands with a jolt, the heavy restraints " +
                                                        "finally fall off of your wrists\nYou step out of the cell.");
                                                    break;
                                                case 2:
                                                    Console.WriteLine("1. Start screaming in terror \n2. \"Help! Guard! Please help!\" \n3. \"Hey, my cell just opened, I did not do this, I am still " +
                                                        "restrained. Just wanna make sure I’m gonna get in trouble for this.\"");
                                                    int u6 = int.Parse(Console.ReadLine());
                                                    switch (u6)
                                                    {
                                                        case 1:
                                                            Health -= 5;
                                                            Console.WriteLine("You shout your head off until a guard rushes over to find your cell open, you still shackled, standing facing the wall and screaming " +
                                                                "in horror as if you were face to face with a demon. \n\"What’s wrong with you!?\" He walks in front of you in an attempt to snap you out of it. " +
                                                                $"As he places both hands aggressively on your shoulders you rear back and head slam him square on the nose. (-5 Health, Current Health: {Health})  \nThe guard is rendered " +
                                                                "unconscious allowing you to release him of his keys and unlock your cuffs. \nTake his uniform? \n1. Yes, of course \n2. No, that’s gonna backfire");
                                                            int u7 = int.Parse(Console.ReadLine());
                                                            switch (u7)
                                                            {
                                                                case 1:
                                                                    Console.WriteLine("You are now wearing a guards uniform");
                                                                    break;
                                                                case 2:
                                                                    Console.WriteLine("You walk out of your cell.");
                                                                    break;
                                                            }
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("The rushing footsteps of a guard rapidly approach your cell, \"Help!\" you shout again, \"I don’t know how, but that thing opened the cell and blended into" +
                                                                " the wall! I think it wants to eat me in my sleep!\" the guard sprints into the cell, glancing at your irons and turning to look at the wall in reference. As he does you kick" +
                                                                " the back of his knee, dropping him to the ground and in a single motion you wrap the short but thick metal chain around his neck and pull it tightly to your stomach. Rendering" +
                                                                " the guard unconscious, allowing you to lift his keys and remove your cuffs. \nTake his uniform? \n1. Yes, of course \n2. No, that’s gonna backfire");
                                                            int u8 = int.Parse(Console.ReadLine());
                                                            switch (u8)
                                                            {
                                                                case 1:
                                                                    Console.WriteLine("You are now wearing a guards uniform");
                                                                    break;
                                                                case 2:
                                                                    Console.WriteLine("You walk out of your cell.");
                                                                    break;
                                                            }
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("You hear the lazy steps of Johnathan the guard, he’s your favorite, but today Johnny’s gotta go. As his footsteps approach the front of your cell you shout out \"Hey, " +
                                                                "my door just kinda swung open, it was not my doing, I’m not trying to lose dinner privileges, in the spirit of honesty, my cuffs are a little loose too.\" Johnny sighs and lets out a " +
                                                                "grunt \"yea you’re ok, lemme just tighten those for you, i’ll put a request in for the door, i’ll just stick a rock in front of it for now.\" John pulls the keys from his back pocket " +
                                                                "and bends over your irons in an attempt to tighten your restraints, as he does you swing your bound wrists up, meeting his chin halfway with your cold iron shackles; knocking him out" +
                                                                " allowing you to swipe his keys and unlock your cuffs. \"Sorry Johnny Boy\"\nYou step out of the cell");
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                            case 2:
                                            Console.WriteLine("\"Your lossss……\" The voice echoes and fades\nYou settle back into your cold, damp, and hostile life. " +
                                                "You rot away in the dungeon, the few weeks you have left are spent thinking about that mysterious voice that once offered you help.");
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("You settle back into your cold, damp, and hostile life. You rot away in the dungeon, the few weeks you have " +
                                        "left are spent thinking about that mysterious voice that once offered you help.");
                                    break;
                            }
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("\"Oh I’m no figment of your imagination my friend\"");    
                    break;
                case 3:
                    Console.WriteLine("\"You seem cool so I’m gonna be straight with you, I’m also trapped in this prison, but together we can escape, scratch my back I scratch yours type of deal.\"");
                    break;
            }


            return "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Story());
        }
    }
}