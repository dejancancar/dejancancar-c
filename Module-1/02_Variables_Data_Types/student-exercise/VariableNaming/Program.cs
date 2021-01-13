using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int raccoonsInTheWoods = 3;
            int raccoonsGoHome = 2;
            //raccoonsInTheWoods = raccoonsInTheWoods - raccoonsGoHome;
            raccoonsInTheWoods -= raccoonsGoHome;
            Console.WriteLine(raccoonsInTheWoods);
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            //flowers -= bees;
            bees = flowers - bees;
            Console.WriteLine(bees);
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int pigeonsEatingBreadcrumbs = 1;
            int hungryPigeon = 1;
            //pigeonsEatingBreadcrumbs = pigeonsEatingBreadcrumbs + hungryPigeon;
            pigeonsEatingBreadcrumbs += hungryPigeon;
            Console.WriteLine(pigeonsEatingBreadcrumbs);
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int owlSittingOnFence = 3;
            int additionalOwls = 2;
            owlSittingOnFence += additionalOwls;
            Console.WriteLine(owlSittingOnFence);
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int beaversWorkingOnHome = 2;
            int beaversGoingForSwim = 1;
            beaversWorkingOnHome -= beaversGoingForSwim;
            Console.WriteLine(beaversWorkingOnHome);
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int toucanSittingOnTree = 2;
            int additionalToucan = 1;
            toucanSittingOnTree += additionalToucan;
            Console.WriteLine(toucanSittingOnTree);
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrelsInTree = 4;
            int nutsInTree = 2;
            squirrelsInTree -= nutsInTree;
            Console.WriteLine(squirrelsInTree);
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quarter = .25M;
            decimal dime = .10M;
            decimal nickel = .05M;
            decimal foundTotal = quarter + dime + (2 * nickel);
            Console.WriteLine(foundTotal);
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int brierClassMuffins = 18;
            int macAdamClassMuffins = 20;
            int flanneryClassMuffins = 17;
            //int totalFirstGradeMuffins = brierClass + macAdamClass + flanneryClass;
            string totalFirstGradeMuffins = brierClassMuffins + macAdamClassMuffins + flanneryClassMuffins + " total muffins!";
            Console.WriteLine(totalFirstGradeMuffins);
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyoCents = .24M;
            decimal whistleCents = .14M;
            decimal totalCents = yoyoCents + whistleCents;
            Console.WriteLine(totalCents);

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int largeMarshmellow = 8;
            int miniMarshmellow = 10;
            int fiveRiceKrispieTreat = largeMarshmellow + miniMarshmellow;
            Console.WriteLine(fiveRiceKrispieTreat);
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHouseSnow = 29;
            int elementarySchoolSnow = 17;
            hiltHouseSnow -= elementarySchoolSnow;
            Console.WriteLine(hiltHouseSnow);
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            decimal tenDollars = 10;
            decimal toyTruckCostDollars = 3;
            decimal pencialCaseDollars = 2;
            decimal totalDollarsLeft = tenDollars - toyTruckCostDollars - pencialCaseDollars;
            Console.WriteLine(totalDollarsLeft);

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int joshMarbles = 16;
            int lostJoshMarbles = 7;
            //int totalMarbles = joshMarbles - lostMarbles;
            //Console.WriteLine(totalMarbles);
            joshMarbles -= lostJoshMarbles;            
            Console.WriteLine(joshMarbles);
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int meganSeashells = 19;
            int totalSeashells = 25;
            int needSeashells = totalSeashells - meganSeashells;
            Console.WriteLine(needSeashells);
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int bradBallons = 17;
            int redBalloon = 8;
            int greenBallon = bradBallons - redBalloon;
            Console.WriteLine(greenBallon);
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int booksOnShelf = 38;
            int addedBooksToShelf = 10;
            int totalBooksOnShelf = booksOnShelf + addedBooksToShelf;
            Console.WriteLine(totalBooksOnShelf);
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int oneBeeLegs = 6;
            int eightBeeLegs = oneBeeLegs * 8;
            Console.WriteLine(eightBeeLegs);

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal iceCreamConeCents = .99M;
            decimal twoIceCreamConeCost = 2 * iceCreamConeCents;
            Console.WriteLine(twoIceCreamConeCost);
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int totalRocksForBorder = 125;
            int currentTotalRocks = 64;
            int rocksNeeded = totalRocksForBorder - currentTotalRocks;
            Console.WriteLine(rocksNeeded);
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int totalHiltMarbles = 38;
            int lostHiltMarbles = 15;
            totalHiltMarbles -= lostHiltMarbles;
            Console.WriteLine(totalHiltMarbles);
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            double milesLeftToConcert = 78;
            double milesToGetGas = 32;
            milesLeftToConcert -= milesToGetGas;
            Console.WriteLine(milesLeftToConcert);
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            double hoursShovelingSnowSaturdayMorning = 1.5;
            double hoursShovelingSnowSatudayAfternoon = .75;
            double totalHoursShoveling = hoursShovelingSnowSatudayAfternoon + hoursShovelingSnowSaturdayMorning;
            Console.WriteLine(totalHoursShoveling);
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int purchasedHotDogs = 6;
            //decimal hotDogCostCents = (decimal).50;
            decimal hotDogCostCents = .50M;
            decimal totalHotDogCostDollars = hotDogCostCents * purchasedHotDogs;
            Console.WriteLine(totalHotDogCostDollars);
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            double totalHiltCents = .50;
            double pencilCostCents = .07;
            double totalPurchasedPencils = totalHiltCents / pencilCostCents;
            int wholePencils = (int)totalPurchasedPencils;
            Console.WriteLine(wholePencils);
           
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalSeenButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totalSeenButterflies - orangeButterflies;
            Console.WriteLine(redButterflies);
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal gaveTheClerkDollars = 1.00M;
            decimal costOfCandyDollars = .54M;
            decimal changeForKateDollars = gaveTheClerkDollars - costOfCandyDollars;
            Console.WriteLine(changeForKateDollars);
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int treesInMarkBackyard = 13;
            int treesToPlant = 12;
            treesInMarkBackyard += treesToPlant;
            Console.WriteLine(treesInMarkBackyard);
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int hoursInDay = 24;
            int joySeeGrandmaDays = 2;
            int totalHoursUntilVisit = hoursInDay * joySeeGrandmaDays;
            Console.WriteLine(totalHoursUntilVisit);
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int kimCousins = 4;
            int piecesOfGumForCousin = 5;
            int totalGumNeeded = kimCousins * piecesOfGumForCousin;
            Console.WriteLine(totalGumNeeded);
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal danTotalDollars = 3.00M;
            decimal costOfCandyBarDollars = 1.00M;
            danTotalDollars -= costOfCandyBarDollars;
            Console.WriteLine(danTotalDollars);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int totalBoatsInLake = 5;
            int peoplePerBoat = 3;
            int totalPeopleOnBoats = totalBoatsInLake * peoplePerBoat;
            Console.WriteLine(totalPeopleOnBoats);
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int totalEllenLegos = 380;
            int lostEllenLegos = 57;
            totalEllenLegos -= lostEllenLegos;
            Console.WriteLine(totalEllenLegos);
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int arthurBakedMuffins = 35;
            int totalMuffinsNeeded = 83;
            int moreMuffinsNeeded = totalMuffinsNeeded - arthurBakedMuffins;
            Console.WriteLine(moreMuffinsNeeded);
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int moreWillyCrayons = willyCrayons - lucyCrayons;
            Console.WriteLine(moreWillyCrayons);
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersOnPage = 10;
            int pagesOfStickers = 22;
            int totalStickers = stickersOnPage * pagesOfStickers;
            Console.WriteLine(totalStickers);
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int totalCupcakesToShare = 96;
            int hungryChildren = 8;
            int wholeCupcakePerChild = totalCupcakesToShare / hungryChildren;
            Console.WriteLine(wholeCupcakePerChild);
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int totalGingerbreadCookies = 47;
            int cookiesPerJar = 6;
            int cookiesNotInJar = totalGingerbreadCookies % cookiesPerJar;
            Console.WriteLine(cookiesNotInJar);
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int preparedCroissants = 59;
            int neighbors = 8;
            int croissantsForMariam = preparedCroissants % neighbors;
            Console.WriteLine(croissantsForMariam);
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int cookiesPerTray = 12;
            int cookiesPerTime = 276;
            int traysNeeded = cookiesPerTime / cookiesPerTray;
            Console.WriteLine(traysNeeded);
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalTinyPretzels = 480;
            int oneServingOfPretzels = 12;
            int totalServingsOfTinyPretzels = totalTinyPretzels / oneServingOfPretzels;
            Console.WriteLine(totalServingsOfTinyPretzels);
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int totalLemonCupcakes = 53;
            int leftOverLemonCupcakes = 2;
            int lemonCupcakesPerBox = 3;
            int boxesGivenAway = (totalLemonCupcakes - leftOverLemonCupcakes) / lemonCupcakesPerBox;
            Console.WriteLine(boxesGivenAway);
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int preparedCarrotSticks = 74;
            int peopleEatingBreakfast = 12;
            int uneatenCarrots = preparedCarrotSticks % peopleEatingBreakfast;
            Console.WriteLine(uneatenCarrots);
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totalTeddyBears = 98;
            int bearsPerShelf = 7;
            int shelvesFilledWithBears = totalTeddyBears / bearsPerShelf;
            Console.WriteLine(shelvesFilledWithBears);
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int pictures = 480;
            int picturesPerAlbum = 20;
            int albumsNeeded = pictures / picturesPerAlbum;
            Console.WriteLine(albumsNeeded);
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int tradingCards = 94;
            int maxCardsPerBox = 8;
            int partialCardsPerBox = tradingCards % maxCardsPerBox;
            int fullBoxes = tradingCards / maxCardsPerBox;
            string answer = "Joe can fully fill " + fullBoxes + " boxes fully and he would be have " + partialCardsPerBox + " cards left over.";
            Console.WriteLine(answer);
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalBooks = 210;
            int shelves = 10;
            int booksPerShelf = totalBooks / shelves;
            Console.WriteLine(booksPerShelf);
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int croissants = 17;
            int guests = 7;
            int croissantsPerGuest = croissants / guests;
            Console.WriteLine(croissantsPerGuest);
            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */
            double roomSizeFeet = 12 * 14;
            double billTimeToPaintOneRoomHours = 2.15;
            double jillTimeToPaintOneRoomHours = 1.90;
            double billHourlyRate = roomSizeFeet / billTimeToPaintOneRoomHours;
            double jillHourlyRate = roomSizeFeet / jillTimeToPaintOneRoomHours;
            double billAndJillHourlyRate = billHourlyRate + jillHourlyRate;
            double fiveRoomPaintTime = (5 * roomSizeFeet) / billAndJillHourlyRate;
            Console.WriteLine(fiveRoomPaintTime);
            double totalRoomSpace = 623 * roomSizeFeet;
            double totalRoomPaintTime = totalRoomSpace / billAndJillHourlyRate;
            double totalDays = totalRoomPaintTime / 8;
            Console.WriteLine(totalDays);

            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */
            string myFirstName = "Dejan";
            string myLastName = "Cancar";
            string myMiddleInitial = "N/A";
            string fullName = myLastName + ", " + myFirstName + " " + myMiddleInitial + ".";
            Console.WriteLine(fullName);
            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */
            double newYorkToChicago = 800;
            double alreadyTravelled = 537;
            double percentTravelledDecimal = alreadyTravelled / newYorkToChicago;
            double percentTravelledConverted = percentTravelledDecimal * 100;
            int percentTravelledWhole = (int)percentTravelledConverted;
            Console.WriteLine(percentTravelledWhole);


        }
    }
}
