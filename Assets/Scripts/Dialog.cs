using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Dialog
{
    List<string> lines = new List<string>
    { "Q1.What is the number obtained by multiplying 15 and 10?","A.0\nB.150\nC.12\nD.100","Q2.100-2*3/4+5+6/2=?","A.213/2\nB.197/2\nC.150\nD.175","Q3.A and B together invested " +
        "Rs. 18000 in a business. The ratio of their investments was 4 : 5. At the end of the year, a" +
        " total profit of Rs. 2700 was generated. Find their profits (in Rs.)",

"A. 1200, 1500\n"+
"B. 1300, 1400\n"+
"C. 1400, 1300\n"+
"D. None of these",
  "Q4.(i^799+i^800+i^801+i^802)/(i^343+i^344+i^345+i^346) = ",
    "A.1\nB.2\nC.0\nD.Can't be determined",
    "Q5.What will be the last digit of 4356 x 567 x 4534 ?",
    "A.5\nB.0\nC.7\nD.3"};
    List<string> lines2 = new List<string>
    { "Q1. Which is the strongest animal in the world compared with size/strength ratio?","A.Ant\nB.Elephant\nC.Rhinocerous\nD.Dung Beetle",
    "Q2.World Tourism Day is celebrated on-",
"A.September 12\n"+
 "B. September 25\n"+
 "C.September 27\n"+
 "D. September 29",
    "Q3 The 'Dalong Village' covering an area of 11.35 sq. km. has recently (May 2017) been declared as" +
        " Biodiversity Heritage Site under Section 37(1) of Biological Diversity Act, 2002. " +
        "The village is situated in the Indian State of -",
"A. Manipur\nB. Madhya Pradesh\nC. Mizoram\nD. Maharashtra",
"Q4'Line of Blood' is a book written by whom?","A. Balraj Khanna\nB. Ursula Vernon\nC. Amal EI-Mohtar\nD. Diksha Basu",
"Q5.What was ‘Word of the Year-2016’ according to the Dictionary.com?",
"A. Xenophobia\nB. Menophobia\nC. Kemophobia\nD. Semophobia"};
    List<string> lines3 = new List<string>
    {"Q1. The H.C.F. of 9/10 , 12/25 , 18/35 and 21/40 is:",
    "A. 3\nB.4/5\nC.3/1400\nD. 3/400",
    "Q2. A number when divided by 18 leaves a remainder 7. The same number when divided by 12 leaves a remainder n. How many values can n take?",
    "A. 2\nB. 0\nC. 1\nD. 3",
    "Q3. Four bells are heard at intervals of 2,3,5 and 7 minutes respectively. " +
        "If all bells toll together exactly at 9 a.m.," +
        " they will again be heard together at",
    "A. 10.10 a.m.\nB. 9.30 a.m.\nC. 11.45 a.m.\nD. 12.30 p.m.",
    "Q4. abc=9000. (a,b)(b,c)(c,a) are pairs of co-prime numbers. Find a + b + c.",
    "A. 142\nB.1009\nC.119\nD.None",
    "Q5. Numbers A, B, C and D have 16, 28, 30 and 27 factors. Which of these could be a perfect cube?",
    "A. A and B\nB. B and C\nC. A,B and C\nD. B and D"
    };
    List<string> lines4 = new List<string>
    {"Q1. Q.2 Who is the UN Secretary General?",


"A. Antonio Guterres\nB. Cristiano Robert\nC. Robert Paul\nD. Mark Admin",
"Q2. NASA launched the ‘OSIRIS-REx’ Mission to collect samples from which asteroid?",

"A. Asteroid Bennu\nB. Cristiano Robert\nC. Robert Paul\nD. Mark Admin",
"Q3. In Bihar, UNESCO has declared which place as a World Heritage Site?",
 "A. Bihar’s ancient Nalanda University\nB. Jaipur National University\nC. Takshila University\nD. Jagjivan University",
 "Q4. How many satellites in a single mission using PSLV C-34 launched in 2016?",
 "(A) 30 satellites\nB. 10 satellites\nC. 20 satellites\nD. 05 satellites",
 "Q5. Who has been appointed as Lt Governor of Puducherry for 2 years?",

"A Kiran Kher\nB. Indira Gandhi\nC. Sindhu\nD. Kiran Bedi"
    };
  List<string> lines5 = new List<string>
  {
      "Q1. Ravi takes 40 seconds to walk up on an escalator which is moving upwards" +
      " but he takes 60 seconds to walk up on an escalator which is moving downwards." +
      " How much time will he take to walk up if the escalator is not moving?",
      "A. 50s\nB. 100s\nC. 48s\nD. 60s",
      "Q2. City A to City B is a downstream journey on a stream which flows at a speed of 5km/hr. Boats P and Q run a shuttle service between the two " +
      "cities that are 300 kms apart. Boat P, which starts from City A has a still-water speed of 25km/hr, while boat Q," +
      " which starts from city B at the same time has a" +
      " still-water speed of 15km/hr. When will the two boats meet for the first time? (this part is easy) When will they meet for the second time?",
      "A. 7.5 hours and 15 hours\nB. 7.5 hours and 18 hours\nC. 8 hours and 18 hours\nD. 7.5 hours and 20hours",
      "Q3. Traders A and B buy two goods for Rs. 1000 and Rs. 2000 respectively. Trader A marks his goods up by x%," +
      " while trader B marks his goods up by 2x% and offers" +
      " a discount of x%. If both make the same non-zero profit, find x.",
      "A. 50%\nB. 25%\nC.37.5%\nD. 40%",
      "Q4. A garment company declared 15% discount for wholesale buyers." +
      " Bharat bought garments from the company for Rs. 25000 after" +
      " getting a discount. He fixed up the selling price of garments in such a way that he earned a profit" +
      " of 8% on original company price. What is the approximate total selling price?",
      "A. 28000\nB. 29000\nC. 32000\nD. 29500",
      "Q5.I f books bought at prices ranging from Rs. 200 to Rs. 350 " +
      "are sold at prices ranging from Rs. 300 to Rs. 425, what is the " +
      "greatest possible profit that might be made in selling eight books?",
      "A. Rs.1800\nB. Rs.1600\nC. Rs.1500\nD. None of these"
  };
    
    public List<string> Lines
    {   
        get { return lines; }
        
    }
    public List<string> Lines2
    {
        get { return lines2; }
    }
    public List<string> Lines3
    {
        get { return lines3; }
    }
    public List <string> Lines4
    {
        get { return lines4; }
    }
    public List<string> Lines5
    {
        get { return lines5; }
    }
}

