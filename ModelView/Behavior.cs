using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{

    public class Behavior
    {

        private bool attack = false;

        public Behavior()
        {

        }

        public Behavior changeAttack()
        {

            attack = true;

            return this;

        }

        public Behavior changeDefense()
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
