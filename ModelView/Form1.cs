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

        private BattleBehavior redCornerBattleBehavior;
        private BattleBehavior blueCornerBattleBehavior;

        public Arena()
        {

            InitializeComponent();

            redCornerCharacter = new CharacterVS(
                this,
                // String name
                "オルフェウス",
                // String role
                "聖戦士",
                // int hitPoint
                12000,
                // int strength
                250,
                // int agility
                75,
                // CharacterView view
                new CharacterView());
            redCornerBattleBehavior = redCornerCharacter.addArena();

            blueCornerCharacter = new CharacterVS(
                this,
                // String name
                "ハデス",
                // String role
                "狂戦士",
                // int hitPoint
                30000,
                // int strength
                500,
                // int agility
                25,
                // CharacterView view
                new CharacterView()).addArena();

            blueCornerBattleBehavior = blueCornerCharacter.addArena();

            redCornerCharacter.addEnemy(blueCornerCharacter);
            blueCornerCharacter.addEnemy(redCornerCharacter);

            redCorner.Text = redCornerCharacter.getName();
            blueCorner.Text = blueCornerCharacter.getName();

            message.Text = "Ready...";

            update();

        }

        public void addUpdateListener(UpdateListener listener)
        {

            updateListeners.Add(listener);

        }

        public void notify()
        {

            update();

        }

        public void update()
        {

            foreach (UpdateListener updateListener in updateListeners)
            {

                updateListener.update();

            }

            if (redCornerCharacter.isDead())
            {

                redBehavior.Text = "（バタンキュー ><）";

            }
            else if (redCornerCharacter.isAttack())
            {

                redBehavior.Text = "攻撃！";

            }
            else
            {

                redBehavior.Text = "＊防御＊";

            }

            if (blueCornerCharacter.isDead())
            {

                blueBehavior.Text = "（バタンキュー ><）";

            }
            else if (blueCornerCharacter.isAttack())
            {

                blueBehavior.Text = "攻撃！";

            }
            else
            {

                blueBehavior.Text = "＊防御＊";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            notify();

        }
    }

}
