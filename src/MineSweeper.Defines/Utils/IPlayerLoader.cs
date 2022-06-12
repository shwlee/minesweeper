using MineSweeper.Defines.Enums;
using MineSweeper.Player;

namespace MineSweeper.Defines.Utils;

public interface IPlayerLoader
{
    IEnumerable<IPlayer> LoadPlayers(Platform platform, int size = 4);

    void ClearLoadedPlayers();
}