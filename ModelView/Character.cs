using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public abstract class Character : UpdateListener, BattleBehavior
    {

        private String name;
        private String role;
        private int hitPoint;
        private int strength;
        private int agility;
        private Character enemy;
        private Behavior behavior;

        public Character(
            String name,
            String role,
            int hitPoint,
            int strength,
            int agility)
        {

            this.name = name;
            this.role = role;
            this.hitPoint = hitPoint;
            this.strength = strength;
            this.agility = agility;

            behavior = new Behavior(this);

        }

        public String getName()
        {

            return name;

        }
        
        public String getRole()
        {

            return role;

        }
        
        public int getHitPoint()
        {

            return hitPoint;

        }
        
        public int getStrength()
        {

            return strength;

        }
        
        public int getAgility()
        {

            return agility;

        }

        public Character addEnemy(Character enemy)
        {

            this.enemy = enemy;

            return enemy;

        }

        public abstract Character addArena();

        /**
         * ※サブクラスは必ず base.update() を発効すること！
         */
        public virtual void update()
        {

            if (enemy != null)
            {

                if (checkAgility() < 0)
                {

                    defense();
                    attack();

                }
                else
                {

                    attack();
                    defense();

                }

            }

        }

        private int checkAgility()
        {

            return agility - enemy.getAgility();

        }

        private void defense()
        {

            if (enemy.isAttack())
            {

                hitPoint -= enemy.getStrength() + enemy.getAgility() * 2;

            }

        }

        public virtual BattleBehavior changeAttack()
        {

            behavior.changeAttack();

            return this;

        }

        public virtual BattleBehavior changeDefense()
        {

            behavior.changeDefense();

            return this;

        }

        private void attack()
        {

            if (enemy.isDefense())
            {

            }

        }

        public bool isAttack()
        {

            return behavior.isAttack();

        }

        public bool isDefense()
        {

            return behavior.isDefense();

        }

        public bool isDead()
        {

            return !(hitPoint > 0);

        }

    }

}
