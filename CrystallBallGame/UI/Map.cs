namespace CrystallBallGame.UI
{
    using System;
    using System.Text;
    public class Map
    {
        public StringBuilder GameMap { get; private set; }

        public Map()
        {
            this.GameMap = CreateMap();
        }
        public static StringBuilder CreateMap()
        {
            StringBuilder map = new StringBuilder();
            map.AppendLine(new string('_', 69));
            map.AppendLine("|~ ~~ ~~~ ~ ~ ~~~ ~ _____.----------._ ~~~  ~~~~ ~~   ~~  ~~~~~ ~~~~|");
            map.AppendLine("|  _   ~~ ~~ __,---'_       \"         `. ~~~ _,--.  ~~~~ __,---.  ~~|");
            map.AppendLine("| | \\___ ~~ /      ( )   \"          \"   `-.,' (') \\~~ ~ {  / _\\ \\~~ |");
            map.AppendLine("|  \\    \\__/_   __(( _)_      (    \"   \"     (_\\_) \\___~ `-.___' \\~~|");
            map.AppendLine("|~~ \\     (  )_(__)_|( ))  \"   ))      ^   \"   |    \"  \\ ~~ ~~/   /~|");
            map.AppendLine("|  ~ \\__ (( _( (  ))  ) _)    ((     ^^    \" |   \"    \\_____|    /~~|");
            map.AppendLine("|~~ ~   \\  ( ))(_)(_)_)|  \"    ))   |\"  \"  \" __,---._ \"  \"   \"  /~~~|");
            map.AppendLine("|~~~~~~~ |(_ _)| | |   |   \"  (   \"      ,-'~~~ ~~~ `-.   ___  /~ ~ |");
            map.AppendLine("|~~~~~~~~|  |  |   |   _,--- ,^o^. _ \"  (~~  ~~~~  ~~~ ) /___\\ \\~~ ~|");
            map.AppendLine("|~~~~~~~/   |      _,----._,'`--'\\.`-._  `._~~_~__~_,-'  |*__|  \\ ~~|");
            map.AppendLine("|~~~~~~/ \"     _,-' / `\\ ,' / _'  \\`.---.._          __        \" \\~ |");
            map.AppendLine("|~~~~ / /   .-' , / ' _,'_  -  _ '- _`._ `.`-._    _/- `--.   \" \" \\~|");
            map.AppendLine("|~~~ / / _-- `---,~.-' __   --  _,---.  `-._   _,-'- / ` \\ \\_   \" |~|");
            map.AppendLine("| ~ | | -- _    /~/  `-_- _  _,' '  \\ \\_`-._,-'  / --   \\  - \\_   / |");
            map.AppendLine("|~~ | \\ -      /~~| \"     ,-'_ /-  `_ ._`._`-...._____...._,--'  /~~|");
            map.AppendLine("| ~~\\  \\_ /   /~~/    ___  `---  ---  - - ' ,--.     ___        |~ ~|");
            map.AppendLine("|~   \\      /'~~|  \" {o o}   \"         \" \" |~~~ \\_,-' ~ `.     ,'~~ |");
            map.AppendLine("| ~~ ~|___/'~~~~~\\    \\\"/      \"  \"   \"    /~ ~~   O ~ ~~`-.__/~ ~~~|");
            map.AppendLine("|~~~ ~~~  ~~~~~~~~`.______________________/ ~~~    |   ~~~ ~~ ~ ~~~~|");
            map.AppendLine("|______~___~~~_______~~_~____~~_____~~___~_~~___~\\_|_/ ~_____~___~__|");
            map.AppendLine(new string('_', 69));

            return map;
        }

    }
}
