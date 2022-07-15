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
    public partial class CharacterView : Form
    {
        public CharacterView()
        {

            InitializeComponent();

        }

        public Label getNameLabel()
        {
            
            return nameLabel;

        }

        public Label getRoleLabel()
        {

            return roleLabel;

        }

        public Label getHitPointLabel()
        {

            return hitPointLabel;

        }

        public Label getStrengthLabel()
        {

            return strengthLabel;

        }

        public Label getAgilityLabel()
        {

            return agilityLabel;

        }

    }

}
