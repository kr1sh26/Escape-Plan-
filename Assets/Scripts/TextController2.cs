using UnityEngine;
using UnityEngine.UI;

public class TextController2 : MonoBehaviour
{

    public Text text;
    private enum States
    {
        slaughter_cell_1, slaughter_cell_2, slaughter_cell_3, graffiti_1,
        graffiti_2, graffiti_3, wooden_slab, paper_1, vent_1, vent_2, boiler_room_1,
        boiler_room_2, arrange_1, keypad_1, Forest
    };
    private States myState;

    // Use this for initialization
    void Start()
    {
        myState = States.slaughter_cell_1;

    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.slaughter_cell_1) { state_slaughter_cell_1(); }

        else if (myState == States.slaughter_cell_2) { state_slaughter_cell_2(); }

        else if (myState == States.slaughter_cell_3) { state_slaughter_cell_3(); }

        else if (myState == States.graffiti_1) { states_graffiti_1(); }

        else if (myState == States.graffiti_2) { states_graffiti_2(); }

        else if (myState == States.graffiti_3) { states_graffiti_3(); }

        else if (myState == States.wooden_slab) { states_wooden_slab(); }

        else if (myState == States.vent_1) { states_vent_1(); }

        else if (myState == States.vent_2) { states_vent_2(); }

        else if (myState == States.boiler_room_1) { states_boiler_room_1(); }

        else if (myState == States.boiler_room_2) { states_boiler_room_2(); }

        else if (myState == States.paper_1) { states_paper_1(); }

        else if (myState == States.arrange_1) { states_arrange_1(); }

        else if (myState == States.keypad_1) { states_keypad_1(); }

        else if (myState == States.Forest) { states_Forest(); }

    }


    void state_slaughter_cell_1()
    {
        text.text = "You've woken up in a filthy room which looks like a slaughter " +
                    "cell where people are bludgeoned to death. You want to escape. " +
                    "Inspect your surroundings to find a way out of this hellhole.\n\n" +
                    "> Press G to inspect graffiti on the wall, or Press W to move the " +
                    "wooden slab, or Press V to inspect the vent.";

        if (Input.GetKeyDown(KeyCode.G)) { myState = States.graffiti_1; }
        else if (Input.GetKeyDown(KeyCode.W)) { myState = States.wooden_slab; }
        else if (Input.GetKeyDown(KeyCode.V)) { myState = States.vent_1; }
    }

    void states_graffiti_1()
    {
        text.text = "You see writings on the wall written with blood. It " +
                    "says 'He will chop you in pieces and feed you to the " +
                    "dogs, save your self while you have a chance'\n\n" +
                    "> Press R to return to exploring the slaughter cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.slaughter_cell_1; }
    }

    void states_wooden_slab()
    {
        text.text = "A wooden slab! what's that doing in the middle of nowhere. " +
                    "You carefully push the slab to the side and see a screwdriver " +
                    "hidden inside in the wall.\n\n" +
                    "> Press S to pick up the screwdriver, or Press R to return to " +
                    "exploring the slaughter cell.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.slaughter_cell_2; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.slaughter_cell_1; }
    }

    void states_vent_1()
    {
        text.text = "You see light on the other side of the vent, but can't access " +
                    "vent. You need find a way to open the it.\n\n" +
                    "> Press R to return to exploring the slaughter cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.slaughter_cell_1; }
    }

    void state_slaughter_cell_2()
    {
        text.text = "Now you're back in the cell and have gained a screwdriver. " +
                    "You hear the sound of a cell gate banging at a far distance. " +
                    "You need to hurry and escape before the killer spots you!\n\n " +
                    "> Press G to inspect the Graffiti, or Press O to open the vent.";

        if (Input.GetKeyDown(KeyCode.G)) { myState = States.graffiti_2; }
        else if (Input.GetKeyDown(KeyCode.O)) { myState = States.vent_2; }
    }

    void states_graffiti_2()
    {
        text.text = "You see writings on the wall written with blood. It " +
                    "says 'He will chop you in pieces and feed you to the " +
                    "dogs, save your self while you have a chance'\n\n" +
                    "> Press R to return to exploring the slaughter cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.slaughter_cell_2; }
    }

    void states_vent_2()
    {
        text.text = "You use the screwdriver to remove the vent and see a crumpled paper. " +
                    "You unfold the paper and see letter L and K written with blood.\n\n" +
                    "> Press B to enter the boiler room, or Press R to return " +
                    "to exploring the slaughter cell.";

        if (Input.GetKeyDown(KeyCode.B)) { myState = States.boiler_room_1; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.slaughter_cell_3; }
    }

    void state_slaughter_cell_3()
    {
        text.text = "You are back again! Looks like you forgot about a clue, " +
                    "Hurry up and inspect your surroundings to find a way out " +
                    "of this hellhole.\n\n " +
                    "> Press G to inspect the Graffiti, or Press R to inspect the vent.";


        if (Input.GetKeyDown(KeyCode.G)) { myState = States.graffiti_3; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.vent_2; }
    }

    void states_graffiti_3()
    {
        text.text = "You see writings on the wall written with blood. It " +
                    "says 'He will chop you in pieces and feed you to the " +
                    "dogs, save your self while you have a chance'\n\n" +
                    "> Press R to return to exploring the slaughter cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.slaughter_cell_3; }
    }

    void states_boiler_room_1()
    {
        text.text = "You've reached the boiler room and see a table with " +
                    "torn pieces of paper, an electronic keypad and a huge " +
                    "cylindrical boiler.\n\n" +
                    "> Press P to inspect the torn pieces of paper, or Press K to use the " +
                    "keypad, or Press R to return to the vent.";

        if (Input.GetKeyDown(KeyCode.P)) { myState = States.paper_1; }
        else if (Input.GetKeyDown(KeyCode.K)) { myState = States.keypad_1; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.slaughter_cell_3; }
    }

    void states_keypad_1()
    {
        text.text = "You need a 4-digit key code to increase pressure " +
                    "of the boiler.\n\n " +
                    "> Press R to return to exploring the boiler room.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.boiler_room_1; }
    }

    void states_paper_1()
    {
        text.text = "You see multiple pieces of paper. Maybe re-arranging them can give " +
                    "you a clue.\n\n" +
                    "> Press A to re-arrange the pieces of paper, or Press R to return " +
                    "to exploring the boiler room.";

        if (Input.GetKeyDown(KeyCode.A)) { myState = States.arrange_1; }
        else if (Input.GetKeyDown(KeyCode.R)) { myState = States.boiler_room_1; }
    }

    void states_arrange_1()
    {
        text.text = "You arrange the pieces and you read _IL_ written with blood. " +
                    "Maybe filling in the previous two letters would help!\n\n" +
                    "> Press R to return to exploring the boiler room.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.boiler_room_2; }
    }

    void states_boiler_room_2()
    {
        text.text = "Now, you are back in the boiler room and have the 4-digit code.\n\n" +
                    "> Press K to use the keypad to enter the code.";

        if (Input.GetKeyDown(KeyCode.K)) { myState = States.Forest; }

    }

    void states_Forest()
    {
        text.text = "You increase the pressure of the boiler which makes it unstable. " +
                    "The boiler explodes and destroys the wall behind it. You successfully " +
                    "escape the slaughter house and run deep into the forest which will " +
                    "lead you to civilization.\n\n " +
                    "> Press P to play again. ";

        if (Input.GetKeyDown(KeyCode.P)) { myState = States.slaughter_cell_1; }

    }
}



