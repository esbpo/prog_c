function ListAllWords()
    local foo = 0
    local bar = ""

    for i,v in ipairs(WordList) do
        bar = bar .. v .. ", "
        foo = foo + 1
        if foo >= 10 then
            foo = 0
            bar = bar .. "\n"
        end
    end
    return bar
end

function love.load()
    WordList = {
        "apple", "banana", "cherry", "grape", "orange", "peach", "pear", "plum", "melon", "kiwi",
        "dog", "cat", "horse", "cow", "sheep", "goat", "lion", "tiger", "zebra", "monkey",
        "red", "blue", "green", "yellow", "purple", "black", "white", "orange", "pink", "brown",
        "car", "truck", "bus", "train", "plane", "ship", "bike", "scooter", "jeep", "van",
        "table", "chair", "couch", "bed", "lamp", "clock", "door", "window", "shelf", "mirror",
        "book", "pen", "pencil", "paper", "marker", "eraser", "notebook", "folder", "glue", "scissors",
        "computer", "mouse", "keyboard", "screen", "printer", "camera", "phone", "tablet", "charger", "speaker",
        "rain", "snow", "storm", "cloud", "wind", "fog", "sun", "moon", "star", "sky",
        "river", "lake", "ocean", "sea", "pond", "waterfall", "stream", "island", "beach", "coast",
        "mountain", "hill", "valley", "forest", "desert", "canyon", "volcano", "glacier", "cave", "cliff",
        "city", "town", "village", "street", "road", "bridge", "house", "building", "tower", "castle",
        "king", "queen", "prince", "princess", "knight", "wizard", "dragon", "giant", "fairy", "ghost",
        "happy", "sad", "angry", "tired", "scared", "brave", "calm", "kind", "smart", "funny",
        "jump", "run", "walk", "crawl", "swim", "fly", "climb", "dance", "sing", "play",
        "hot", "cold", "warm", "cool", "dry", "wet", "loud", "quiet", "fast", "slow",
        "gold", "silver", "iron", "steel", "copper", "bronze", "diamond", "ruby", "emerald", "pearl",
        "bread", "rice", "pasta", "pizza", "burger", "salad", "soup", "cake", "cookie", "candy",
        "doctor", "nurse", "teacher", "student", "farmer", "chef", "pilot", "driver", "singer", "dancer",
        "hat", "shirt", "pants", "dress", "shoes", "socks", "jacket", "scarf", "gloves", "belt",
        "ball", "bat", "goal", "game", "team", "score", "match", "race", "sport", "trophy",
        "music", "song", "band", "drum", "flute", "guitar", "violin", "piano", "trumpet", "singer",
        "robot", "alien", "rocket", "planet", "space", "starship", "asteroid", "galaxy", "satellite", "comet",
        "earth", "mars", "venus", "jupiter", "saturn", "uranus", "neptune", "pluto", "orbit", "meteor",
        "circle", "square", "triangle", "rectangle", "diamond", "heart", "star", "oval", "cube", "sphere",
        "milk", "water", "juice", "soda", "coffee", "tea", "sugar", "salt", "pepper", "honey",
        "butter", "cheese", "egg", "fish", "meat", "bread", "fruit", "vegetable", "oil", "flour",
        "clock", "watch", "calendar", "year", "month", "week", "day", "hour", "minute", "second",
        "north", "south", "east", "west", "left", "right", "up", "down", "front", "back",
        "spring", "summer", "autumn", "winter", "season", "holiday", "birthday", "party", "festival", "celebration",
        "train", "station", "airport", "harbor", "garage", "highway", "tunnel", "subway", "railway", "platform",
        "money", "coin", "cash", "bank", "shop", "store", "market", "trade", "price", "value",
        "art", "paint", "brush", "canvas", "color", "drawing", "statue", "sculpture", "gallery", "museum",
        "letter", "word", "sentence", "story", "book", "novel", "poem", "page", "chapter", "library",
        "lion", "tiger", "bear", "wolf", "fox", "rabbit", "mouse", "rat", "bat", "owl",
        "ant", "bee", "fly", "wasp", "spider", "bug", "worm", "snail", "slug", "crab",
        "shark", "whale", "dolphin", "seal", "otter", "penguin", "seagull", "pelican", "eagle", "hawk",
        "kingdom", "empire", "nation", "country", "state", "city", "region", "province", "district", "village",
        "friend", "enemy", "family", "brother", "sister", "mother", "father", "uncle", "aunt", "cousin",
        "school", "class", "lesson", "teacher", "student", "exam", "test", "subject", "study", "grade",
        "idea", "dream", "thought", "plan", "goal", "wish", "hope", "luck", "chance", "choice",
        "engine", "wheel", "gear", "brake", "motor", "fuel", "tire", "horn", "light", "seat",
        "river", "stream", "brook", "creek", "spring", "bay", "gulf", "lagoon", "delta", "shore",
        "forest", "woods", "grove", "jungle", "rainforest", "swamp", "marsh", "meadow", "field", "plain",
        "clothes", "shirt", "pants", "dress", "jacket", "coat", "hat", "gloves", "boots", "sweater",
        "doctor", "nurse", "patient", "hospital", "clinic", "medicine", "pill", "tablet", "syringe", "bandage",
        "king", "queen", "knight", "bishop", "rook", "pawn", "check", "mate", "board", "chess",
        "magic", "spell", "wand", "potion", "witch", "wizard", "dragon", "troll", "ogre", "fairy"
    }

    Imgs = {
        love.graphics.newImage("img1.png"),
        love.graphics.newImage("img2.png"),
        love.graphics.newImage("img3.png"),
        love.graphics.newImage("img4.png"),
        love.graphics.newImage("img5.png"),
        love.graphics.newImage("img6.png"),
        love.graphics.newImage("img7.png"),
        love.graphics.newImage("img8.png"),
        love.graphics.newImage("img9.png"),
        love.graphics.newImage("img10.png"),
        love.graphics.newImage("img11.png"),
        love.graphics.newImage("img12.png"),
        love.graphics.newImage("img13.png"),
        love.graphics.newImage("img14.png"),
    }

    GuessedWords = {}

    Alphabet = "abcdefghijklmnopqrstuvwxyz"
    math.randomseed(os.time())
    CurrentWord = WordList[math.random(1, #WordList)]
    GuessedLetters = " "
    LastKeyPressed = nil
    MaxAttempts = 13
    TimeSpent = 0
    ActiveImg = 1
    GameState = nil
    ColourChange = {red = 0, green = 0, blue = 0}
    Rolling = false
    RollCount = 0
    RollWords = ListAllWords()
    Delete = true
end

function IndexOf(table, value)
    for i,v in ipairs(table) do
        if v == value then
            return i
        end
    end
end

function love.keypressed(key, scancode, isrepeat)
    if key == "escape" then
        love.event.quit()
    end
    if GameState == nil then
        if Alphabet:find(key) then
            LastKeyPressed = key
        end

        if LastKeyPressed then
            if key --[[ == "return" ]]then
                if not GuessedLetters:find(LastKeyPressed) then
                    GuessedLetters = GuessedLetters .. " " .. LastKeyPressed

                    if not CurrentWord:find(LastKeyPressed) then
                        MaxAttempts = MaxAttempts - 1
                        ActiveImg = ActiveImg + 1
                        if ActiveImg > 14 then
                            ActiveImg = 14
                        end
                        if MaxAttempts <= 0 then
                            print("Game Over! The word was: " .. CurrentWord)
                            GameState = false
                        end
                    end
                end
                LastKeyPressed = nil
            end
        end
    end

    if GameState or GameState == false then
        if key == "space" then
            GameState = nil
            CurrentWord = WordList[math.random(1, #WordList)]
            GuessedLetters = " "
            LastKeyPressed = nil
            TimeSpent = 0
            ActiveImg = 1
            MaxAttempts = 13
            Delete = true
        end
    end
end

function love.update(dt)
    TimeSpent = TimeSpent + dt

    ColourChange.red = ColourChange.red + 0.1*dt
    ColourChange.green = ColourChange.green + 0.2*dt
    ColourChange.blue = ColourChange.blue + 0.3*dt

    if ColourChange.red > 1 then
        ColourChange.red = 0
    end

    if ColourChange.green > 1 then
        ColourChange.green = 0
    end

    if ColourChange.blue > 1 then
        ColourChange.blue = 0
    end

    if Rolling then
        RollCount = RollCount + 40 * dt
    end
end

local font = love.graphics.newFont(24)

function DrawWord()
    local temp = #GuessedLetters/2 * 12
    love.graphics.print("Guessed letters: ", 0, 0)
    love.graphics.print(GuessedLetters, 500-temp, 0)
    love.graphics.print("Attempts left: " .. MaxAttempts, 0, 40)
    local printout = ""
    for i = 1, #CurrentWord do
        local letter = CurrentWord:sub(i, i)
        if GuessedLetters:find(letter) then
            printout = printout .. letter
        else
            printout = printout .. "-"
        end
    end
    local temp2 = #printout * 6
    love.graphics.print(printout, 500-temp2, 575)

    if not printout:find("-") then
        GameState = true
    end
end

function love.draw()
    love.graphics.setFont(font)
    if not Rolling then
        love.graphics.draw(Imgs[ActiveImg], 0, 0)
        love.graphics.print("Selected letter: " .. CurrentWord, 0, 625)
        if LastKeyPressed then
            love.graphics.print(LastKeyPressed, 490, 625, 0, 1, 1)
        end
        love.graphics.print(math.floor(TimeSpent), 900, 0)
        DrawWord()

        if GameState then
            if Delete then
                table.insert(GuessedWords, CurrentWord)
                table.remove(WordList, IndexOf(WordList, CurrentWord))
                Delete = false
            end

            if #WordList == 0 then
                Rolling = true
            else
                love.graphics.setColor(ColourChange.red, ColourChange.green, ColourChange.blue)
                love.graphics.print("You Won! Press space to play again", 300, 40)
                love.graphics.setColor(1,1,1)
            end
        end

        if GameState == false then
            love.graphics.print("You lost. Press space to play again.", 250, 40)
            love.graphics.print("The word was " .. CurrentWord, 325, 80)
        end
    else
        love.graphics.print("You guessed all these words, congratulations:\n" .. RollWords, 0, 750-RollCount)
    end
end