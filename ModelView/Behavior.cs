using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{

    public class Behavior : BattleBehavior
    {

        private Character character;
        private bool attack = false;

        public Behavior(Character character)
        {

            this.character = character;

        }

        public String getName()
        {

            return character.getName();

        }

        public BattleBehavior changeAttack()
        {

            attack = true;

            return this;

        }

        public BattleBehavior changeDefense()
        {

            attack = false;

            return this;

        }

        public bool isAttack()
        {

            return attack;

        }

        public bool isDefense()
        {

            return !attack;

        }

    }

}
