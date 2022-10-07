

     for(int x =0; x<1001; x++){
        Console.Write(x);
        Random r = new Random();
        string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };
        string[] vowels = { "a", "e", "i", "o", "u", "y" };
        string Name = "";
        Name += consonants[r.Next(consonants.Length)].ToUpper();
        Name += vowels[r.Next(vowels.Length)];
        int b = Name.Length; 
        while (b < 6)
        {
            Name += consonants[r.Next(consonants.Length - 1)];
            b++;
            Name += vowels[r.Next(vowels.Length-1)];
            b++;
           
        }
            Console.Write($": {Name}");
     
        Random M = new Random();
        string[] Midconsonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "qu", "r", "s", "t", "v", "w", "x", "z" };
        string[] Midvowels = { "a", "e", "i", "o", "u", "y" };
        string MiddleName = "";
        MiddleName += Midconsonants[M.Next(Midconsonants.Length)].ToUpper();
        MiddleName += Midvowels[M.Next(Midvowels.Length)];
        b = MiddleName.Length;
        while (b < 6)
        {
            MiddleName += consonants[M.Next(Midconsonants.Length)];
            b++;
            MiddleName += vowels[M.Next(Midvowels.Length)];
            b++;
        }
            Console.Write($" {MiddleName}");

          Random L = new Random();
        string[] lastconsonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "qu", "r", "s", "t", "v", "w", "x", "z" };
        string[] Lastvowels = { "a", "e", "i", "o", "u", "y" };
        string LastName = "";
        LastName += lastconsonants[L.Next(lastconsonants.Length)].ToUpper();
        LastName += Lastvowels[L.Next(Lastvowels.Length)];
        b = LastName.Length;
        while (b < 4)
        {
            LastName += lastconsonants[L.Next(lastconsonants.Length)];
            LastName += Lastvowels[L.Next(Lastvowels.Length)];
            b++;
        }
            Console.Write($" {LastName} ");  
        Random random = new Random();
        string [] jobs = {"dogwalker", "fisher", "butterfly hunter", "computer programer", "teacher", "computer salesman"};
        string occupation = "";
        occupation = jobs[random.Next(jobs.Length)];
        Console.Write(occupation);



        Random h = new Random();
        int hInt = h.Next(8,100);
        int range = 100;
        double hDouble = h.NextDouble()*range;
        if (hDouble < 7.5)
    {
        hDouble = hDouble*10;
    }
        int x;
        Console.WriteLine($" d/h {hDouble ##.##}");
     }
     Console.ReadKey();


     