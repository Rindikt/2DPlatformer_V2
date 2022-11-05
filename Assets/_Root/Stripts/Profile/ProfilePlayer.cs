using Tool;

namespace Profile
{
    internal class ProfilePlayer
    {
        public readonly SubscriptionProperty<GameState> CurrentState;

        public ProfilePlayer(GameState initailState)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentState.Value = initailState;
        }
    }
}
