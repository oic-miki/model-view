using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public interface BattleBehavior
    {

        String getName();

        BattleBehavior changeAttack();

        BattleBehavior changeDefense();

        bool isAttack();

        bool isDefense();

    }

}
