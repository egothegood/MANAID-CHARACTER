using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEditor.Experimental.GraphView;

public class masc : MonoBehaviour
{
    private int hair = 0, eye = 1, top = 0;
    private string hairColor = "white", eyeColor = "black", topColor = "black";

    // hair style buttons
    public Button plainHair, tiedHair, wolfHair;

    // hair color buttons
    public Button brownHair, purpleHair, redHair, whiteHair;

    // eye shape buttons
    public Button eyeOne, eyeTwo, eyeThree;

    // eye color buttons
    public Button eyeBlack, eyeBlue, eyeGreen;

    // mouth buttons
    public Button mouthOne, mouthTwo, mouthThree, mouthFour, mouthFive;

    // top style buttons
    public Button slvls, turtle, raglan;

    // top color buttons
    public Button blackTop, blueTop, purpleTop, redTop;

    // piercings buttons
    public Button pierceOne, pierceTwo, pierceThree, pierceNone;

    public Button toHairColor, toEyeShape, toEyeColor, toMouth, toTop, toTopColor, toPiercings, done, again, quitFR;

    public Image 
                 frontplainBrown, frontWolfBrown,
                 frontplainPurple, frontWolfPurple,
               frontplainRed, frontWolfRed,
        frontplainWhite, frontWolfWhite,

       
                 backtiedBrown, backWolfBrown,
                 backtiedPurple, backWolfPurple,
               backtiedRed, backWolfRed,
         backtiedWhite, backWolfWhite,

        eyes1Black, eyes1Blue, eyes1Green,
        eyes2Black, eyes2Blue, eyes2Green,
        eyes3Black, eyes3Blue, eyes3Green,

        mouth1, mouth2, mouth3, mouth4, mouth5,

        sBlack, sBlue, sPurple, sRed,
        tBlack, tBlue, tPurple, tRed,
        rBlack, rBlue, rPurple, rRed,

        thankYou,

        piercing1, piercing2, piercing3;


