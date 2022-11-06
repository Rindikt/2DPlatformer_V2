using Tool;

namespace Profile
{
    internal class ProfileLevel
    {
        public readonly SubscriptionProperty<LevelState> CurrentState;

        public ProfileLevel(LevelState initailState)
        {
            CurrentState = new SubscriptionProperty<LevelState>();
            CurrentState.Value = initailState;
        }
    }
}
