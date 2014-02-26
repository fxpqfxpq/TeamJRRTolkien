namespace CrystallBallGame.UI
{
    using System;
    using System.Text;
    public class Map
    {
        private const int MapWidth = 71;
        private const int MapHeight = 22;
        

        public Map()
        {
            this.MapLevel = CreateMap();
        }

        public char[,] MapLevel { get; private set; }
        

        public static char[,] CreateMap()
        {
            StringBuilder result = new StringBuilder();
            char[,] currMap = new char[MapHeight, MapWidth];

            result.AppendLine(new string('_', 69));
            result.AppendLine("|~ ~~ ~~~ ~ ~ ~~~ ~ _____.----------._ ~~~  ~~~~ ~~   ~~  ~~~~~ ~~~~|");
            result.AppendLine("|  _   ~~ ~~ __,---'_       \"         `. ~~~ _,--.  ~~~~ __,---.  ~~|");
            result.AppendLine("| | \\___ ~~ /      ( )   \"          \"   `-.,' (') \\~~ ~ {  / _\\ \\~~ |");
            result.AppendLine("|  \\    \\__/_   __(( _)_      (    \"   \"     (_\\_) \\___~ `-.___' \\~~|");
            result.AppendLine("|~~ \\     (  )_(__)_|( ))  \"   ))      ^   \"   |    \"  \\ ~~ ~~/   /~|");
            result.AppendLine("|  ~ \\__ (( _( (  ))  ) _)    ((     ^^    \" |   \"    \\_____|    /~~|");
            result.AppendLine("|~~ ~   \\  ( ))(_)(_)_)|  \"    ))   |\"  \"  \" __,---._ \"  \"   \"  /~~~|");
            result.AppendLine("|~~~~~~~ |(_ _)| | |   |   \"  (   \"      ,-'~~~ ~~~ `-.   ___  /~ ~ |");
            result.AppendLine("|~~~~~~~~|  |  |   |   _,--- ,^o^. _ \"  (~~  ~~~~  ~~~ ) /___\\ \\~~ ~|");
            result.AppendLine("|~~~~~~~/   |      _,----._,'`--'\\.`-._  `._~~_~__~_,-'  |H__|  \\ ~~|");
            result.AppendLine("|~~~~~~/ \"     _,-' / `\\ ,' / _'  \\`.---.._          __        \" \\~ |");
            result.AppendLine("|~~~~ / /   .-' , / ' _,'_  -  _ '- _`._ `.`-._    _/- `--.   \" \" \\~|");
            result.AppendLine("|~~~ / / _-- `---,~.-' __   --  _,---.  `-._   _,-'- / ` \\ \\_   \" |~|");
            result.AppendLine("| ~ | | -- _    /~/  `-_- _  _,' '  \\ \\_`-._,-'  / --   \\  - \\_   / |");
            result.AppendLine("|~~ | \\ -      /~~| \"     ,-'_ /-  `_ ._`._`-...._____...._,--'  /~~|");
            result.AppendLine("| ~~\\  \\_ /   /~~/    ___  `---  ---  - - ' ,--.     ___        |~ ~|");
            result.AppendLine("|~   \\      /'~~|  \" {o o}   \"         \" \" |~~~ \\_,-' ~ `.     ,'~~ |");
            result.AppendLine("| ~~ ~|___/'~~~~~\\    \\\"/      \"  \"   \"    /~ ~~   O ~ ~~`-.__/~ ~~~|");
            result.AppendLine("|~~~ ~~~  ~~~~~~~~`.______________________/ ~~~    |   ~~~ ~~ ~ ~~~~|");
            result.AppendLine("|______~___~~~_______~~_~____~~_____~~___~_~~___~\\_|_/ ~_____~___~__|");
            result.AppendLine(new string('_', 69));
            
            int index = 0;

            for (int row = 0; row < currMap.GetLength(0); row++)
            {
                for (int col = 0; col < currMap.GetLength(1); col++)
                {
                    currMap[row, col] = result[index];
                    index++;
                }
            }

            return currMap;
        }

    }
}