    void Start()
    {
        thankYou.gameObject.SetActive(false);
        done.gameObject.SetActive(false);
        again.gameObject.SetActive(false);
        quitFR.gameObject.SetActive(false);
        toEyeShape.gameObject.SetActive(false);
        toMouth.gameObject.SetActive(false);
        toEyeColor.gameObject.SetActive(false);
        toTop.gameObject.SetActive(false);
        toTopColor.gameObject.SetActive(false);
        toPiercings.gameObject.SetActive(false);
        
        brownHair.gameObject .SetActive(false);
        purpleHair.gameObject .SetActive(false);
        redHair.gameObject .SetActive(false);
       whiteHair.gameObject .SetActive(false);
        eyeOne.gameObject .SetActive(false);
        eyeTwo.gameObject .SetActive(false);    
        eyeThree.gameObject .SetActive(false);
        eyeBlack.gameObject .SetActive(false);
        eyeBlue.gameObject .SetActive(false);   
        eyeGreen.gameObject .SetActive(false);
        slvls.gameObject .SetActive(false);
        turtle.gameObject .SetActive(false);
        raglan.gameObject .SetActive(false);
        blackTop.gameObject .SetActive(false);
        blueTop.gameObject .SetActive(false);
        purpleTop.gameObject .SetActive(false);
        redTop.gameObject .SetActive(false);
        piercing1.gameObject.SetActive(false);
        piercing2 .gameObject.SetActive(false);
        piercing3 .gameObject.SetActive(false);
        mouth2 .gameObject.SetActive(false);
        mouth3 .gameObject.SetActive(false);
        mouth4 .gameObject.SetActive(false);
        mouth5 .gameObject.SetActive(false);
        sBlue .gameObject.SetActive(false);
        sPurple .gameObject.SetActive(false);
        sRed .gameObject.SetActive(false);
        sBlack .gameObject .SetActive(false);
        tBlack .gameObject.SetActive(false);
        tBlue .gameObject.SetActive(false);
        tPurple .gameObject.SetActive(false);
        tRed .gameObject.SetActive(false);
        rBlack .gameObject .SetActive(true);
        rBlue .gameObject.SetActive(false);
        rPurple .gameObject.SetActive(false);
        rRed .gameObject.SetActive(false);
        eyes1Blue.gameObject.SetActive(false);
        eyes1Green.gameObject.SetActive(false) ;
        eyes2Black.gameObject.SetActive(false);
        eyes2Blue.gameObject.SetActive(false ) ;
        eyes2Green.gameObject.SetActive(false );
        eyes3Black.gameObject.SetActive(false);
        eyes3Blue.gameObject.SetActive(false);
        eyes3Green.gameObject.SetActive(false);
       
        
        frontplainBrown.gameObject.SetActive(false);
        frontWolfBrown.gameObject.SetActive(false);
      
        frontplainPurple.gameObject.SetActive(false);
        frontWolfPurple.gameObject.SetActive(false);    
      
        frontplainRed.gameObject.SetActive(false);
        frontWolfRed.gameObject.SetActive(false);
        
       
        backtiedBrown.gameObject.SetActive(false);
        backWolfBrown.gameObject.SetActive(false);
  
        backtiedPurple.gameObject.SetActive(false);
        backWolfPurple.gameObject.SetActive(false) ;

        backtiedRed.gameObject.SetActive(false);
        backWolfRed.gameObject.SetActive(false);

     
        backtiedWhite.gameObject.SetActive(false);
        backWolfWhite.gameObject.SetActive(false) ;


        frontplainWhite.gameObject.SetActive(true ) ;
        frontWolfWhite.gameObject.SetActive(false ) ;

        pierceNone.gameObject.SetActive(false);
        pierceOne.gameObject.SetActive(false);
        pierceTwo.gameObject.SetActive(false);
        pierceThree
            .gameObject.SetActive(false);

        mouthOne.gameObject.SetActive(false);
        mouthTwo.gameObject.SetActive(false);
        mouthThree.gameObject.SetActive(false);
        mouthFour.gameObject.SetActive(false);
        mouthFive.gameObject.SetActive(false);

        done.gameObject.SetActive(false);
    }

    // hair style
    // 0 = plain, 1 = tied, 2 = wolf

    void RemoveHairStyle()
    {
        if (hair == 0)
        {
            frontplainWhite.gameObject.SetActive(false);
           
        }

        else if (hair == 1)
        {
            frontplainWhite.gameObject.SetActive(false);
            backtiedWhite.gameObject.SetActive(false);
        }

        else if (hair == 2)
        {
            frontWolfWhite.
                gameObject.SetActive(false) ;
            backWolfWhite .gameObject.SetActive(false) ;
        }
    }
    public void ClickPlain()
    {
        RemoveHairStyle();
        frontplainWhite.gameObject.SetActive(true);
       
        
        hair = 0;
    }

    public void ClickTied()
    {
        RemoveHairStyle();
        frontplainWhite.gameObject.SetActive(true);
        backtiedWhite.gameObject.SetActive(true);
       
        hair = 1;
    }

    public void ClickWolf()
    {
        RemoveHairStyle();
        frontWolfWhite.gameObject.SetActive(true);
        backWolfWhite.gameObject.SetActive(true);
      
        hair = 2;
    }

    public void ToHairColor()
    {
        plainHair.gameObject.SetActive(false);
        tiedHair.gameObject.SetActive(false);
        wolfHair.gameObject.SetActive(false);
        toHairColor.gameObject.SetActive(false);

        toEyeShape.gameObject.SetActive(true);
        brownHair.gameObject.SetActive(true);
        whiteHair.gameObject.SetActive(true);
        purpleHair.gameObject.SetActive(true);
        redHair.gameObject.SetActive(true);
    }

    // hair color

