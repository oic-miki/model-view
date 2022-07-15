using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public class CharacterVS : Character
    {

        private CharacterView view;

        public CharacterVS(
            String name,
            String role,
            int hitPoint,
            int strength,
            int agility,
            CharacterView view) : base(name, role, hitPoint, strength, agility)
        {

            this.view  = view;

        }

        public override Character addArena()
        {

            view.Show();

            return this;

        }

        public override void update()
        {

            base.update();

            view.getNameLabel().Text = getName();
            view.getRoleLabel().Text = getRole();
            view.getHitPointLabel().Text = getHitPoint().ToString();
            view.getStrengthLabel().Text = getStrength().ToString();
            view.getAgilityLabel().Text = getAgility().ToString();

        }

    }

}
