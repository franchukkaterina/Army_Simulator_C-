namespace Weapon{
    using Soldiers;
    using Shell;
   public class Rifle : IWeapon{
        public int HP_Level { get; private set; }
        public Shell shell;
        public int Power { get; private set; }
       
        protected Rifle(int power)
        {
            this.HP_Level= 100;
            this.Power = power;
        }
        public int Hit(Soldier owner,Soldier enemy  ){
             owner.Defend(enemy);
             return --this.HP_Level;
        }

    }
}