    void RemoveHairColor()
    {
        if (hair == 0)
        {
           
            if (hairColor == "white")
            {
                frontplainWhite.gameObject.SetActive(false);

            }

            else if (hairColor == "purple")
            {
                frontplainPurple.gameObject.SetActive(false);

            }

            else if (hairColor == "brown")
            {
                frontplainBrown.gameObject.SetActive(false);
              
            }

            else if (hairColor == "red")
            {
                frontplainRed.gameObject.SetActive(false);
                
            }
        }

        else if (hair == 1)
        {
            if (hairColor == "white")
            {
                frontplainWhite.gameObject.SetActive(false);
                backtiedWhite.gameObject.SetActive(false);
            }

            else if (hairColor == "purple")
            {
                frontplainPurple.gameObject.SetActive(false);
                backtiedPurple.gameObject.SetActive(false);
            }

            else if (hairColor == "brown")
            {
                frontplainBrown.gameObject.SetActive(false);
                backtiedBrown.gameObject.SetActive(false);
            }

            else if (hairColor == "red")
            {
                frontplainRed.gameObject.SetActive(false);
                backtiedRed.gameObject.SetActive(false);
            }
        }

        else if (hair == 2)
        {
            if (hairColor == "white")
            {
                frontWolfWhite.gameObject.SetActive(false);
                backWolfWhite.gameObject.SetActive(false);
            }

            else if (hairColor == "purple")
            {
                frontWolfPurple.gameObject.SetActive(false);
                backWolfPurple.gameObject.SetActive(false);
            }

            else if (hairColor == "brown")
            {
                frontWolfBrown.gameObject.SetActive(false);
                backWolfBrown.gameObject.SetActive(false);
            }

            else if (hairColor == "red")
            {
                frontWolfRed.gameObject.SetActive(false);
                backWolfRed.gameObject.SetActive(false);
            }
        }
    }

    public void ClickWhiteHair()
    {
        RemoveHairColor();
        if (hair == 0)
        {
            frontplainWhite.gameObject.SetActive(true);
            
        }
        else if (hair == 1) { 
            frontplainWhite.gameObject.SetActive(true);
            backtiedWhite.gameObject.SetActive(true);
        }

        else if (hair == 2)
        {
            frontWolfWhite.gameObject.SetActive(true);
            backWolfWhite.gameObject.SetActive (true);
        }

        hairColor = "white";
    }

    public void ClickBrownHair()
    {
        RemoveHairColor();
        if (hair == 0)
        {
            frontplainBrown.gameObject.SetActive(true);
            
        }
        else if (hair == 1)
        {
            frontplainBrown.gameObject.SetActive(true);
            backtiedBrown.gameObject.SetActive(true);
        }

        else if (hair == 2)
        {
            frontWolfBrown.gameObject.SetActive(true);
            backWolfBrown.gameObject.SetActive(true);
        }

        hairColor = "brown";
    }

    public void ClickPurpleHair()
    {
        RemoveHairColor();
        if (hair == 0)
        {
            frontplainPurple.gameObject.SetActive(true);
           
        }
        else if (hair == 1)
        {
            frontplainPurple.gameObject.SetActive(true);
            backtiedPurple.gameObject.SetActive(true);
        }

        else if (hair == 2)
        {
            frontWolfPurple.gameObject.SetActive(true);
            backWolfPurple.gameObject.SetActive(true);
        }

        hairColor = "purple";
    }
    public void ClickRedHair()
    {
        RemoveHairColor();
        if (hair == 0)
        {
            frontplainRed.gameObject.SetActive(true);
           
        }
        else if (hair == 1)
        {
            frontplainRed.gameObject.SetActive(true);
            backtiedRed.gameObject.SetActive(true);
        }

        else if (hair == 2)
        {
            frontWolfRed.gameObject.SetActive(true);
            backWolfRed.gameObject.SetActive(true);
        }

        hairColor = "red";
    }

