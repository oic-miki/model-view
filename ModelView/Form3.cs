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
    public partial class BehaviorController : Form
    {

        private BattleBehavior behavior;

        public BehaviorController(BattleBehavior behavior)
        {

            InitializeComponent();

            this.behavior = behavior;

            label1.Text = behavior.getName();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            behavior.changeAttack();

        }

        private void defense_Click(object sender, EventArgs e)
        {

            behavior.changeDefense();

        }

    }

}
