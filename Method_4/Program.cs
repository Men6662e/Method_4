void polosa()
{
    Console.WriteLine("============================================================");
}
void SayHellowRu()
{
    Console.WriteLine("Привет! Заполни анкету, то что снизу!");
    Console.WriteLine();
}

void SayHellowEn()
{
    Console.WriteLine("Hi! Fill out the questionnaire below!");
    Console.WriteLine();
}

void SayHelloFr()
{
    Console.WriteLine("Bonjour! Remplissez le formulaire, celui qui est en bas!");
    Console.WriteLine();
}

void UnketaRu()
{
    polosa();
    Console.WriteLine("\t    --- Анкета нового пользователя ---");
    polosa();
    Console.Write("Введите ваше имя: "); string Name = Convert.ToString(Console.ReadLine()!);
    Console.Write("Введите вашу фамилию: "); string SurName = Convert.ToString(Console.ReadLine()!);
    Console.Write("Введите вашу дату рождения в формате ДД.ММ.ГГГГ: "); DateTime age = DateTime.Parse(Console.ReadLine()!);
    polosa();
    Console.WriteLine("\t    --- Профиль пользователя создан ---");
    polosa();
    Console.WriteLine($"Имя: {Name}\nФамилия: {SurName}\nВаша дата рождения: {age.ToString("dd.MM.yyyy")}");
    polosa();
}

void UnketaEn()
{
    polosa();
    Console.WriteLine("\t       --- New User Questionnaire ---");
    polosa();
    Console.Write("Enter your first name: "); string Name = Convert.ToString(Console.ReadLine()!);
    Console.Write("Enter your last name: "); string SurName = Convert.ToString(Console.ReadLine()!);
    Console.Write("Enter your date of birth in DD.MM.YYYY format: "); DateTime age = DateTime.Parse(Console.ReadLine()!);
    polosa();
    Console.WriteLine("\t        --- User profile created ---");
    polosa();
    Console.WriteLine($"First Name: {Name}\nLast Name: {SurName}\nDate of Birth: {age.ToString("dd.MM.yyyy")}");
    polosa();
}

void UnketaFr()
{
    polosa();
    Console.WriteLine("\t  --- Formulaire de nouvel utilisateur ---");
    polosa();
    Console.Write("Veuillez saisir votre prénom: "); string Name = Convert.ToString(Console.ReadLine()!);
    Console.Write("Veuillez saisir votre nom de famille: "); string SurName = Convert.ToString(Console.ReadLine()!);
    Console.Write("Veuillez saisir votre date de naissance au format JJ.MM.AAAA: "); DateTime age = DateTime.Parse(Console.ReadLine()!);
    polosa();
    Console.WriteLine("\t      --- Profil utilisateur créé ---");
    polosa();
    Console.WriteLine($"Nom: {Name}\nPrénom: {SurName}\nVotre date de naissance: {age.ToString("dd.MM.yyyy")}");
    polosa();
}

Console.WriteLine("Выберете язык! | Select a language! | Choisissez la langue! | ru/en/fr");
string? unketa = Convert.ToString(Console.ReadLine());
switch (unketa)
{
    case "ru":
        SayHellowRu();
        UnketaRu();
        break;
    case "en":
        SayHellowEn();
        UnketaEn();
        break;
    case "fr":
        SayHelloFr();
        UnketaFr();
        break;
    default:
        Console.WriteLine("Вы ввели не тот язык! | You selected the wrong language! | Vous avez entré la mauvaise langue!");
        break;
}