    public void ToEyeShape()
    {
        toEyeShape.gameObject.SetActive(false);
        brownHair.gameObject.SetActive(false);
        whiteHair.gameObject.SetActive(false);
        purpleHair.gameObject.SetActive(false);
        redHair.gameObject.SetActive(false);

        eyeOne.gameObject.SetActive(true);
        eyeTwo.gameObject.SetActive(true);
        eyeThree.gameObject.SetActive(true);
        toEyeColor.gameObject.SetActive(true);
    }

    // eye shape
    
     void RestartEyeShape()
    {
        if (eye == 1)
        {
            eyes1Black.gameObject.SetActive(false);
        }

        else if (eye == 2)
        {
            eyes2Black.gameObject.SetActive(false);
        }

        else if (eye == 3)
        {
            eyes3Black.gameObject.SetActive(false);
        }
    }

    public void ClickEyeOne()
    {
        RestartEyeShape();
        eyes1Black.gameObject.SetActive(true) ;
        eye = 1;
    }

    public void ClickEyeTwo()
    {
        RestartEyeShape();
        eyes2Black.gameObject.SetActive(true);
        eye = 2;
    }

    public void ClickEyeThree()
    {
        RestartEyeShape();
        eyes3Black.gameObject.SetActive(true);
        eye = 3;
    }

    public void ToEyeColor()
    {
        eyeOne.gameObject.SetActive(false);
        eyeTwo.gameObject.SetActive(false);
        eyeThree.gameObject.SetActive(false);
        toEyeColor.gameObject.SetActive(false);

        toMouth.gameObject.SetActive(true);
        eyeBlack.gameObject.SetActive(true);
        eyeBlue.gameObject.SetActive(true);
        eyeGreen.gameObject.SetActive(true);
    }

    // eye color

     void RestartEyeColor()
    {
        if (eye == 1)
        {
            if (eyeColor == "black")
            {
                eyes1Black.gameObject.SetActive(false);
            }

            else if (eyeColor == "blue")
            {
                eyes1Blue.gameObject.SetActive(false);
            }

            else if (eyeColor == "green")
            {
                eyes1Green.gameObject.SetActive(false); 
            }
        }

        else if (eye == 2)
        {
            if (eyeColor == "black")
            {
                eyes2Black.gameObject.SetActive(false);
            }

            else if (eyeColor == "blue")
            {
                eyes2Blue.gameObject.SetActive(false);
            }

            else if (eyeColor == "green")
            {
                eyes2Green.gameObject.SetActive(false);
            }
        }

        else if (eye == 3)
        {
            if (eyeColor == "black")
            {
                eyes3Black.gameObject.SetActive(false);
            }

            else if (eyeColor == "blue")
            {
                eyes3Blue.gameObject.SetActive(false);
            }

            else if (eyeColor == "green")
            {
                eyes3Green.gameObject.SetActive(false);
            }
        }
    }

    public void ClickBlackEyes()
    {
        RestartEyeColor();
        if (eye == 1)
        {
            eyes1Black.gameObject.SetActive(true);
            eyeColor = "black";
        }

        else if (eye == 2)
        {
            eyes2Black.gameObject.SetActive(true);
            eyeColor = "black";
        }

        else if (eye == 3)
        {
            eyes3Black.gameObject.SetActive(true);
            eyeColor = "black";
        }
    }

    public void ClickBlueEyes()
    {
        RestartEyeColor();
        if (eye == 1)
        {
            eyes1Blue.gameObject.SetActive(true);
            eyeColor = "blue";
        }

        else if (eye == 2)
        {
            eyes2Blue.gameObject.SetActive(true);
            eyeColor = "blue";
        }

        else if (eye == 3)
        {
            eyes3Blue.gameObject.SetActive(true);
            eyeColor = "blue";
        }
    }

