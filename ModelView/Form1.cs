using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelView
{
    public partial class Arena : Form
    {

        private List<UpdateListener> updateListeners = new List<UpdateListener>();

        private Character redCornerCharacter;
        private Character blueCornerCharacter;

        public Arena()
        {

            InitializeComponent();

            redCornerCharacter = new CharacterVS(
                // String name
                "オルフェウス",
                // String role
                "聖戦士",
                // int hitPoint
                120,
                // int strength
                250,
                // int agility
                75,
                // CharacterView view
                new CharacterView());

            redCorner.Text = redCornerCharacter.getName();

            blueCornerCharacter = new CharacterVS(
                // String name
                "ハデス",
                // String role
                "狂戦士",
                // int hitPoint
                300,
                // int strength
                500,
                // int agility
                25,
                // CharacterView view
                new CharacterView());

            blueCorner.Text = blueCornerCharacter.getName();

            updateListeners.Add(redCornerCharacter.addArena().addEnemy(blueCornerCharacter));
            updateListeners.Add(blueCornerCharacter.addArena().addEnemy(redCornerCharacter));

            message.Text = "Ready...";

            update();

        }

        public void update()
        {

            foreach (UpdateListener updateListener in updateListeners)
            {

                updateListener.update();

            }

// TODO
            if (redCornerCharacter.isAttack())
            {

                redBehavior.Text = "攻撃！";

            }
            else
            {

                redBehavior.Text = "（防御）";

            }

            if (blueCornerCharacter.isAttack())
            {

                blueBehavior.Text = "攻撃！";

            }
            else
            {

                blueBehavior.Text = "（防御）";

            }

        }

    }

}
