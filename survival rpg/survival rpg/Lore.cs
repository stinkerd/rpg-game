using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using survival_rpg;
using static CrashedRPG;
internal class Commando : gameLore
{
    public string loreCharacter()
    {
        string loreText = "The Starlight Voyager, on a routine mission, suddenly faced a catastrophic hull failure.\n" +
            "Amidst the chaos, the Commando sprang into action, leading the crew in a desperate attempt to stabilize the ship.\n" +
            "Despite their efforts, they crashed onto a lush planet below.\n" +
            "Emerging from the wreckage, the Commando saw the flickering lights of the back-up pod, signaling hope amidst the devastation.\n" +
            "With determination, they set out to find the ship, reboot the systems, and escape the planet's grasp.";
        TypingEffect.PrintSlowly(loreText, 20);
        return loreText;
    }
}
internal class Scavenger : gameLore
{
    public string loreCharacter()
    {
        string loreText = "In the depths of space, the Scavenger searched for relics amidst the debris of forgotten worlds aboard\nthe Starlight Voyager. " +
            "Suddenly, disaster struck as the ship was torn apart by a hull failure. " +
            "Despite their efforts,\nthey crashed onto a lush planet below.\n\n" +
            "Crashing onto an unknown planet, the Scavenger saw opportunity amidst the wreckage. " +
            "Eyes gleaming with anticipation,\nthey set out to explore the ruins of the ancient civilization, searching for treasures\nthat could aid in their escape. " +
            "With the goal of finding the ship and unlocking the planet's secrets, \n\nthe Scavenger embarked on a quest for fortune and glory.";
        TypingEffect.PrintSlowly(loreText, 20);
        return loreText;
    }
}
internal class Captain : gameLore
{
    public string loreCharacter()
    {
        string loreText = "Guiding the Starlight Voyager through the cosmic seas, the Captain faced a dire situation as the ship was crippled by a catastrophic hull failure.\n" +
            "With resolve, they led the crew in a crash landing onto a distant planet below.\n" +
            "Surveying the landscape, the Captain saw the glimmering lights of the back-up pod, a beacon of hope in the darkness.\n" +
            "Determined to lead their crew to safety, they set out to find the ship, reboot the systems, and chart a course back to the stars.\n";
        TypingEffect.PrintSlowly(loreText, 20);
        return loreText;
    }
}