    public void ClickGreenEyes()
    {
        RestartEyeColor();
        if (eye == 1)
        {
            eyes1Green.gameObject.SetActive(true);
            eyeColor = "green";
        }

        else if (eye == 2)
        {
            eyes2Green.gameObject.SetActive(true);
            eyeColor = "green";
        }

        else if (eye == 3)
        {
            eyes3Green.gameObject.SetActive(true);
            eyeColor = "green";
        }
    }

    public void ToMouth()
    {
        toMouth.gameObject.SetActive(false);
        eyeBlack.gameObject.SetActive(false);
        eyeBlue.gameObject.SetActive(false);
        eyeGreen.gameObject.SetActive(false);
        

        toTop.gameObject.SetActive(true);
        mouthOne.gameObject.SetActive(true);
        mouthTwo.gameObject.SetActive(true);
        mouthThree.gameObject.SetActive(true);
        mouthFour.gameObject.SetActive(true);
        mouthFive.gameObject.SetActive(true);
    }

    // mouth

    void RestartMouth()
    {
        mouth1.gameObject.SetActive(false);
        mouth2.gameObject.SetActive(false);
        mouth3.gameObject.SetActive(false);
        mouth4.gameObject.SetActive(false);
        mouth5.gameObject.SetActive(false);
    }

    public void ClickMouthOne()
    {
        RestartMouth();
        mouth1.gameObject.SetActive(true);
    }

    public void ClickMouthTwo()
    {
        RestartMouth();
        mouth2.gameObject.SetActive(true);
    }

    public void ClickMouthThree()
    {
        RestartMouth();
        mouth3.gameObject.SetActive(true);
    }

    public void ClickMouthFour()
    {
        RestartMouth();
        mouth4.gameObject.SetActive(true);
    }

    public void ClickMouthFive()
    {
        RestartMouth();
        mouth5.gameObject.SetActive(true);
    }

    public void ToTop()
    {
        toTop.gameObject.SetActive(false);
        mouthOne.gameObject.SetActive(false);
        mouthTwo.gameObject.SetActive(false);
        mouthThree.gameObject.SetActive(false);
        mouthFour.gameObject.SetActive(false);
        mouthFive.gameObject.SetActive(false);

        toTopColor.gameObject.SetActive(true);
        slvls.gameObject.SetActive(true);
        raglan.gameObject.SetActive(true);
        turtle.gameObject.SetActive(true);
    }

    // top
    // 0 = sleeveless, 1 = turtleneck, 2 = raglan

    void RestartTop()
    {
        sBlack.gameObject.SetActive(false);
        rBlack.gameObject.SetActive(false);
        tBlack.gameObject.SetActive(false);
    }

    public void ClickSleeveless()
    {
        RestartTop();
        sBlack.gameObject.SetActive(true);
        top = 0;
    }

    public void ClickTurtleneck()
    {
        RestartTop();
        tBlack.gameObject.SetActive(true);
        top = 1;
    }

    public void ClickRaglan()
    {
        RestartTop();
        rBlack.gameObject.SetActive(true);
        top = 2;
    }

    public void ToTopColor()
    {
        toTopColor.gameObject.SetActive(false);
        slvls.gameObject.SetActive(false);
        raglan.gameObject.SetActive(false);
        turtle.gameObject.SetActive(false);

        toPiercings.gameObject.SetActive(true);    
        blackTop.gameObject.SetActive(true);
        blueTop.gameObject.SetActive(true);
        redTop.gameObject.SetActive(true);
        purpleTop.gameObject.SetActive(true);
    }

    // top color

