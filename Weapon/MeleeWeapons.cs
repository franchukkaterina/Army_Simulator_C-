namespace Weapon{
    using Soldiers;
   public class MeleeWeapons : IWeapon{
        public int HP_Level { get; private set; }
       
        public int Damage { get; private set; }
       
        protected MeleeWeapons(int damage)
        {
            this.HP_Level= 100;
            this.Damage = damage;
        }
        public int Hit(Soldier owner,Soldier enemy  ){
             owner.Defend(enemy);
             return --this.HP_Level;
        }

    }
}