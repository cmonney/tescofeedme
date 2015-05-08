namespace tescofeedmewebapi.Models
{
    internal static class AllRecipes
    {
        private static readonly Recipe HaddockRecipe = new Recipe
        {
            Title = "Haddock with summer vegetables recipe",
            HowLongItTakesInMins = 40,
            HowManyItFeeds = 4,
            ImageName = "red_pepper_recipe1",
            Ingredients =
                new[]
                {
                    new Ingredient("2 red peppers, seeded and cut into strips ", 1.2),
                    new Ingredient("4 x 200g haddock fillets", 6.5),
                    new Ingredient("2 aubergines, chopped", 1.5),
                    new Ingredient("2 courgettes, sliced into thick discs", 0.8),
                    new Ingredient("2 yellow peppers, seeded and cut into strips ", 1.2),
                    new Ingredient("2 garlic cloves, unpeeled but lightly crushed with the back of a knife", 0.3),
                    new Ingredient("1 tbsp balsamic vinegar (optional)", 1.0),
                    new Ingredient("salt", 0.29),
                    new Ingredient("pepper", 0.65),
                    new Ingredient("bunch chives, chopped", 0.7),
                    new Ingredient("small handful basil leaves, shredded", 0.7),
                    new Ingredient("4 tbsp olive oil", 1.0),
                    new Ingredient("juice of ½ lemon", 0.3),
                },

            Instructions = "Preheat the oven to gas 6, 200°C, fan 180°C. " +
                           "Toss the vegetables in olive oil and place in a large roasting tin. Season and drizzle with the balsamic vinegar if using. Roast in the oven for 30-40 minutes until lightly browned and tender. Sprinkle with the chives and set aside." +
                           "Place the haddock fillets on a baking sheet, season and drizzle with a little olive oil. Roast in the oven for 7-10 minutes until just cooked through and flaking easily." +
                           "Serve the haddock with the roasted vegetables, sprinkled with basil leaves and a squeeze of lemon juice.",
            PricePerPerson = 5.10,
            FeedbackScore = 5
        };

        private static readonly Recipe LambSteaks = new Recipe
        {
            Title = "Sizzling lamb steaks",
            HowLongItTakesInMins = 15,
            HowManyItFeeds = 4,
            ImageName = "red_pepper_recipe2",
            Ingredients =
                new[]
                {
                    new Ingredient("2 roasted red peppers, cut into chunks ", 2.80),
                    new Ingredient("4 Healthy Living lamb steaks ", 8.0),
                    new Ingredient("2 tsp hot chilli sauce", 0.89),
                    new Ingredient("3 carrots", 0.24),
                    new Ingredient("1 cucumber", 0.35),
                    new Ingredient("2 oranges, segmented", 0.6),
                    new Ingredient("75g (3oz) olives", 1.5),
                    new Ingredient("2 tbsp balsamic vinegar", 1.0),
                    new Ingredient("2 tsp ground cumin ", 0.85)
                },
            Instructions =
                "Sprinkle the cumin and chilli sauce on both sides of the steaks, marinate for 15 minutes (if you have time)." +
                "Preheat the grill then cook the lamb steaks for 8-12 minutes, turning halfway through, until the meat is tender." +
                "Meanwhile, make the salad. Using a peeler, cut the carrots and cucumber into long thin strips. Using a sharp knife, cut the top and bottom off each orange, cut away all the peel and pith, then cut out each segment of orange (hold the fruit over a bowl as you do this to catch the juice; use it in the dressing). " +
                "Mix the carrots, cucumber, oranges and roasted pepper and olives in a salad bowl and drizzle with the orange juice and balsamic vinegar. " +
                "Allow the meat to rest for 3-4 minutes, then slice and arrange on top of the salad. Serve immediately.",
            PricePerPerson = 3.22,
            FeedbackScore = 5
        };


        private static readonly Recipe StuffedPeppers = new Recipe
        {
            Title = "Peppers stuffed with cod",
            HowLongItTakesInMins = 35,
            HowManyItFeeds = 4,
            ImageName = "red_pepper_recipe3",
            Ingredients =
                new[]
                {
                    new Ingredient("600g cod ", 4.8),
                    new Ingredient("6 red peppers ", 3.6),
                    new Ingredient("1 small red chilli pepper (optional)", 1.99),
                    new Ingredient("3 tomatoes", 0.69),
                    new Ingredient("1 small bunch of basil", 0.7),
                    new Ingredient("2 cloves of garlic", 0.3),
                    new Ingredient("100ml olive oil", 1.0),
                    new Ingredient("80g grated parmesan", 1.4),
                    new Ingredient("1 tsp balsamic vinegar", 1.0)
                },
            Instructions =
                "Cut the tops off the peppers, and carefully remove the core and seeds. Reserve the tops and hulls of the peppers." +
                "Wash the tomatoes and remove the stalks. Plunge them into boiling water for a few minutes until the skin starts to detach. Remove the skins then loosely crush them in a bowl. Wash and chop the chilli finely, and peel and finely chop the garlic. Thin out the leaves from the bunch of basil and loosely chop." +
                "Heat half the oil in a large casserole dish, then add the peppers (placing them vertically, open top upwards), lower the heat and cook for 10 minutes." +
                "Cook the cod in boiling water for 5 minutes then drain it and thin out the slices. Heat the remaining oil in a pan and then add the cod, tomatoes and garlic, cook for 5 minutes then turn the heat off and add the basil, chilli pepper and balsamic vinegar and mix well." +
                "Preheat the oven to 180°C / Gas Mark 6." +
                "Take the peppers and gently stuff them with the cod, tomato and garlic mixture and place them in an ovenproof dish. Place the lids back onto the peppers, cover them loosely with foil and then place into the oven. Cook for 15 minutes. Remove from the oven, remove the foil, and sprinkle with the grates parmesan and serve.",
            PricePerPerson = 3.22,
            FeedbackScore = 4
        };

        private static readonly Recipe SteakAndChips = new Recipe
        {
            Title = "Steak and chips",
            HowLongItTakesInMins = 45,
            HowManyItFeeds = 4,
            ImageName = "sponsored_recipe1",
            Ingredients =
                new[]
                {
                    new Ingredient("2 baking potatoes, cut into wedges", 0.6),
                    new Ingredient("30ml (2 tbsp) olive oil", 1.2),
                    new Ingredient("1/2 tsp paprika", 0.85),
                    new Ingredient("250g (8oz) frozen peas", 1.5),
                    new Ingredient("1 Little Gem lettuce, torn into pieces ", 0.8),
                    new Ingredient("handful fresh mint leaves", 1.5),
                    new Ingredient("1 lemon, squeezed", 0.3),
                    new Ingredient("475g (15oz) beef rump steak", 6.46),
                },
            Instructions =
                "Preheat the oven to gas 5, 190°C, fan 170°C. In a roasting tray, toss the potatoes with half the oil, the paprika, and a little seasoning. Roast in the oven for 35 minutes, until golden." +
                "Meanwhile, cook the peas in boiling salted water for 2 minutes. Drain and refresh under cold running water, then toss with the lettuce and mint. Brush the steaks with a little of the remaining oil and set aside. Whisk the rest of the oil with the lemon juice and seasoning, then drizzle over the lettuce and peas." +
                "Heat a frying pan until hot, add the steak and fry for 4-5 minutes on each side, until cooked through. Transfer to a board for 5 minutes to rest." +
                "Pour the pan juices over the peas. Slice the steak and serve with the potato wedges and vegetables.",
            PricePerPerson = 2.46,
            FeedbackScore = 5
        };


//        private static Recipe _linguini = new Recipe
//        {
//            Title = "Lemon and courgette linguine",
//            HowLongItTakesInMins = 10,
//            HowManyItFeeds = 2,
//            ImageName = "img1",
//            Ingredients =
//                new[] {},
//            Instructions = "do baking",
//            PricePerPerson = 17.10
//        };

        private static readonly Recipe FishCurry = new Recipe
        {
            Title = "Indian fish curry",
            HowLongItTakesInMins = 20,
            HowManyItFeeds = 4,
            ImageName = "curry_recipe1",
            Ingredients =
                new[]
                {
                    new Ingredient("1 onion", 0.50),
                    new Ingredient("1 red pepper", 0.60),
                    new Ingredient("2 garlic cloves", 0.60),
                    new Ingredient("1 tsp ground coriander", 0.85),
                    new Ingredient("1/2 tsp tumeric", 0.85),
                    new Ingredient("2-3 fresh red chillies, finely chopped", 0.85),
                    new Ingredient("400ml coconut milk", 1.69),
                    new Ingredient("500g (1lb) cod", 9.6),
                    new Ingredient("4 shallots", 0.75),
                },
            Instructions =
                "Slice 1 onion into thin wedges, then fry in 2 tbsp sunflower oil until just turning golden. Add in 1 thinly sliced red pepper, 2-3 fresh red chillies (or more depending how hot you like your curry), 2 sliced garlic cloves, 1 tsp black or brown mustard seeds and fry for 2-3 more minutes." +
                "Add 1 tsp ground coriander, 1/4 tsp turmeric, 1/4 tsp chilli powder, 1 tsp grated root ginger and stir-fry for 1 minute. Pour in a 400ml can coconut milk and 175ml (6fl oz) water and simmer for 8-10 mins, until slightly thickened." +
                "Season, then add 500g (1lb) cod (or any other firm, white-fleshed fish) cut into big chunks, and simmer gently, covered, for 4-5 minutes, or until just cooked. " +
                "Meanwhile, fry 4 thinly sliced shallots in 1 tbsp sunflower oil until golden and crispy." +
                "Scatter over the shallots and coriander leaves. Serve with lime wedges and cooked basmati rice.",
            PricePerPerson = 3.83,
            FeedbackScore = 4
        };

        private static readonly Recipe LambBurgers = new Recipe
        {
            Title = "Indian lamb burgers",
            HowLongItTakesInMins = 30,
            HowManyItFeeds = 4,
            ImageName = "curry_recipe2",
            Ingredients =
                new Ingredient[]
                {
                    new Ingredient("500g lamb mince ", 2.75),
                    new Ingredient("1 green chilli, deseeded and finely chopped", 0.6),
                    new Ingredient("1 tsp mustard seeds, toasted", 0.85),
                    new Ingredient("1 tsp ground coriander", 0.85),
                    new Ingredient("1tsp ground cumin", 0.85),
                    new Ingredient("2 garlic cloves, crushed", 0.60),
                    new Ingredient("pinch cinnamon", 0.85),
                    new Ingredient("salt", 0.29),
                    new Ingredient("pepper", 0.65),
                    new Ingredient("olive oil", 1.0),
                    new Ingredient("yogurt, to serve", 1.1),
                    new Ingredient("mint", 0.7),
                    new Ingredient("burger buns, to serve", 0.65),
                },
            Instructions =
                "Place the lamb mince in a bowl and add the chilli. Crush the mustard seeds to a powder in a pestle and mortar and add to the lamb with the rest of the spices and seasoning." +
                "Form the meat into four patties, 2cm thick, brush with oil and leave, covered, in the refrigerator for at least 30 minutes." +
                "Heat the barbecue until the coals are glowing and there are no flames. Cook the burgers for about four minutes per side or until cooked through. Serve in the buns, topped with yogurt mixed with mint.",
            PricePerPerson = 2.65,
            FeedbackScore = 4
        };

        private static readonly Recipe Omlette = new Recipe
        {
            Title = "Indian masala omelette",
            HowLongItTakesInMins = 15,
            HowManyItFeeds = 4,
            ImageName = "curry_recipe3",
            Ingredients =
                new[]
                {
                    new Ingredient("15ml (1tbsp) sunflower or vegetable oil", 0.75),
                    new Ingredient("1 garlic clove, crushed", 0.6),
                    new Ingredient("2 spring onions", 0.49),
                    new Ingredient("1 medium tomato", 0.69),
                    new Ingredient("1/2 medium green chilli", 0.60),
                    new Ingredient("1 tsp medium curry powder", 1.0),
                    new Ingredient("1/2 tsp garam masala", 0.85),
                    new Ingredient("2 eggs", 0.89),
                    new Ingredient("1 tbsp fresh coriander", 0.7)
                },
            Instructions =
                "Heat 1 tbsp of sunflower or vegetable oil in a 20·5cm (8in) nonstick frying pan and add 1 clove crushed garlic, 2 spring onions, 1 medium tomato and 1/2 medium green chilli, chopped. Cook for 2-3 minutes until soft. Add 1 tsp medium curry powder and 1/2 tsp garam masala and fry for a further minute." +
                "Beat 2 eggs together in a small bowl and season. Add the egg mixture to the pan and swirl the pan until the omelette mixture is cooked underneath." +
                "Carefully flip the omelette over and cook for 1-2 minutes, until golden. Scatter with 1 tbsp of fresh coriander and serve immediately.",
            PricePerPerson = 6.27,
            FeedbackScore = 4
        };

        private static readonly Recipe LambCurry = new Recipe
        {
            Title = "Indian lamb curry",
            HowLongItTakesInMins = 25,
            HowManyItFeeds = 4,
            ImageName = "curry_recipe4",
            Ingredients =
                new[]
                {
                    new Ingredient("500g diced lamb ", 8.0),
                    new Ingredient("50ml groundnut oil", 3.0),
                    new Ingredient("100g baby spinach", 1.5),
                    new Ingredient("2 medium white potatoes, diced", 1.75),
                    new Ingredient("1 onion, finely sliced", 0.16),
                    new Ingredient("1tbsp ginger, minced", 0.9),
                    new Ingredient("3 cloves garlic, minced", 0.9),
                    new Ingredient("750 ml vegetable stock", 0.65),
                    new Ingredient("110g Tesco Thai red curry paste", 1.69),
                    new Ingredient("1 tbsp brown sugar", 1.49),
                    new Ingredient("juice of 1 lime", 0.3),
                    new Ingredient("1 tbsp fish sauce", 2.39),
                    new Ingredient("pepper", 0.65)
                },
            Instructions =
                "Heat the groundnut oil in a large casserole dish over a moderate heat. Saute the diced lamb in batches until golden brown all over. Remove and drain on a plate lined with kitchen paper." +
                "Add the onion, ginger and garlic to the dish and saute over a reduced heat for 4-5 minutes, stirring occasionally. Add the paste and fry gently for 1-2 minutes, stirring occasionally. Add the lamb and potato back to the dish, then cover with the stock. Bring the mixture to a simmer and cook gently for 25-30 minutes until the potato and lamb are soft." +
                "Once the lamb and potato are soft, adjust the seasoning with the sugar, lime juice, fish sauce and pepper. Remove from the heat and stir in the spinach until wilted. Allow to stand for a few minutes before serving.",
            PricePerPerson = 5.70,
            FeedbackScore = 5
        };

        public static readonly Recipe[] IndianLowBudget = {FishCurry, LambBurgers, Omlette, LambCurry};
        public static readonly Recipe[] RecipesContainBalsamiqVinegar = {LambSteaks, HaddockRecipe, StuffedPeppers};

        public static readonly Recipe SponsoredRecipe = SteakAndChips;

        public static readonly Recipe[] Italian = { LambSteaks, HaddockRecipe, StuffedPeppers };
        public static readonly Recipe[] French = { LambSteaks, HaddockRecipe, StuffedPeppers };
    }
}