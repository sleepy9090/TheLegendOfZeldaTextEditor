using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Shawn M. Crawford
namespace TheLegendOfZeldaTextEditor {
    public partial class FormGameText : Form {

        string path = "";

        public FormGameText() {
            InitializeComponent();
        }

        public string sendPathToOtherForm {
            get {
                return path;
            }
            set {
                path = value;
            }
        }

        private void readRomText() {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                // Last character needs special encoding
                backend.getText(absoluteFilename, textBoxInGame1, 0x13, 0x405E, 1); // IT'S DANGEROUS TO GO
                backend.getText(absoluteFilename, textBoxInGame1, 0x1, 0x4071, 2);

                backend.getText(absoluteFilename, textBoxInGame2, 0x10, 0x4076, 1); // ALONE! TAKE THIS.
                backend.getText(absoluteFilename, textBoxInGame2, 0x1, 0x4086, 4);

                backend.getText(absoluteFilename, textBoxInGame3, 0x12, 0x4089, 1); // MASTER USING IT AND
                backend.getText(absoluteFilename, textBoxInGame3, 0x1, 0x409B, 2);

                backend.getText(absoluteFilename, textBoxInGame4, 0x11, 0x409F, 1); // YOU CAN HAVE THIS
                backend.getText(absoluteFilename, textBoxInGame4, 0x1, 0x40B0, 4);

                backend.getText(absoluteFilename, textBoxInGame5, 0x16, 0x40B2, 1); // TAKE ANY ROAD YOU WANT

                backend.getText(absoluteFilename, textBoxInGame6, 0x14, 0x40CA, 1); // SECRET IS IN THE TREE
                backend.getText(absoluteFilename, textBoxInGame6, 0x1, 0x40DE, 2);

                backend.getText(absoluteFilename, textBoxInGame7, 0xF, 0x40E3, 1); // AT THE DEAD-END.
                backend.getText(absoluteFilename, textBoxInGame7, 0x1, 0x40F2, 4);

                backend.getText(absoluteFilename, textBoxInGame8, 0xF, 0x40F6, 1); // LET'S PLAY MONEY
                backend.getText(absoluteFilename, textBoxInGame8, 0x1, 0x4105, 2);

                backend.getText(absoluteFilename, textBoxInGame9, 0xB, 0x4109, 1); // MAKING GAME.
                backend.getText(absoluteFilename, textBoxInGame9, 0x1, 0x4114, 4);

                backend.getText(absoluteFilename, textBoxInGame10, 0x12, 0x4117, 1); // PAY ME FOR THE DOOR
                backend.getText(absoluteFilename, textBoxInGame10, 0x1, 0x4129, 2);

                backend.getText(absoluteFilename, textBoxInGame11, 0xD, 0x412F, 1); // REPAIR CHARGE.
                backend.getText(absoluteFilename, textBoxInGame11, 0x1, 0x413C, 4);

                backend.getText(absoluteFilename, textBoxInGame12, 0xF, 0x4141, 1); // SHOW THIS TO THE
                backend.getText(absoluteFilename, textBoxInGame12, 0x1, 0x4150, 2);

                backend.getText(absoluteFilename, textBoxInGame13, 0x9, 0x4158, 1); // OLD WOMAN.
                backend.getText(absoluteFilename, textBoxInGame13, 0x1, 0x4161, 4);

                backend.getText(absoluteFilename, textBoxInGame14, 0xF, 0x4166, 1); // MEET THE OLD MAN
                backend.getText(absoluteFilename, textBoxInGame14, 0x1, 0x4175, 2);

                backend.getText(absoluteFilename, textBoxInGame15, 0xC, 0x417C, 1); // AT THE GRAVE.
                backend.getText(absoluteFilename, textBoxInGame15, 0x1, 0x4188, 4);

                backend.getText(absoluteFilename, textBoxInGame16, 0x12, 0x418B, 1); // BUY MEDICINE BEFORE
                backend.getText(absoluteFilename, textBoxInGame16, 0x1, 0x419D, 2);

                backend.getText(absoluteFilename, textBoxInGame17, 0x6, 0x41A0, 1); // YOU GO.
                backend.getText(absoluteFilename, textBoxInGame17, 0x1, 0x41A6, 4);

                backend.getText(absoluteFilename, textBoxInGame18, 0x14, 0x41A9, 1); // PAY ME AND I'LL TALK.
                backend.getText(absoluteFilename, textBoxInGame18, 0x1, 0x41BD, 4);

                backend.getText(absoluteFilename, textBoxInGame19, 0x10, 0x41C1, 1); // THIS AIN'T ENOUGH
                backend.getText(absoluteFilename, textBoxInGame19, 0x1, 0x41D1, 2);

                backend.getText(absoluteFilename, textBoxInGame20, 0x7, 0x41DA, 1); // TO TALK.
                backend.getText(absoluteFilename, textBoxInGame20, 0x1, 0x41E1, 4);

                backend.getText(absoluteFilename, textBoxInGame21, 0x8, 0x41E9, 1); // GO UP,UP,
                backend.getText(absoluteFilename, textBoxInGame21, 0x1, 0x41F1, 2);

                backend.getText(absoluteFilename, textBoxInGame22, 0x12, 0x41F5, 1); // THE MOUNTAIN AHEAD.
                backend.getText(absoluteFilename, textBoxInGame22, 0x1, 0x4207, 4);

                backend.getText(absoluteFilename, textBoxInGame23, 0x13, 0x420A, 1); // GO NORTH,WEST,SOUTH,
                backend.getText(absoluteFilename, textBoxInGame23, 0x1, 0x421D, 2);

                backend.getText(absoluteFilename, textBoxInGame24, 0x11, 0x4220, 1); // WEST TO THE FOREST
                backend.getText(absoluteFilename, textBoxInGame24, 0x1, 0x4231, 3);

                backend.getText(absoluteFilename, textBoxInGame25, 0x7, 0x4234, 1); // OF MAZE.
                backend.getText(absoluteFilename, textBoxInGame25, 0x1, 0x423B, 4);

                backend.getText(absoluteFilename, textBoxInGame26, 0x10, 0x4240, 1); // BOY, YOU'RE RICH.
                backend.getText(absoluteFilename, textBoxInGame26, 0x1, 0x4250, 4);

                backend.getText(absoluteFilename, textBoxInGame27, 0x15, 0x4252, 1); // BUY SOMETHIN' WILL YA!
                backend.getText(absoluteFilename, textBoxInGame27, 0x1, 0x4267, 4);

                backend.getText(absoluteFilename, textBoxInGame28, 0xB, 0x426D, 1); // BOY, THIS IS
                backend.getText(absoluteFilename, textBoxInGame28, 0x1, 0x4278, 2);

                backend.getText(absoluteFilename, textBoxInGame29, 0x10, 0x427C, 1); // REALLY EXPENSIVE!
                backend.getText(absoluteFilename, textBoxInGame29, 0x1, 0x428C, 4);

                backend.getText(absoluteFilename, textBoxInGame30, 0x15, 0x428E, 1); // TAKE ANY ONE YOU WANT.
                backend.getText(absoluteFilename, textBoxInGame30, 0x1, 0x42A3, 4);

                backend.getText(absoluteFilename, textBoxInGame31, 0xC, 0x42A9, 1); // IT'S A SECRET
                backend.getText(absoluteFilename, textBoxInGame31, 0x1, 0x42B5, 2);

                backend.getText(absoluteFilename, textBoxInGame32, 0xC, 0x42BB, 1); // TO EVERYBODY.
                backend.getText(absoluteFilename, textBoxInGame32, 0x1, 0x42C7, 4);

                backend.getText(absoluteFilename, textBoxInGame33, 0x11, 0x42CB, 1); // GRUMBLE,GRUMBLE...
                backend.getText(absoluteFilename, textBoxInGame33, 0x1, 0x42DC, 4);

                backend.getText(absoluteFilename, textBoxInGame34, 0x12, 0x42DF, 1); // EASTMOST PENNINSULA
                backend.getText(absoluteFilename, textBoxInGame34, 0x1, 0x42F1, 2);

                backend.getText(absoluteFilename, textBoxInGame35, 0xD, 0x42F7, 1); // IS THE SECRET.
                backend.getText(absoluteFilename, textBoxInGame35, 0x1, 0x4304, 4);

                backend.getText(absoluteFilename, textBoxInGame36, 0x16, 0x4306, 1); // DODONGO DISLIKES SMOKE.
                backend.getText(absoluteFilename, textBoxInGame36, 0x1, 0x431C, 4);

                backend.getText(absoluteFilename, textBoxInGame37, 0x14, 0x431E, 1); // DID YOU GET THE SWORD
                backend.getText(absoluteFilename, textBoxInGame37, 0x1, 0x4332, 2);

                backend.getText(absoluteFilename, textBoxInGame38, 0x12, 0x4334, 1); // FROM THE OLD MAN ON
                backend.getText(absoluteFilename, textBoxInGame38, 0x1, 0x4346, 3);

                backend.getText(absoluteFilename, textBoxInGame39, 0x14, 0x4348, 1); // TOP OF THE WATERFALL?
                backend.getText(absoluteFilename, textBoxInGame39, 0x1, 0x435C, 4);

                backend.getText(absoluteFilename, textBoxInGame40, 0xC, 0x4362, 1); // WALK INTO THE
                backend.getText(absoluteFilename, textBoxInGame40, 0x1, 0x436E, 2);

                backend.getText(absoluteFilename, textBoxInGame41, 0x9, 0x4376, 1); // WATERFALL.
                backend.getText(absoluteFilename, textBoxInGame41, 0x1, 0x437F, 4);

                backend.getText(absoluteFilename, textBoxInGame42, 0x13, 0x4382, 1); // SECRET POWER IS SAID
                backend.getText(absoluteFilename, textBoxInGame42, 0x1, 0x4395, 2);

                backend.getText(absoluteFilename, textBoxInGame43, 0x12, 0x4399, 1); // TO BE IN THE ARROW.
                backend.getText(absoluteFilename, textBoxInGame43, 0x1, 0x43AB, 4);

                backend.getText(absoluteFilename, textBoxInGame44, 0xE, 0x43B0, 1); // DIGDOGGER HATES
                backend.getText(absoluteFilename, textBoxInGame44, 0x1, 0x43BE, 2);

                backend.getText(absoluteFilename, textBoxInGame45, 0x15, 0x43C0, 1); // CERTAIN KIND OF SOUND.
                backend.getText(absoluteFilename, textBoxInGame45, 0x1, 0x43D5, 4);

                backend.getText(absoluteFilename, textBoxInGame46, 0xF, 0x43DA, 1); // I BET YOU'D LIKE
                backend.getText(absoluteFilename, textBoxInGame46, 0x1, 0x43E9, 2);

                backend.getText(absoluteFilename, textBoxInGame47, 0x12, 0x43ED, 1); // TO HAVE MORE BOMBS.
                backend.getText(absoluteFilename, textBoxInGame47, 0x1, 0x43FF, 4);

                backend.getText(absoluteFilename, textBoxInGame48, 0xF, 0x4404, 1); // IF YOU GO IN THE
                backend.getText(absoluteFilename, textBoxInGame48, 0x1, 0x4413, 2);

                backend.getText(absoluteFilename, textBoxInGame49, 0x16, 0x4415, 1); // DIRECTION OF THE ARROW.
                backend.getText(absoluteFilename, textBoxInGame49, 0x1, 0x442B, 4);

                backend.getText(absoluteFilename, textBoxInGame50, 0xE, 0x4430, 1); // LEAVE YOUR LIFE
                backend.getText(absoluteFilename, textBoxInGame50, 0x1, 0x443E, 2);

                backend.getText(absoluteFilename, textBoxInGame51, 0x8, 0x4446, 1); // OR MONEY.
                backend.getText(absoluteFilename, textBoxInGame51, 0x1, 0x444E, 4);

                backend.getText(absoluteFilename, textBoxInGame52, 0x16, 0x4450, 1); // THERE ARE SECRETS WHERE
                backend.getText(absoluteFilename, textBoxInGame52, 0x1, 0x4466, 2);

                backend.getText(absoluteFilename, textBoxInGame53, 0x12, 0x446A, 1); // FAIRIES DON'T LIVE.
                backend.getText(absoluteFilename, textBoxInGame53, 0x1, 0x447C, 4);

                backend.getText(absoluteFilename, textBoxInGame54, 0xE, 0x4481, 1); // AIM AT THE EYES
                backend.getText(absoluteFilename, textBoxInGame54, 0x1, 0x448F, 2);

                backend.getText(absoluteFilename, textBoxInGame55, 0x8, 0x4497, 1); // OF GOHMA.
                backend.getText(absoluteFilename, textBoxInGame55, 0x1, 0x449F, 4);

                backend.getText(absoluteFilename, textBoxInGame56, 0x12, 0x44A2, 1); // SOUTH OF ARROW MARK
                backend.getText(absoluteFilename, textBoxInGame56, 0x1, 0x44B4, 2);

                backend.getText(absoluteFilename, textBoxInGame57, 0xE, 0x44B9, 1); // HIDES A SECRET.
                backend.getText(absoluteFilename, textBoxInGame57, 0x1, 0x44C7, 4);

                backend.getText(absoluteFilename, textBoxInGame58, 0x12, 0x44CA, 1); // THERE'S A SECRET IN
                backend.getText(absoluteFilename, textBoxInGame58, 0x1, 0x44DC, 2);

                backend.getText(absoluteFilename, textBoxInGame59, 0x13, 0x44DF, 1); // THE TIP OF THE NOSE.
                backend.getText(absoluteFilename, textBoxInGame59, 0x1, 0x44F2, 4);

                backend.getText(absoluteFilename, textBoxInGame60, 0x10, 0x44F6, 1); // SPECTACLE ROCK IS
                backend.getText(absoluteFilename, textBoxInGame60, 0x1, 0x4506, 2);

                backend.getText(absoluteFilename, textBoxInGame61, 0x14, 0x4509, 1); // AN ENTRANCE TO DEATH.
                backend.getText(absoluteFilename, textBoxInGame61, 0x1, 0x451D, 4);

                backend.getText(absoluteFilename, textBoxInGame62, 0x17, 0x451E, 1); // 10TH ENEMY HAS THE BOMB.
                backend.getText(absoluteFilename, textBoxInGame62, 0x1, 0x4535, 4);

                backend.getText(absoluteFilename, textBoxInGame63, 0x15, 0x4537, 1); // ONES WHO DOES NOT HAVE
                backend.getText(absoluteFilename, textBoxInGame63, 0x1, 0x454C, 2);

                backend.getText(absoluteFilename, textBoxInGame64, 0x14, 0x454E, 1); // TRIFORCE CAN'T GO IN.
                backend.getText(absoluteFilename, textBoxInGame64, 0x1, 0x4562, 4);

                backend.getText(absoluteFilename, textBoxInGame65, 0x11, 0x4566, 1); // PATRA HAS THE MAP.
                backend.getText(absoluteFilename, textBoxInGame65, 0x1, 0x4577, 4);

                backend.getText(absoluteFilename, textBoxInGame66, 0x13, 0x457A, 1); // GO TO THE NEXT ROOM.
                backend.getText(absoluteFilename, textBoxInGame66, 0x1, 0x458D, 4);

                backend.getText(absoluteFilename, textBoxInGame67, 0xC, 0x4593, 1); // EYES OF SKULL
                backend.getText(absoluteFilename, textBoxInGame67, 0x1, 0x459F, 2);

                backend.getText(absoluteFilename, textBoxInGame68, 0xC, 0x45A5, 1); // HAS A SECRET.
                backend.getText(absoluteFilename, textBoxInGame68, 0x1, 0x45B1, 4);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x13, textBoxInGame1, 0x405E, 1); // IT'S DANGEROUS TO GO
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame1.Text.Substring(textBoxInGame1.Text.Length - 1, 1), 0x4071, 2);

                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame2, 0x4076, 1); // ALONE! TAKE THIS.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame2.Text.Substring(textBoxInGame2.Text.Length - 1, 1), 0x4086, 4);

                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame3, 0x4089, 1); // MASTER USING IT AND
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame3.Text.Substring(textBoxInGame3.Text.Length - 1, 1), 0x409B, 2);

                backend.updateROMText(absoluteFilename, 0x11, textBoxInGame4, 0x409F, 1); // YOU CAN HAVE THIS
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame4.Text.Substring(textBoxInGame4.Text.Length - 1, 1), 0x40B0, 4);

                backend.updateROMText(absoluteFilename, 0x16, textBoxInGame5, 0x40B2, 1); // TAKE ANY ROAD YOU WANT

                backend.updateROMText(absoluteFilename, 0x11, textBoxInGame6, 0x40CA, 1); // SECRET IS IN THE TREE
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame6.Text.Substring(textBoxInGame6.Text.Length - 1, 1), 0x40DE, 2);

                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame7, 0x40E3, 1); // AT THE DEAD-END.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame7.Text.Substring(textBoxInGame7.Text.Length - 1, 1), 0x40F2, 4);

                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame8, 0x40F6, 1); // LET'S PLAY MONEY
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame8.Text.Substring(textBoxInGame8.Text.Length - 1, 1), 0x4105, 2);

                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame9, 0x4109, 1); // MAKING GAME.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame9.Text.Substring(textBoxInGame9.Text.Length - 1, 1), 0x4114, 4);

                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame10, 0x4117, 1); // PAY ME FOR THE DOOR
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame10.Text.Substring(textBoxInGame10.Text.Length - 1, 1), 0x4129, 2);

                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame11, 0x412F, 1); // REPAIR CHARGE.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame11.Text.Substring(textBoxInGame11.Text.Length - 1, 1), 0x413C, 4);

                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame12, 0x4141, 1); // SHOW THIS TO THE
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame12.Text.Substring(textBoxInGame12.Text.Length - 1, 1), 0x4150, 2);

                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame13, 0x4158, 1); // OLD WOMAN.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame13.Text.Substring(textBoxInGame13.Text.Length - 1, 1), 0x4161, 4);

                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame14, 0x4166, 1); // MEET THE OLD MAN
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame14.Text.Substring(textBoxInGame14.Text.Length - 1, 1), 0x4175, 2);

                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame15, 0x417C, 1); // AT THE GRAVE.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame15.Text.Substring(textBoxInGame15.Text.Length - 1, 1), 0x4188, 4);

                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame16, 0x418B, 1); // BUY MEDICINE BEFORE
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame16.Text.Substring(textBoxInGame16.Text.Length - 1, 1), 0x419D, 2);

                backend.updateROMText(absoluteFilename, 0x6, textBoxInGame17, 0x41A0, 1); // YOU GO.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame17.Text.Substring(textBoxInGame17.Text.Length - 1, 1), 0x41A6, 4);

                backend.updateROMText(absoluteFilename, 0x14, textBoxInGame18, 0x41A9, 1); // PAY ME AND I'LL TALK.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame18.Text.Substring(textBoxInGame18.Text.Length - 1, 1), 0x41BD, 4);

                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame19, 0x41C1, 1); // THIS AIN'T ENOUGH
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame19.Text.Substring(textBoxInGame19.Text.Length - 1, 1), 0x41D1, 2);

                backend.updateROMText(absoluteFilename, 0x7, textBoxInGame20, 0x41DA, 1); // TO TALK.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame20.Text.Substring(textBoxInGame20.Text.Length - 1, 1), 0x41E1, 4);

                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame21, 0x41E9, 1); // GO UP,UP,
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame21.Text.Substring(textBoxInGame21.Text.Length - 1, 1), 0x41F1, 2);

                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame22, 0x41F5, 1); // THE MOUNTAIN AHEAD.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame22.Text.Substring(textBoxInGame22.Text.Length - 1, 1), 0x4207, 4);

                backend.updateROMText(absoluteFilename, 0x13, textBoxInGame23, 0x420A, 1); // GO NORTH,WEST,SOUTH,
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame23.Text.Substring(textBoxInGame23.Text.Length - 1, 1), 0x421D, 2);

                backend.updateROMText(absoluteFilename, 0x11, textBoxInGame24, 0x4220, 1); // WEST TO THE FOREST
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame24.Text.Substring(textBoxInGame24.Text.Length - 1, 1), 0x4231, 3);

                backend.updateROMText(absoluteFilename, 0x7, textBoxInGame25, 0x4234, 1); // OF MAZE.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame25.Text.Substring(textBoxInGame25.Text.Length - 1, 1), 0x423B, 4);

                backend.updateROMText(absoluteFilename, 0x7, textBoxInGame26, 0x4240, 1); // BOY, YOU'RE RICH.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame26.Text.Substring(textBoxInGame26.Text.Length - 1, 1), 0x4250, 4);

                backend.updateROMText(absoluteFilename, 0x15, textBoxInGame27, 0x4252, 1); // BUY SOMETHIN' WILL YA!
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame27.Text.Substring(textBoxInGame27.Text.Length - 1, 1), 0x4267, 4);

                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame28, 0x426D, 1); // BOY, THIS IS
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame28.Text.Substring(textBoxInGame28.Text.Length - 1, 1), 0x4278, 2);

                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame29, 0x427C, 1); // REALLY EXPENSIVE!
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame29.Text.Substring(textBoxInGame29.Text.Length - 1, 1), 0x428C, 4);

                backend.updateROMText(absoluteFilename, 0x15, textBoxInGame30, 0x428E, 1); // TAKE ANY ONE YOU WANT.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame30.Text.Substring(textBoxInGame30.Text.Length - 1, 1), 0x42A3, 4);

                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame31, 0x42A9, 1); // IT'S A SECRET
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame31.Text.Substring(textBoxInGame31.Text.Length - 1, 1), 0x42B5, 2);

                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame32, 0x42BB, 1); // TO EVERYBODY.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame32.Text.Substring(textBoxInGame32.Text.Length - 1, 1), 0x42C7, 4);

                backend.updateROMText(absoluteFilename, 0x11, textBoxInGame33, 0x42CB, 1); // GRUMBLE,GRUMBLE...
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame33.Text.Substring(textBoxInGame33.Text.Length - 1, 1), 0x42DC, 4);

                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame34, 0x42DF, 1); // EASTMOST PENNINSULA
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame34.Text.Substring(textBoxInGame34.Text.Length - 1, 1), 0x42F1, 2);

                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame35, 0x42F7, 1); // IS THE SECRET.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame35.Text.Substring(textBoxInGame35.Text.Length - 1, 1), 0x4304, 4);

                backend.updateROMText(absoluteFilename, 0x16, textBoxInGame36, 0x4306, 1); // DODONGO DISLIKES SMOKE.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame36.Text.Substring(textBoxInGame36.Text.Length - 1, 1), 0x431C, 4);

                backend.updateROMText(absoluteFilename, 0x14, textBoxInGame37, 0x431E, 1); // DID YOU GET THE SWORD
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame37.Text.Substring(textBoxInGame37.Text.Length - 1, 1), 0x4332, 2);

                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame38, 0x4334, 1); // FROM THE OLD MAN ON
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame38.Text.Substring(textBoxInGame38.Text.Length - 1, 1), 0x4348, 3);

                backend.updateROMText(absoluteFilename, 0x14, textBoxInGame39, 0x4348, 1); // TOP OF THE WATERFALL?
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame39.Text.Substring(textBoxInGame39.Text.Length - 1, 1), 0x435C, 4);

                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame40, 0x4362, 1); // WALK INTO THE
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame40.Text.Substring(textBoxInGame40.Text.Length - 1, 1), 0x436E, 2);

                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame41, 0x4376, 1); // WATERFALL.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame41.Text.Substring(textBoxInGame41.Text.Length - 1, 1), 0x437F, 4);

                backend.updateROMText(absoluteFilename, 0x13, textBoxInGame42, 0x4382, 1); // SECRET POWER IS SAID
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame42.Text.Substring(textBoxInGame42.Text.Length - 1, 1), 0x4395, 2);

                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame43, 0x4399, 1); // TO BE IN THE ARROW.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame43.Text.Substring(textBoxInGame43.Text.Length - 1, 1), 0x43AB, 4);

                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame44, 0x43B0, 1); // DIGDOGGER HATES
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame44.Text.Substring(textBoxInGame44.Text.Length - 1, 1), 0x43BE, 2);

                backend.updateROMText(absoluteFilename, 0x15, textBoxInGame45, 0x43C0, 1); // CERTAIN KIND OF SOUND.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame45.Text.Substring(textBoxInGame45.Text.Length - 1, 1), 0x43D5, 4);

                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame46, 0x43DA, 1); // I BET YOU'D LIKE
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame46.Text.Substring(textBoxInGame46.Text.Length - 1, 1), 0x43E9, 2);

                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame47, 0x43ED, 1); // TO HAVE MORE BOMBS.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame47.Text.Substring(textBoxInGame47.Text.Length - 1, 1), 0x43FF, 4);

                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame48, 0x4404, 1); // IF YOU GO IN THE
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame48.Text.Substring(textBoxInGame48.Text.Length - 1, 1), 0x4413, 2);

                backend.updateROMText(absoluteFilename, 0x16, textBoxInGame49, 0x4415, 1); // DIRECTION OF THE ARROW.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame49.Text.Substring(textBoxInGame49.Text.Length - 1, 1), 0x442B, 4);

                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame50, 0x4430, 1); // LEAVE YOUR LIFE
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame50.Text.Substring(textBoxInGame50.Text.Length - 1, 1), 0x443E, 2);

                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame51, 0x4446, 1); // OR MONEY.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame51.Text.Substring(textBoxInGame51.Text.Length - 1, 1), 0x444E, 4);

                backend.updateROMText(absoluteFilename, 0x16, textBoxInGame52, 0x4450, 1); // THERE ARE SECRETS WHERE
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame52.Text.Substring(textBoxInGame52.Text.Length - 1, 1), 0x4466, 2);
                
                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame53, 0x446A, 1); // FAIRIES DON'T LIVE.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame53.Text.Substring(textBoxInGame53.Text.Length - 1, 1), 0x447C, 4);

                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame54, 0x4481, 1); // AIM AT THE EYES
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame54.Text.Substring(textBoxInGame54.Text.Length - 1, 1), 0x448F, 2);

                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame55, 0x4497, 1); // OF GOHMA.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame55.Text.Substring(textBoxInGame55.Text.Length - 1, 1), 0x449F, 4);

                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame56, 0x44A2, 1); // SOUTH OF ARROW MARK
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame56.Text.Substring(textBoxInGame56.Text.Length - 1, 1), 0x44B4, 2);

                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame57, 0x44B9, 1); // HIDES A SECRET.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame57.Text.Substring(textBoxInGame57.Text.Length - 1, 1), 0x44C7, 4);

                backend.updateROMText(absoluteFilename, 0x12, textBoxInGame58, 0x44CA, 1); // THERE'S A SECRET IN
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame58.Text.Substring(textBoxInGame58.Text.Length - 1, 1), 0x44DC, 2);

                backend.updateROMText(absoluteFilename, 0x13, textBoxInGame59, 0x44DF, 1); // THE TIP OF THE NOSE.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame59.Text.Substring(textBoxInGame59.Text.Length - 1, 1), 0x44F2, 4);

                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame60, 0x44F6, 1); // SPECTACLE ROCK IS
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame60.Text.Substring(textBoxInGame60.Text.Length - 1, 1), 0x4506, 2);

                backend.updateROMText(absoluteFilename, 0x14, textBoxInGame61, 0x4509, 1); // AN ENTRANCE TO DEATH.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame61.Text.Substring(textBoxInGame61.Text.Length - 1, 1), 0x451D, 4);

                backend.updateROMText(absoluteFilename, 0x17, textBoxInGame62, 0x451E, 1); // 10TH ENEMY HAS THE BOMB.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame62.Text.Substring(textBoxInGame62.Text.Length - 1, 1), 0x4535, 4);

                backend.updateROMText(absoluteFilename, 0x15, textBoxInGame63, 0x4537, 1); // ONES WHO DOES NOT HAVE
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame63.Text.Substring(textBoxInGame63.Text.Length - 1, 1), 0x454C, 2);

                backend.updateROMText(absoluteFilename, 0x14, textBoxInGame64, 0x454E, 1); // TRIFORCE CAN'T GO IN.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame64.Text.Substring(textBoxInGame64.Text.Length - 1, 1), 0x4562, 4);

                backend.updateROMText(absoluteFilename, 0x11, textBoxInGame65, 0x4566, 1); // PATRA HAS THE MAP.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame65.Text.Substring(textBoxInGame65.Text.Length - 1, 1), 0x4577, 4);

                backend.updateROMText(absoluteFilename, 0x13, textBoxInGame66, 0x457A, 1); // GO TO THE NEXT ROOM.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame66.Text.Substring(textBoxInGame66.Text.Length - 1, 1), 0x458D, 4);

                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame67, 0x4593, 1); // EYES OF SKULL
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame67.Text.Substring(textBoxInGame67.Text.Length - 1, 1), 0x459F, 2);

                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame68, 0x45A5, 1); // HAS A SECRET.
                backend.updateROMTextSingleLetter(absoluteFilename, 0x1, textBoxInGame68.Text.Substring(textBoxInGame68.Text.Length - 1, 1), 0x45B1, 4);

                MessageBox.Show("Updated Text!", "The Legend of Zelda Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxInGame1.MaxLength = 0x14;
            textBoxInGame2.MaxLength = 0x11;
            textBoxInGame3.MaxLength = 0x13;
            textBoxInGame4.MaxLength = 0x12;
            textBoxInGame5.MaxLength = 0x16;

            textBoxInGame6.MaxLength = 0x15;
            textBoxInGame7.MaxLength = 0x10;
            textBoxInGame8.MaxLength = 0x10;
            textBoxInGame9.MaxLength = 0xC;
            textBoxInGame10.MaxLength = 0x13;

            textBoxInGame11.MaxLength = 0xE;
            textBoxInGame12.MaxLength = 0x10;
            textBoxInGame13.MaxLength = 0xA;
            textBoxInGame14.MaxLength = 0x10;
            textBoxInGame15.MaxLength = 0xD;

            textBoxInGame16.MaxLength = 0x13;
            textBoxInGame17.MaxLength = 0x7;
            textBoxInGame18.MaxLength = 0x15;
            textBoxInGame19.MaxLength = 0x11;
            textBoxInGame20.MaxLength = 0x8;

            textBoxInGame21.MaxLength = 0x9;
            textBoxInGame22.MaxLength = 0x13;
            textBoxInGame23.MaxLength = 0x14;
            textBoxInGame24.MaxLength = 0x12;
            textBoxInGame25.MaxLength = 0x8;

            textBoxInGame26.MaxLength = 0x11;
            textBoxInGame27.MaxLength = 0x16;
            textBoxInGame28.MaxLength = 0xC;
            textBoxInGame29.MaxLength = 0x11;
            textBoxInGame30.MaxLength = 0x16;

            textBoxInGame31.MaxLength = 0xD;
            textBoxInGame32.MaxLength = 0xD;
            textBoxInGame33.MaxLength = 0x12;
            textBoxInGame34.MaxLength = 0x13;
            textBoxInGame35.MaxLength = 0xE;

            textBoxInGame36.MaxLength = 0x17;
            textBoxInGame37.MaxLength = 0x15;
            textBoxInGame38.MaxLength = 0x13;
            textBoxInGame39.MaxLength = 0x15;
            textBoxInGame40.MaxLength = 0xD;

            textBoxInGame41.MaxLength = 0xA;
            textBoxInGame42.MaxLength = 0x14;
            textBoxInGame43.MaxLength = 0x13;
            textBoxInGame44.MaxLength = 0xF;
            textBoxInGame45.MaxLength = 0x16;

            textBoxInGame46.MaxLength = 0x10;
            textBoxInGame47.MaxLength = 0x13;
            textBoxInGame48.MaxLength = 0x10;
            textBoxInGame49.MaxLength = 0x17;
            textBoxInGame50.MaxLength = 0xF;

            textBoxInGame51.MaxLength = 0x9;
            textBoxInGame52.MaxLength = 0x17;
            textBoxInGame53.MaxLength = 0x13;
            textBoxInGame54.MaxLength = 0xF;
            textBoxInGame55.MaxLength = 0x9;

            textBoxInGame56.MaxLength = 0x13;
            textBoxInGame57.MaxLength = 0xF;
            textBoxInGame58.MaxLength = 0x13;
            textBoxInGame59.MaxLength = 0x14;
            textBoxInGame60.MaxLength = 0x11;

            textBoxInGame61.MaxLength = 0x15;
            textBoxInGame62.MaxLength = 0x18;
            textBoxInGame63.MaxLength = 0x16;
            textBoxInGame64.MaxLength = 0x15;
            textBoxInGame65.MaxLength = 0x12;

            textBoxInGame66.MaxLength = 0x14;
            textBoxInGame67.MaxLength = 0xD;
            textBoxInGame68.MaxLength = 0xD;
        }

        private void FormGameText_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