    void RestartTopColor()
    {
        if (top == 0)
        {
             if (topColor == "black")
            {
                sBlack.gameObject.SetActive(false);
            }

             else if (topColor == "blue")
            {
                sBlue.gameObject.SetActive(false);
            }

             else if (topColor == "purple")
            {
                sPurple.gameObject.SetActive(false);
            }

             else if (topColor == "red")
            {
                sRed.gameObject.SetActive(false);
            }
        }

        else if (top == 1)
        {
            if (topColor == "black")
            {
                tBlack.gameObject.SetActive(false);
            }

            else if (topColor == "blue")
            {
                tBlue.gameObject.SetActive(false);
            }

            else if (topColor == "purple")
            {
                tPurple.gameObject.SetActive(false);
            }

            else if (topColor == "red")
            {
                tRed.gameObject.SetActive(false);
            }
        }

        if (top == 2)
        {
            if (topColor == "black")
            {
                rBlack.gameObject.SetActive(false);
            }

            else if (topColor == "blue")
            {
                rBlue.gameObject.SetActive(false);
            }

            else if (topColor == "purple")
            {
                rPurple.gameObject.SetActive(false);
            }

            else if (topColor == "red")
            {
                rRed.gameObject.SetActive(false);
            }
        }
    }

    public void ClickBlackTop()
    {
        RestartTopColor();

        if (top == 0)
        {
            sBlack.gameObject.SetActive(true);
        }

       else if (top == 1)
        {
            tBlack.gameObject.SetActive(true);
        }

        else if (top == 2)
        {
            rBlack.gameObject.SetActive(true);
        }

        topColor = "black";
    }

    public void ClickPurpleTop()
    {
        RestartTopColor();

        if (top == 0)
        {
            sPurple.gameObject.SetActive(true);
        }

        else if (top == 1)
        {
            tPurple.gameObject.SetActive(true);
        }

        else if (top == 2)
        {
            rPurple.gameObject.SetActive(true);
        }

        topColor = "purple";
    }

    public void ClickBlueTop()
    {
        RestartTopColor();

        if (top == 0)
        {
            sBlue.gameObject.SetActive(true);
        }

        else if (top == 1)
        {
            tBlue.gameObject.SetActive(true);
        }

        else if (top == 2)
        {
            rBlue.gameObject.SetActive(true);
        }

        topColor = "blue";
    }

    public void ClickRedTop()
    {
        RestartTopColor();

        if (top == 0)
        {
            sRed.gameObject.SetActive(true);
        }

        else if (top == 1)
        {
            tRed.gameObject.SetActive(true);
        }

        else if (top == 2)
        {
            rRed.gameObject.SetActive(true);
        }

        topColor = "red";
    }

    public void ToPiercings()
    {
        toPiercings.gameObject.SetActive(false);
        blackTop.gameObject.SetActive(false);
        blueTop.gameObject.SetActive(false);
        redTop.gameObject.SetActive(false);
        purpleTop.gameObject.SetActive(false);

        done.gameObject.SetActive(true);
        pierceOne.gameObject.SetActive(true);
        pierceTwo.gameObject.SetActive(true);
        pierceThree.gameObject.SetActive(true);
        pierceNone.gameObject.SetActive(true);
    }

    // piercings

    void RemovePiercings()
    {
        piercing1.gameObject.SetActive(false);
        piercing2.gameObject.SetActive(false);
        piercing3.gameObject.SetActive(false);
    }

    public void ClickPierceOne()
    {
        RemovePiercings();
        piercing1.gameObject.SetActive(true);
    }

    public void ClickPierceTwo()
    {
        RemovePiercings();
        piercing2.gameObject.SetActive(true);
    }

    public void ClickPierceThree()
    {
        RemovePiercings();
        piercing3.gameObject.SetActive(true);
    }

    public void ClickPierceNone()
    {
        RemovePiercings();
    }

    public void ClickDone()
    {
        done.gameObject.SetActive(false);
        pierceOne.gameObject.SetActive(false);
        pierceTwo.gameObject.SetActive(false);
        pierceThree.gameObject.SetActive(false);
        pierceNone.gameObject.SetActive(false);

        thankYou.gameObject.SetActive(true );
        quitFR.gameObject.SetActive(true);
        again.gameObject.SetActive(true);
    }

    public void ClickQuitFR()
    {
        Application.Quit();
    }

    public void ClickAgain()
    {
        SceneManager.LoadScene("genderChoice");
    }
}
