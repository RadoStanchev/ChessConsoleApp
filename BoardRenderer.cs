namespace ChessConsole
{
    public static class BoardRenderer
    {
        private const string reset = "\u001B[0m";
        private const string whitePieceColor = "\u001B[97m";
        private const string blackPieceColor = "\u001B[30m";

        private const string whiteBackground = "\u001B[47m";
        private const string blackBackground= "\u001B[0;100m";
        private const string highlightedBackground = "\u001B[45m";

        public static void Render(Board board)
        {
            for (int i = 1; i <= 8; i++)
            {
                foreach (var file in Enum.GetValues(typeof(File)))
                {

                }
            }
        }
    }
}
