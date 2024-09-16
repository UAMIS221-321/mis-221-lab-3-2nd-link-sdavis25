// Main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);
// End Main

static string GetEnjoymentLevel(){
    System.Console.WriteLine("What enjoyment level do you want to experience? Enter Boring, Average, Fun, or Epic");
    return Console.ReadLine();
}

static string GetStadiumRecommendation(string enjoymentLevel){
    if(enjoymentLevel == "Boring"){
        return "Neyland Stadium";
    }
    else if(enjoymentLevel == "Average"){
        return "Jordan-Hare Stadium";
    }
    else if(enjoymentLevel == "Fun"){
        return "Tiger Stadium";
    }
    else if(enjoymentLevel == "Epic"){
        return "Saban Field at Bryant-Denny Stadum";
    }
    else{
        return "that is an invalid input";
    }
}

static string GetGameRecommendation(string stadium){
    if(stadium == "Neyland Stadium"){
        return "vs Kent State";
    }
    else if(stadium == "Jordan-Hare Stadium"){
        return "vs Kentucky";
    }
    else if(stadium == "Tiger Stadium"){
        return "vs Alabama";
    }
    else if(stadium == "Saban Field at Bryant-Denny Stadum"){
        return "vs Auburn";
    }
    else{
        return "that is an invalid input";
    }
}


static void DisplayStadiumDetails(string stadium, string game){
    Console.Clear();
    System.Console.WriteLine($"The stadium we recommend is {stadium}. The game being played there is {game}!");
}
