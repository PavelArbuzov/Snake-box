namespace Snake_box
{
    public sealed class SimpleEnemy : BaseEnemy
    {
        #region PrivateData

        private SimpleEnemyData _data;

        #endregion

        #region ClassLifeCycles

        public SimpleEnemy()
        {
            _data = Data.Instance.SimpleEnemy;
            Type = EnemyType.Simple;
            prefab = _data.prefab;
            _SpawnCenter = _data.SpawnCenter.transform.position;
            _spawnRadius = _data.SpawnRadius;
            _speed = _data.speed;
            _hp = _data.hp;
            _damage = _data.damage;
            GetTarget();
        }

        #endregion
    }
}
